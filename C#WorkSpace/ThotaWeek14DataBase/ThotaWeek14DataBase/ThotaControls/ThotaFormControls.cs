using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ThotaControls
{
    public partial class ThotaFormControls : Form
    {
        public ThotaFormControls()
        {
            InitializeComponent();
        }

        private void ThotaFormControls_Load(object sender, EventArgs e)
        {
            //instantiate the class
            ThotaWeek14DataBase.RNRDataClass rnrDataClass = new ThotaWeek14DataBase.RNRDataClass();
            //create the sqlstring
            string sqlStr = "SELECT ISBN,Title,Author, Publisher, Subject_code,Subject,Fiction from Books join Subjects on (SubjectCode=Subject_Code)";
            //declare a dataset and call the method get data
            DataSet booksDataSet = rnrDataClass.getDataSet(sqlStr);

            //databindings
            // declaring a binding source
            BindingSource bookBindingSource = new BindingSource();
            bookBindingSource.DataSource = booksDataSet.Tables[0];

            //assigning one table in the dataset as datasource.

            //sort the data in the binding source on author
            bookBindingSource.Sort = "Author";

            AuthorcomboBox.Items.Clear();
            AuthorcomboBox.DataSource = bookBindingSource;
            AuthorcomboBox.DisplayMember = "Author";
            AuthorcomboBox.ValueMember = "ISBN";
            AuthorcomboBox.DataBindings.Add("text", bookBindingSource, "Author", false, DataSourceUpdateMode.Never);
            //Databindings for textbox
            TitletextBox.DataBindings.Add("text", bookBindingSource, "Title", false, DataSourceUpdateMode.Never);
            PublishertextBox.DataBindings.Add("text", bookBindingSource, "Publisher", false, DataSourceUpdateMode.Never);
            SubjectCodetextBox.DataBindings.Add("text", bookBindingSource, "Subject_Code", false, DataSourceUpdateMode.Never);
            SubjecttextBox.DataBindings.Add("text", bookBindingSource, "Subject", false, DataSourceUpdateMode.Never);
            FictiontextBox.DataBindings.Add("text", bookBindingSource, "Fiction", false, DataSourceUpdateMode.Never);
        }
    }
}
