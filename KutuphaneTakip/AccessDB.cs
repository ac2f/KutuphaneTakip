using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
namespace KutuphaneTakip
{
    public partial class AccessDB
    {
        public Dictionary<string, string> tables = new Dictionary<string, string>() { };
        string dbFile;
        public OleDbConnection connection;
        public AccessDB(string dbFile)
        {
            this.dbFile = dbFile;
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbFile);
            connection.Open();
        }
        public void AddNewTable(string key, string table)
        {
            tables[key] = table;
        }

        public string SubString(string text, int start, int end)
        {
            string last = "";
            for (int i = start; i < end && i < text.Length; i++)
            {
                last += text[i];
            }
            return last;
        }

        public DataTable GetRows(string tableKey, string condition = "")
        {
            string table = tables[tableKey];
            DataTable dt = new DataTable();
            new OleDbDataAdapter("SELECT * FROM " + table + " " + condition, this.connection).Fill(dt);
            return dt;
        }
        public DataTable GetRows(string tableKey, string condition, string innerJoinTableKey, string innerJoinOnColumn)
        {
            string tableMain = tables[tableKey];
            string tableInnerJoiner = tables[innerJoinTableKey];
            DataTable dt = new DataTable();
            new OleDbDataAdapter("SELECT * FROM " + tableMain + " " + condition + " INNER JOIN " + tableInnerJoiner + "  ON "+tableInnerJoiner+"." + innerJoinOnColumn + "="+tableMain+"." + innerJoinOnColumn, this.connection).Fill(dt);
            return dt;
        }
        public int SumColumn(string tableKey, string column, string condition = "")
        {
            string table = tables[tableKey];
            DataTable dt = new DataTable();
            new OleDbDataAdapter("SELECT SUM(" + column + ") as total FROM " + table + " " + condition, connection).Fill(dt);
            //return dt.Rows[0].Field<int>("total");
            return int.Parse(dt.Rows[0].Field<double>("total").ToString());
        }
        public int CountColumn(string tableKey, string column, string condition = "")
        {
            string table = tables[tableKey];
            DataTable dt = new DataTable();
            new OleDbDataAdapter("SELECT COUNT(" + column + ") as total FROM " + table + " " + condition, connection).Fill(dt);
            //return dt.Rows[0].Field<int>("total");
            return int.Parse(dt.Rows[0].Field<int>("total").ToString());
        }
        public void ExecuteQuery(string query)
        {
            System.Windows.Forms.MessageBox.Show(query);
            new OleDbCommand(query, connection).ExecuteNonQuery();
        }
        public string CreateExactCondition(Dictionary<string, string> data)
        {
            string sqlString = " WHERE ";
            if (data.Keys.Count < 1)
                return "";
            foreach (var item in data)
            {
                sqlString += (item.Key + "='" + item.Value + "' and ");
            };
            sqlString = this.SubString(sqlString, 0, sqlString.Length - 5);
            return sqlString;
        }
        public void ClearTable(string tableKey)
        {
            string table = tables[tableKey];
            new OleDbCommand("DELETE FROM " + table).ExecuteNonQuery();
        }
        public string CreateLikeCondition(string key, string value)
        {
            string sqlString = " WHERE " + key + " LIKE '*"+ value + "*'";
            return sqlString;
        } 
        public string CreateLikeCondition(string[] keys, string value)
        {
            string sqlString = " WHERE ";
            foreach (string key in keys)
            {
                sqlString += (key + " LIKE '%" + value + "%' or ");
            }
            sqlString = this.SubString(sqlString, 0, sqlString.Length - 3);
            return sqlString;
        }
        public string CreateDeleteQueryString(string tableKey, string condition = "")
        {
            string table = tables[tableKey];
            return "DELETE FROM " + table + " " + condition;
        }
        public string CreateUpdateQueryString(string tableKey, Dictionary<string, string> data, string condition = "")
        {
            string sqlString = "UPDATE " + tableKey + " SET ";
            foreach (var item in data)
            {
                sqlString += (item.Key + "='" + item.Value + "', ");
            }
            sqlString = this.SubString(sqlString, 0, sqlString.Length - 2) + " " + condition;
            return sqlString;
        }
        public string CreateInsertIntoQueryString(string tableKey, Dictionary<string, string> data)
        {
            string table = tables[tableKey];
            string sqlString = "INSERT INTO " + table + " (";
            foreach (var item in data)
            {
                sqlString += item.Key + ", ";
            }
            sqlString = SubString(sqlString, 0, sqlString.Length - 2) + ") VALUES (";
            foreach (var item in data)
            {
                sqlString += "'" + item.Value + "', ";
            }
            sqlString = SubString(sqlString, 0, sqlString.Length - 2) + ")";
            sqlString.Substring(0, sqlString.Length - 2);
            return sqlString;
        }
    }
}