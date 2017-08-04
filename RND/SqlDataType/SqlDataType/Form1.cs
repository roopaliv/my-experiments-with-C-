using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace SqlDataType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //DataSet ds = new DataSet("TestDataSet");
            //ds.ReadXml(@"C:\Users\rdev\Downloads\z3 entity type audit report_ExtractionTask.xml");
            //dataGridView1.DataSource = ds.Tables[0];
            //foreach (DataColumn dc in ds.Tables[0].Columns)
            //{
            //    Console.WriteLine(dc.ColumnName+"  "+dc.DataType);
            //}
            string input = "Rahulf\rVinod";
            
            string screw='"'+input+'"';
            //string str= string.Format(@""{0}"", input);
            //Path.Combine(input, @"\");


            string test1 = Regex.Replace(@input, @"\\", @"\\");   
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
        }
    }
}
