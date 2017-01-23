// Created by Rohit Sanka 700644555
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DBApplication
{
    public class ConnectClass
    {
        private SqlConnection rnrConnection;
        private string rnrConnectionString = ConfigurationManager.ConnectionStrings["DBApplication.Properties.Settings.RnrBooksConnectionString"].ConnectionString;
        private SqlDataAdapter booksAdapter;
        public string DBErrors { get; set; }
        private SqlConnection getConnection() {
            rnrConnection = new SqlConnection(rnrConnectionString);
            return rnrConnection;
        }

        private void openConnection() {
            if (rnrConnection.State == ConnectionState.Closed) {

                rnrConnection.Open();

            }
        }
        private void closeConnection() {

            rnrConnection.Close();
        }




        public int insertBooks(string ISBNString, string titleString, string authorString, string publisherString, string subjectCodeString, string shelfLocationString, bool fictionBoolean)
        {
            string sqlString = "INSERT INTO BOOKS (ISBN,Title,Author,Publisher,Subject_Code,Shelf_Location,Fiction) values(@ISBN,@Title,@Author,@Publisher,@Subject_Code,@Shelf_Location,@Fiction)";
            SqlCommand insertCommand = new SqlCommand(sqlString,this.getConnection());
            int insertResult = 0;
            try
            {
                insertCommand.Parameters.AddWithValue("@ISBN", ISBNString);
                insertCommand.Parameters.AddWithValue("@Title", titleString);
                insertCommand.Parameters.AddWithValue("@Author", authorString);
                insertCommand.Parameters.AddWithValue("@Publisher", publisherString);
                insertCommand.Parameters.AddWithValue("@Subject_Code", subjectCodeString);
                insertCommand.Parameters.AddWithValue("@Shelf_Location", shelfLocationString);
                insertCommand.Parameters.AddWithValue("@Fiction", fictionBoolean);
                this.openConnection();
                insertResult = insertCommand.ExecuteNonQuery();
                return insertResult;


            }
            catch (Exception ex)
            {
                DBErrors = ex.Message;
                return insertResult;
            }
            finally {

                this.closeConnection();
                insertCommand.Dispose();
            }


        }

        public DataTable selectBooksTable()
        {

            DataTable rnrBooksTable = new DataTable();
            string sqlString = "Select ISBN,Title,Author,Publisher,Subject_Code,Shelf_Location,Fiction From BOOKS";
            SqlCommand selectCommand = new SqlCommand(sqlString,this.getConnection());
            try {
                DataSet rnrDataSet = new DataSet();
                booksAdapter=new SqlDataAdapter(selectCommand);
                this.openConnection();
                booksAdapter.Fill(rnrDataSet);
                rnrBooksTable = rnrDataSet.Tables[0];
                return rnrBooksTable;

            }
            catch(Exception ex){
                DBErrors = ex.Message;
                return rnrBooksTable;
            }
        }

        public string updateChanges(DataTable booksDataTable)
        {

            try
            {
                this.openConnection();
                booksAdapter.Update(booksDataTable);
                return "Changed";
            }
            finally {
                this.closeConnection();
            }
        }

        
    }
}
