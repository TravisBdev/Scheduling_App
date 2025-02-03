using Microsoft.Win32;
using System.Globalization;

namespace Travis_Brown_Scheduling_Application
{
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
            SystemEvents.UserPreferenceChanged += HandleUserPreferenceChanged;
        }

        private void Translate() {
            string isoCode = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

            if (isoCode == "es") {
                lblLoginWelcome.Text = "¡Bienvenido! Por favor verifique sus credenciales a continuación.";
                lblLoginTitle.Text = "Acceso";
                lblLoginUserName.Text = "Nombre de usuario";
                lblLoginPassword.Text = "Contraseña";
                btnLoginSubmit.Text = "Entregar";
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
    }
}
