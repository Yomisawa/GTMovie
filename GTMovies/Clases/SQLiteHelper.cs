using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using GTMovies;

public class SQLiteHelper
{
    private string connectionString;

    public SQLiteHelper(string dbPath)
    {
        connectionString = $"Data Source={dbPath};Version=3;";
    }

    public void InitializeDatabase()
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            // Crear tabla Users
            string createUserTableQuery = @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL UNIQUE,
                    Password TEXT NOT NULL,
                    Email TEXT
                )";

            ExecuteNonQuery(createUserTableQuery, connection);

            // Crear tabla FavoriteMovies
            string createFavoriteMoviesTableQuery = @"
                CREATE TABLE IF NOT EXISTS FavoriteMovies (
                    UserId INTEGER,
                    MovieId INTEGER,
                    FOREIGN KEY(UserId) REFERENCES Users(Id)
                )";

            ExecuteNonQuery(createFavoriteMoviesTableQuery, connection);

            // Crear tabla Movies
            string createMoviesTableQuery = @"
                CREATE TABLE IF NOT EXISTS Movies (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Title TEXT NOT NULL,
                    Description TEXT,
                    ImagePath TEXT
                )";

            ExecuteNonQuery(createMoviesTableQuery, connection);
        }
    }

    public void SaveUser(User user)
    {
        string sql = @"INSERT INTO Users (Username, Password, Email) 
                       VALUES (@Username, @Password, @Email)";

        ExecuteNonQuery(sql, new Dictionary<string, object>
        {
            { "@Username", user.Username },
            { "@Password", user.Password },
            { "@Email", string.IsNullOrEmpty(user.Email) ? DBNull.Value : (object)user.Email }
        });
    }

    public User AuthenticateUser(string username, string password)
    {
        string sql = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";

        DataTable dataTable = ExecuteQuery(sql, new Dictionary<string, object>
        {
            { "@Username", username },
            { "@Password", password }
        });

        if (dataTable.Rows.Count == 1)
        {
            DataRow row = dataTable.Rows[0];
            int id = Convert.ToInt32(row["Id"]);
            string email = row["Email"].ToString();

            return new User(username, password, email) { Id = id };
        }

        return null;
    }

    public List<User> GetAllUsers()
    {
        List<User> users = new List<User>();

        string sql = "SELECT * FROM Users";

        DataTable dataTable = ExecuteQuery(sql);

        foreach (DataRow row in dataTable.Rows)
        {
            int id = Convert.ToInt32(row["Id"]);
            string username = row["Username"].ToString();
            string password = row["Password"].ToString();
            string email = row["Email"].ToString();

            User user = new User(username, password, email)
            {
                Id = id
            };

            users.Add(user);
        }

        return users;
    }

    public void AddFavoriteMovie(int userId, int movieId)
    {
        string sql = "INSERT INTO FavoriteMovies (UserId, MovieId) VALUES (@UserId, @MovieId)";

        ExecuteNonQuery(sql, new Dictionary<string, object>
        {
            { "@UserId", userId },
            { "@MovieId", movieId }
        });
    }

    public List<int> GetFavoriteMovies(int userId)
    {
        List<int> favoriteMovies = new List<int>();

        string sql = "SELECT MovieId FROM FavoriteMovies WHERE UserId = @UserId";

        DataTable dataTable = ExecuteQuery(sql, new Dictionary<string, object>
        {
            { "@UserId", userId }
        });

        foreach (DataRow row in dataTable.Rows)
        {
            int movieId = Convert.ToInt32(row["MovieId"]);
            favoriteMovies.Add(movieId);
        }

        return favoriteMovies;
    }

    public void RemoveFavoriteMovie(int userId, int movieId)
    {
        string sql = "DELETE FROM FavoriteMovies WHERE UserId = @UserId AND MovieId = @MovieId";

        ExecuteNonQuery(sql, new Dictionary<string, object>
    {
        { "@UserId", userId },
        { "@MovieId", movieId }
    });
    }


    private DataTable ExecuteQuery(string sql, Dictionary<string, object> parameters = null)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }

    private void ExecuteNonQuery(string sql, SQLiteConnection connection)
    {
        using (SQLiteCommand command = new SQLiteCommand(sql, connection))
        {
            command.ExecuteNonQuery();
        }
    }

    private void ExecuteNonQuery(string sql, Dictionary<string, object> parameters = null)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }

                command.ExecuteNonQuery();
            }
        }
    }
}
