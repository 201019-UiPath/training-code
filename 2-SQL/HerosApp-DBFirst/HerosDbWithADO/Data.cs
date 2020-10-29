using System;
using Npgsql;

namespace HerosDbWithADO
{
    public class Data
    {
    // - path to database 
        string conStr="Host=lallah.db.elephantsql.com; port=5432; Database=eiidauob; Username=eiidauob; password=Yn1w_m8JGLTxLNkRwF9JVyfWrvmci_--";
    // - create a connection
        NpgsqlConnection connection;
    // - Fire the query
        NpgsqlCommand command;
    // - get the results
        NpgsqlDataReader reader;
        string query="select * from Superpeople";

        public void GetSuperPersonConnected(){
            try{
                connection = new NpgsqlConnection(conStr);
                connection.Open();
                //command = new NpgsqlCommand(connection:connection, cmdText:query); //using named parameters
                command = new NpgsqlCommand(query, connection); 
                //return the results of query
                reader=command.ExecuteReader();
                // Execute Reader reads value, used with select queries
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
    }
}
