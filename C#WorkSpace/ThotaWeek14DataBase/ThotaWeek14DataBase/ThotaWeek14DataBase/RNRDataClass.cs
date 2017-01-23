using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ThotaWeek14DataBase
{
   public class RNRDataClass
    {
       //created by Sreeja Thota

       //this class connects to the database,
       //accepts a sqlstring and returns a DataSet

       //declaring connection;
       private SqlConnection rnrConnection;
       //connectionstring;
       string rnrConnectionString= ConfigurationManager.ConnectionStrings["ThotaWeek14DataBase.Properties.Settings.RnrBooksConnectionString"].ToString();

       //method that accepts a sqlstring and returns a adataset

       public DataSet getDataSet(string sqlString)
       {
           //declaring a dataset object which will be returned
           DataSet booksDataSet = new DataSet();
           try
           {
            //instantiate rnrconnection
               rnrConnection = new SqlConnection(rnrConnectionString);
               //instantiate adapter
               SqlDataAdapter rnrDataAdapter = new SqlDataAdapter(sqlString, rnrConnection);

               //open the connection
               rnrConnection.Open();
               //fill the dataset
               rnrDataAdapter.Fill(booksDataSet);

               //return the dataset
               return booksDataSet;
           }
           finally
           {
            //close the connection
               rnrConnection.Close();
           }
       }//end dataSet

    }
}
