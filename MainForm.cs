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

            ColorComboBox1.SelectedIndex = 0;
            ColorComboBox2.SelectedIndex = 0;
            ColorComboBox3.SelectedIndex = 0;
            ColorComboBox4.SelectedIndex = 0;

            TreeComboBox1.SelectedIndex = 0;
            TreeComboBox2.SelectedIndex = 0;
            TreeComboBox3.SelectedIndex = 0;
            TreeComboBox4.SelectedIndex = 0;

            ModelComboBox1.SelectedIndex = 0;
            ModelComboBox2.SelectedIndex = 0;
            ModelComboBox3.SelectedIndex = 0;
            ModelComboBox4.SelectedIndex = 0;


            ColorComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            ColorComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            ColorComboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            ColorComboBox4.DropDownStyle = ComboBoxStyle.DropDownList;

            TreeComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            TreeComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            TreeComboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            TreeComboBox4.DropDownStyle = ComboBoxStyle.DropDownList;

            ModelComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            ModelComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            ModelComboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            ModelComboBox4.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            BoatOrder order = new BoatOrder();
            order.Color = ColorComboBox1.Text;
            order.BasePrice = 2500000;
            order.ProductName = ModelComboBox1.Text;
            order.BoatType = "Стандартная комплектация";
            order.WoodType = TreeComboBox1.Text;
            order.RowerSeatCount = 6;
            order.HasMast = MachtaCheckBox1.Checked ? "есть" : "нет";
            order.OrderReady = "Работы не начаты";

            OrdetInf ordet = new OrdetInf(order);
            ordet.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            BoatOrder order = new BoatOrder();
            order.Color = ColorComboBox2.Text;
            order.BasePrice = 1200000;
            order.ProductName = ModelComboBox2.Text;
            order.BoatType = "Эконом класс";
            order.WoodType = TreeComboBox2.Text;
            order.RowerSeatCount = 4;
            order.HasMast = MachtaCheckBox2.Checked ? "есть" : "нет";
            order.OrderReady = "Работы не начаты";
            order.dopService = getDopServuce(DopCheckedListBox2);
            order.countDopServises = getCountDopServuce(DopCheckedListBox2);
            OrdetInf ordet = new OrdetInf(order);
            ordet.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            BoatOrder order = new BoatOrder();
            order.Color = ColorComboBox3.Text;
            order.BasePrice = 8500000;
            order.ProductName = ModelComboBox3.Text;
            order.BoatType = "Люкс класс";
            order.WoodType = TreeComboBox3.Text;
            order.RowerSeatCount = 12;
            order.HasMast = MachtaCheckBox3.Checked ? "есть" : "нет";
            order.dopService = getDopServuce(DopCheckedListBox3);
            order.OrderReady = "Работы не начаты";
            order.countDopServises = getCountDopServuce(DopCheckedListBox3);

            OrdetInf ordet = new OrdetInf(order);
            ordet.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            BoatOrder order = new BoatOrder();
            order.Color = ColorComboBox4.Text;
            order.BasePrice = 4000000;
            order.ProductName = ModelComboBox4.Text;
            order.BoatType = "Стандартная модель";
            order.WoodType = TreeComboBox4.Text;
            order.RowerSeatCount = 8;
            order.HasMast = MachtaCheckBox4.Checked ? "есть" : "нет";
            order.dopService = getDopServuce(DopCheckedListBox4);
            order.countDopServises = getCountDopServuce(DopCheckedListBox4);
            order.OrderReady = "Работы не начаты";

            OrdetInf ordet = new OrdetInf(order);
            ordet.Show();
        }
        private int getCountDopServuce(CheckedListBox box)
        {
            int res = 0;
            for (int i = 0; i < box.Items.Count; i++)
            {
                if (box.GetItemChecked(i) == true)
                {

                    res++;

                }
            }
            return res;
        }

        private string getDopServuce(CheckedListBox box)
        {
            string res = "";
            foreach (var selectedItem in box.CheckedItems)
            {
                res += " " + selectedItem.ToString();
            }
            return res.Trim();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            DataForm data = new DataForm();
            data.Show();
        }
    }
}
