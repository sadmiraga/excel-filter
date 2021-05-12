using System;
using System.Windows.Forms;
using System.Collections.Generic;
//custom using 
using Aspose.Cells;
using MSExcel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
//using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;


//destinatario |  provincia + spedizione 

namespace xlsFilter
{

    

    public partial class Form1 : Form
    {

        //function for editing raw cell value to ID
        public string cutID(string uneditedID)
        {
            //remove name
            uneditedID = uneditedID.Substring(uneditedID.LastIndexOf("#") + 1);

            //remove chars
            char variableCheck = uneditedID[uneditedID.Length - 1];

            while (!Char.IsNumber(variableCheck))
                {
                    uneditedID = uneditedID.Substring(0, uneditedID.Length - 1);
                    variableCheck = uneditedID[uneditedID.Length - 1];

                }

            return uneditedID;
        }

        public string excelPath = "";
        public string savePath = "";
        public string backSlash =  @"\";
        public string newExcelName = "";

        //excel data 
        List<string> ids = new List<string>();
        List<string> trackingNumbers = new List<string>();


        private MSExcel._Application excel;
        private MSExcel._Workbook workbook;
        private MSExcel._Worksheet worksheet;
        private MSExcel.Sheets sheet;

        public Form1()
        {
            InitializeComponent();
        }

        //browse for excel file
        private void excelButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Excel Worksheets 2003(*.xls)|*.xls|Excel Worksheets 2007(*.xlsx)|*.xlsx|Word Documents(*.doc)|*.doc";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                excelPath = sFileName;
                excelLabel.Text = excelPath;
            }
        }

        //generate filtered excel file 
        private void generateButton_Click(object sender, EventArgs e)
        {
            if(excelPath != "") { 

            Excel.Application existingApp = new Excel.Application();
            Excel.Workbook xlWorkbook1 = existingApp.Workbooks.Open(excelPath);
            Excel._Worksheet xlWorksheet1 = xlWorkbook1.Sheets[1];
            Excel.Range xlRange = xlWorksheet1.UsedRange;

            int rowCount = xlRange.Rows.Count; //redovi - prema dole, 
            int colCount = xlRange.Columns.Count; // kolone - u stranu

            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    //store tracking number
                    if (j == 1 && i!=1)
                    {
                        string fullTrackingNumber = "GO" + xlRange.Cells[i, j].Value2.ToString();
                        trackingNumbers.Add(fullTrackingNumber);
                    }

                    //store ID
                    if(j==11 && i != 1)
                    {
                        //get value from excel
                        string fullid = xlRange.Cells[i, j].Value2.ToString();                        
                        ids.Add(cutID(fullid));
                    } // end of excel access ID IF
                }
             }


            //choose folder where to save excel file
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    savePath = fbd.SelectedPath;
                }
            }

            //generate full path for excel file
            if(fileNameInput.Text == "")
                {
                    newExcelName = "sadmir";
                } else
                {
                    newExcelName = fileNameInput.Text;
                }

            string fullPath = savePath + backSlash + newExcelName + ".xlsx";

            //create app
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[1, 1] = "ID";
            xlWorkSheet.Cells[1, 2] = "Tracking Number";
           
            for(int i = 0; i <= ids.Count-1; i++)
            {
                xlWorkSheet.Cells[i+2, 1] = ids[i];
                xlWorkSheet.Cells[i+2, 2] = trackingNumbers[i];
            }

            xlWorkBook.SaveAs(fullPath, 51);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            MessageBox.Show("Filtered excel file created, you can find it in \n "+fullPath);

            //clear data for next one
            excelPath = "";
            savePath = "";
            newExcelName = "";
            excelLabel.Text = "";

            } else
            {
                MessageBox.Show("Choose excel file first");
            }

        } // end of generate button function 
    }
}
