using AirProject.DB;
using AirProject.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AirProject
{
    public partial class UserDataForm : Form
    {
        MySqlConnection connection = DBconnection.getConnection();
        public UserDataForm()
        {
            InitializeComponent();
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            updateTable();
        }




        public void updateTable()
        {
            string sqlQuery = "SELECT order_number, product_name, boat_type, rower_seat_count, wood_type, color, has_mast, base_price, customer_name, customer_passport_number, order_ready, order_date, dop_services, res_price FROM boat_orders WHERE user_id = @user_id";

            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);
                cmd.Parameters.AddWithValue("@user_id", Basket.userID);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка обновления таблицы: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
