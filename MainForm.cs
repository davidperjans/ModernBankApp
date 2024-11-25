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

namespace ModernBankApp
{
    public partial class MainForm : Form
    {

        /* --- Attribut för att kunna röra formulet --- */
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        /* ------------------------------------ */

        /* --- Färgattribut för knappar --- */
        private Button? currentActiveButton = null;
        private Color defaultColor = Color.FromArgb(57, 59, 64);
        private Color activeColor = Color.FromArgb(41, 43, 47);

        /* --- Initialisera User klassen --- */
        private User user;
        private List<User> users;

        public MainForm(List<User> users, User user)
        {
            InitializeComponent();
            this.users = users;
            this.user = user;

            welcomeUserLabel.Text = $"Welcome: {user.Username}";


            home1.Visible = true;
            accounts1.Visible = false;
            settings1.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetActiveButton(homeBtn);
        }




        /* --- Knappfunktionalitet i sidebar --- */
        private void SetActiveButton(Button activeButton)
        {
            // Återställ färgen på den tidigare aktiva knappen
            if (currentActiveButton != null)
            {
                currentActiveButton.BackColor = defaultColor; // Standardfärg
                currentActiveButton.ForeColor = Color.Gray;
            }

            // Uppdatera den nya aktiva knappen
            activeButton.BackColor = activeColor; // Aktiv färg
            activeButton.ForeColor = Color.White;

            // Uppdatera referensen till aktuell aktiv knapp
            currentActiveButton = activeButton;
        }
        private void ExitAndSaveMethod()
        {
            DialogResult check = MessageBox.Show("Are you sure you want to save and exit?"
                            , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                DataManager.SaveUsersToFile(users);
                Form1 startForm = new Form1();
                startForm.Show();
                this.Hide();
            }
        }



        /* ---  Design & funktionalitet --- */
        private void exitBtn_Click(object sender, EventArgs e)
        {
            DataManager.SaveUsersToFile(users);
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
        private void homeBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            home1.Visible = true;
            accounts1.Visible = false;
            settings1.Visible = false;
        }
        private void accountsBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            home1.Visible = false;
            accounts1.Visible = true;
            settings1.Visible = false;

            accounts1.InitializeData(user);
            accounts1.Refresh();
        }
        private void settingsBtn_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            home1.Visible = false;
            accounts1.Visible = false;
            settings1.Visible = true;
        }
        private void homeBtn_MouseEnter(object sender, EventArgs e)
        {
            homeBtn.ForeColor = Color.White;
        }
        private void homeBtn_MouseLeave(object sender, EventArgs e)
        {
            if (currentActiveButton != homeBtn)
            {
                homeBtn.ForeColor = Color.Gray;
            }
        }
        private void accountsBtn_MouseEnter(object sender, EventArgs e)
        {
            accountsBtn.ForeColor = Color.White;
        }
        private void accountsBtn_MouseLeave(object sender, EventArgs e)
        {
            if (currentActiveButton != accountsBtn)
            {
                accountsBtn.ForeColor = Color.Gray;
            }
        }
        private void settingsBtn_MouseEnter(object sender, EventArgs e)
        {
            settingsBtn.ForeColor = Color.White;
        }
        private void settingsBtn_MouseLeave(object sender, EventArgs e)
        {
            if (currentActiveButton != settingsBtn)
            {
                settingsBtn.ForeColor = Color.Gray;
            }
        }
        private void logoutBtn_MouseEnter(object sender, EventArgs e)
        {
            logoutBtn.ForeColor = Color.White;
        }
        private void logoutBtn_MouseLeave(object sender, EventArgs e)
        {
            if (currentActiveButton != logoutBtn)
            {
                logoutBtn.ForeColor = Color.Gray;
            }
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            ExitAndSaveMethod();
        }
    }
}
