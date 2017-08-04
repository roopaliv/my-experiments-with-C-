using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Diagnostics;
using System.Threading;
namespace EditableDataGrid
{
    public enum ControlType
    {
        TEXT,
        DROPDOWN,
        DATETIME,
        BUTTON,
        RADIO_BTN_LIST,
        CHECKBOX_LIST
    }

    public partial class Form1 : Form
    {
        string XMLFilePath = @"C:\Users\rdev\Downloads\YieldAnalysis.xml";
        string ExistingXML = @"C:\Users\rdev\Desktop\PolarisCore\PolarisLibrary\Modules\PRisk\configs\ExposureStressAnalysis.xml";


        string TopMenuXML = @"C:\Users\rdev\Desktop\PolarisCore\PolarisUI\Polaris.Demo.UI\PolarisUI\ConfigFiles\TopMenu\AdminMenu.xml";
        string ViewConfigXMLPath = @"C:\Users\rdev\Desktop\PolarisCore\PolarisUI\Polaris.Demo.UI\PolarisUI\ConfigFiles\ViewConfig.xml";
        string MasterConfigXMLPath = @"C:\Users\rdev\Desktop\PolarisCore\PolarisUI\Polaris.Demo.UI\PolarisUI\ConfigFiles\MasterConfig.xml";
        string path = System.IO.Directory.GetCurrentDirectory();
        string startupPath = Environment.CurrentDirectory;

