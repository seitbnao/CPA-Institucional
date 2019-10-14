using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Sistema___CPA.Arquivos
{
    public class DataBase
    {
        private string connString;
        public MySqlConnection conn;

        /*
CREATE USER 'fessulpa_cpa'@'%' IDENTIFIED VIA mysql_native_password USING '***';GRANT ALL PRIVILEGES ON *.* TO 'fessulpa_cpa'@'%' REQUIRE NONE WITH GRANT OPTION MAX_QUERIES_PER_HOUR 0 MAX_CONNECTIONS_PER_HOUR 0 MAX_UPDATES_PER_HOUR 0 MAX_USER_CONNECTIONS 0;
         * */
        public DataBase(string server = "SERVIDOR_02", string database = "provas", string uid = "fessulpa_cpa", string password = "fessulpa2019")
        {
            try
            {
                connString = string.Format("server={0};database={1};user={2};password={3}", server, database, uid, password);
                conn = new MySqlConnection(connString);
            }
           catch(Exception Ex)
            {
                MessageBox.Show("Erro ao conectar com o servidor de aplicação");
                return;
            }
        }
         
        public void Init()
        {
            try
            {
                conn.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        } //Close connection
        public bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        } //open connection to database
        public bool OpenConnection()
        {
            try
            {
                CloseConnection();
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Não foi possível se conectar no banco de dados.  Contate o administrador");
                        break;

                    case 1045:
                        MessageBox.Show("Usuário e/ou senha inválido, por favor tente novamente");
                        break;
                }
                return false;
            }
        }
        public void processQuery(string query, Action<MySqlDataReader> fn)
        {
            try
            {
                using (var connection = conn)
                {
                    connection.Close();
                    connection.Open();
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            fn(reader);
                        }
                    }
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message + "Query:" + query);
                return;
            }
        }
        public bool Query(String Texto)
        {
           
            string query = Texto;

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, conn);

                //Execute command
                cmd.ExecuteNonQuery();
                
                //close connection
                this.CloseConnection();
                return true;
            }
            return false;
        }

        public bool sendMenssage(string Text)
        {
            DialogResult result = MessageBox.Show(Text, "FESSULPA - CPA", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Close()
        {
            try
            {
                conn.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
