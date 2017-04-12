using MySql.Data.MySqlClient;

namespace Project_3_Windows_form.Imports
{
    public abstract class IConnection
    {
        protected MySqlConnection conn;

        public IConnection()
        {
            //Fill in the correct Database information, correct to your own database for own use
            conn = new MySqlConnection("Uid=root;Pwd=4690;Database=a13;");
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
