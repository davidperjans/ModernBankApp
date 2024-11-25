using ModernBankApp.Classes.JSON;
using ModernBankApp.Classes.UserFolder;
using Newtonsoft.Json;

namespace ModernBankApp
{
    public partial class Form1 : Form
    {
        /* --- Attribut för att kunna röra formulet --- */
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        /* ------------------------------------ */

        private List<User> users;

        public Form1()
        {
            InitializeComponent();
            users = new List<User>();
        }


        /* --- Inläsning av formuläret (JSON) --- */
        private void Form1_Load(object sender, EventArgs e)
        {

            /* --- JSON Inläsning --- */
            string filePath = "users.json";
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                users = JsonConvert.DeserializeObject<List<User>>(json)!;
            }
            else
            {
                MessageBox.Show("User file not found!");
            }
        }


        /* --- Headerpanelens funktionalitet --- */
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void exitBtn_MouseEnter(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.SteelBlue;
            exitBtn.ForeColor = Color.White;
        }
        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackColor = Color.FromArgb(37, 37, 37);
            exitBtn.ForeColor = Color.Gray;
        }
        private void maximizeBtn_MouseEnter(object sender, EventArgs e)
        {
            maximizeBtn.BackColor = Color.SteelBlue;
            maximizeBtn.ForeColor = Color.White;
        }
        private void maximizeBtn_MouseLeave(object sender, EventArgs e)
        {
            maximizeBtn.BackColor = Color.FromArgb(37, 37, 37);
            maximizeBtn.ForeColor = Color.Gray;
        }
        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void minimizeBtn_MouseEnter(object sender, EventArgs e)
        {
            minimizeBtn.BackColor = Color.SteelBlue;
            minimizeBtn.ForeColor = Color.White;
        }
        private void minimizeBtn_MouseLeave(object sender, EventArgs e)
        {
            minimizeBtn.BackColor = Color.FromArgb(37, 37, 37);
            minimizeBtn.ForeColor = Color.Gray;
        }
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }
        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }
        private void headerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }


        /* --- Login funktionaliteten --- */
        private void login_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showpassword.Checked)
            {
                login_password.PasswordChar = '\0';
            }
            else
            {
                login_password.PasswordChar = '*';
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(users);
            registerForm.Show();
            this.Hide();
        }
        private void login_btn_Click(object sender, EventArgs e)
        {

            string user_username = login_username.Text;
            if (string.IsNullOrEmpty(user_username))
            {
                MessageBox.Show("Please enter your username");
            }

            string user_password = login_password.Text;
            if (string.IsNullOrEmpty(user_password))
            {
                MessageBox.Show("Please enter your password");
            }

            var user = users.FirstOrDefault(user => user.Username == user_username && user.Password == user_password);

            if (user == null)
            {
                MessageBox.Show("Wrong username or password");
                login_username.Text = null;
                login_password.Text = null;
                return;
            }


            MessageBox.Show("Login successfull!");


            MainForm mainForm = new MainForm(users, user);
            mainForm.Show();
            this.Hide();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            LoadUsersFromFile();
        }

        private void LoadUsersFromFile()
        {
            string filePath = "users.json";
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                users = JsonConvert.DeserializeObject<List<User>>(json)!;
            }
            else
            {
                users = new List<User>();
            }
        }
    }
}
