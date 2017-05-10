using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  //Its for MySQL 

namespace Productor_Consumidor
{
    class ComandosSQL
    {
        public void showData()
        {
            try
            {
                string MyConnection2 = "server=127.0.0.1;user id=sa;password=;database=sys";
                //Display query  
                string QueryUpdate = "select * from lista_transaccion;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(QueryUpdate, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
               // DataTable dTable = new DataTable();
              //  MyAdapter.Fill(dTable);
               // dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                   // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void insertData(int quantity, String origin, String destiny)
        {
            try
            {

                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "server=127.0.0.1;user id=sa;password=12345678;database=sys";
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "Insert into lista_transaccion(origen,destino) values('" + origin + "','" + destiny + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MyConn2.Open();
                // Here our query will be executed and data saved into the database.
                //for (int i = 0; i < Convert.ToInt32(quantity); i++)
                {
                    MySqlDataReader MyReader2;
                    MyReader2 = MyCommand2.ExecuteReader();
                    MyReader2.Close();

                }

               Console.WriteLine("Save Data");
                MyConn2.Close();
               // showData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteData(String origin, String destiny)
        {
            try
            {
                string MyConnection2 = "server=127.0.0.1;user id=sa;password=12345678;database=sys";
                string Query = "delete from lista_transaccion where origen='" + origin + "' and destino = '" + destiny + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                Console.WriteLine("Data Deleted");
                while (MyReader2.Read())
                {
                }
                MyReader2.Close();
                MyConn2.Close();
                showData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
