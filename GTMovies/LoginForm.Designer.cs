namespace GTMovies
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            BtnGoToRegistration = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.MenuHighlight;
            txtUsername.Location = new Point(354, 108);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(238, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.MenuHighlight;
            txtPassword.Location = new Point(354, 167);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(238, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(440, 84);
            label1.Name = "label1";
            label1.Size = new Size(70, 18);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(426, 143);
            label2.Name = "label2";
            label2.Size = new Size(101, 18);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // btnLogin
            // 
            btnLogin.FlatAppearance.BorderColor = Color.Red;
            btnLogin.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(323, 424);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 77);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Iniciar Sesion";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // 
            // BtnGoToRegistration
            // 
            BtnGoToRegistration.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BtnGoToRegistration.Location = new Point(517, 424);
            BtnGoToRegistration.Margin = new Padding(3, 4, 3, 4);
            BtnGoToRegistration.Name = "BtnGoToRegistration";
            BtnGoToRegistration.Size = new Size(107, 77);
            BtnGoToRegistration.TabIndex = 5;
            BtnGoToRegistration.Text = "Registrarme";
            BtnGoToRegistration.UseVisualStyleBackColor = true;
            BtnGoToRegistration.Click += BtnGoToRegistration_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fnd;
            pictureBox1.Location = new Point(-2, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(931, 608);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(354, 27);
            label3.Name = "label3";
            label3.Size = new Size(290, 28);
            label3.TabIndex = 7;
            label3.Text = "Bienvenido a GTMovies.\r\n";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(336, 527);
            label4.Name = "label4";
            label4.Size = new Size(326, 17);
            label4.TabIndex = 8;
            label4.Text = "¿No tienes una cuenta? Registrate es gratis";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 603);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(BtnGoToRegistration);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private Button BtnGoToRegistration;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
    }
}