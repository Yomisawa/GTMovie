using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GTMovies
{
    public partial class FavoriteMoviesForm : Form
    {
        private List<Movie> favoriteMovies;
        private Dictionary<string, int> movieImageIndexMap;
        private string dataFilePath = "favoriteMovies.txt"; 
        public FavoriteMoviesForm(List<Movie> favoriteMovies)
        {
            InitializeComponent();
            this.favoriteMovies = favoriteMovies;
            InitializeImageList(); 
            InitializeMovieImageIndexMap();
            DisplayFavoriteMovies();
        }

        private void InitializeImageList()
        {
           
            imageListFavoriteMovies.ImageSize = new Size(128, 128); 

            
            imageListFavoriteMovies.Images.Add(Properties.Resources.CoverImage0); // Reemplaza con el nombre real de tu recurso
            imageListFavoriteMovies.Images.Add(Properties.Resources.CoverImage1); // Reemplaza con el nombre real de tu recurso
            imageListFavoriteMovies.Images.Add(Properties.Resources.CoverImage2); // Reemplaza con el nombre real de tu recurso
            imageListFavoriteMovies.Images.Add(Properties.Resources.CoverImage3); // Reemplaza con el nombre real de tu recurso
            imageListFavoriteMovies.Images.Add(Properties.Resources.CoverImage4); // Reemplaza con el nombre real de tu recurso
            imageListFavoriteMovies.Images.Add(Properties.Resources.CoverImage5); // Reemplaza con el nombre real de tu recurso
            imageListFavoriteMovies.Images.Add(Properties.Resources.CoverImage6); // Reemplaza con el nombre real de tu recurso
            imageListFavoriteMovies.Images.Add(Properties.Resources.CoverImage7); // Reemplaza con el nombre real de tu recurso
            imageListFavoriteMovies.Images.Add(Properties.Resources.CoverImage8); // Reemplaza con el nombre real de tu recurso
            imageListFavoriteMovies.Images.Add(Properties.Resources.CoverImage9); // Reemplaza con el nombre real de tu recurso

            // Asocia el ImageList al ListView
            listView1.LargeImageList = imageListFavoriteMovies;
        }

        private void InitializeMovieImageIndexMap()
        {
            movieImageIndexMap = new Dictionary<string, int>
            {
                { "MATRIX", 0 },
                { "VOLVER AL FUTURO", 1 },
                { "FROGS", 2 },
                { "2012", 3 },
                { "IT", 4 },
                { "JOHN WICK 3", 5 },
                { "TITANIC", 6 },
                { "TOMB RAIDER", 7 },
                { "CONSTANTINE", 8 },
                { "DOBLES DE ACCION", 9 },
               
            };
        }

        private void DisplayFavoriteMovies()
        {
            listView1.Items.Clear();

            foreach (var movie in favoriteMovies)
            {
                var listViewItem = new ListViewItem(movie.Title);
                listViewItem.SubItems.Add(movie.Description);

                int imageIndex = GetImageIndex(movie);

                if (imageIndex != -1)
                {
                    listViewItem.ImageIndex = imageIndex;
                }
                else
                {
                    listViewItem.ImageIndex = -1; // Sin imagen
                }

                listView1.Items.Add(listViewItem);
            }

            // Verifica que la vista del ListView está configurada para mostrar imágenes grandes
            listView1.View = View.LargeIcon;
        }

        private int GetImageIndex(Movie movie)
        {
            if (movieImageIndexMap.TryGetValue(movie.Title, out int imageIndex))
            {
                return imageIndex;
            }
            return -1; // Devolver -1 si no se encuentra la imagen
        }

        private void AddMovieToFavorite(Movie newMovie)
        {
            favoriteMovies.Add(newMovie);
            DisplayFavoriteMovies();
        }

        private void RemoveMovieFromFavorite(int index)
        {
            if (index >= 0 && index < favoriteMovies.Count)
            {
                favoriteMovies.RemoveAt(index);
                DisplayFavoriteMovies();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                int index = selectedItem.Index;
                RemoveMovieFromFavorite(index);
                MessageBox.Show("Película eliminada de favoritos.");
            }
            else
            {
                MessageBox.Show("Seleccione una película para eliminar.");
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is FavoriteMoviesForm form &&
                   EqualityComparer<List<Movie>>.Default.Equals(favoriteMovies, form.favoriteMovies);
        }
    }
}
