using System;
using System.Windows.Forms;

namespace GTMovies
{
    public partial class LoginForm : Form
    {
        private SQLiteHelper sqliteHelper;
        

        public LoginForm(SQLiteHelper helper)
        {
            InitializeComponent();
            sqliteHelper = helper;
            btnLogin.Click += BtnLogin_Click; 
        }

        private bool errorMessageShown = false; 

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Lógica de autenticación
            User authenticatedUser = sqliteHelper.AuthenticateUser(username, password);

            if (authenticatedUser != null)
            {
                if (!IsMainFormOpen(authenticatedUser))
                {
                    
                    MessageBox.Show("Inicio de sesión exitoso.", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    MainForm mainForm = new MainForm(sqliteHelper, authenticatedUser)
                    {
                        Tag = authenticatedUser 
                    };
                    this.Hide();
                    mainForm.FormClosed += (s, args) =>
                    {
                        this.Show();
                        mainForm.Dispose();
                    }; 
                    mainForm.Show(); 
                }
             
            }
            else
            {
                if (!errorMessageShown) // Verificar si el mensaje de error ya se ha mostrado
                {
                    
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorMessageShown = true; 
                }
                else
                {
                    
                    errorMessageShown = false;
                }
            }
        }


        private bool IsMainFormOpen(User authenticatedUser)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is MainForm && form.Tag is User user && user.Id == authenticatedUser.Id)
                {
                    
                    form.Activate();
                    return true;
                }
            }
            return false;
        }

        private void BtnGoToRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm(sqliteHelper);
            registrationForm.ShowDialog(); 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
