﻿using System;
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
        public List<int> ImportAvgCars()
        {
            List<int> speed = new List<int>();
            try
            {
                conn.Open();
                MySqlCommand cmd;
                string searchQuery = @"SELECT * FROM intensiteit";
                cmd = new MySqlCommand(searchQuery, conn);

                cmd.Prepare();

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    speed.Add(dataReader.GetInt32("Intensiteit"));
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
                string searchQuery = @"SELECT intensiteit FROM Intensiteit";
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
            
            int countItteration = 1;
            int avgday = 0;
            int day = 1;
            List<int> AVGDay = new List<int>();
            foreach (int minute in intensity)
            {
                //Takes the speed of every minute and adds them up then devides them when they reach 1440 minutes (a day) to get the average
                if (countItteration < 1440)
                {
                    avgday = avgday + minute;
                    countItteration++;
                    //Console.WriteLine(countItteration);
                }
                else
                {
                    avgday = avgday / 1440;

                    AVGDay.Add(avgday); // activates the insert function to insert the created data into a model
                    day++;
                    avgday = 0;
                    countItteration = 1;
                }
            }
            return AVGDay;
        }
        public List<_2ValueNodes> ImportWeatherAndCars()
        {
            List<_2ValueNodes> valueNodes = new List<_2ValueNodes>();
            try
            {
                conn.Open();
                MySqlCommand cmd;
                string searchQuery = @"SELECT autosdag.gemAuto, weer.gemTemp FROM autosdag JOIN weer ON autosdag.dag=weer.datum";
                cmd = new MySqlCommand(searchQuery, conn);

                cmd.Prepare();

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int cars = dataReader.GetInt32("gemAuto");
                    int weather = dataReader.GetInt32("gemTemp");
                    weather = weather / 10;
                    valueNodes.Add(new _2ValueNodes(weather, cars));
                }
            }
            catch
            {
                MessageBox.Show("Importing speed/weather failed");
            }
            finally
            {
                conn.Close();
            }
            return valueNodes;
        }
    }

}
