using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

// Adapter를 사용하지 않고 DB 다루는 예제// DataReader 사용 

namespace ConsoleApp5
{
    class CommandExam
    {
        static OleDbConnection cn;
        public static void Main() {
            OleCn();
            Openning();

            Console.WriteLine("The Original Table");
            Output();

            Console.WriteLine("Added Table");
            Adding();
            Output();

            Console.WriteLine("Modified Table");
            Modifying();
            Output();

            Console.WriteLine("Deleted Table");
            Deleting();
            Output();

            Closing();
        }

        public static void OleCn() {
            string OleCnString = ("Provider = OraOLEDB.Oracle;data source = topcredu;User ID = scott;Password = tiger");
            cn = new OleDbConnection(OleCnString);
        }

        public static void Openning() {
            cn.Open();
        }

        public static void Output() {
            string sql = "select empno id, ename name from emp";
            OleDbCommand cmd;
            OleDbDataReader dr;
            
            cmd = new OleDbCommand(sql,cn);
            dr = cmd.ExecuteReader();

            Console.Write("\n");

            while (dr.Read()) {
                Console.WriteLine("{0, -10}\t{1,-10}",dr[0].ToString().Trim(),
                    dr[1].ToString().Trim());
            }
            Console.Write("\n");
            dr.Close();
        }

        public static void Adding() {
            try
            {
                string sqladd = "INSERT INTO emp (empno,ename) VALUES (5698,'OJC')";
                OleDbCommand cmdAdd = new OleDbCommand(sqladd, cn);

                int rowsadded = cmdAdd.ExecuteNonQuery();
                Console.WriteLine("Number of rows added: " + rowsadded);
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        }

        public static void Modifying() {
            try
            {
                string sqlmodify = "update emp set ename = '오닷넷' where empno = 5698";
                OleDbCommand cmdupdate = new OleDbCommand(sqlmodify, cn);
                int rows = cmdupdate.ExecuteNonQuery();
                Console.WriteLine("Number of rows modified: " + rows);
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        }

        public static void Deleting() {
            try
            {
                string sqldelete = "delete from emp where empno = 5698";
                OleDbCommand cmddelete = new OleDbCommand(sqldelete, cn);
                int rows = cmddelete.ExecuteNonQuery();
                Console.WriteLine("Number of rows deleted: " + rows);
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        }

        public static void Closing() {
            cn.Close();
        }
    }
}
