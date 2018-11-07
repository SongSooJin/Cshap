using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;


// [DataTable Public Property]
// [SQL명령 표시 예제– 콘솔 응용 프로그램]

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            OracleConnection thisConnection = new OracleConnection(
            @"data source=topcredu;User ID=scott;Password=tiger");

            thisConnection.Open();

            OracleDataAdapter thisAdapter = new
            OracleDataAdapter("SELECT * from emp", thisConnection);

            OracleCommandBuilder thisBuilder = new OracleCommandBuilder(thisAdapter);

            Console.WriteLine("SQL SELECT Command is:\n{0}\n",
                                thisAdapter.SelectCommand.CommandText);

            OracleCommand updateCommand = thisBuilder.GetUpdateCommand();
            Console.WriteLine("SQL UPDATE Command is:\n{0}\n",
                                updateCommand.CommandText);

            OracleCommand insertCommand = thisBuilder.GetInsertCommand();
            Console.WriteLine("SQL INSERT Command is:\n{0}\n",
                                insertCommand.CommandText);

            OracleCommand deleteCommand = thisBuilder.GetDeleteCommand();
            Console.WriteLine("SQL DELETE Command is:\n{0}",
                                deleteCommand.CommandText);

            thisConnection.Close();
        }
    }
}
