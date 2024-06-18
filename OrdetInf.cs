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

namespace AirProject.DB
{
    public partial class OrdetInf : Form
    {
        BoatOrder boatOrder {get; set;}
        public OrdetInf(BoatOrder boatOrder)
        {
            InitializeComponent();
            this.boatOrder = boatOrder;
            textBox2.MaxLength = 10;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

            private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Не все поля заполнены", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                boatOrder.CustomerName = textBox1.Text;
                boatOrder.CustomerPassportNumber = textBox2.Text;
                boatOrder.orderDate = DateTime.Now;
                double resPrice = (double)((boatOrder.countDopServises * 10000) + ((boatOrder.BasePrice / 100) * 115));
                boatOrder.resPrice =Convert.ToString(resPrice);
                DAO.SaveOrder(boatOrder);
                MessageBox.Show("Заказ успешно сохранен!");
                Close();
            }

        }
    }
}
