using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//new usings
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Project_3_Windows_form.Imports
{
    public class A13Import : IConnection
    {
            public List<int> ImportSpeeds()
            {
                List<int> speed = new List<int>();
                try
                {
                    conn.Open();
                    MySqlCommand cmd;
                    string searchQuery = @"SELECT * FROM Snelheid";
                    cmd = new MySqlCommand(searchQuery, conn);

                    cmd.Prepare();

                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        speed.Add(dataReader.GetInt32("Snelheid"));
                    }
                }
                catch
                {
                    MessageBox.Show("Importing speed failed");
                }
                finally
                {
                    conn.Close();
                }
                return speed;
            }
        public List<int> ImportAVGdailySpeed()
        {
            List<int> speed = new List<int>();
            try
            {
                conn.Open();
                MySqlCommand cmd;
                string searchQuery = @"SELECT gemSnelheid FROM snelheiddag";
                cmd = new MySqlCommand(searchQuery, conn);

                cmd.Prepare();

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    speed.Add(dataReader.GetInt32("gemSnelheid"));
                }
            }
            catch
            {
                MessageBox.Show("Importing speed failed");
            }
            finally
            {
                conn.Close();
            }
            return speed;
        }
        public List<int> ImportAVGCarsAmount()
        {
            List<int> intensity = new List<int>();
            try
            {
                conn.Open();
                MySqlCommand cmd;
                string searchQuery = @"SELECT * FROM Intensiteit";
                cmd = new MySqlCommand(searchQuery, conn);

                cmd.Prepare();

                MySqlDataReader datareader = cmd.ExecuteReader();

                while (datareader.Read())
                {
                    intensity.Add(datareader.GetInt32("Intensiteit"));
                }
            }
            catch
            {
                MessageBox.Show("Importing intensity failed");
            }
            finally
            {
                conn.Close();
            }
            return intensity;
        }
    }
    
}
