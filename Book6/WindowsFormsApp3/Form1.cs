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

//  Transaction 예제 
// Transaction : 하나의 논리적인 단위 
// 트랜잭션이 성공과 실패가 분명하고 상호 독립적이며, 일관되고 믿을 수 있는 시스템을 의미한다.
// 되면 다되고 안되면 다 안되어야 함 

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbDataAdapter adapter = null;
        DataSet ds = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            ds = new DataSet("emp");

            string conStr = "Provider = OraOLEDB.Oracle;data source = topcredu;User ID = scott;Password = tiger";

            using (OleDbConnection connection = new OleDbConnection(conStr)) {
                OleDbCommand command = new OleDbCommand();
                OleDbTransaction tr = null;

                try
                {
                    connection.Open();
                    // tr은 트랜잭션
                    tr = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = tr;

                    command.CommandText = "insert into emp (empno,ename)"
                        + "values (9865,'3000 길동')";
                    int i = command.ExecuteNonQuery();
                    Console.WriteLine(i + "건 Inserted!");

                    command.CommandText = "insert into emp (empno,ename)"
                        + "values (2653,'3000 길동')";
                    i = command.ExecuteNonQuery();

                    tr.Commit(); // 전부 DB에 저장 

                    adapter = new OleDbDataAdapter("select * from emp", connection);
                    adapter.Fill(ds, "EMP");
                    dataGridView1.DataSource = ds.Tables["EMP"];

                    adapter.Fill(ds, "EMP");
                }
                catch (Exception ex)
                {
                    tr?.Rollback(); // 에러났으니 전부다 취소 
                    MessageBox.Show(ex.Message, "emp Table Loading Error");
                }
                finally {
                    connection.Close();
                }
            }
        }
    }
}
