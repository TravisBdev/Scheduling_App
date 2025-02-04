using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System.Globalization;
using Travis_Brown_Scheduling_Application.Forms;

namespace Travis_Brown_Scheduling_Application
{
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
            SystemEvents.UserPreferenceChanged += HandleUserPreferenceChanged;
        }

        string emptyFieldMessage;
        string invalidLoginMessage;
        string failed;
        string dbError;

        private void Translate() {
            string isoCode = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            


            if (isoCode == "es") {
                lblLoginWelcome.Text = "¡Bienvenido! Por favor verifique sus credenciales a continuación.";
                lblLoginTitle.Text = "Acceso";
                lblLoginUserName.Text = "Nombre de usuario";
                lblLoginPassword.Text = "Contraseña";
                btnLoginSubmit.Text = "Entregar";
                emptyFieldMessage = "Por favor complete ambos campos.";
                invalidLoginMessage = "El nombre de usuario y la contraseña no coinciden.";
                failed = "Error de inicio de sesion.";
                dbError = "Error de base de datos.";
            } else {
                emptyFieldMessage = "Please fill out all fields.";
                invalidLoginMessage = "The username and password are not valid.";
                failed = "Login failed.";
                dbError = "Database Error.";
            }
        }

        private void Login_Load(object sender, EventArgs e) {
            Translate();
        }

        private void HandleUserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e) {
            if (e.Category == UserPreferenceCategory.Locale) {
                Translate();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e) {
            SystemEvents.UserPreferenceChanged -= HandleUserPreferenceChanged;
        }

        private void btnLoginSubmit_Click(object sender, EventArgs e) {
            string username = tbLoginUserName.Text.Trim();
            string password = tbLoginPassword.Text.Trim();

           if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) {
                MessageBox.Show(emptyFieldMessage, failed, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=localhost;user=test;database=client_schedule;port=3306;password=test";

            using MySqlConnection conn = new(connectionString);
            try {
                conn.Open();

                string query = "SELECT COUNT(*) FROM `user` WHERE userName = @username AND password = @password";

                using MySqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int isValidUser = Convert.ToInt32(cmd.ExecuteScalar());

                if(isValidUser > 0) {
                    this.Hide();
                    DirectoryForm directoryForm = new();
                    directoryForm.ShowDialog();
                    this.Close();
                }else {
                    MessageBox.Show(invalidLoginMessage, failed, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            } catch (Exception ex) {
                MessageBox.Show(dbError + ex.Message, failed, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
