// Created by Rohit Sanka 700644555

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SankaWeek15DBApplication
{
    public partial class rnrForm : Form
    {
        public rnrForm()
        {
            InitializeComponent();
        }
        private DBApplication.ConnectClass rnrDBConnect = new DBApplication.ConnectClass();
        DataTable booksDataTable;
        private void InsertRowButton_Click(object sender, EventArgs e)
        {

            try {
                string ISBNString = ISBNTextBox.Text;
                string titleString = TitletTextBox.Text;
                string authorString = AuthorTextBox.Text;
                string publisherString = PublisherTextBox.Text;
                string subjectCodeString = SubjectCodeTextBox.Text;
                string shelfLocationString = ShelfLocationTextBox.Text;
                bool fictionBoolean = fictionBool();
                int result = rnrDBConnect.insertBooks(ISBNString, titleString, authorString, publisherString, subjectCodeString, shelfLocationString, fictionBoolean);

            }

            catch(Exception ex){
                errorLabel1.Text = string.Format(ex.Message);
            }
        }


        private bool fictionBool() { 
        return(FictionComboBox.SelectedIndex==0?true:false);
        
        
        }
        
        private void UbdataDatabaseButton_Click(object sender, EventArgs e)
        {

            try {

                dataGridView1.EndEdit();
                booksDataTable.AcceptChanges();
                string result = rnrDBConnect.updateChanges(booksDataTable);
                if(result!=""){
                    errorLabel1.Text = result;

                }
            }
                catch(Exception ex){
                errorLabel1.Text=ex.Message;
                }
            }
        

        
    

    

        private void rnrForm_Load(object sender, EventArgs e)
        {
            booksDataTable = rnrDBConnect.selectBooksTable();
            if (booksDataTable != null)
            {
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = booksDataTable;
            }
            else {
                errorLabel1.Text = rnrDBConnect.DBErrors;
            }
        }





    }
}
