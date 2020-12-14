using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using LAZYANT_LIB;

namespace PMIS
{
    public class Export
    {

        public class ToExcel {

            static String WrkPth = System.Windows.Forms.Application.StartupPath + "\\Template\\";

            public static void Issuance(Boolean IsRequest, System.Data.DataTable dt, Hashtable hd)
            {

                String MyFilePtah = "";
                MyFilePtah = WrkPth + "Issuance.xlsx";
                Microsoft.Office.Interop.Excel.Application xl = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Worksheet ws;

                try
                {

                    ws = xl.Workbooks.Open(@MyFilePtah).Sheets["Sheet1"];

                    ws.Cells[5, 5] = hd["RISNo"];
                    ws.Cells[6, 5] = hd["SAINo"];
                    ws.Cells[7, 1] = hd["College"];
                    ws.Cells[7, 3] = hd["Code"];
                    ws.Cells[35, 6] = hd["Total"];
                    ws.Cells[36, 2] = hd["Purpose"];
                    ws.Cells[41, 3] = hd["RequestedBy"];
                    ws.Cells[43, 3] = hd["RequestedDate"];

                    if (IsRequest == false)
                    {
                        ws.Cells[41, 4] = hd["ApproveBy"];
                        ws.Cells[41, 5] = hd["IssuedDate"];
                        ws.Cells[41, 6] = hd["RecieveDate"];
                        ws.Cells[43, 4] = hd["ApproveDate"];
                        ws.Cells[43, 5] = hd["IssuedDate"];
                        ws.Cells[43, 6] = hd["RecieveBy"];
                    }

                    int r = 12;

                    foreach (System.Data.DataRow row in dt.Rows)
                    {
                        ws.Cells[r, 1] = row["Item_no"];
                        ws.Cells[r, 2] = row["Unit"];
                        ws.Cells[r, 3] = row["ItemName"];
                        ws.Cells[r, 5] = row["Quantity"];
                        ws.Cells[r, 6] = row["UnitPrice"];
                        ws.Cells[r, 7] = row["totalCost"];

                        r++;
                    }

                    SaveFileDialog sv = new SaveFileDialog();
                    string fname = "";
                    sv.Filter = "Excel (*.xlsx)|*.xlsx";
                    sv.ShowDialog();

                    if (sv.FileName != "")
                    {
                        fname = sv.FileName;
                        sv.OverwritePrompt = false;
                        ws.SaveAs(fname);

                        sv.Dispose();
                        xl.Workbooks.Close();
                        xl.Quit();
                        System.Diagnostics.Process.Start(fname);

                    }
                    else { xl.Quit(); }

                  
                }
                catch (Exception e)
                {
                    Msg.Error(e.Message.ToString()); 
                }

            }

            public static void AdjustmentDaily(System.Data.DataTable dt, DateTime d)
            {
                String MyFilePtah = "";
                MyFilePtah = WrkPth + "Adjustment.xlsx";
                Microsoft.Office.Interop.Excel.Application xl = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Worksheet ws;

                try
                {

                    ws = xl.Workbooks.Open(@MyFilePtah).Sheets["Sheet1"];
                    ws.Cells[1, 1] = "Adjustment Summary of stocks for Date of " + d.ToString("MMMM dd, yyyy");

                    Double t1 = 0, t2 = 0, t3 = 0, t4 = 0;
                    int r = 5;

                    foreach (System.Data.DataRow row in dt.Rows)
                    {
                        ws.Cells[r, 1] = row["Stock_No"];
                        ws.Cells[r, 2] = row["ItemName"];
                        ws.Cells[r, 3] = row["UnitPrice"];
                        ws.Cells[r, 4] = row["Stock_Begin"];
                        ws.Cells[r, 5] = row["ItemUnit"];
                        ws.Cells[r, 6] = Convert.ToDouble(row["Stock_Begin"]) * Convert.ToDouble(row["UnitPrice"]);
                        t1 = t1 + Convert.ToDouble(row["Stock_Begin"]) * Convert.ToDouble(row["UnitPrice"]);
                        ws.Cells[r, 7] = row["Stock_Purchase"];
                        ws.Cells[r, 8] = row["ItemUnit"];
                        ws.Cells[r, 9] = Convert.ToDouble(row["Stock_Purchase"]) * Convert.ToDouble(row["UnitPrice"]);
                        t2 = t2 + Convert.ToDouble(row["Stock_Purchase"]) * Convert.ToDouble(row["UnitPrice"]);
                        ws.Cells[r, 10] = row["Stock_Out"];
                        ws.Cells[r, 11] = row["ItemUnit"];
                        ws.Cells[r, 12] = Convert.ToDouble(row["Stock_Out"]) * Convert.ToDouble(row["UnitPrice"]);
                        t3 = t3 + Convert.ToDouble(row["Stock_Out"]) * Convert.ToDouble(row["UnitPrice"]);
                        ws.Cells[r, 13] = row["Stock_End"];
                        ws.Cells[r, 14] = row["ItemUnit"];
                        ws.Cells[r, 15] = Convert.ToDouble(row["Stock_End"]) * Convert.ToDouble(row["UnitPrice"]);
                        t4 = t4 + Convert.ToDouble(row["Stock_End"]) * Convert.ToDouble(row["UnitPrice"]);
                        r++;
                    }

                    ws.Cells[29, 5] = t1;
                    ws.Cells[29, 8] = t2;
                    ws.Cells[29, 11] = t3;
                    ws.Cells[29, 14] = t4;

                    SaveFileDialog sv = new SaveFileDialog();
                    string fname = "";
                    sv.Filter = "Excel (*.xlsx)|*.xlsx";
                    sv.ShowDialog();

                    if (sv.FileName != "")
                    {
                        fname = sv.FileName;
                        sv.OverwritePrompt = false;
                        ws.SaveAs(fname);

                        sv.Dispose();
                        xl.Workbooks.Close();
                        xl.Quit();
                        System.Diagnostics.Process.Start(fname);

                    }
                    else {
                        xl.Quit();
                    }

                    
                }
                catch (Exception e)
                {
                    Msg.Error(e.Message.ToString());
                }
            }

