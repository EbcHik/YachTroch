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
    public partial class AddBoatForm : Form
    {
        public AddBoatForm()
        {
            InitializeComponent();
            textBox4.MaxLength = 2;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boat boat = new Boat();

            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    throw new ArgumentException("Имя не может быть пустым.");
                }
                boat.Name = textBox1.Text;

                if (string.IsNullOrWhiteSpace(ClassComboBox.Text))
                {
                    throw new ArgumentException("Класс не может быть пустым.");
                }
                boat.Class = ClassComboBox.Text;

                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    throw new ArgumentException("Модель не может быть пустой.");
                }
                boat.Model = textBox2.Text;

                if (string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    throw new ArgumentException("Цена не может быть пустой.");
                }
                if (!decimal.TryParse(textBox3.Text, out decimal price))
                {
                    throw new ArgumentException("Цена должна быть числом.");
                }
                boat.Price = price;

                if (string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    throw new ArgumentException("Количество мест не может быть пустым.");
                }
                if (!int.TryParse(textBox4.Text, out int rowerSeatCount))
                {
                    throw new ArgumentException("Количество мест должно быть целым числом.");
                }
                boat.RowerSeatCount = rowerSeatCount;

                if (radioButton1.Checked)
                {
                    boat.Has_must = "да";
                }
                else
                {
                    boat.Has_must = "нет";
                }


                BoatDAO.saveBoat(boat);

                MessageBox.Show("Добавлено");



            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
