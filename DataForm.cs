using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirProject.DB
{
    public partial class DataForm : Form


    {

        MySqlConnection connection = DBconnection.getConnection();
        public DataForm()
        {
            InitializeComponent();
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            updateTable();

        }

        public void updateTable()
        {

            string sqlQuery = "SELECT order_number,product_name, boat_type, rower_seat_count, wood_type, color, has_mast, base_price, customer_name, customer_passport_number, order_ready, order_date, dop_services, res_price FROM boat_orders";
            dataGridView1.Rows.Clear();
            using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.HeaderText = "Action";
                buttonColumn.Name = "Action";
                buttonColumn.Text = "Изменить состояние заказа";
                buttonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.CellContentClick += dataGridView1_CellContentClick;
                dataGridView1.Columns.Add(buttonColumn);


                dataGridView1.DataSource = dataTable;
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что кнопка была нажата в нужной нам колонке
            if (e.ColumnIndex == dataGridView1.Columns["Action"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int productID = (int)selectedRow.Cells["order_number"].Value;
                ChenchStatus chench = new ChenchStatus(productID,this);
                chench.Show();
            }
        }

        private void DataForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
