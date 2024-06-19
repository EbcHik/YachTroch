using AirProject.DB;
using AirProject.Model;
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

namespace AirProject
{
    public partial class SourseForm : Form
    {
        User activeUser;

        decimal price;
        string dop;
        public SourseForm(User user)
        {
            UserTheme.theme = user.Theme;
            if (UserTheme.theme == "black")
            {
                this.BackColor = Color.DarkSlateGray;
            }
            InitializeComponent();
            activeUser = user;
            init();
            Basket.userID = user.Id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserProfileForm form = new UserProfileForm(activeUser);
            form.ShowDialog();
        }

        private void init()
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            ResPanel.Visible = false;
        }

        private void ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearAll();
            button2.Visible = true;
            List<Boat> boats = BoatDAO.GetItemsWithClass(ClassComboBox.Text);
            foreach(Boat boat in boats)
            {
                ModelComboBox.Items.Add(boat);
            }
            panel2.Visible = true;

            loadDopService(ClassComboBox.Text);
        }

        private void ModelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void TypeTreeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResPanel.Visible = true;
            Boat boat = (Boat)ModelComboBox.SelectedItem;
            price = ((boat.Price / 100) * 115);
            ResPriceTextBox.Text = price.ToString();
        }

        private void clearAll()
        {
            price = 0;
            dop = "";
            init();
            ModelComboBox.Items.Clear();
            checkedListBox.Items.Clear();
            button2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearAll();

        }

        private void loadDopService(string Class){
            if(Class == "Стандарт")
            {
                checkedListBox.Items.Add(new DopService("Зонт", 2000));
                checkedListBox.Items.Add(new DopService("Весла", 1500));
                checkedListBox.Items.Add(new DopService("Спасательный жилет", 1000));
            }else if (Class == "Эконом")
            {
                checkedListBox.Items.Add(new DopService("Черпак", 500));
                checkedListBox.Items.Add(new DopService("Весла", 1500));
                checkedListBox.Items.Add(new DopService("Спасательный жилет", 1500));
            }
            else
            {
                checkedListBox.Items.Add(new DopService("Навес", 7000));
                checkedListBox.Items.Add(new DopService("Холодильник", 10000));
                checkedListBox.Items.Add(new DopService("Спасательный жилет", 1500));
            }
        }

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void calculation()
        {
            dop = "";
            price = 0;
            Boat boat = (Boat)ModelComboBox.SelectedItem;
            price = ((boat.Price / 100) * 115);
            foreach (DopService item in checkedListBox.CheckedItems)
            {
                price += item.Price;
                dop += " " + item.Name;
            }
            ResPriceTextBox.Text = price.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculation();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            calculation();
            Boat boat = (Boat)ModelComboBox.SelectedItem;
            Order order = new Order(boat.Class,boat.Model,boat.Has_must,boat.RowerSeatCount,ColorComboBox.Text,TypeTreeComboBox.Text,dop,price,boat);
            Basket.orders.Add(order);
            Basket.resPrice += order.Price;
            MessageBox.Show("Добавлено в корзину.");
            clearAll();

        }


        private void downloadPhoto(string Class)
        {
            if (Class == "Стандарт")
            {
                pictureBox1.ImageLocation = "\\Resources\\luks.jpg";
            }
            else if (Class == "Эконом")
            {
                pictureBox1.ImageLocation = "\\Resources\\Classic.jpg";
            }
            else
            {
                pictureBox1.ImageLocation = "\\Resources\\standart.jpg";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ВasketForm вasketForm = new ВasketForm(activeUser);
            вasketForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserDataForm form = new UserDataForm();
            form.ShowDialog();
        }
    }
}
