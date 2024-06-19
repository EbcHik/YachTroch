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

        List<BoatOrder> orders = new List<BoatOrder>();

        public OrdetInf(BoatOrder boatOrder)
        {
            InitializeComponent();
            this.boatOrder = boatOrder;
            textBox2.MaxLength = 10;
            toBoatOrder();
        }


        private void toBoatOrder()
        {
            foreach(Order order in Basket.orders)
            {
                BoatOrder boatOrder = new BoatOrder();
                boatOrder.ProductName = order.boat.Name;
                boatOrder.resPrice = order.Price.ToString();
                boatOrder.RowerSeatCount = order.RowerSeatCount;
                boatOrder.BoatType = order.Class;
                boatOrder.WoodType = order.TypeTree;
                boatOrder.Color = order.Color;
                boatOrder.dopService = order.dop;
                boatOrder.BasePrice = order.boat.Price;
                orders.Add(boatOrder);
            }
            

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
                foreach (BoatOrder boatOrder in orders)
                {
                    boatOrder.CustomerName = textBox1.Text;
                    boatOrder.CustomerPassportNumber = textBox2.Text;
                    boatOrder.orderDate = DateTime.Now;
                    boatOrder.OrderReady = "Работы не начаты";
                    DAO.SaveOrder(boatOrder);
                }
                MessageBox.Show("Заказ успешно сохранен!");
                Close();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
