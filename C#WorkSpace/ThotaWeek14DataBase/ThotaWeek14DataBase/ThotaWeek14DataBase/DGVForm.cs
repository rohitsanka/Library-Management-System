using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThotaWeek14DataBase
{
    public partial class ThotaDGVForm : Form
    {
        public ThotaDGVForm()
        {
            InitializeComponent();
        }


        private void ThotaDGVForm_Load(object sender, EventArgs e)
        {
            //instantiate the class
            RNRDataClass rnrDataClass = new RNRDataClass();
            //create the sqlstring
            string sqlStr = "SELECT Title,Author, Publisher, Subject_code,Fiction from Books ";
            //declare a dataset object
            DataSet booksData = new DataSet();

            //call the class mathod to get the dataset
            booksData = rnrDataClass.getDataSet(sqlStr);

            //set up the dgv column and assign data source
            dataGridView1.AutoGenerateColumns = true;

            //assign dataSource(data set)
            dataGridView1.DataSource = booksData.Tables[0];

        }
    }
}
