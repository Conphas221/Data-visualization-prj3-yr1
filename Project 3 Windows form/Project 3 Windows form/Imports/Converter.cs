using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//new usings
using Project_3_Windows_form.Imports;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Project_3_Windows_form
{
    class Converter: IConnection
    {
        A13Import importer = new A13Import();
        public void ConvertDatabaseToNewList(List<int> data)
        {
            createTable(@"DROP TABLE IF EXISTS snelheid_c78; CREATE TABLE IF NOT EXISTS `snelheid_c78` (`dag` date DEFAULT NULL, `gemSnelheid` int(11) DEFAULT NULL);");
            DateTime date = new DateTime(2011/1/1);
            date = date.AddYears(2010); // correction due to the original date being 0001/01/01 for unknown reasons
            date = date.Date;
            int countItteration= 1;
            int avgday = 0;
            //int day = 1;
            
            foreach (int minute in data)
            {
                //Takes the speed of every minute and adds them up then devides them when they reach 1440 minutes (a day) to get the average
                if(countItteration < 1440)
                {
                    avgday = avgday + minute;
                    countItteration++;
                }
                else
                {
                    avgday = avgday / 1440;
                    InsertNewValues(date.Date, avgday); // activates the insert function to insert the created data into a model
                    date = date.AddDays(1);
                    avgday = 0;
                    countItteration = 1;
                }
            }
            MessageBox.Show("Importing finished");
        }
        private void createTable(string query)//creates a table using a query
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch {

            }
            finally
            {
                conn.Close();
            }
        }
        public void InsertNewValues(DateTime day, int avgspeed)
        {
            try
            {
                conn.Open();
                string query = @"INSERT INTO snelheid_c78 (dag, gemSnelheid) VALUES (@day, @gemSnelheid)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd = new MySqlCommand(query, conn);

                MySqlParameter dayParam = new MySqlParameter("@day", MySqlDbType.Date);
                MySqlParameter gemSnelheidParam = new MySqlParameter("@gemSnelheid", MySqlDbType.Int32);

                dayParam.Value = day.ToString();
                gemSnelheidParam.Value = avgspeed;

                cmd.Parameters.Add(dayParam);
                cmd.Parameters.Add(gemSnelheidParam);

                cmd.Prepare();

                cmd.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Updaten van Contact mislukt");
            }
            finally
            {
                conn.Close();
            }

        }
        public void ConvertDatabase(List<int> data)
        {
            createTable(@"DROP TABLE IF EXISTS autosDag; CREATE TABLE IF NOT EXISTS `autosDag` (`dag` date DEFAULT NULL, `gemAuto` int(11) DEFAULT NULL);");
            DateTime date = new DateTime(2011 / 1 / 1);
            date = date.AddYears(2010); // correction due to the original date being 0001/01/01 for unknown reasons
            date = date.Date;
            int countItteration = 1;
            int avgday = 0;

            foreach (int minute in data)
            {
                //Takes the speed of every minute and adds them up then devides them when they reach 1440 minutes (a day) to get the average
                if (countItteration < 1440)
                {
                    avgday = avgday + minute;
                    countItteration++;
                }
                else
                {
                    avgday = avgday / 1440;
                    InsertNewAutos(date.Date, avgday); // activates the insert function to insert the created data into a model
                    date = date.AddDays(1);
                    avgday = 0;
                    countItteration = 1;
                }
            }
            MessageBox.Show("Importing finished");
        }
        public void InsertNewAutos(DateTime day, int avgspeed)
        {
            try
            {
                conn.Open();
                string query = @"INSERT INTO autosDag (dag, gemAuto) VALUES (@day, @gemSnelheid)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd = new MySqlCommand(query, conn);

                MySqlParameter dayParam = new MySqlParameter("@day", MySqlDbType.Date);
                MySqlParameter gemSnelheidParam = new MySqlParameter("@gemSnelheid", MySqlDbType.Int32);

                dayParam.Value = day.ToString();
                gemSnelheidParam.Value = avgspeed;

                cmd.Parameters.Add(dayParam);
                cmd.Parameters.Add(gemSnelheidParam);

                cmd.Prepare();

                cmd.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Updating Cars failed");
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
