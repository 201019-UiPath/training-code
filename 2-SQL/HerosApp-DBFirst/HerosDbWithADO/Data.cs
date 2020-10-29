using System;
using Npgsql;
using System.Data;

namespace HerosDbWithADO
{
    public class Data
    {
    // - path to database 
        string conStr="Host=lallah.db.elephantsql.com; port=5432; Database=eiidauob; Username=eiidauob; password=Yn1w_m8JGLTxLNkRwF9JVyfWrvmci_--";
    // - create a connection
        NpgsqlConnection connection;
    // - Fire the query
        NpgsqlCommand command; // Connected
        NpgsqlDataAdapter dataAdapter; // disconnected
    // - get the results
        NpgsqlDataReader reader;// reads in connected fashion in forward only direction
        DataSet dataSet; // local storage to store output of DataAdapter in disconnected fashion

        string query="select * from Superpeople";

        public void GetSuperPersonConnected(){
            try{
                connection = new NpgsqlConnection(conStr);
                connection.Open();
                //command = new NpgsqlCommand(connection:connection, cmdText:query); //using named parameters
                command = new NpgsqlCommand(query, connection); 
                //return the results of query
                reader=command.ExecuteReader();
                // ExecuteReader reads value, used with select queries
                // ExecuteNonQuery used with Insert, delete and update
                while(reader.Read()){
                    Console.WriteLine($"{reader[0]} {reader[1]}");
                }
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
                // Log the exception
            }
            finally{
                connection.Close();
            }
        }

        public void GetSuperPersonDisConnected(){
            connection =new NpgsqlConnection(conStr);
            // DataAdapter - fires the query, get results when connection is available
            dataAdapter=new NpgsqlDataAdapter(query, connection);
            dataSet=new DataSet();// creating an in-memory Db
            int tables= dataAdapter.Fill(dataSet);
            if(tables!=0){
                foreach(DataRow rows in dataSet.Tables[0].Rows){
                    Console.WriteLine($"{rows["id"]}  {rows["workname"]}  {rows["hideout"]}");
                }
            }

        }
    }
}
