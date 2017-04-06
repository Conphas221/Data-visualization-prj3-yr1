using MySql.Data.MySqlClient;

namespace Project_3_Windows_form.Imports
{
    public abstract class Aimport
    {
        protected MySqlConnection conn;

        public Aimport()
        {
            //Fill in the correct Database information
            conn = new MySqlConnection("Uid=root;pwd=;Database=a13;");
        }
        // Converts null values to useable values
        public string DataReaderGetStringNull(string value, MySqlDataReader dataReader)
        {
            int ordinal = dataReader.GetOrdinal(value);
            return dataReader.IsDBNull(ordinal) ? null : dataReader.GetString(ordinal);
        }
        public int DataReaderGetIntNull(string value, MySqlDataReader dataReader)
        {

            int ordinal = dataReader.GetOrdinal(value);
            return dataReader.IsDBNull(ordinal) ? 0 : dataReader.GetInt32(ordinal);
        }
    }
}
