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
        public void ConvertDatabaseToNewList()
        {
            A13Import importer = new A13Import();
            List<int> data = importer.ImportSpeeds(); // gets the list to convert
            int countItteration= 1;
            int avgday = 0;
            int day = 1;
            createTableSnelheidDag();
            foreach(int minute in data)
            {
                //Takes the speed of every minute and adds them up then devides them when they reach 1440 minutes (a day) to get the average
                if(countItteration < 1440)
                {
                    avgday = avgday + minute;
                    countItteration++;
                    //Console.WriteLine(countItteration);
                }
                else
                {
                    avgday = avgday / 1440;

                    InsertNewValues(day, avgday); // activates the insert function to insert the created data into a model
                    day++;
                    avgday = 0;
                    countItteration = 1;
                }
            }
            MessageBox.Show("Importing finished");
        }
        private void createTableSnelheidDag()
        {
            try
            {
                conn.Open();
                string query = @"DROP TABLE IF EXISTS snelheidDag; CREATE TABLE IF NOT EXISTS `snelheidDag` (`dag` int(11) DEFAULT NULL, `gemSnelheid` int(11) DEFAULT NULL);";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                conn.Close();
            }
        }
        public void InsertNewValues(int day, int avgspeed)
        {
            try
            {
                conn.Open();
                string query = @"CREATE TABLE IF NOT EXISTS `snelheidDag` (`dag` int(11) DEFAULT NULL, `gemSnelheid` int(11) DEFAULT NULL);";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                query = @"INSERT INTO snelheidDag (dag, gemSnelheid) VALUES (@day, @gemSnelheid)";

                cmd = new MySqlCommand(query, conn);

                MySqlParameter dayParam = new MySqlParameter("@day", MySqlDbType.Int32);
                MySqlParameter gemSnelheidParam = new MySqlParameter("@gemSnelheid", MySqlDbType.Int32);

                dayParam.Value = day;
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
    }
}
