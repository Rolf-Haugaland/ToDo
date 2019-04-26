using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ToDo
{
    public class ConfigurationManager
    {
        public string GetConnectionString()
        {
            if (StaticInfo.curretnDatabase == null)
                throw new Exception("staticinfo.currentdatabase is null(GetConnectionString in ConfigurationManager)");
            return "server=" + StaticInfo.curretnDatabase.IP + ";port=" + StaticInfo.curretnDatabase.port.ToString() + ";database=" +
                StaticInfo.curretnDatabase.databaseName + ";uid=" + StaticInfo.curretnDatabase.username + ";pwd=" + StaticInfo.curretnDatabase.password + ";";
        }

        public void UploadToDo(ToDo todo)
        {
            MySqlConnection con = new MySqlConnection(GetConnectionString());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into ToDo(WhatToDo,WhenToDo,ToDo.Type,ToDo.References) VALUES('" + todo.WhatToDo + "',@DateTime,'" + todo.type + "','" + string.Join("#$", todo.References) + "')";
            MySqlParameter paramdatetime = new MySqlParameter()
            {
                Value = todo.When,
                ParameterName = "@DateTime"
            };
            cmd.Parameters.Add(paramdatetime);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<ToDo> GetFromDatabase()
        {
            if (StaticInfo.curretnDatabase == null)
                throw new Exception("Error, database is null(GetFromDatabase)");

            MySqlConnection con = new MySqlConnection(GetConnectionString());
            MySqlCommand cmd = new MySqlCommand("select * from ToDo", con);

            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();


            List<ToDo> ToDos = new List<ToDo>();

            string[] a = { "#", "$" };

            while (reader.Read())
            {
                ToDo todo = new ToDo()
                {
                    type = reader["type"].ToString(),
                    WhatToDo = reader["WhatToDo"].ToString(),
                    When = Convert.ToDateTime(reader["WhenToDo"].ToString()),
                    IDFromDB = Convert.ToInt32(reader["ID"])
                };

                string AllReferences = reader["references"].ToString();
                List<string> allReferencesList = AllReferences.Split(a, StringSplitOptions.None).ToList();
                if(allReferencesList != null)
                {
                    todo.References = reader["references"].ToString().Split(a, StringSplitOptions.None).ToList();
                }
                else
                {
                    List<string> onelist = new List<string>();
                    onelist.Add(reader["references"].ToString());
                    todo.References = onelist;
                }

                ToDos.Add(todo);
            }
            con.Close();
            return ToDos;
        }
    }
}
