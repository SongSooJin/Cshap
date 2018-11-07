using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

// DB Connection
// [간단한 입력 예제, 오라클 scott계정의 EMP Table에 한건의 데이터를 간단히 입력]

namespace OracleTest
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = null;
        OleDbDataAdapter adapter = null;
        DataSet ds = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ds = new DataSet("emp"); // 메모리에 있는 DB 

                string conStr = "Provider=OraOLEDB.Oracle;data source=topcredu;User ID = scott;Password = tiger";

                conn = new OleDbConnection(conStr);
                conn.Open();

                OleDbCommand command = new OleDbCommand("insert into emp(empno,ename) values(5429, 'OJC')", conn);
                command.ExecuteNonQuery();

                adapter = new OleDbDataAdapter("select * from emp where ename='OJC' ", conn);
                adapter.Fill(ds,"EMP");
                dataGridView1.DataSource = ds.Tables["EMP"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "emp Table Loading Error");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
