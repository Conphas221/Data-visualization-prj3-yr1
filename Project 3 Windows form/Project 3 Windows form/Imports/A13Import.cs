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
    class A13Import : Aimport
    {
            public List<int> ImportSpeeds(int search)
            {
                List<int> speed = new List<int>();
                try
                {
                    conn.Open();
                    MySqlCommand cmd;
                    string searchQuery = @"SELECT * FROM a13 WHERE snelheid LIKE @search";
                    cmd = new MySqlCommand(searchQuery, conn);

                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                    cmd.Prepare();

                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        speed.Add(dataReader.GetInt32("snelheid"));
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
        }
    }