        public Form1()
        {
            InitializeComponent();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (Int64 i = 0; i < 100000; i++)
            {
                //Thread.Sleep(1);
            }
            sw.Stop();
            Console.WriteLine("IN ++"+sw.Elapsed);
            sw.Reset();
            sw.Start();
            for (Int64 i = 100000; i > 0; i--)
            { }
            sw.Stop();
            Console.WriteLine("IN --" + sw.Elapsed);
            //DataTable dt = new DataTable();
            //dt.Columns.Add("A");
            //dt.Columns.Add("B");
            //dt.Columns.Add("C");
            //dt.Columns.Add("D");

            //for (int j = 0; j < 20; j++)
            //{
            //    dt.Rows.Add("aa", "bb", "cc", "dd");
            //}
            //this.dataGridView1.DataSource = dt;
            ////this.dataGridView1.Paint += new PaintEventHandler(dataGridView1_Paint);
            //this.dataGridView1.Scroll += new ScrollEventHandler(dataGridView1_Scroll);
            //this.dataGridView1.CellPainting +=
            //    new DataGridViewCellPaintingEventHandler(dataGridView1_CellPainting);
            #region XML
            //string ASOfDate = "strategy";
            //ASOfDate=ASOfDate.Replace("_", " ");
            //string s = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ASOfDate.ToLower());
            //string paaaa = "com.ivp.polaris.core.ui.controls.reportviewer.ReportViewerPage.aspx?reportConfigKey=OpsCustomReport";
            //Regex rgMeter = new Regex("reportConfigKey=(.+)$");
            //string op=rgMeter.Match(paaaa).Groups[1].Value;
            //string pattern = @"[^ ]*$";
            //string input = "com.ivp.polaris.module.risk.configs.InvestmentDetails.xml";
            //Match rvrvr = Regex.Match(paaaa, pattern, RegexOptions.IgnoreCase);
            ////string op = input.Replace(".xml");


            //string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            //UriBuilder uri = new UriBuilder(codeBase);
            //string path = Uri.UnescapeDataString(uri.Path);
            //string Dname= Path.GetDirectoryName(path);

            //string xmlPath = "com.ivp.polaris.module.risk.configsYieldAnalysis.xml";
            //string fullPath = Assembly.GetAssembly(typeof(ControlType)).Location;

            ////get the folder that's in
            //string theDirectory = Path.GetDirectoryName(fullPath);


            //XDocument xdocTopMenu = XDocument.Load(TopMenuXML);
            ////string identifier = test.Split(new[] { "identifier" }, int.MaxValue, StringSplitOptions.None)[1].Split('=')[1].Trim();
            //string name = "a";
            //string Header = xdocTopMenu.Descendants("Item").Where(d => d.Attribute("sourcehref").Value.Contains("identifier")).Where(n => n.Attribute("sourcehref").Value.Split(new[] { "identifier" }, int.MaxValue, StringSplitOptions.None)[1].Split('=')[1].Trim() == name)
            //          .Select(n => n.Parent.Parent).Descendants("header").FirstOrDefault().Value.Trim();
            ////string final="";
            ////XDocument xdoc1 = XDocument.Load(ExistingXML);
            ////var name = xdoc1.Descendants("ReportViewerInfo").FirstOrDefault().Attribute("Id").Value;

            ////XDocument xdocViewConfig = XDocument.Load(ViewConfigXMLPath);
            ////var result5 = xdocViewConfig.Descendants("view").Where(n => n.Attribute("identifier").Value.Trim() == name)
            ////            .Select(n => n.Parent).FirstOrDefault();


            ////XDocument xdocTopMenu = XDocument.Load(TopMenuXML);
            

            ////var result4 = xdocTopMenu.Descendants("header").Where(n => n.Value.Trim() == "PnL DashBoards")
            ////             .Select(n => n.Parent).FirstOrDefault();
            ////bool eeee= result4.Descendants("Item").Where(n => n.Attribute("name").Value == "PnLash").Count() == 0 ? false : true;
            ////string test = "Home.aspx?identifier=ExposureStressAnalysis";
            //////string[] arr = test.Split(new []{"identifier"});
            ////string parts = test.Split(new[] { "identifier" }, int.MaxValue, StringSplitOptions.None)[1].Split('=')[1].Trim();

            ////XDocument xdocMasterConfig = XDocument.Load(MasterConfigXMLPath);
            ////var result3 = xdocMasterConfig.Descendants("reportViewer").FirstOrDefault();
            ////var rrrr = result3.Descendants("config");
            ////foreach (var Config in rrrr)
            ////{
            ////    var ConfigKey = Config.Attribute("key").Value;
            ////}

            ////var MasterExist = result3.Descendants("config").Where(n => n.Attribute("key").Value == "PnLDash").Count()==0?false:true;
            ////XDocument xdoc = XDocument.Load(TopMenuXML);
            ////var result= xdoc.Descendants("header");
           
            ////var result1 = xdoc.Descendants("header").Where(n => n.Value.Trim() == "PnL DashBoards")
            ////            .Select(n => n.Parent).ToArray();
            
            ////var result2 = xdocViewConfig.Descendants("PnL").FirstOrDefault();
            ////result2.Add();


            ////string Type=string.Empty;
            ////var result1 = xdoc.Descendants("ScriptInfo").Where(n => n.Attribute("Id").Value == "KeyMetrics")
            ////      .Select(n => n.Parent).ToArray();
            ////if (result1.Count() == 0)
            ////{
            ////    var result = xdoc.Descendants("AssemblyInfo").Where(n => n.Attribute("Id").Value == "KeyMetrics")
            ////           .Select(n => n.Parent).ToArray();
            ////   Type = result[0].Name.ToString();
            ////}
            ////else
            ////{
            ////    Type = result1[0].Name.ToString();
            ////}
            ////DataSet dsBinding = new DataSet();
            ////dsBinding.ReadXml(XMLFilePath);
            ////DataTable dtPanelInfo = dsBinding.Tables["PanelInfo"];
            ////DataTable dtContainerInfo = dsBinding.Tables["ContainerInfo"];
            ////DataTable dtControlInfo = dsBinding.Tables["ControlInfo"];
            ////DataTable dtValueInfo = dsBinding.Tables["ValueInfo"];
            ////DataTable dtControls = new DataTable();
            ////dtControls.Columns.Add("Type", typeof(string));
            ////dtControls.Columns.Add("Id", typeof(string));
            ////dtControls.Columns.Add("Label", typeof(string));
            ////dtControls.Columns.Add("BindingId", typeof(string));
            ////dtControls.Columns.Add("BindingType", typeof(string));
            ////dtControls.Columns.Add("Value", typeof(string));
            ////foreach (DataRow drControlInfo in dtControlInfo.Rows)
            ////{
            ////    string ControlInfo_Id = drControlInfo["ControlInfo_Id"].ToString();
            ////    DataRow[] drarr = dtValueInfo.Select("ControlInfo_Id = '"+ControlInfo_Id+"'");
            ////    DataRow drControl = dtControls.NewRow();
            ////    drControl["Type"] = drControlInfo["Type"];
            ////    drControl["Id"] = drControlInfo["Type"];
            ////    drControl["Label"] = drControlInfo["Type"];
            ////    drControl["BindingId"] = drarr[0]["BindingId"];
            ////    drControl["BindingType"] = drarr[0]["BindingType"];
            ////    drControl["Value"] = "20091230";
            ////    dtControls.Rows.Add(drControl);
            ////}

            ////var BindingParent = from result in xdoc.Descendants("BindingInfo")
            ////                    select result;

            ////if (BindingParent.Count() == 0)
            ////{

            ////    XElement bindinginfo = new XElement("BindingInfo");
            ////    xdoc.Element("ReportViewerInfo").Add(bindinginfo);
            ////    xdoc.Save(XMLFilePath);
            ////}
            ////else
            ////{
            ////    var AssemblyBinding = from result in xdoc.Descendants("AssemblyBindings")
            ////                        select result;
            ////    if (AssemblyBinding.Count() == 0)
            ////    {
            ////        XElement Assemblybinding = new XElement("AssemblyBindings");
            ////        xdoc.Element("ReportViewerInfo").Element("BindingInfo").Add(Assemblybinding);
            ////        xdoc.Save(XMLFilePath);
            ////    }
            ////    else
            ////    {
            ////        XElement AssemblyInfo = new XElement("AssemblyInfo", new XAttribute("Id", "KeyMetrics"), new XAttribute("ClassName", "PTableau"));
            ////        xdoc.Element("ReportViewerInfo").Element("BindingInfo").Element("AssemblyBindings").Add(AssemblyInfo);
            ////        xdoc.Save(XMLFilePath);
            ////    }
            ////}
            ////XElement xelement = XElement.Load(XMLFilePath);
            ////////XDocument xdoc = XDocument.Load(XMLFilePath);            

            ////////var BindingParent = from result in xdoc.Descendants("BindingInfo")
            ////////                    select result;

            ////////if (BindingParent.Count() == 0)
            ////////{

            ////////    XElement bindinginfo = new XElement("BindingInfo");
            ////////    xdoc.Element("ReportViewerInfo").Add(bindinginfo);
            ////////    xdoc.Save(XMLFilePath);
            ////////}
            ////////else
            ////////{
            ////////    var AssemblyBinding = from result in xdoc.Descendants("AssemblyBindings")
            ////////                        select result;
            ////////    if (AssemblyBinding.Count() == 0)
            ////////    {
            ////////        XElement Assemblybinding = new XElement("AssemblyBindings");
            ////////        xdoc.Element("ReportViewerInfo").Element("BindingInfo").Add(Assemblybinding);
            ////////        xdoc.Save(XMLFilePath);
            ////////    }
            ////////    else
            ////////    {
            ////////        XElement AssemblyInfo = new XElement("AssemblyInfo", new XAttribute("Id", "KeyMetrics"), new XAttribute("ClassName", "PTableau"));
            ////////        xdoc.Element("ReportViewerInfo").Element("BindingInfo").Element("AssemblyBindings").Add(AssemblyInfo);
            ////////        xdoc.Save(XMLFilePath);
            ////////    }
            ////////}
            #endregion XML
        }
        void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //merge the cell[1,1] and cell[2,1]
            if (e.RowIndex == 1)
            {
                if (e.ColumnIndex == 1)
                {
                    e.PaintBackground(e.ClipBounds, true);
                    Rectangle r = e.CellBounds;
                    Rectangle r1 = this.dataGridView1.GetCellDisplayRectangle(2, 1, true);
                    r.Width += r1.Width - 1;
                    r.Height -= 1;
                    using (SolidBrush brBk = new SolidBrush(e.CellStyle.BackColor))
                    using (SolidBrush brFr = new SolidBrush(e.CellStyle.ForeColor))
                    {
                        e.Graphics.FillRectangle(brBk, r);
                        StringFormat sf = new StringFormat();
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;
                        e.Graphics.DrawString("cell merged", e.CellStyle.Font, brFr, r, sf);
                    }
                    e.Handled = true;
                }
                if (e.ColumnIndex == 2)
                {
                    using (Pen p = new Pen(this.dataGridView1.GridColor))
                    {
                        e.Graphics.DrawLine(p, e.CellBounds.Left, e.CellBounds.Bottom - 1,
                            e.CellBounds.Right, e.CellBounds.Bottom - 1);
                        e.Graphics.DrawLine(p, e.CellBounds.Right - 1, e.CellBounds.Top,
                            e.CellBounds.Right - 1, e.CellBounds.Bottom);
                    }
                    e.Handled = true;
                }
            }
        }

