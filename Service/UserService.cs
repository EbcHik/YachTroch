using AirProject.DB;
using AirProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirProject.Service
{
    internal class UserService{
        public Boolean saveUser(string name, string lastName, string login, string password){
            if (!string.IsNullOrEmpty(name) &&
            !string.IsNullOrEmpty(lastName) &&
            !string.IsNullOrEmpty(login) &&
            !string.IsNullOrEmpty(password))
            {
                if (!DAO.IsUserExists(login))
                {
                    DAO.dbSaveUser(name, lastName, login, password);
                    return true;
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!!!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
                return false;
            }
        }


        public bool entry(string login, string password) {
            if (DAO.IsUserExists(login)){
                User user = DAO.GetUserByLogin(login);
                if (user.Password == password) { 
                    return true;
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                    return false;
                }
            }
            
            return false;
        }
    }
}
