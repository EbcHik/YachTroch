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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();


        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            DataForm data = new DataForm();
            data.Show();
        }

        private void addBoat()
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddBoatForm form = new AddBoatForm();
            form.ShowDialog();
        }
    }
}
