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
    public partial class ВasketForm : Form
    {
        User myUser;
        public ВasketForm(User user)
        {
            InitializeComponent();
            init();
            myUser = user;
        }

        private void init()
        {
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataTable dataTable = new DataTable();
            List<Order> orders = Basket.orders;

            dataTable.Columns.Add("Класс", typeof(string));
            dataTable.Columns.Add("Модель", typeof(string));
            dataTable.Columns.Add("Наличие мачты", typeof(string));
            dataTable.Columns.Add("Мест", typeof(int));
            dataTable.Columns.Add("Цвет", typeof(string));
            dataTable.Columns.Add("Материал", typeof(string));
            dataTable.Columns.Add("Доп", typeof(string));
            dataTable.Columns.Add("Цена", typeof(decimal));

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Action";
            buttonColumn.Name = "Action";
            buttonColumn.Text = "Изменить состояние заказа";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Columns.Add(buttonColumn);



            foreach (Order order in orders)
            {
                dataTable.Rows.Add(order.Class, order.Model, order.Has_must, order.RowerSeatCount, order.Color, order.TypeTree, order.dop, order.Price);
            }

            dataGridView1.DataSource = dataTable;

            ResCostTextBox.Text = Basket.resPrice.ToString();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == dataGridView1.Columns["Action"].Index && e.RowIndex >= 0)
            {
                
                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту строку?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    Basket.orders.RemoveAt(e.RowIndex);
                    UpdateTotalPrice();
                }
            }
        }

        private void UpdateTotalPrice()
        {
           
            decimal totalPrice = Basket.orders.Sum(order => order.Price);
            ResCostTextBox.Text = totalPrice.ToString();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            OrdetInf ordetInf = new OrdetInf(new BoatOrder());
            ordetInf.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           


        }
    }
}
