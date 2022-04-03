using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
namespace Tava.Controllers
{
    class CheckDatabase
    {
        private const string SqlConnection = "Persist Security Info=False; Integrated Security=true; Initial Catalog=Tava; server=(local); TrustServerCertificate=True";

        public void Check()
        {
            bool alreadyExists;
            var fromMaster = SqlConnection.Replace("Initial Catalog=Tava", "Initial Catalog=master");

            const string cmdText = "SELECT COUNT(*) FROM master.dbo.sysdatabases where name=@database";

            using (var sqlConn = new SqlConnection(fromMaster))
            {
                using (var sqlCmd = new SqlCommand(cmdText, sqlConn))
                {
                    sqlCmd.Parameters.Add("@database", SqlDbType.NVarChar).Value = "Tava";

                    sqlConn.Open();
                    alreadyExists = Convert.ToInt32(sqlCmd.ExecuteScalar()) == 1;
                }
            }

            if (!alreadyExists)
            {
                CreateDatabase();
            }
        }

        private void CreateDatabase()
        {
            try
            {
                var fromMaster = SqlConnection.Replace("Initial Catalog=Tava", "Initial Catalog=master");
                var connectionString = new SqlConnection(fromMaster);

                connectionString.Open();

                var desiredPath = Environment.CurrentDirectory.Replace("\\Tava\\bin\\Debug\\net5.0-windows",
                    "\\Database");
                var data = File.ReadAllText(desiredPath + @"\tava-sv.sql");
                var server = new Server(new ServerConnection(connectionString));
                server.ConnectionContext.ExecuteNonQuery(data);

            }
            catch (Exception errorFound)
            {
                MessageBox.Show($"There was an error: {errorFound.Message}");
            }
        }
    }
}
