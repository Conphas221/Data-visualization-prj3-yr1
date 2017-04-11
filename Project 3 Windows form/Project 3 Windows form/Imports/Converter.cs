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
        public void ConvertDatabaseToNewList(List<int> data)
        {
            createTable(@"DROP TABLE IF EXISTS snelheidDag; CREATE TABLE IF NOT EXISTS `snelheidDag` (`dag` date DEFAULT NULL, `gemSnelheid` int(11) DEFAULT NULL);");

            A13Import importer = new A13Import(); // gets the list to convert
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
                string query = @"INSERT INTO snelheidDag (dag, gemSnelheid) VALUES (@day, @gemSnelheid)";

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
    }
}
