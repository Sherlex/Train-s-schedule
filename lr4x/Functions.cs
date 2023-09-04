using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace lr4x
{
    public class TrainScheduleDB
    {

        public TrainScheduleDB(string filename, string tableName)
        {
            Connection = new SQLiteConnection();
            SQLCommand = new SQLiteCommand();
            file_name = filename;
            table_name = tableName;
        }

        public bool IsConnected
        {
            get
            {
                return Connection.State == ConnectionState.Open;
            }
        }

        public bool CreateAndConnect()
        {
            if (File.Exists(file_name))
            {
                return false;
            }

            SQLiteConnection.CreateFile(file_name);
            Connect();
            Create();
            return true;
        }

        public bool ConnectToExisting()
        {
            if (!File.Exists(file_name))
            {
                return false;
            }

            Connect();
            return true;
        }

        public DataTable ReadAll()
        {
            DataTable data_table = new DataTable();
            string sql_query = $"SELECT * FROM {table_name}";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql_query, Connection);
            adapter.Fill(data_table);
            return data_table;
        }

        public void Add(TrainSchedule train_schedule)
        {
            SQLCommand.CommandText = $"INSERT INTO {table_name} ('Number', 'Departure', 'Arrival', 'Departure_time', 'Arrival_time') " +
            $"values ('{ train_schedule.Number}' , '{train_schedule.Departure}', '{train_schedule.Arrival}', '{train_schedule.Departure_time}', " +
            $"'{train_schedule.Arrival_time}')";
            SQLCommand.ExecuteNonQuery();
        }

        public void Edit(int id, TrainSchedule item)
        {
            SQLCommand.CommandText = $"UPDATE {table_name} SET 'Number' = '{item.Number}', 'Departure'='{item.Departure}'," +
                 $"'Arrival'='{item.Arrival}', 'Departure_time'='{item.Departure_time}', 'Arrival_time'='{item.Arrival_time}' " +
                                  $"WHERE id = {id}";
            SQLCommand.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            SQLCommand.CommandText = $"DELETE FROM {table_name} WHERE id = {id}";
            SQLCommand.ExecuteNonQuery();
        }

        public void ClearAll()
        {
            SQLCommand.CommandText = $"DROP TABLE {table_name}";
            SQLCommand.ExecuteNonQuery();
            Create();
        }

        private string file_name { get; }
        private string table_name { get; }
        private SQLiteConnection Connection { get; set; }
        private SQLiteCommand SQLCommand { get; set; }

        private void Create()
        {
            SQLCommand.CommandText = $"CREATE TABLE IF NOT EXISTS {table_name} " +
                                 $"(id INTEGER PRIMARY KEY AUTOINCREMENT, Number TEXT, Departure TEXT, Arrival TEXT, Departure_time TEXT, Arrival_time TEXT)";
            SQLCommand.ExecuteNonQuery();
        }

        private void Connect()
        {
            Connection = new SQLiteConnection("Data Source=" + file_name + ";Version=3;");
            Connection.Open();
            SQLCommand.Connection = Connection;
        }

    }

    public class TrainSchedule
    {
        public TrainSchedule(string number, string departure, string arrival, string departure_time, string arrival_time)
        {
            Number = number;
            Departure = departure;
            Arrival = arrival;
            Departure_time = departure_time;
            Arrival_time = arrival_time;
        }

        public string Number { get; }
        public string Departure { get; }
        public string Arrival { get; }
        public string Departure_time { get; }
        public string Arrival_time { get; }
    }
}
