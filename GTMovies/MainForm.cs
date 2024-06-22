using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTMovies
{
    public partial class MainForm : Form
    {
        private List<Movie> movies;
        private List<Movie> favoriteMovies; 


        public MainForm(SQLiteHelper sqliteHelper)
        {
            InitializeComponent();
            InitializeData(); 
            favoriteMovies = new List<Movie>(); 
        }


        private void InitializeData()
        {
            movies = new List<Movie>
    {
       new Movie("MATRIX", "Un hacker informático aprende de la existencia de los Matrix y la rebelión que busca liberar a la humanidad de su opresión."),
new Movie("VOLVER AL FUTURO", "Un joven es enviado accidentalmente al pasado en el tiempo y debe asegurarse de que sus padres se encuentren."),
new Movie("FROGS", "Unas ranas mutantes comienzan a atacar a una familia en su casa en medio del pantano."),
new Movie("2012", "En el año 2012, un desastre global amenaza con acabar con la civilización tal como se conoce."),
new Movie("IT", "Un grupo de niños se enfrenta a un monstruo que toma la forma de un payaso y que ha atormentado su ciudad durante generaciones."),
new Movie("JOHN WICK 3", "El asesino a sueldo John Wick enfrenta a toda la mafia después de ser declarado fuera de la ley."),
new Movie("TITANIC", "La historia de amor entre un pasajero de primera clase y una joven de tercera clase en el trágico viaje inaugural del RMS Titanic."),
new Movie("TOMB RAIDER", "Una joven arqueóloga se aventura en una isla peligrosa para encontrar a su padre desaparecido y desentrañar misterios antiguos."),
new Movie("CONSTANTINE", "Un detective con habilidades para detectar lo sobrenatural se embarca en una misión para salvar a la hija de un viejo amigo del infierno."),
new Movie("DOBLES DE ACCION", "Dos hermanos gemelos que son estrellas de acción se ven envueltos en un complot internacional mientras tratan de limpiar su nombre."),
    };
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MostrarInformacionPelicula(0); 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MostrarInformacionPelicula(1); 
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MostrarInformacionPelicula(2); 
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MostrarInformacionPelicula(3); 
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MostrarInformacionPelicula(4); 
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MostrarInformacionPelicula(5); 
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MostrarInformacionPelicula(6); 
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MostrarInformacionPelicula(7); 
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MostrarInformacionPelicula(8); 
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MostrarInformacionPelicula(9); 
        }
        // Repite para los demás PictureBoxes según sea necesario

        private void MostrarInformacionPelicula(int indice)
        {
            if (indice >=  0 && indice < movies.Count)
            {
                richTextBox1.Text = $"Título: {movies[indice].Title}\n\nDescripción: {movies[indice].Description}";
            }
        }

        public MainForm(SQLiteHelper sqliteHelper, User authenticatedUser) : this(sqliteHelper)
        {
            AuthenticatedUser = authenticatedUser;
        }

        public User AuthenticatedUser { get; }

        private void button1_Click(object sender, EventArgs e)
        {
            // Añadir la película mostrada actualmente a la lista de favoritos
            int indicePeliculaActual = GetIndicePeliculaMostrada();
            if (indicePeliculaActual != -1)
            {
                Movie pelicula = movies[indicePeliculaActual];
                if (!favoriteMovies.Contains(pelicula))
                {
                    favoriteMovies.Add(pelicula);
                    MessageBox.Show("Película añadida a favoritos.");
                }
                else
                {
                    MessageBox.Show("Esta película ya está en tus favoritos.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para mostrar las películas favoritas
            ShowFavoriteMovies();
        }

        private void ShowFavoriteMovies()
        {
            // Crear y mostrar el formulario de películas favoritas
            FavoriteMoviesForm favoriteForm = new FavoriteMoviesForm(favoriteMovies);
            favoriteForm.ShowDialog();
        }

        private int GetIndicePeliculaMostrada()
        {
            // Obtener el índice de la película actualmente mostrada en richTextBox1
            string[] lines = richTextBox1.Lines;
            if (lines.Length > 0 && lines[0].StartsWith("Título:"))
            {
                string titulo = lines[0].Substring(8).Trim();
                for (int i = 0; i < movies.Count; i++)
                {
                    if (movies[i].Title.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
       private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
