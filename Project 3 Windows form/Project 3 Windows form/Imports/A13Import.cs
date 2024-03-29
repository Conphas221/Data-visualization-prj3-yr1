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
        // imports the speeds from the database
        public List<int> ImportSpeeds()
        {
            List<int> speed = new List<int>();
            try
            {
                conn.Open();
                MySqlCommand cmd;
                string searchQuery = @"SELECT * FROM intensiteit_c78";
                cmd = new MySqlCommand(searchQuery, conn);

                cmd.Prepare();

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    speed.Add(dataReader.GetInt32("intensiteitc78"));
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

        // imports the avarage amount of carss each minute and returns it in a list of intergers
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
                MessageBox.Show("Importing  avg cars failed");
            }
            finally
            {
                conn.Close();
            }
            return speed;
        }

        //IMports the speed from the converted daily speed model
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
        //Takes the intensety model and converts it into dayly numbers
        public List<int> ImportAVGCarsAmount()
        {
            List<int> intensity = ImportAvgCars();
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

        // imports weather and average amount of cars and returns it as one tuple
        public List<Tuple<int, int>> ImportWeatherAndCars()
        {
            List<Tuple<int, int>> ValueNodes = new List<Tuple<int, int>>();
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
                    ValueNodes.Add(new Tuple<int, int>(weather, cars));
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
            return ValueNodes;
        }

        // imports the average amount of cars at 2 different milestones
        public List<Tuple<int, int>> Import2CarAverage()
        {
            List<Tuple<int, int>> ValueNodes = new List<Tuple<int, int>>();
            try
            {
                conn.Open();
                MySqlCommand cmd;
                string searchQuery = @"select snelheid_c78.gemSnelheid78, snelheiddag.gemSnelheid from snelheid_c78 join snelheiddag on snelheid_c78.dag=snelheiddag.dag;";
                cmd = new MySqlCommand(searchQuery, conn);

                cmd.Prepare();

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int snelheidMijlpaal78 = dataReader.GetInt32("gemSnelheid78");
                    int snelheidMijlpaal142 = dataReader.GetInt32("gemSnelheid");
                    ValueNodes.Add(new Tuple<int, int>(snelheidMijlpaal78, snelheidMijlpaal142));
                }
            }
            catch
            {
                MessageBox.Show("Importing average cars failed");
            }
            finally
            {
                conn.Close();
            }
            return ValueNodes;
        }
    }

}
