using AirProject.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AirProject.DB
{
    public class BoatDAO
    {
        public BoatDAO() { }
        public static MySqlConnection connection = DBconnection.getConnection();

        public static List<Boat> GetItemsWithClass(string classValue)
        {
            List<Boat> items = new List<Boat>();

            try
            {
                connection.Open();
                string selectQuery = "SELECT id, name, class, model, has_must, price, rower_seat_count FROM boats WHERE class = @class";
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                cmd.Parameters.AddWithValue("@class", classValue);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Boat item = new Boat()
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("name"),
                            Class = reader.GetString("class"),
                            Model = reader.GetString("model"),
                            Has_must = reader.GetString("has_must"),
                            Price = reader.GetDecimal("price"),
                            RowerSeatCount = reader.GetInt32("rower_seat_count")
                        };
                        items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка получения объектов!");
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return items;
        }

        public static void saveBoat(Boat boat)
        {
            try
            {
                connection.Open();
                string saveQuery = "INSERT INTO boats(name, class, model, has_must, price, rower_seat_count) VALUES(@name, @class,@model, @has_must, @price,@rower_seat_count)";
                MySqlCommand cmd = new MySqlCommand(saveQuery, connection);
                cmd.Parameters.AddWithValue("@name", boat.Name);
                cmd.Parameters.AddWithValue("@class", boat.Class);
                cmd.Parameters.AddWithValue("@model", boat.Model);
                cmd.Parameters.AddWithValue("@has_must", boat.Has_must);
                cmd.Parameters.AddWithValue("@price", boat.Price);
                cmd.Parameters.AddWithValue("@rower_seat_count", boat.RowerSeatCount);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Яхта сохранена");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка сохранения яхты!");
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
