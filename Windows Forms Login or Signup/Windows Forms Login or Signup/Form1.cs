using System.Collections;

namespace Windows_Forms_Login_or_Signup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signupPasswordLbl_Click(object sender, EventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            //Reveals the signup UI
            signupLogoLbl.Visible = true;
            signupBg.Visible = true;
            signupPasswordLbl.Visible = true;
            signupPasswordTxt.Visible = true;
            signupUsernameLbl.Visible = true;
            signupUsernameTxt.Visible = true;
            cancelBtn.Visible = true;
            createaccountBtn.Visible = true;

            //hides the login UI
            loginBg.Visible = false;
            loginBtn.Visible = false;
            loginUsernameLbl.Visible = false;
            loginUsernameTxt.Visible = false;
            loginUsernameLbl.Visible = false;
            loginPasswordTxt.Visible = false;
            loginPasswordLbl.Visible = false;
            loginBtn.Visible = false;
            signupBtn.Visible = false;
            loginLogoLbl.Visible = false;
            loginMottoLbl.Visible = false;
        }

        ArrayList usernames = [];
        ArrayList passwords = [];

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //if no accounts have been created yet, a special alert will show
            if (usernames.Count == 0)
            {
                MessageBox.Show("There are still no accounts that are present in the system. Please create a new account first before signing in by clicking the sign-up button!");
                loginUsernameTxt.Text = "";
                loginPasswordTxt.Text = "";
                signupUsernameTxt.Text = "";
                signupPasswordTxt.Text = "";
            }
            else
            {
                //using a for loop to check whether if the usrname and password is correct
                for (int i = 0; i < usernames.Count; i++) 
                {
                    if (loginUsernameTxt.Text == Convert.ToString(usernames[i]) && loginPasswordTxt.Text == Convert.ToString(passwords[i]))
                    {
                        MessageBox.Show("User " + usernames[i] + " logged in!");
                        loginUsernameTxt.Text = "";
                        loginPasswordTxt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password, please try again. ");
                        loginUsernameTxt.Text = "";
                        loginPasswordTxt.Text = "";
                    }
                }
            }
        }

        private void createaccountBtn_Click(object sender, EventArgs e)
        {
            //adds the created username and password into the data structure of arraylist
            usernames.Add(signupUsernameTxt.Text);
            passwords.Add(signupPasswordTxt.Text);

            MessageBox.Show("Your account has been created, you may now log-in!");
            //hides the signup UI
            signupLogoLbl.Visible = false;
            signupBg.Visible = false;
            signupPasswordLbl.Visible = false;
            signupPasswordTxt.Visible = false;
            signupUsernameLbl.Visible = false;
            signupUsernameTxt.Visible = false;
            cancelBtn.Visible = false;
            createaccountBtn.Visible = false;

            //reveals the login UI
            loginBg.Visible = true;
            loginBtn.Visible = true;
            loginUsernameLbl.Visible = true;
            loginUsernameTxt.Visible = true;
            loginUsernameLbl.Visible = true;
            loginPasswordTxt.Visible = true;
            loginPasswordLbl.Visible = true;
            loginBtn.Visible = true;
            signupBtn.Visible = true;
            loginLogoLbl.Visible = true;
            loginMottoLbl.Visible = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //hides the signup UI
            signupLogoLbl.Visible = false;
            signupBg.Visible = false;
            signupPasswordLbl.Visible = false;
            signupPasswordTxt.Visible = false;
            signupUsernameLbl.Visible = false;
            signupUsernameTxt.Visible = false;
            cancelBtn.Visible = false;
            createaccountBtn.Visible = false;

            //reveals the login UI
            loginBg.Visible = true;
            loginBtn.Visible = true;
            loginUsernameLbl.Visible = true;
            loginUsernameTxt.Visible = true;
            loginUsernameLbl.Visible = true;
            loginPasswordTxt.Visible = true;
            loginPasswordLbl.Visible = true;
            loginBtn.Visible = true;
            signupBtn.Visible = true;
            loginLogoLbl.Visible = true;
            loginMottoLbl.Visible = true;

            //clears the text of the username and passwords of both login or signup
            loginUsernameTxt.Text = "";
            loginPasswordTxt.Text = "";
            signupUsernameTxt.Text = "";
            signupPasswordTxt.Text = "";
        }
    }
}
