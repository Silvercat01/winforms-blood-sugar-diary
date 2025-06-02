using BloodSugarClassLibrary;
using BloodSugarClassLibrary.Services;
using BloodSugarClassLibrary.Data;


namespace BloodSugarDiary
{
    public partial class LoginForm : Form
    {
        public static int _userId;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var context = new UserContext();
            var authService = new AuthService(context);

            var result = authService.Login(usernameTextBox.Text, passwordTextBox.Text);

            switch (result)
            {
                case LoginResult.EmptyFields:
                    infoLabel.Text = "Please fill in all fields!";
                    break;

                case LoginResult.Success:
                    _userId = context.Users
                        .First(u => u.Username == usernameTextBox.Text).Id;

                    infoLabel.Text = "Login successful!";

                    DiaryForm diaryform = new DiaryForm(_userId);
                    this.Hide();
                    diaryform.FormClosed += (s, args) => this.Close();
                    diaryform.Show();
                    break;

                case LoginResult.InvalidPassword:
                    infoLabel.Text = "Invalid password!";
                    break;

                case LoginResult.UserNotFound:
                    infoLabel.Text = "User doesn't exist, you have to sign up first";
                    break;
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            var context = new UserContext();
            var authService = new AuthService(context);

            var result = authService.SignUp(usernameTextBox.Text, passwordTextBox.Text);

            switch (result)
            {
                case LoginResult.EmptyFields:
                    infoLabel.Text = "Please fill in all fields!";
                    break;

                case LoginResult.Success:
                    infoLabel.Text = "Sign up successful!";

                    _userId = context.Users
                        .First(u => u.Username == usernameTextBox.Text).Id;

                    PatientDataForm patientdataform = new PatientDataForm(_userId);
                    this.Hide();
                    patientdataform.FormClosed += (s, args) => this.Close();
                    patientdataform.Show();
                    break;

                case LoginResult.InvalidPassword:
                    infoLabel.Text = "Invalid password!";
                    break;

                case LoginResult.AlreadyExists:
                    infoLabel.Text = "User already exists!";
                    break;
            }
        }
    }
}