            public static void AdjustmentMonthly(System.Data.DataTable dt, String year, String month)
            {
                String MyFilePtah = "";
                MyFilePtah = WrkPth + "Adjustment.xlsx";
                Microsoft.Office.Interop.Excel.Application xl = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Worksheet ws;

                try
                {

                    ws = xl.Workbooks.Open(@MyFilePtah).Sheets["Sheet1"];
                    ws.Cells[1, 1] = "Adjustment Summary of stocks for Year of " + year + " and " + Microsoft.VisualBasic.DateAndTime.MonthName(Convert.ToInt32(month)).ToString().ToUpper();

                    Double t1 = 0, t2 = 0, t3 = 0, t4 = 0;
                    int r = 5;

                    foreach (System.Data.DataRow row in dt.Rows)
                    {
                        ws.Cells[r, 1] = row["Stock_No"];
                        ws.Cells[r, 2] = row["ItemName"];
                        ws.Cells[r, 3] = row["UnitPrice"];
                        ws.Cells[r, 4] = row["Stock_Begin"];
                        ws.Cells[r, 5] = row["ItemUnit"];
                        ws.Cells[r, 6] = Convert.ToDouble(row["Stock_Begin"]) * Convert.ToDouble(row["UnitPrice"]);
                        t1 = t1 + Convert.ToDouble(row["Stock_Begin"]) * Convert.ToDouble(row["UnitPrice"]);
                        ws.Cells[r, 7] = row["Stock_Purchase"];
                        ws.Cells[r, 8] = row["ItemUnit"];
                        ws.Cells[r, 9] = Convert.ToDouble(row["Stock_Purchase"]) * Convert.ToDouble(row["UnitPrice"]);
                        t2 = t2 + Convert.ToDouble(row["Stock_Purchase"]) * Convert.ToDouble(row["UnitPrice"]);
                        ws.Cells[r, 10] = row["Stock_Out"];
                        ws.Cells[r, 11] = row["ItemUnit"];
                        ws.Cells[r, 12] = Convert.ToDouble(row["Stock_Out"]) * Convert.ToDouble(row["UnitPrice"]);
                        t3 = t3 + Convert.ToDouble(row["Stock_Out"]) * Convert.ToDouble(row["UnitPrice"]);
                        ws.Cells[r, 13] = row["Stock_End"];
                        ws.Cells[r, 14] = row["ItemUnit"];
                        ws.Cells[r, 15] = Convert.ToDouble(row["Stock_End"]) * Convert.ToDouble(row["UnitPrice"]);
                        t4 = t4 + Convert.ToDouble(row["Stock_End"]) * Convert.ToDouble(row["UnitPrice"]);
                        r++;
                    }

                    ws.Cells[29, 5] = t1;
                    ws.Cells[29, 8] = t2;
                    ws.Cells[29, 11] = t3;
                    ws.Cells[29, 14] = t4;

                    SaveFileDialog sv = new SaveFileDialog();
                    string fname = "";
                    sv.Filter = "Excel (*.xlsx)|*.xlsx";
                    sv.FileName = "";
                    sv.ShowDialog();

                    if (sv.FileName != "")
                    {
                        fname = sv.FileName;
                        sv.OverwritePrompt = false;
                        ws.SaveAs(fname);

                        sv.Dispose();
                        xl.Workbooks.Close();
                        
                        System.Diagnostics.Process.Start(fname);

                    }

                    xl.Quit();
            
                }
                catch (Exception e)
                {
                    Msg.Error(e.Message.ToString());
                }
            }

        }
    }
}
