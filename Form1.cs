using AirProject.DB;
using AirProject.Model;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DBconnection.dbInit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EntryButton_Click(object sender, EventArgs e){
          UserService userService = new UserService();
            if(userService.entry(textBoxLogin.Text, textBoxPassword.Text)){
                User user = DAO.GetUserByLogin(textBoxLogin.Text);
                if (user.Role == 1){
                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.ShowDialog();
                    Close();
                }
                else
                {
                    SourseForm form = new SourseForm(user);
                    this.Hide();
                    form.ShowDialog();
                    Close();
                }

            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegForm reg = new RegForm();
            reg.ShowDialog();
        }
    }
}
