using MarkdownLog;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;
using System.IO;



namespace Calculation_public_services
{
    internal class Maneger_DB
    {
        public string name;
        List<string> tables = new List<string>();
        static string dB_info = "W:/all_files/programing/c#/site/c#site/Calculation public services/dataBase/TestDB.db";

        public Maneger_DB() { }
        public Maneger_DB(string name )
        {
            this.name = name ;

            if (!File.Exists(name))
                SQLiteConnection.CreateFile(name); // если базы данных нету, то создать базу данных
        }

        public void Cread_Table(string tableName)
        {
            this.tables.Add(tableName);
            using(SQLiteConnection Connect = new SQLiteConnection($"Data Source={name}; Version=3;")) // в строке указывается к какой базе подключаемся

            {
                // строка запроса, который надо будет выполнить

                string commandText = $"CREATE TABLE IF NOT EXISTS [{tableName}] " +
                    "( [id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                    "[name_service] TEXT," +
                    "[metric] TEXT," +
                    "[volume] REAL," +
                    "[tariff] REAL," +
                    "[summa_in_service] REAL" +
                    ")"; // создать таблицу, если её нет
                Conect_table(commandText, Connect);
            }
        }

        public void Data_in_service(int id_service, decimal volume_in_month, decimal summa_in_service)
        {
            var vale = Convert_Duble(volume_in_month);
            var pay = Convert_Duble(summa_in_service);
            
            Dictionary <string,object > dict = new Dictionary<string,object>();
            dict = Get_Date_Tariff_info (id_service);
            var tar = Convert_Duble(dict["tariff"]);
            string table = tables[tables.Count - 1];
            using(SQLiteConnection Connect = new SQLiteConnection($"Data Source={name}; Version=3;"))// в строке указывается к какой базе подключаемся
            {
                string commandText = $"INSERT INTO {table} " +
                    $"(name_service,metric,volume,tariff,summa_in_service ) " +
                    $"VALUES (" +
                    $"\"{dict["Name"]}\"," +
                    $"\"{dict["metric"]}\"," +
                    $"\"{vale:F5}\"," +
                    $"\" {tar} \", " +
                    $"\"{pay}\");";

                Conect_table(commandText, Connect);
                
            }
        }

        void Conect_table(string commandText, SQLiteConnection Connect)
        {
            SQLiteCommand Command = new SQLiteCommand(commandText, Connect);

            Connect.Open(); // открыть соединение

            Command.ExecuteNonQuery(); // выполнить запрос

            Connect.Close(); // закрыть соединение}
        }

        public Dictionary<string, object> Get_Date_Tariff_info(int id)=>Get_Date(dB_info, "Tariff_Info", id);
        public Dictionary<string, object> Get_Date_Total_Valume(int id)=>Get_Date(dB_info, "Totol_valume", id);
        Dictionary<string, object> Get_Date(string dataBase , string table, int id) 
        {
            var date = new Dictionary<string, object>();

            string commandText = $"SELECT * FROM {table} WHERE id ={id};";

            SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={dataBase}; Version=3;");

            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand(commandText, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            

            while (reader.Read())
            {
                for (int i = 0; i < 5; i++)
                {
                    if (!reader.IsDBNull(i))
                    {
                        object m = reader[i];
                        date.Add(reader.GetName(i), m);
                    }
                }
            }

            m_dbConnection.Close();
            return date;
        }

        string Convert_Duble(object n) 
        { 
            var val = Convert.ToString(n).Split(',');
            string s_vale = $"{val[0]}.{val[1]}";
            return s_vale;        
        }
        public void Set_Date(string table, int id , string name, decimal vale) 
        {
            var s_vale = Convert_Duble(vale);
            string commandText = $"UPDATE {table} SET {name} = \"{s_vale}\" WHERE id = {id};";  
            SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source={dB_info}; Version=3;");
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand(commandText, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close() ;
        }
       
        
        
        public List<object>[] Get_table_info(string dB ,string table) 
        {
            string commandText = $"SELECT * FROM {table};";

            SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source=\"W:/all_files/programing/c#/site/c#site/Calculation public services/dataBase/{dB}.db\"; Version=3;");

            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand(commandText, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            List<object>[] arr = new List<object>[1];
            while (reader.Read())
            {
                Array.Resize(ref arr ,reader.StepCount);
                List<object> list = new List<object>();
                for (int i = 0; i < reader.FieldCount; i++) 
                {
                    var m = reader[i];
                    list.Add(m);
                }                
                arr[arr.Length-1] = list;                
            }
            return arr;
         }

        internal string[] Get_table_name(string dB)
        {
            string commandText = $"SELECT name FROM sqlite_master WHERE type = \"table\";";

            SQLiteConnection m_dbConnection = new SQLiteConnection($"Data Source=\"W:/all_files/programing/c#/site/c#site/Calculation public services/dataBase/{dB}.db\"; Version=3;");

            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand(commandText, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            string[] arr = new string[1];
            var caunt = 0;
            while (reader.Read()) 
            {               
                Array.Resize(ref arr, reader.StepCount);
                var m = reader["name"];
                arr[arr.Length - 1] = (string)m;
                caunt++;                
            }
            return arr;
        }

    }
}
