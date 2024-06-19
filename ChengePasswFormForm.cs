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
    public partial class ChengePasswFormForm : Form
    {
        User myUser;
        public ChengePasswFormForm(User user)
        {
            UserTheme.theme = user.Theme;
            if (UserTheme.theme == "black")
            {
                this.BackColor = Color.DarkSlateGray;
            }
            InitializeComponent();
            myUser = DAO.GetUserByLogin(user.Login);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(myUser.Password == textBox1.Text){
                if (textBox1.Text != textBox2.Text) {
                    if (textBox2.Text.Length > 6)
                    {
                        DAO.dbUpdateUserPassw(myUser.Id, textBox2.Text);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Новый пароль короче 6 символов");
                    }
                }
                else
                {
                    MessageBox.Show("Новый пароль такой же как и старый.");
                }
            }
            else
            {
                MessageBox.Show("Неверный текущий пароль.");
            }
        }
    }
}