        void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            //only redraw the cell[1,1] and cell[2,1] when scrolling
            this.dataGridView1.InvalidateCell(1, 1);
            this.dataGridView1.InvalidateCell(2, 1);
        }
    }

    public class HMergedCell : DataGridViewTextBoxCell
    {
        private int m_nLeftColumn = 0;
        private int m_nRightColumn = 0;

        /// <summary>
        /// Column Index of the left-most cell to be merged.
        /// This cell controls the merged text.
        /// </summary>
        public int LeftColumn
        {
            get { return m_nLeftColumn; }
            set { m_nLeftColumn = value; }
        }

        /// <summary>
        /// Column Index of the right-most cell to be merged
        /// </summary>
        public int RightColumn
        {
            get { return m_nRightColumn; }
            set { m_nRightColumn = value; }
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle,
        DataGridViewPaintParts paintParts)
        {
            try
            {
                int mergeindex = ColumnIndex - m_nLeftColumn;
                int i = 0;
                int nWidth = 0;
                int nWidthLeft = 0;
                string strText = null;

                Pen pen = new Pen(Brushes.Black);

                // Draw the background
                graphics.FillRectangle(new SolidBrush(SystemColors.Control), cellBounds);

                // Draw the separator for rows
                graphics.DrawLine(new Pen(new SolidBrush(SystemColors.ControlDark)), cellBounds.Left, cellBounds.Bottom - 1, cellBounds.Right, cellBounds.Bottom - 1);

                // Draw the right vertical line for the cell
                if (ColumnIndex == m_nRightColumn)
                {
                    graphics.DrawLine(new Pen(new SolidBrush(SystemColors.ControlDark)), cellBounds.Right - 1, cellBounds.Top, cellBounds.Right - 1, cellBounds.Bottom);
                }

                // Draw the text
                RectangleF rectDest = RectangleF.Empty;
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                sf.Trimming = StringTrimming.EllipsisCharacter;

                // Determine the total width of the merged cell
                nWidth = 0;
                for (i = m_nLeftColumn; i <= m_nRightColumn; i++)
                {
                    nWidth += this.OwningRow.Cells[i].Size.Width;
                }

                // Determine the width before the current cell.
                nWidthLeft = 0;
                for (i = m_nLeftColumn; i <= ColumnIndex - 1; i++)
                {
                    nWidthLeft += this.OwningRow.Cells[i].Size.Width;
                }

                // Retrieve the text to be displayed
                strText = this.OwningRow.Cells[m_nLeftColumn].Value.ToString();

                rectDest = new RectangleF(cellBounds.Left - nWidthLeft, cellBounds.Top, nWidth, cellBounds.Height);
                graphics.DrawString(strText, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, rectDest, sf);
            }
            catch (Exception ex)
            {
                //Trace.WriteLine(ex.ToString());
            }
        }

    }

}
