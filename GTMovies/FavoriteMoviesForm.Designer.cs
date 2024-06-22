namespace GTMovies
{
    partial class FavoriteMoviesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ImageList imageListFavoriteMovies;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.ListView listView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoriteMoviesForm));
            imageListFavoriteMovies = new ImageList(components);
            buttonRemove = new Button();
            columnHeaderTitle = new ColumnHeader();
            columnHeaderDescription = new ColumnHeader();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // imageListFavoriteMovies
            // 
            imageListFavoriteMovies.ColorDepth = ColorDepth.Depth32Bit;
            imageListFavoriteMovies.ImageStream = (ImageListStreamer)resources.GetObject("imageListFavoriteMovies.ImageStream");
            imageListFavoriteMovies.TransparentColor = Color.Transparent;
            imageListFavoriteMovies.Images.SetKeyName(0, "CoverImage0");
            imageListFavoriteMovies.Images.SetKeyName(1, "CoverImage1");
            imageListFavoriteMovies.Images.SetKeyName(2, "CoverImage2");
            imageListFavoriteMovies.Images.SetKeyName(3, "CoverImage3");
            imageListFavoriteMovies.Images.SetKeyName(4, "CoverImage4");
            imageListFavoriteMovies.Images.SetKeyName(5, "CoverImage5");
            imageListFavoriteMovies.Images.SetKeyName(6, "CoverImage6");
            imageListFavoriteMovies.Images.SetKeyName(7, "CoverImage7");
            imageListFavoriteMovies.Images.SetKeyName(8, "CoverImage8");
            imageListFavoriteMovies.Images.SetKeyName(9, "CoverImage9");
            // 
            // buttonRemove
            // 
            buttonRemove.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic);
            buttonRemove.Location = new Point(12, 331);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(131, 30);
            buttonRemove.TabIndex = 1;
            buttonRemove.Text = "Eliminar película";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // columnHeaderTitle
            // 
            columnHeaderTitle.Text = "Título";
            columnHeaderTitle.Width = 200;
            // 
            // columnHeaderDescription
            // 
            columnHeaderDescription.Text = "Descripción";
            columnHeaderDescription.Width = 800;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.InactiveCaption;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeaderTitle, columnHeaderDescription });
            listView1.FullRowSelect = true;
            listView1.LargeImageList = imageListFavoriteMovies;
            listView1.Location = new Point(0, 0);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(887, 325);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FavoriteMoviesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(887, 432);
            Controls.Add(buttonRemove);
            Controls.Add(listView1);
            Name = "FavoriteMoviesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Películas Favoritas";
            ResumeLayout(false);
        }
    }
}
