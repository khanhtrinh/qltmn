using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.Collections;

namespace WindowsFormsApplication1
{
    public class Dynamic_contain
    {
        public int[] ID_TP_Dy = new int[1000];          //Mang ID thuc pham thay doi
        public int count_DC = 0;                        //Dem so thuc pham thay doi
        //public int count_TP_input=0;
        public string[] buffer = new string[1000];

        //Cac bien dung cho chuc nang moi(28-8)
        public int[] id_store_arr_hn = new int[1000];       //id_tp hang ngay du tru
        public int[] id_store_arr_kho = new int[1000];      //id_tp kho du tru
        public int[] store_arr_hn = new int[1000];          //luong thuc pham hang ngay du tru [id_tp hang ngay du tru]
        public int[] store_arr_kho = new int[1000];         //luong thuc pham kho du tru [id_tp kho du tru
        public int[] id_add_arr_hn = new int[1000];         //id_tp hang ngay mua them
        public int[] id_add_arr_kho = new int[1000];        //id_tp kho xuat them
        public int[] id_sub_arr_hn = new int[1000];         //id_tp hang ngay tra lai
        public int[] id_sub_arr_kho = new int[1000];        //id_tp kho nhap lai

        //public string[] today = new string[1000];

        public Dynamic_contain()
        {
            query_DC();
        }

        //Doc co so du lieu
        public void query_DC()
        {
            StreamReader sr_DC = File.OpenText("data/database/TP_linhdong.dat");
            string input = null;
            while ((input = sr_DC.ReadLine()) != null)
            {
                buffer[count_DC] = input;
                string me = buffer[count_DC];
                ID_TP_Dy[count_DC] = Int32.Parse(me);
                count_DC++;
            }
            sr_DC.Close();
        }

        //Ham ghi vao file
        public void write_file()
        {
            string write_DC = "";

            for (int i = 0; i < count_DC; i++)
            {
                write_DC += ID_TP_Dy[i];
            }
            File.WriteAllText("data/database/TP_linhdong.dat", write_DC);
        }

        //Ham insert TP linh dong vao file
        public void insertToFile(string tpld)
        {
            StreamWriter insert = new StreamWriter("data/database/TP_linhdong.dat");
            insert.Write(tpld);
            insert.Close();
        }

        //Ham kiem tra thuc pham co linh dong duoc hay khong
        public bool check_bl(int id)
        {
            bool check = false;
            for (int i = 0; i < count_DC; i++)
            {
                if (id == ID_TP_Dy[i])
                {
                    check = true;
                }
            }
            return check;
        }

        //Tinh tong tien
        public int[] tong(int[] arr1, int[] arr2, int n)
        {
            int[] result = new int[1000];
            for (int i = 0; i < n; i++)
            {
                result = arr1[i] + arr2[i];
            }
            return result;
        }
    }
}