using System;
using System.Windows.Forms;
using GTMovies;
namespace GTMovies
{
    public partial class RegistrationForm : Form
    {
        private SQLiteHelper sqliteHelper;

        public RegistrationForm(SQLiteHelper helper)
        {
            InitializeComponent();
            sqliteHelper = helper;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string email = txtEmail.Text.Trim();

            // Verificar la longitud del nombre de usuario y el correo electrónico
            if (username.Length > 20 || email.Length > 20)
            {
                MessageBox.Show("El nombre de usuario y el correo electrónico deben tener máximo 20 caracteres.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Guardar usuario en la base de datos SQLite
            User newUser = new User(username, password, email);
            sqliteHelper.SaveUser(newUser);

            MessageBox.Show("Usuario registrado correctamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Cerrar el formulario después del registro exitoso
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
