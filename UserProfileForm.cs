using AirProject.DB;
using AirProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirProject
{
    public partial class UserProfileForm : Form
    {
        
        User myUser;
        User activeUser;
        public UserProfileForm(User user)
        {
            UserTheme.theme = user.Theme;
            if (UserTheme.theme == "black")
            {
                this.BackColor = Color.DarkSlateGray;
            }
            InitializeComponent();
            myUser = DAO.GetUserByLogin(user.Login);
            blockTextBox();
            updateForm();




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void updateForm()
        {
            activeUser = DAO.GetUserByLogin(myUser.Login);
            NameTextBox.Text = activeUser.Name;
            LnameTextBox.Text = activeUser.LastName;
            StutusRichTextBox.Text = activeUser.Status;
            UserTheme.theme = activeUser.Theme;

            if (activeUser.Theme == "white")
            {
                ThemeComboBox.SelectedIndex = 0;
            }
            else
            {
                ThemeComboBox.SelectedIndex = 1;
            }
        }

        private void blockTextBox()
        {
            NameTextBox.ReadOnly = true;
            LnameTextBox.ReadOnly = true;
            StutusRichTextBox.ReadOnly = true;
        }

        private void СhangeButton_Click(object sender, EventArgs e)
        {
            NameTextBox.ReadOnly = false;
            LnameTextBox.ReadOnly = false;
            StutusRichTextBox.ReadOnly = false;
            СhangeButton.Visible = false;
            SaveButton.Visible = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DAO.dbUpdateUser(activeUser.Id, NameTextBox.Text, LnameTextBox.Text,StutusRichTextBox.Text,ThemeComboBox.Text);
            СhangeButton.Visible = true;
            SaveButton.Visible = false;
            blockTextBox();
            
            updateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChengePasswFormForm form = new ChengePasswFormForm(activeUser);
            form.ShowDialog();
        }

    }
}
