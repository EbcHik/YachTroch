using AirProject.DB;
using AirProject.Service;
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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LastNameLable_Click(object sender, EventArgs e)
        {

        }

        private void PaswLabel_Click(object sender, EventArgs e)
        {

        }

        private void RegAcceptButton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            if (AdminCheckRadioButton.Checked)
            {
                if (textBoxPassw.Text == "admin")
                {
                    if (userService.saveUser(textBoxName.Text, textBoxLastName.Text, textBoxlogin.Text, textBoxPassw.Text, 1))
                    {
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Для авторизации с ролью администратор нужен определенный пароль.");
                }
            }
            else
            {
                if (userService.saveUser(textBoxName.Text, textBoxLastName.Text, textBoxlogin.Text, textBoxPassw.Text, 0))
                {
                    Close();
                }
            }
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }
    }
}
