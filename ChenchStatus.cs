using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class ChenchStatus : Form
    {
        MySqlConnection connection = DBconnection.getConnection();
        int orderId;
        DataForm form;
        public ChenchStatus(int orderId,DataForm form)
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            this.orderId = orderId;
            this.form = form;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                try
                {
                    connection.Open();

                    string sql = "UPDATE boat_orders SET order_ready = @Status WHERE order_number = @id";

                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@Status", comboBox1.Text);
                    command.Parameters.AddWithValue("@id", orderId);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Статус заказа обновлен успешно!");
                    connection.Close();
                    form.Close();
                    DataForm data = new DataForm();
                    data.Show();
                    Close();

                }
                catch (Exception ex)
                {
                    connection.Close();
                    Console.WriteLine("Ошибка при выполнении запроса: " + ex.Message);
                }

        }
    }
}
