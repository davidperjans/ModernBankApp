using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModernBankApp.Classes.JSON;
using ModernBankApp.Classes.UserFolder;
using Newtonsoft.Json;

namespace ModernBankApp
{
    public partial class RegisterForm : Form
    {

        /* --- Attribut för att kunna röra formulet --- */
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        /* ------------------------------------ */

        private List<User> users;

        public RegisterForm(List<User> users)
        {
            InitializeComponent();
            this.users = users;
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

        private void register_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            string registeruser_username = register_username.Text;
            if (string.IsNullOrEmpty(registeruser_username))
            {
                MessageBox.Show("Please choose your username");
            }

            string registeruser_password = register_password.Text;
            if (string.IsNullOrEmpty(registeruser_password))
            {
                MessageBox.Show("Please choose your password");
            }

            var user = users.FirstOrDefault(user => user.Username == registeruser_username);

            if (user != null)
            {
                MessageBox.Show("There is already an account with that username");
                register_username.Text = null;
                register_password.Text = null;
                return;
            }

            User newUser = new User(registeruser_username, registeruser_password);
            users.Add(newUser);

            DataManager.SaveUsersToFile(users);

            MessageBox.Show("Account created! You can now login!");
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();

        }

        private void SaveUsersToFile()
        {
            string filePath = "users.json";
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        private void register_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (register_showpassword.Checked)
            {
                register_password.PasswordChar = '\0';
            }
            else
            {
                register_password.PasswordChar = '*';
            }
        }
    }
}
