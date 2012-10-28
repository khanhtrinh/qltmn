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
//using System.Data.Sql.*;

namespace WindowsFormsApplication1
{
    public class datakho
    {
        public int[] id_thucpham = new int[1000];
        public int[] gia_thucpham = new int[1000];
        public int[] luongthucpham = new int[1000];
        public string[] ngay_cap_nhat = new string[1000];
        public DateTime[] ngayCapnhat = new DateTime[1000];
        public string[] buffer = new string[1000];
        public int count = 0;

        public datakho() { queryData(); }

        public void queryData()
        {
            StreamReader sr1 = File.OpenText("data/database/kho.dat");
            string input = null;
            while ((input = sr1.ReadLine()) != null)
            {
                buffer[count] = input;
                string[] filter = input.Split("/".ToCharArray());
                //MessageBox.Show(filter[0] + filter[1] + filter[2] + filter[3]);
                id_thucpham[count] = Int32.Parse(filter[0]);
                gia_thucpham[count] = Int32.Parse(filter[1]);
                luongthucpham[count] = Int32.Parse(filter[2]);
                ngay_cap_nhat[count] = filter[3];
                count++;
                //chuyen String thanh ngay
            }
            sr1.Close();
        }

        public string reload(string s, int ID, int Price, int Quality)
        {
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            string date = day + "-" + month + "-" + year;
            count = 0;
            string result = "";
            int check = 0;
            string[] row = s.Split("\n".ToCharArray());
            for (int i = 0; i < row.Length - 1; i++)
            {
                string[] filter = row[i].Split("/".ToCharArray());
                id_thucpham[count] = Int32.Parse(filter[0]);
                gia_thucpham[count] = Int32.Parse(filter[1]);
                luongthucpham[count] = Int32.Parse(filter[2]);
                ngay_cap_nhat[count] = filter[3];
                if (check == 0 && id_thucpham[count] >= ID)
                {
                    result = result + ID + "/" + Price + "/" + Quality + "/" + date + "\n";
                    check = 1;
                }
                count++;
                result = result + row[i] + "\n";
            }
            return result;
        }

        public void updateData(string str)
        {
            StreamWriter write1 = new StreamWriter("data/database/kho.dat");
            write1.Write(str);
            write1.Close();
        }

        public void updateDataTP(string str)
        {
            StreamWriter write1 = new StreamWriter("data/database/thucpham.dat");
            write1.Write(str);
            write1.Close();
            //MessageBox.Show("Update TP thành công");
        }
    }

    public class thongtinkho
    {
        public int id_thucpham;
        public int luongyeucau;
        public int[] luong_sd = new int[100];
        public int[] gia_sd = new int[100];
        public int[] luong_con = new int[100];
        public string[] ngay_cap_nhat = new string[100];
        public int count;
        public int count_buffer = 0;
        public DateTime[] ngaycapnhat = new DateTime[100];
        public datakho dtk;
        public int check_satify;

        public thongtinkho(int id, int luongyc, int commandID, datakho dtk1)
        {
            id_thucpham = id;
            luongyeucau = luongyc;
            count = 0;
            dtk = dtk1;
            check_satify = 0;
            //MessageBox.Show("Bat Dau " + id_thucpham + "/" + luongyeucau);
            if (commandID == 1)
            {
                DivisionThucpham();
            }
            else
            {
                UpdateInformationThucpham();
            }
        }

        public void DivisionThucpham()
        {
            modun_quanli_thucdon_dinhduong md1 = new modun_quanli_thucdon_dinhduong();
            md1.query_thucpham();
            for (int i = dtk.count; i >= 0; i--)
            {
                if (dtk.id_thucpham[i] == id_thucpham)
                {
                    gia_sd[count] = dtk.gia_thucpham[i];
                    ngay_cap_nhat[count] = dtk.ngay_cap_nhat[i];
                    if (dtk.luongthucpham[i] < luongyeucau)
                    {
                        luong_sd[count] = dtk.luongthucpham[i];
                        dtk.luongthucpham[i] = 0;
                        luong_con[i] = 0;
                        luongyeucau = luongyeucau - luong_sd[count];
                        count++;
                    }
                    else
                    {
                        luong_sd[count] = luongyeucau;
                        dtk.luongthucpham[i] = dtk.luongthucpham[i] - luongyeucau;
                        luong_con[count] = dtk.luongthucpham[i];
                        luongyeucau = 0;
                        count++;
                        break;
                    }
                }
            }
            
            if (luongyeucau > 0)
            {
                MessageBox.Show("Thực phâm " + md1.findNameThucPham(id_thucpham) + "thiếu" + luongyeucau + "");
                check_satify = 1;
            }
        }

        public string UpdateInformationThucpham()
        {
            string result = null;
            for (int i = 0; i < dtk.count; i++)
            {
                result = result + dtk.id_thucpham[i] + "/" + dtk.gia_thucpham[i] + "/" + dtk.luongthucpham[i] + "/" + dtk.ngayCapnhat[i] + "\n";
            }
            return result;
        }
    }

    public class modun_quanli_kho
    {
        public datakho dtk = new datakho();
        public int count;
        public int[] id_tp = new int[200];
        public int[] luongthucpham = new int[200];
        public int[] IDTPexport = new int[200];
        public int[] LuongTPExport = new int[200];
        public int[] PriceTPExport = new int[200];
        public int[] LuongTon = new int[200];
        public string[] NgayCapNhat = new string[200];
        public int count_export;
        public string update_infor = "";
        public int check_satify;

        public thongtinkho[] ttk;

        public modun_quanli_kho(int[] id_tp, int[] luongtp, int count)
        {
            this.count = count;
            ttk = new thongtinkho[count];
            count_export = 0;
            for (int i = 0; i < count; i++)
            {
                this.id_tp[i] = id_tp[i];
                this.luongthucpham[i] = luongtp[i];
                ttk[i] = new thongtinkho(this.id_tp[i], this.luongthucpham[i], 1, dtk);
                for (int j = 0; j < ttk[i].count; j++)
                {
                    IDTPexport[count_export] = ttk[i].id_thucpham;
                    LuongTPExport[count_export] = ttk[i].luong_sd[j];
                    PriceTPExport[count_export] = ttk[i].gia_sd[j];
                    LuongTon[count_export] = ttk[i].luong_con[j];
                    NgayCapNhat[count_export] = ttk[i].ngay_cap_nhat[j];
                    count_export++;
                }
                dtk = ttk[i].dtk;
                if (ttk[i].check_satify == 1) check_satify = 1;
            }
            for (int i = 0; i < dtk.count; i++)
            {
                if (dtk.luongthucpham[i] != 0)
                {
                    update_infor = update_infor + dtk.id_thucpham[i] + "/" + dtk.gia_thucpham[i] + "/" + dtk.luongthucpham[i] + "/" + dtk.ngay_cap_nhat[i] + "\n";
                }
            }
            //MessageBox.Show(update_infor);
        }
    }

    public class modun_quanli_thucdon_dinhduong
    {
        public string[] thucdon = new string[200];

        //lay ID cua thuc don duoc chon
        public int count_TD = 0;
        public int current_ID_TD = 0;
        public int[] ID_TD = new int[1000];

        //lay thong tin cua mon an
        public int count_MA = 0;
        public int[] ID_MA = new int[1000];
        public string[] name_MA = new string[1000];
        public string[] type_MA = new string[1000];
        public string[,] name_MA_BA = new string[1000, 1000];
        public int[] count_MA_BA = new int[10000];
        public int[] luong_MA_chuan = new int[10000];

        //lay thong tin cua thuc pham
        public int count_TP = 0;
        public int[] ID_TP = new int[1000];
        public string[] name_TP = new string[1000];
        public string[] type_TP = new string[1000];
        public string[] unit_TP = new string[1000];
        public int[] luong_TP_kho_new = new int[1000];
        public int[] dongia_TP_kho_new = new int[1000];
        public int[] luong_TP_kho_old = new int[10000];
        public int[] dongia_TP_kho_old = new int[10000];

        //lay thong tin cua vi chat
        public int count_VC = 0;
        public int[] ID_VC = new int[1000];
        public string[] name_VC = new string[1000];

        //bang quan he thuc don - mon an
        public int[,] luong_TD_MA = new int[1000, 1000];

        //bang quan he monan - thucpham
        public int[,] luong_MA_TP = new int[1000, 1000];

        //bang quan he thuc pham - vi chat
        public int[,] luong_TP_VC = new int[1000, 1000];

        //tinh luong bua an - mon an
        public int[] ID_MA_use = new int[6];
        public string[] name_MA_use = new string[6];
        public string[] type_MA_use = new string[6];
        public int[,] luong_BA_MA_use = new int[4, 3];
        public int[,] local_MA_use = new int[4, 3];
        public int local_TD = -1;

        //tinh luong thuc pham co su dung
        public int[] ID_TP_use = new int[1000];
        public string[] name_TP_use = new string[1000];
        public int[] luong_TD_TP_use = new int[1000];
        public string[] type_TP_use = new string[1000];
        public int count_TP_use = 0;

        //tinh luong bua an - thuc pham 
        public int[,] luong_BA_TP_use = new int[4, 1000];
        public int[] count_tp_use = new int[4];
        public int[,] buffer_a = new int[500, 500];
        public int[,] buffer_b = new int[500, 500];
        public int[,] buffer_c = new int[500, 500];
        public int n = 0, m = 0, k = 0;

        //tinh vi chat cho bua an
        public int[,] luong_BA_VC_use = new int[10, 1000];

        public modun_quanli_thucdon_dinhduong()
        {
            for (int i = 0; i < 6; i++)
            {
                name_MA_use[i] = "----";
            }
        }

        public int findIDThucPham(string NameThucPham)
        {
            int result = -1;
            for (int i = 0; i < count_TP; i++)
            {
                if (name_TP[i] == NameThucPham)
                {
                    result = ID_TP[i];
                }
            }
            return result;
        }

        public string findNameThucPham(int IDThucPham)
        {
            string result = null;
            for (int i = 0; i < count_TP; i++)
            {
                if (ID_TP[i] == IDThucPham)
                {
                    result = name_TP[i];
                }
            }
            return result;
        }

        public void query_thucdon()
        {
            FileInfo f1 = new FileInfo("data/database/thucdon.dat");
            if (f1.Exists == true)
            {
                StreamReader sr1 = File.OpenText("data/database/thucdon.dat");
                string input = null;
                while ((input = sr1.ReadLine()) != null)
                {
                    string[] filter = input.Split("/".ToCharArray());
                    ID_TD[count_TD] = Int32.Parse(filter[0]);
                    count_TD++;
                }
                //Console.WriteLine("" + "");
                sr1.Close();
            }
            String date = DateTime.Now.ToString();
            DateTime date1 = Convert.ToDateTime(date);
            string DayOfWeek = date1.DayOfWeek.ToString();
            //MessageBox.Show(DayOfWeek + "");
            switch (DayOfWeek)
            {
                case ("Monday"):
                    current_ID_TD = 0;
                    //MessageBox.Show("" + current_ID_TD);
                    break;
                case ("Tuesday"):
                    current_ID_TD = 1;
                    //MessageBox.Show("" + current_ID_TD);
                    break;
                case ("Wednesday"):
                    current_ID_TD = 2;
                    //MessageBox.Show("" + current_ID_TD);
                    break;
            }
        }

        public void query_monan()
        {
            FileInfo f2 = new FileInfo("data/database/monan.dat");
            if (f2.Exists == true)
            {
                StreamReader sr2 = File.OpenText("data/database/monan.dat");
                string input = null;
                while ((input = sr2.ReadLine()) != null)
                {
                    string[] filter = input.Split("/".ToCharArray());
                    ID_MA[count_MA] = Int32.Parse(filter[0]);
                    name_MA[count_MA] = filter[1];
                    type_MA[count_MA] = filter[2];
                    luong_MA_chuan[count_MA] = Int32.Parse(filter[3]);
                    if (type_MA[count_MA] == "pam")
                    {
                        name_MA_BA[0, count_MA_BA[0]] = name_MA[count_MA];
                        count_MA_BA[0]++;
                    }
                    if (type_MA[count_MA] == "eam")
                    {
                        name_MA_BA[1, count_MA_BA[1]] = name_MA[count_MA];
                        count_MA_BA[1]++;
                    }
                    if (type_MA[count_MA] == "ppm1")
                    {
                        name_MA_BA[2, count_MA_BA[2]] = name_MA[count_MA];
                        count_MA_BA[2]++;
                    }
                    if (type_MA[count_MA] == "ppm2")
                    {
                        name_MA_BA[3, count_MA_BA[3]] = name_MA[count_MA];
                        count_MA_BA[3]++;
                    }
                    if (type_MA[count_MA] == "ppm3")
                    {
                        name_MA_BA[4, count_MA_BA[4]] = name_MA[count_MA];
                        count_MA_BA[4]++;
                    }
                    if (type_MA[count_MA] == "epm")
                    {
                        name_MA_BA[5, count_MA_BA[5]] = name_MA[count_MA];
                        count_MA_BA[5]++;
                    }
                    count_MA++;
                }
                sr2.Close();
            }
        }

        public void query_thucpham()
        {
            FileInfo f3 = new FileInfo("data/database/thucpham.dat");
            if (f3.Exists == true)
            {
                StreamReader sr3 = File.OpenText("data/database/thucpham.dat");
                string input = null;
                while ((input = sr3.ReadLine()) != null)
                {
                    //MessageBox.Show(input);
                    string[] filter = input.Split("/".ToCharArray());
                    ID_TP[count_TP] = Int32.Parse(filter[0]);
                    name_TP[count_TP] = filter[1];
                    type_TP[count_TP] = filter[2];
                    //if (type_TP[count_TP] == "Hàng ngày") MessageBox.Show(name_TP[count_TP] + "->" + type_TP[count_TP]);
                    unit_TP[count_TP] = filter[3];
                    luong_TP_kho_new[count_TP] = Int32.Parse(filter[4]);
                    dongia_TP_kho_new[count_TP] = Int32.Parse(filter[5]);
                    luong_TP_kho_old[count_TP] = Int32.Parse(filter[6]);
                    dongia_TP_kho_old[count_TP] = Int32.Parse(filter[7]);
                    count_TP++;
                }
                sr3.Close();
            }
        }

        public void query_vichat()
        {
            FileInfo f4 = new FileInfo("data/database/vichat.dat");
            if (f4.Exists == true)
            {
                StreamReader sr4 = File.OpenText("data/database/vichat.dat");
                string input = null;
                while ((input = sr4.ReadLine()) != null)
                {
                    string[] filter = input.Split("/".ToCharArray());
                    ID_VC[count_VC] = Int32.Parse(filter[0]);
                    name_VC[count_VC] = filter[1];
                    count_VC++;
                }
                sr4.Close();
            }
        }

        public void query_join_thucdon_monan()
        {
            FileInfo f5 = new FileInfo("data/database/thucdon_monan.dat");
            if (f5.Exists == true)
            {
                StreamReader sr5 = File.OpenText("data/database/thucdon_monan.dat");
                string input = null;
                while ((input = sr5.ReadLine()) != null)
                {
                    string[] filter = input.Split("/".ToCharArray());
                    int ID_TD_relation = Int32.Parse(filter[0]);
                    int ID_MA_relation = Int32.Parse(filter[1]);
                    int row_TD_MA = location_array(ID_TD_relation, ID_TD, count_TD);
                    int colum_TD_MA = location_array(ID_MA_relation, ID_MA, count_MA);
                    if (row_TD_MA != -1 && colum_TD_MA != -1)
                    {
                        luong_TD_MA[row_TD_MA, colum_TD_MA] = Int32.Parse(filter[2]);
                    }
                }
                sr5.Close();
            }
        }

        public void query_join_thucdon_monan_mg()
        {
            FileInfo f5 = new FileInfo("data/database/thucdon_monan1.dat");
            if (f5.Exists == true)
            {
                StreamReader sr5 = File.OpenText("data/database/thucdon_monan1.dat");
                string input = null;
                while ((input = sr5.ReadLine()) != null)
                {
                    string[] filter = input.Split("/".ToCharArray());
                    int ID_TD_relation = Int32.Parse(filter[0]);
                    int ID_MA_relation = Int32.Parse(filter[1]);
                    int row_TD_MA = location_array(ID_TD_relation, ID_TD, count_TD);
                    int colum_TD_MA = location_array(ID_MA_relation, ID_MA, count_MA);
                    if (row_TD_MA != -1 && colum_TD_MA != -1)
                    {
                        luong_TD_MA[row_TD_MA, colum_TD_MA] = Int32.Parse(filter[2]);
                    }
                }
                sr5.Close();
            }
        }

        public void query_join_monan_thucpham()
        {
            FileInfo f6 = new FileInfo("data/database/monan_thucpham.dat");
            if (f6.Exists == true)
            {
                StreamReader sr6 = File.OpenText("data/database/monan_thucpham.dat");
                string input = null;
                while ((input = sr6.ReadLine()) != null)
                {
                    string[] filter = input.Split("/".ToCharArray());
                    int ID_MA_relation = Int32.Parse(filter[0]);
                    int ID_TP_relation = Int32.Parse(filter[1]);
                    int row_MA_TP = location_array(ID_MA_relation, ID_MA, count_MA);
                    int colum_MA_TP = location_array(ID_TP_relation, ID_TP, count_TP);
                    if (row_MA_TP != -1 && colum_MA_TP != -1)
                    {
                        luong_MA_TP[row_MA_TP, colum_MA_TP] = Int32.Parse(filter[2]);
                    }
                }
                sr6.Close();
            }
        }

        public void query_join_thucpham_vichat()
        {
            FileInfo f7 = new FileInfo("data/database/thucpham_vichat.dat");
            if (f7.Exists == true)
            {
                StreamReader sr7 = File.OpenText("data/database/thucpham_vichat.dat");
                string input = null;
                while ((input = sr7.ReadLine()) != null)
                {
                    string[] filter = input.Split("/".ToCharArray());
                    int ID_TP_relation = Int32.Parse(filter[0]);
                    int ID_VC_relation = Int32.Parse(filter[1]);
                    int row_TP_VC = location_array(ID_TP_relation, ID_TP, count_TP);
                    int colum_TP_VC = location_array(ID_VC_relation, ID_VC, count_VC);
                    if (row_TP_VC != -1 && colum_TP_VC != -1)
                    {
                        luong_TP_VC[row_TP_VC, colum_TP_VC] = Int32.Parse(filter[2]);
                    }
                }
                sr7.Close();
            }
        }

        public void compute_table_luong_BA_MA()
        {
            local_TD = location_array(current_ID_TD, ID_TD, count_TD);

            for (int i = 0; i < count_MA; i++)
            {
                if (luong_TD_MA[local_TD, i] != 0)
                {
                    if (type_MA[i] == "pam")
                    {
                        ID_MA_use[0] = ID_MA[i];
                        luong_BA_MA_use[0, 0] = luong_TD_MA[local_TD, i];
                        name_MA_use[0] = name_MA[i];
                        local_MA_use[0, 0] = i;
                    }
                    if (type_MA[i] == "eam")
                    {
                        ID_MA_use[1] = ID_MA[i];
                        luong_BA_MA_use[1, 0] = luong_TD_MA[local_TD, i];
                        name_MA_use[1] = name_MA[i];
                        local_MA_use[1, 0] = i;
                    }
                    if (type_MA[i] == "ppm1")
                    {
                        ID_MA_use[2] = ID_MA[i];
                        luong_BA_MA_use[2, 0] = luong_TD_MA[local_TD, i];
                        name_MA_use[2] = name_MA[i];
                        local_MA_use[2, 0] = i;
                    }
                    if (type_MA[i] == "ppm2")
                    {
                        ID_MA_use[3] = ID_MA[i];
                        luong_BA_MA_use[2, 1] = luong_TD_MA[local_TD, i];
                        name_MA_use[3] = name_MA[i];
                        local_MA_use[2, 1] = i;
                    }
                    if (type_MA[i] == "ppm3")
                    {
                        ID_MA_use[4] = ID_MA[i];
                        luong_BA_MA_use[2, 2] = luong_TD_MA[local_TD, i];
                        name_MA_use[4] = name_MA[i];
                        local_MA_use[2, 2] = i;
                    }
                    if (type_MA[i] == "epm")
                    {
                        ID_MA_use[5] = ID_MA[i];
                        luong_BA_MA_use[3, 0] = luong_TD_MA[local_TD, i];
                        name_MA_use[5] = name_MA[i];
                        local_MA_use[3, 0] = i;
                    }
                }
            }
        }

        public void change_monan(int index, int x)
        {
            ID_MA_use[index] = x;
            if (index == 0 || index == 1)
            {
                luong_BA_MA_use[index, 0] = luong_MA_chuan[location_array(x, ID_MA, count_MA)];
                local_MA_use[index, 0] = location_array(x, ID_MA, count_MA);
            }
            if (index > 1 && index < 5)
            {
                luong_BA_MA_use[2, index - 2] = luong_MA_chuan[location_array(x, ID_MA, count_MA)];
                local_MA_use[2, index - 2] = location_array(x, ID_MA, count_MA);
            }
            if (index == 5)
            {
                luong_BA_MA_use[3, 0] = luong_MA_chuan[location_array(x, ID_MA, count_MA)];
                local_MA_use[3, 0] = location_array(x, ID_MA, count_MA);
            }
            name_MA_use[index] = name_MA[location_array(x, ID_MA, count_MA)];

            //tinh luong thuc pham cho bua sang
            n = 1;
            buffer_a[0, 0] = luong_BA_MA_use[0, 0];
            for (int i = 0; i < count_TP; i++)
            {
                buffer_b[0, i] = luong_MA_TP[local_MA_use[0, 0], i];

            }
            m = count_TP; k = 1;
            buffer_c = sup_matrix(buffer_a, buffer_b, n, m, k);
            for (int i = 0; i < count_TP; i++)
            {
                luong_BA_TP_use[0, i] = buffer_c[0, i];
            }

            //tinh luong thuc pham cho bua sang phu
            n = 1;
            buffer_a[0, 0] = luong_BA_MA_use[1, 0];
            for (int i = 0; i < count_TP; i++)
            {
                buffer_b[0, i] = luong_MA_TP[local_MA_use[1, 0], i];
            }
            m = count_TP; k = 1;
            buffer_c = sup_matrix(buffer_a, buffer_b, n, m, k);
            for (int i = 0; i < count_TP; i++)
            {
                luong_BA_TP_use[1, i] = buffer_c[0, i];
            }

            //tinh luong thuc pham cho bua trua chinh
            n = 1;
            buffer_a[0, 0] = luong_BA_MA_use[2, 0];
            buffer_a[0, 1] = luong_BA_MA_use[2, 1];
            buffer_a[0, 2] = luong_BA_MA_use[2, 2];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < count_TP; j++)
                {
                    buffer_b[i, j] = luong_MA_TP[local_MA_use[2, i], j];
                }
            }
            m = count_TP; k = 3;
            buffer_c = sup_matrix(buffer_a, buffer_b, n, m, k);

            for (int i = 0; i < count_TP; i++)
            {
                luong_BA_TP_use[2, i] = buffer_c[0, i];
            }

            //tinh luong thuc pham cho bua chieu phu
            n = 1;
            buffer_a[0, 0] = luong_BA_MA_use[3, 0];
            for (int i = 0; i < count_TP; i++)
            {
                buffer_b[0, i] = luong_MA_TP[local_MA_use[3, 0], i];
            }
            m = count_TP; k = 1;
            buffer_c = sup_matrix(buffer_a, buffer_b, n, m, k);
            for (int i = 0; i < count_TP; i++)
            {
                luong_BA_TP_use[3, i] = buffer_c[0, i];
            }
            count_TP_use = 0;
            for (int i = 0; i < count_TP; i++)
            {
                int sum_luong_tp = 0;
                for (int j = 0; j < 4; j++)
                {
                    sum_luong_tp = sum_luong_tp + luong_BA_TP_use[j, i];
                }
                if (sum_luong_tp != 0)
                {
                    ID_TP_use[count_TP_use] = ID_TP[i];
                    name_TP_use[count_TP_use] = name_TP[i];
                    type_TP_use[count_TP_use] = type_TP[i];
                    //MessageBox.Show(type_TP_use[count_TP_use]);
                    luong_TD_TP_use[count_TP_use] = sum_luong_tp;
                    count_TP_use++;
                }
            }

        }

        public void compute_table_luong_BA_TP()
        {
            //tinh luong thuc pham cho bua sang
            n = 1;
            buffer_a[0, 0] = luong_BA_MA_use[0, 0];
            for (int i = 0; i < count_TP; i++)
            {
                buffer_b[0, i] = luong_MA_TP[local_MA_use[0, 0], i];
            }
            m = count_TP; k = 1;
            buffer_c = sup_matrix(buffer_a, buffer_b, n, m, k);
            for (int i = 0; i < count_TP; i++)
            {
                luong_BA_TP_use[0, i] = buffer_c[0, i];
            }

            //tinh luong thuc pham cho bua sang phu
            n = 1;
            buffer_a[0, 0] = luong_BA_MA_use[1, 0];
            for (int i = 0; i < count_TP; i++)
            {
                buffer_b[0, i] = luong_MA_TP[local_MA_use[1, 0], i];
            }
            m = count_TP; k = 1;
            buffer_c = sup_matrix(buffer_a, buffer_b, n, m, k);
            for (int i = 0; i < count_TP; i++)
            {
                luong_BA_TP_use[1, i] = buffer_c[0, i];
            }

            //tinh luong thuc pham cho bua trua chinh
            n = 1;
            buffer_a[0, 0] = luong_BA_MA_use[2, 0];
            buffer_a[0, 1] = luong_BA_MA_use[2, 1];
            buffer_a[0, 2] = luong_BA_MA_use[2, 2];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < count_TP; j++)
                {
                    buffer_b[i, j] = luong_MA_TP[local_MA_use[2, i], j];
                }
            }
            m = count_TP; k = 3;
            buffer_c = sup_matrix(buffer_a, buffer_b, n, m, k);

            for (int i = 0; i < count_TP; i++)
            {
                luong_BA_TP_use[2, i] = buffer_c[0, i];
            }

            //tinh luong thuc pham cho bua chieu phu
            n = 1;
            buffer_a[0, 0] = luong_BA_MA_use[3, 0];
            for (int i = 0; i < count_TP; i++)
            {
                buffer_b[0, i] = luong_MA_TP[local_MA_use[3, 0], i];
            }
            m = count_TP; k = 1;
            buffer_c = sup_matrix(buffer_a, buffer_b, n, m, k);
            for (int i = 0; i < count_TP; i++)
            {
                luong_BA_TP_use[3, i] = buffer_c[0, i];
            }

            for (int i = 0; i < count_TP; i++)
            {
                int sum_luong_tp = 0;
                for (int j = 0; j < 4; j++)
                {
                    sum_luong_tp = sum_luong_tp + luong_BA_TP_use[j, i];
                }

                if (sum_luong_tp != 0)
                {
                    ID_TP_use[count_TP_use] = ID_TP[i];
                    name_TP_use[count_TP_use] = name_TP[i];
                    type_TP_use[count_TP_use] = type_TP[i];
                    //MessageBox.Show("" + type_TP_use[count_TP_use]);
                    luong_TD_TP_use[count_TP_use] = sum_luong_tp;
                    count_TP_use++;
                }
            }
        }

        public void show(int s)
        {
            MessageBox.Show(s + "");
        }

        public void compute_table_luong_BA_VC()
        {

            luong_BA_VC_use = sup_matrix(luong_BA_TP_use, luong_TP_VC, 4, count_VC, count_TP);
            //MessageBox.Show(luong_BA_VC_use[0,0] + "");
        }

        //ham lay vi tri cua 1 phan tu trong mang 
        public int location_array(int x, int[] x_array, int n)
        {
            int result = -1;
            for (int i = 0; i < n; i++)
            {
                if (x == x_array[i])
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        //ham nhan 2 mang 2 chieu
        public int[,] sup_matrix(int[,] a, int[,] b, int n, int m, int k)
        {
            int[,] c = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int buffer_c = 0;
                    for (int t = 0; t < k; t++)
                    {
                        buffer_c = buffer_c + a[i, t] * b[t, j];
                    }
                    c[i, j] = buffer_c;
                }
            }
            return c;
        }
    }
    /*
    public class modun_quanli_HDTP
    {
        public int count_TP_t = 0;
        public int[] ID_TP_t = new int[1000];
        public string[] name_TP_t = new string[1000];
        public string[] type_TP_t = new string[1000];
        public string[] unit_TP_t = new string[1000];
        public int[] luong_TP_kho_new_t = new int[1000];
        public int[] dongia_TP_kho_new_t = new int[1000];
        public int[] luong_TP_kho_old_t = new int[10000];
        public int[] dongia_TP_kho_old_t = new int[10000];

        public modun_quanli_HDTP() { }

        public void getList()
        {
            FileInfo f = new FileInfo("E:\\thucpham.dat");
            if (f.Exists == true)
            {
                StreamReader sr = File.OpenText("E:\\thucpham.dat");
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    //MessageBox.Show(input);
                    string[] filter = input.Split("/".ToCharArray());
                    if(filter[2].Equals("Hàng ngày")){
                        ID_TP_t[count_TP_t] = Int32.Parse(filter[0]);
                        name_TP_t[count_TP_t] = filter[1];
                        type_TP_t[count_TP_t] = filter[2];
                        //if (type_TP[count_TP] == "Hàng ngày") MessageBox.Show(name_TP[count_TP] + "->" + type_TP[count_TP]);
                        unit_TP_t[count_TP_t] = filter[3];
                        luong_TP_kho_new_t[count_TP_t] = Int32.Parse(filter[4]);
                        dongia_TP_kho_new_t[count_TP_t] = Int32.Parse(filter[5]);
                        luong_TP_kho_old_t[count_TP_t] = Int32.Parse(filter[6]);
                        dongia_TP_kho_old_t[count_TP_t] = Int32.Parse(filter[7]);
                        count_TP_t++;
                    }
                }
                sr.Close();
            }
        }

        public string genStr()
        {
            string str = "";
            for (int i = 0; i < count_TP_t; i++)
            {
                str = str + ID_TP_t[i] + "/";
                str = str + name_TP_t[i] + "/";
                str = str + unit_TP_t[i] + "/";
                str = str + dongia_TP_kho_new_t[i] + "/";
                str = str + luong_TP_kho_new_t[i] + "\n";
            }

            return str;
        }

        public void check() { }

        public void store(string str) 
        {
            string fileName = Convert.ToString(DateTime.Now.Year) + "-" 
                + Convert.ToString(DateTime.Now.Month) + "-"
                + Convert.ToString(DateTime.Now.Day) + "-" 
                + Convert.ToString(DateTime.Now.Hour) + ".dat";

            StreamWriter file = new StreamWriter("E:\\" + fileName);
            file.Write(str);

            file.Close();
        }

        public void xuatXls() 
        {
            String[,] array = new string[count_TP_t + 1, 8];

            array[0, 0] = "STT";
            array[0, 1] = "ID";
            array[0, 2] = "Tên thực phẩm";
            array[0, 3] = "Đơn giá";
            array[0, 4] = "Đơn vị tính";
            array[0, 5] = "Số lượng";
            array[0, 6] = "Thành tiền";
            array[0, 7] = "Nhà cung cấp";

            for (int i = 1; i <= count_TP_t; i++)
            {
                array[i, 0] = Convert.ToString(i);
                array[i, 1] = Convert.ToString(ID_TP_t[i-1]);
                array[i, 2] = name_TP_t[i-1];
                array[i, 3] = Convert.ToString(dongia_TP_kho_new_t[i - 1]);
                array[i, 4] = Convert.ToString(unit_TP_t[i - 1]);
                array[i, 5] = Convert.ToString(luong_TP_kho_new_t[i - 1]);
                array[i, 6] = Convert.ToString(dongia_TP_kho_new_t[i - 1] * luong_TP_kho_new_t[i - 1]);
            }

            COMExcel.Application xlApp = new COMExcel.Application();
            xlApp.Visible = true;
            COMExcel.Workbook wb = xlApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            COMExcel.Worksheet ws = (COMExcel.Worksheet)wb.Worksheets.get_Item(1);
            COMExcel.Range rng = ws.Cells.get_Resize(array.GetLength(0), array.GetLength(1));
            rng.Value = array;
            //rng.Value or rng.Value2????
            rng.Columns.AutoFit();
            
            string fileName = "E:\\" + Convert.ToString(DateTime.Now.Year) + "-"
                + Convert.ToString(DateTime.Now.Month) + "-"
                + Convert.ToString(DateTime.Now.Day) + "-"
                + Convert.ToString(DateTime.Now.Hour) + ".xls";
             

            wb.SaveAs(fileName, COMExcel.XlFileFormat.xlWorkbookNormal, null, null, false, false, COMExcel.XlSaveAsAccessMode.xlExclusive, false, false);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wb);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);

        }

        public void xuatHoaDon() { }
    }
     */
    public class modun_quanli_HDTP
    {
        public int count_TP_t = 0;
        public int[] ID_TP_t = new int[1000];
        public string[] name_TP_t = new string[1000];
        public string[] type_TP_t = new string[1000];
        public string[] unit_TP_t = new string[1000];
        public Int64[] luong_TP_kho_new_t = new Int64[1000];
        public Int64[] dongia_TP_kho_new_t = new Int64[1000];
        public Int64[] luong_TP_kho_old_t = new Int64[10000];
        public Int64[] dongia_TP_kho_old_t = new Int64[10000];
        public string[] nhaphanphoi = new string[1000];
        public string[] ngaybatdau = new string[1000];
        public string[] ngayketthuc = new string[1000];

        public modun_quanli_HDTP() { }

        //lay ds nhung thuc pham mua hang ngay
        public void getList()
        {
            FileInfo f = new FileInfo("data/database/thucpham.dat");
            if (f.Exists == true)
            {
                StreamReader sr = File.OpenText("data/database/thucpham.dat");
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    string[] filter = input.Split("/".ToCharArray());
                    if (filter[2].Equals("Hàng ngày"))
                    {
                        ID_TP_t[count_TP_t] = Int32.Parse(filter[0]);
                        name_TP_t[count_TP_t] = filter[1];
                        type_TP_t[count_TP_t] = filter[2];
                        unit_TP_t[count_TP_t] = filter[3];
                        luong_TP_kho_new_t[count_TP_t] = Int64.Parse(filter[4]);
                        dongia_TP_kho_new_t[count_TP_t] = Int64.Parse(filter[5]);
                        luong_TP_kho_old_t[count_TP_t] = Int64.Parse(filter[6]);
                        dongia_TP_kho_old_t[count_TP_t] = Int64.Parse(filter[7]);
                        nhaphanphoi[count_TP_t] = "";
                        ngaybatdau[count_TP_t] = "";
                        ngayketthuc[count_TP_t] = "";
                        count_TP_t++;
                    }
                }
                sr.Close();
            }
        }

        //tao string viet file 
        public string genStr()
        {
            string str = "";
            for (int i = 0; i < count_TP_t; i++)
            {
                str = str + ID_TP_t[i] + "/";
                str = str + name_TP_t[i] + "/";
                str = str + unit_TP_t[i] + "/";
                str = str + dongia_TP_kho_new_t[i] + "/";
                str = str + luong_TP_kho_new_t[i] + "\n";
            }
            return str;
        }

        //
        public void check() { }

        //luu thong tin vao file
        public void store(string str)
        {
            string fileName = Convert.ToString(DateTime.Now.Year) + "-"
                + Convert.ToString(DateTime.Now.Month) + "-"
                + Convert.ToString(DateTime.Now.Day) + "-"
                + Convert.ToString(DateTime.Now.Hour) + ".dat";

            StreamWriter file = new StreamWriter("E:\\" + fileName);
            file.Write(str);

            file.Close();
        }

        //
        public void xuatXls()
        {
            String[,] array = new string[count_TP_t + 1, 8];

            array[0, 0] = "STT";
            array[0, 1] = "ID";
            array[0, 2] = "Tên thực phẩm";
            array[0, 3] = "Đơn giá";
            array[0, 4] = "Đơn vị tính";
            array[0, 5] = "Số lượng";
            array[0, 6] = "Thành tiền";
            array[0, 7] = "Nhà cung cấp";

            for (int i = 1; i <= count_TP_t; i++)
            {
                array[i, 0] = Convert.ToString(i);
                array[i, 1] = Convert.ToString(ID_TP_t[i - 1]);
                array[i, 2] = name_TP_t[i - 1];
                array[i, 3] = Convert.ToString(dongia_TP_kho_new_t[i - 1]);
                array[i, 4] = Convert.ToString(unit_TP_t[i - 1]);
                array[i, 5] = Convert.ToString(luong_TP_kho_new_t[i - 1]);
                array[i, 6] = Convert.ToString(dongia_TP_kho_new_t[i - 1] * luong_TP_kho_new_t[i - 1]);
            }

            COMExcel.Application xlApp = new COMExcel.Application();
            xlApp.Visible = true;
            COMExcel.Workbook wb = xlApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            COMExcel.Worksheet ws = (COMExcel.Worksheet)wb.Worksheets.get_Item(1);
            COMExcel.Range rng = ws.Cells.get_Resize(array.GetLength(0), array.GetLength(1));
            rng.Value = array;
            rng.Columns.AutoFit();

            string fileName = "E:\\" + Convert.ToString(DateTime.Now.Year) + "-"
                + Convert.ToString(DateTime.Now.Month) + "-"
                + Convert.ToString(DateTime.Now.Day) + "-"
                + Convert.ToString(DateTime.Now.Hour) + ".xls";


            wb.SaveAs(fileName, COMExcel.XlFileFormat.xlWorkbookNormal, null, null, false, false, COMExcel.XlSaveAsAccessMode.xlExclusive, false, false);

            //wb.PrintPreview

            System.Runtime.InteropServices.Marshal.ReleaseComObject(wb);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);

        }

        public void xuatHoaDon() { }
	
	public int locate(int ID, int[] tb, int array_size)
        {
            int result = -1;
            for (int i = 0; i < array_size; i++)
            {
                if (tb[i] == ID)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        public int locate(int ID, int[,] tb, int array_size)
        {
            int result = -1;
            for (int i = 0; i < array_size; i++)
            {
                if (tb[i, 0] == ID)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
    }

    public class modun_canbang_dinhduong
    {
        // them
        public modun_quanli_HDTP quanli_HDTP = new modun_quanli_HDTP();
        public modun_quanli_thucdon_dinhduong md1 = new modun_quanli_thucdon_dinhduong();

        public int[] ID_TP = new int[200]; // mảng chưa ID thực phẩm
        public System.Int64[] gia_old = new System.Int64[200];
        public System.Int64[] gia_new = new System.Int64[200];
        public int[] dv_TP = new int[200]; // mảng chứa đơn vị tính của thực phẩm (1000 or 1)
        public int[,] tp_vc = new int[200, 10]; // mảng chứa lượng vi chất trong mỗi thực phẩm
        public int countTP = 0;  // đếm số loại thực phẩm có
        public int count_MA_TD = 0;  // đếm số món ăn được dùng trong thực đơn hiện tại
        public int[] td_ma = new int[20];  // mảng chưa ID món ăn được dùng trong thực đơn hiện tại
        public double[,] ma_tp = new double[20, 200];  // chứa lượng thực phẩm cho các món ăn trong thực đơn hiện tại
        public double[] vichat = new double[10]; // luong vi chat trong thuc don hien tai
        public int[] pro = new int[200];  // chua Id thuc pham giau protein
        public int[] glu = new int[200];
        public int[] lip = new int[200];
        public int[] cal = new int[200];
        public const int hs = 500;
        public const int delta = 500 / hs;
        public double[,] buffer = new double[20, 200];
        

        public modun_canbang_dinhduong()
        {
            quanli_HDTP.getList();
            getIDTP();
            get_gia();
            get_dv();
            getTPVC();
            getpro();
            getlip();
            getglu();
            getcal();
        }

        // sinh bảng các món ăn có trong thực đơn, và đếm xem trong thực đơn có bao nhiêu món phục vụ tính toán (count_MA_TD)
        public void get_TD_MA(int ID_TD)
        {
            count_MA_TD = 0;
            FileInfo file = new FileInfo("data/database/thucdon_monan.dat");
            if (file.Exists == true)
            {
                StreamReader sr = File.OpenText("data/database/thucdon_monan.dat");
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    string[] filter = input.Split("/".ToCharArray());
                    if (filter[0].Equals(ID_TD + "") && Convert.ToInt32(filter[2]) > 0)
                    {
                        td_ma[count_MA_TD] = Convert.ToInt32(filter[1]);
                        count_MA_TD++;
                    }
                }
            }
        }
		
        // sinh bảng giá thực phẩm
        public void get_gia()
        {
            FileInfo file = new FileInfo("data/database/thucpham.dat");
            if (file.Exists == true)
            {
                StreamReader sr = File.OpenText("data/database/thucpham.dat");
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    string[] filter = input.Split("/".ToCharArray());
                    int index = locate(Convert.ToInt32(filter[0]), ID_TP, 200);
                    gia_new[index] = Convert.ToInt64(filter[7]);
                    gia_old[index] = Convert.ToInt64(filter[7]);
                }
            }
        }

        // sinh bang don vi tinh thuc pham
        public void get_dv()
        {
            FileInfo file = new FileInfo("data/database/thucpham.dat");
            if (file.Exists == true)
            {
                StreamReader sr = File.OpenText("data/database/thucpham.dat");
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    string[] filter = input.Split("/".ToCharArray());
                    int index = locate(Convert.ToInt32(filter[0]), ID_TP, 200);
                    if (filter[3].Equals("kg"))
                    {
                        dv_TP[index] = 1000;
                    }
                    else if (filter[3].Equals("g"))
                    {
                        dv_TP[index] = 1;
                    }
                }
            }
        }

        // sinh bảng món ăn - thực phẩm ma_tp của thực đơn hiện tại
        public void get_MA_TP(int[] tb_MA, int count_MA_)
        {
            string input = null;
			//chuyen sang module can bang dinh duong
			StreamReader sr = File.OpenText("data/database/monan_thucpham.dat");
			while ((input = sr.ReadLine()) != null)
			{
				string[] filter = input.Split("/".ToCharArray());
				for (int i = 0; i < count_MA_; i++)
				{
					if (filter[0].Equals(tb_MA[i] + ""))
					{
						int ID_use = Convert.ToInt32(filter[1]);
						int sl_use = Convert.ToInt32(filter[2]);

						int index = locate(ID_use, ID_TP, 200);
						ma_tp[i, index] = sl_use;
					}
				}
			}
        }

        // hàm sinh bảng ID của thực phẩm ID_TP, và đếm xem có bao nhiêu thực phẩm (countTP)
        public void getIDTP()
        {
            FileInfo file = new FileInfo("data/database/thucpham.dat");
            if (file.Exists == true)
            {
                countTP = 0;
                StreamReader sr = File.OpenText("data/database/thucpham.dat");
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    string[] filter = input.Split("/".ToCharArray());
                    int IDTP = Convert.ToInt32(filter[0]);

                    ID_TP[countTP] = IDTP;
                    countTP++;
                }

            }
        }

        // Hàm sinh bảng lượng vi chất trong thực phẩm tp_vc
        public void getTPVC()
        {
            FileInfo file = new FileInfo("data/database/thucpham_vichat.dat");
            if (file.Exists == true)
            {
                StreamReader sr = File.OpenText("data/database/thucpham_vichat.dat");
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    string[] filter = input.Split("/".ToCharArray());
                    int IDTP = Convert.ToInt32(filter[0]);
                    int index = locate(IDTP, ID_TP, 200);
                    int IDVC = Convert.ToInt32(filter[1]);
                    int luongVC = Convert.ToInt32(filter[2]);

                    tp_vc[index, IDVC] = luongVC;
                }

            }
        }

        //hàm cân bằng thực đơn (chưa hoàn chỉnh)
        public void balanceTD()
        {
            get_TD_MA(1);
            get_MA_TP(td_ma, count_MA_TD);
            while (true)
            {
                if ((compute_gia_thucdon(count_MA_TD) < 5450) && (compute_gia_thucdon(count_MA_TD) > 5130) && (checkvc() == 0)) break;
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 200; j++)
                    {
                        buffer[i, j] = ma_tp[i, j];
                    }
                }
                //canbang_tien(5300);
                cb_tien(5300);
                MessageBox.Show("Gia tien: " + compute_gia_thucdon(count_MA_TD) + "\n" + "calo " + vichat[3]);
                double gia_cu = compute_gia_thucdon(count_MA_TD);
                MessageBox.Show("checkvc: " + checkvc());
                canbangvc();
                check(gia_cu);
            }
        }

        // check trong ham balance
        public void check(double giacu)
        {
            if (compute_gia_thucdon(count_MA_TD) < 0.96 * giacu)
            {
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 200; j++)
                    {
                        ma_tp[i, j] = buffer[i, j];
                    }
                }
                MessageBox.Show("Da revert." + compute_gia_thucdon(count_MA_TD));
            }
            else if (compute_gia_thucdon(count_MA_TD) > 1.04 * giacu)
            {
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 200; j++)
                    {
                        ma_tp[i, j] = buffer[i, j];
                    }
                }
                MessageBox.Show("Da revert." + compute_gia_thucdon(count_MA_TD));
            }
        }

        // Ham can bang tien
        public void canbang_tien(int gia_chuan)
        {
            //const int hs = 500;                           //So hoc sinh trong truong
            const int delta = 1000 / hs;                  //Don vi them bot cua moi thuc pham

            System.Int64[] change = new System.Int64[200];//mang hieu cua gia moi va gia cu
            double gia_td = 0;                            //Gia thuc don
            string report_ID = "";                        //In ra mess ve id thay doi
            string report_gia = "";                       //In ra mess ve gia thay doi
            int i_max_chg = 0;                            //Lay ra phan tu co gia thay doi nhieu nhat
            int[] dau = new int[200];                     //Kiem tra xem gia tri thay doi la tang hay giam

            ////Lay gia tri id, gia, don vi vao mang
            gia_td = compute_gia_thucdon(count_MA_TD);

            MessageBox.Show("Chua can bang:" + gia_td);

            for (int i = 0; i < countTP; i++)
            {
                //Tim thuc pham thay doi
                change[i] = gia_new[i] - gia_old[i];

                i_max_chg = max_change(change);
                dau = am_duong(change);
                //MessageBox.Show(change[i] + "");
            }

            MessageBox.Show(i_max_chg + "");
            MessageBox.Show(dau[i_max_chg] + "");
            while ((gia_td > (gia_chuan+20)) || (gia_td < (gia_chuan-20)))
            {
                for (int i = 0; i < count_MA_TD; i++)
                {
                    if (ma_tp[i, i_max_chg] > 0)
                    {
                        ma_tp[i, i_max_chg] -= dau[i_max_chg] * delta;
                        gia_td = compute_gia_thucdon(count_MA_TD);
                    }
                }
            }
            
            MessageBox.Show("Can bang:" + gia_td);

            //In ra bang messagebox
            for (int i = 0; i < countTP; i++)
            {
                if (change[i] != 0)
                {
                    report_ID += ID_TP[i] + "";
                    report_gia += gia_new[i] + "";
                }
            }

            MessageBox.Show("ID thuc pham thay doi: " + report_ID + "\n" + "Gia moi cua thuc pham thay doi: " + report_gia);
        }

        //Tinh phan tu co gia tri thay doi lon nhat
        public int max_change(Int64[] change)
        {
            System.Int64 max = Math.Abs(change[0]);
            int imax = 0;

            for (int i = 0; i < countTP; i++)
            {
                if (Math.Abs(change[i]) > max)
                {
                    max = Math.Abs(change[i]);
                    imax = i;
                }
            }

            return imax;
        }

        //Ham su dung su tang, giam cua gia
        public int[] am_duong(Int64[] change)
        {
            int[] dau = new int[200];
            for (int i = 0; i < countTP; i++)
            {
                if (change[i] < 0)
                {
                    dau[i] = -1;
                }

                if (change[i] >= 0)
                {
                    dau[i] = 1;
                }
            }

            return dau;
        }

        public void cb_tien(int gia_chuan)
        {
            double gia_td = compute_gia_thucdon(count_MA_TD);
			
			tinhvc();
            MessageBox.Show("Gia ban dau: " + gia_td + "VC ban dau: " + vichat[3]);
			
            if (gia_td > gia_chuan && vichat[3] > 700000)
            {
                for (int i = 0; i < count_MA_TD; i++)
                {
                    for (int j = 0; j < countTP; j++)
                    {
                        if (tp_vc[j, 3] > 1000 && ma_tp[i, j] > 0)             //giam tp co nhieu cal (> 1000)
                        {
                            ma_tp[i, j] -= delta;
                        }
                        gia_td = compute_gia_thucdon(count_MA_TD);
                        tinhvc();
                    }
                }
                MessageBox.Show("Gia 1: " + gia_td + " VC1: " + vichat[3]);
            }

            //thua tien thieu chat
            if (gia_td > gia_chuan && vichat[3] < 700000)
            {
                for (int i = 0; i < count_MA_TD; i++)
                {
                    for (int j = 0; j < countTP; j++)
                    {
                        if (tp_vc[j, 3] > 0 && tp_vc[j, 3] < 1000 && ma_tp[i, j] > 0)             //giam tp co it cal (< 1000)
                        {
                            ma_tp[i, j] -= delta;
                        }
                        gia_td = compute_gia_thucdon(count_MA_TD);
                        tinhvc();
                    }
                }
                //MessageBox.Show("Gia 2: " + gia_td + " VC2: " + vichat[3]);
            }
            
            //Thieu tien thua chat
            if (gia_td < gia_chuan && vichat[3] > 700000)
            {
                for (int i = 0; i < count_MA_TD; i++)
                {
                    for (int j = 0; j < countTP; j++)
                    {
                        if (tp_vc[j, 3] > 0 && tp_vc[j, 3] < 1000 && ma_tp[i, j] > 0)             //Tang thang it cal (<1000)
                        {
                            ma_tp[i, j] += delta;
                        }
                        gia_td = compute_gia_thucdon(count_MA_TD);
                        tinhvc();
                    }
                }
            }

            //Thieu tien thieu chat
            if (gia_td < gia_chuan && vichat[3] < 700000)
            {
                for (int i = 0; i < count_MA_TD; i++)
                {
                    for (int j = 0; j < countTP; j++)
                    {
                        if (tp_vc[j, 3] > 1000 && ma_tp[i, j] > 0)             //Tang tp co nhieu cal (> 1000)
                        {
                            ma_tp[i, j] += delta;
                        }
                        gia_td = compute_gia_thucdon(count_MA_TD);
                    }
                }
                //MessageBox.Show("Gia 4: " + gia_td + " VC4: " + vichat[3]);
            }

			//Goi de quy
            if (gia_td > gia_chuan + 50 || gia_td < gia_chuan - 50 || vichat[3] > 721000 || vichat[3] < 679000)
                cb_tien(gia_chuan);
            
        }

        // tính giá tiền của thực đơn hiện tại
        public double compute_gia_thucdon(int count_MA_used)
        {
            double result = 0;
            for (int i = 0; i < count_MA_used; i++)
            {
                for (int j = 0; j < countTP; j++)
                {
                    result = result + (ma_tp[i, j] / 1000 * gia_new[j]);
                }
            }

            return result;
        }

        /*
        // ham tinh luong vi chat trong thuc don
        public void canbangvc()
        {
            tinhvc();
            MessageBox.Show("pro " + vichat[0] + " lip " + vichat[1] + " glu " + vichat[2] + " cal " + vichat[3]);
            int tmp;
            int[] count_pro = new int[200]; // dem so lan thay doi cua thuc pham
            int i = 0;
            int[] count_glu = new int[200];
            int j = 0;
            int[] count_lip = new int[200];
            int m = 0;
            int[] count_cal = new int[200];
            int n = 0;
            for (int count_lapn = 0; count_lapn < 1000 && (tmp = checkvc()) != 0; count_lapn++ )
            {
                for (int count_lap = 0; count_lap < 1000; count_lap++)
                {
                    if (checkvc() == 1 && i < 200)
                    {
                        double delta = dv_TP[pro[i]] / hs;
                        int vitri = 0;
                        while (vitri < count_MA_TD && count_pro[i] < 2)
                        {
                            if (ma_tp[vitri, pro[i]] > 0)
                            {
                                ma_tp[vitri, pro[i]] -= delta;
                                count_pro[i]++;
                                MessageBox.Show("Da giam " + pro[i]);
                            }
                            vitri++;
                            if (checkvc() != 1) break;
                        }
                        i++;
                        if (i == 200)
                        {
                            for (int k = 0; k < 200; k++)
                            {
                                count_pro[k] = 0;
                            }
                            i = 0;
                        }

                    }
                    if (count_lap == 999) MessageBox.Show("Thua protein, khong the can bang");
                }
                for (int count_lap = 0; count_lap < 1000; count_lap++)
                {
                    if ((tmp = checkvc()) == 2 && j < 200)
                    {
                        double delta = dv_TP[glu[j]] / hs;
                        int vitri = 0;
                        while (vitri < count_MA_TD && count_glu[j] < 2)
                        {
                            if (ma_tp[vitri, glu[j]] > 0)
                            {
                                ma_tp[vitri, glu[j]] -= delta;
                                count_glu[j]++;
                                MessageBox.Show("Da giam: " + glu[j]);
                            }
                            vitri++;
                            if (checkvc() != 2) break;
                        }
                        j++;
                        if (j == 200)
                        {
                            for (int k = 0; k < 200; k++)
                            {
                                count_glu[k] = 0;
                            }
                            j = 0;
                        }
                    }
                    if (count_lap == 999) MessageBox.Show("Thua gluxit, khong the can bang");
                }
                for (int count_lap = 0; count_lap < 1000; count_lap++)
                {
                    if ((tmp = checkvc()) == 3 && m < 200)
                    {
                        double delta = dv_TP[lip[m]] / hs;
                        int vitri = 0;
                        while (vitri < count_MA_TD && count_lip[m] < 2)
                        {
                            if (ma_tp[vitri, lip[m]] > 0)
                            {
                                ma_tp[vitri, lip[m]] -= delta;
                                count_lip[m]++;
                                MessageBox.Show("Da giam: " + lip[m]);
                            }
                            vitri++;
                            if (checkvc() != 3) break;
                        }
                        m++;
                        if (m == 200)
                        {
                            for (int k = 0; k < 200; k++)
                            {
                                count_lip[k] = 0;
                            }
                            m = 0;
                        }
                    }
                    if (count_lap == 999) MessageBox.Show("Thua lipit, khong the can bang");
                }
                for (int count_lap = 0; count_lap < 1000; count_lap++)
                {
                    if ((tmp = checkvc()) == 4 && n < 200)
                    {
                        double delta = dv_TP[cal[n]] / hs;
                        int vitri = 0;
                        while (vitri < count_MA_TD && count_cal[n] < 2)
                        {
                            if (ma_tp[vitri, cal[n]] > 0)
                            {
                                ma_tp[vitri, cal[n]] -= delta;
                                count_cal[n]++;
                                MessageBox.Show("Da giam: " + cal[n]);
                            }
                            vitri++;
                            if (checkvc() != 4) break;

                        }
                        n++;
                        if (n == 200)
                        {
                            for (int k = 0; k < 200; k++)
                            {
                                count_cal[k] = 0;
                            }
                            n = 0;
                        }
                    }
                }
                for (int count_lap = 0; count_lap < 1000; count_lap++)
                {
                    if ((tmp = checkvc()) == -4 && n < 200)
                    {
                        double delta = dv_TP[cal[n]] / hs;
                        int vitri = 0;
                        while (vitri < count_MA_TD && count_cal[n] < 2)
                        {
                            if (ma_tp[vitri, cal[n]] > 0)
                            {
                                ma_tp[vitri, cal[n]] += delta;
                                count_cal[n]++;
                                MessageBox.Show("Da giam: " + cal[n]);
                            }
                            vitri++;
                            if (checkvc() != -4) break;
                        }
                        n++;
                        if (n == 200)
                        {
                            for (int k = 0; k < 200; k++)
                            {
                                count_cal[k] = 0;
                            }
                            n = 0;
                        }
                    }
                }
                if (count_lapn == 999) MessageBox.Show("Khong the can bang");
            }
        }
         */

        // ham can bang vi chat
        public void canbangvc()
        {
            int tmp;
            int[] count_pro = new int[200]; // dem so lan thay doi cua thuc pham
            int i = 0;
            int[] count_glu = new int[200];
            int j = 0;
            int[] count_lip = new int[200];
            int m = 0;
            int[] count_cal = new int[200];
            int n = 0;
            while ((tmp = checkvc()) != 0)
            {

                while (checkvc() == 1 && i < 200)
                {
                    double delta = dv_TP[pro[i]] / hs;
                    int vitri = 0;
                    while (vitri < count_MA_TD && count_pro[i] < 2)
                    {
                        if (ma_tp[vitri, pro[i]] > 0)
                        {
                            ma_tp[vitri, pro[i]] -= delta;
                            count_pro[i]++;
                        }
                        vitri++;
                        if (checkvc() != 1) break;
                    }
                    i++;
                }

                while ((tmp = checkvc()) == 2 && j < 200)
                {
                    double delta = dv_TP[glu[j]] / hs;
                    int vitri = 0;
                    while (vitri < count_MA_TD && count_glu[j] < 2)
                    {
                        if (ma_tp[vitri, glu[j]] > 0)
                        {
                            ma_tp[vitri, glu[j]] -= delta;
                            count_glu[j]++;
                        }
                        vitri++;
                        if (checkvc() != 2) break;
                    }
                    j++;
                }

                while ((tmp = checkvc()) == 3 && m < 200)
                {
                    double delta = dv_TP[lip[m]] / hs;
                    int vitri = 0;
                    while (vitri < count_MA_TD && count_lip[m] < 2)
                    {
                        if (ma_tp[vitri, lip[m]] > 0)
                        {
                            ma_tp[vitri, lip[m]] -= delta;
                            count_lip[m]++;
                        }
                        vitri++;
                        if (checkvc() != 3) break;
                    }
                    m++;
                }

                while ((tmp = checkvc()) == 4 && n < 200)
                {

                    double delta = dv_TP[cal[n]] / hs;
                    int vitri = 0;
                    while (vitri < count_MA_TD && count_cal[n] < 2)
                    {
                        if (ma_tp[vitri, cal[n]] > 0)
                        {
                            ma_tp[vitri, cal[n]] -= delta;
                            count_cal[n]++;
                        }
                        vitri++;
                        if (checkvc() != 4) break;
                    }
                    n++;
                }

                while ((tmp = checkvc()) == -4 && n < 200)
                {
                    double delta = dv_TP[cal[n]] / hs;
                    int vitri = 0;
                    while (vitri < count_MA_TD && count_cal[n] < 2)
                    {
                        if (ma_tp[vitri, cal[n]] > 0)
                        {
                            ma_tp[vitri, cal[n]] += delta;
                            count_cal[n]++;
                        }
                        vitri++;
                        if (checkvc() != -4) break;
                    }
                    n++;
                }
            }
            //MessageBox.Show("pro " + vichat[0] + " lip " + vichat[1] + " glu " + vichat[2] + " cal " + vichat[3]);
        }

        // ham tinh luong vi chat trong thuc don
        public void tinhvc()
        {
            for (int i = 0; i < 10; i++)
            {
                vichat[i] = 0;
            }
            for (int countvc = 0; countvc < 10; countvc++)
            {
                for (int i = 0; i < count_MA_TD; i++)
                {
                    for (int j = 0; j < 200; j++)
                    {
                        vichat[countvc] += ma_tp[i, j] * tp_vc[j, countvc];
                    }
                }
            }
            string str = null;
            for (int i = 0; i < 10; i++)
            {
                str += vichat[i] + "   ";
            }
            //MessageBox.Show(str);
        }
        
        // lay thuc pham giau protein
        public void getpro()
        {
            getmax(0, 200);
        }
        // lay thuc pham giau gluxit
        public void getglu()
        {
            getmax(2, 200);
        }
        // lay thuc pham giau lipit
        public void getlip()
        {
            getmax(1, 200);
        }
        // lay thuc pham giau calo
        public void getcal()
        {
            getmax(3, 200);
        }

        // ham check xem luong vi chat da on chua
        // = 0 : tot
        // +1: thua protein
        // +2: thua gluxit
        // +3: thua lipit
        // +4: thieu calo
        public int checkvc()
        {
            tinhvc();
            int result = 0;
            double sumvc = vichat[0] + vichat[1] + vichat[2];
            double pro = vichat[0] / sumvc;
            double glu = vichat[2] / sumvc;
            double lip = vichat[1] / sumvc;

            if (vichat[3] < 670000) result = -4;
            else if (vichat[3] > 730000) result = 4;
            

            return result;
        }



        public int locate(int ID, int[] tb, int array_size)
        {
            int result = -1;
            for (int i = 0; i < array_size; i++)
            {
                if (tb[i] == ID)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        public int locate(int ID, int[,] tb, int array_size)
        {
            int result = -1;
            for (int i = 0; i < array_size; i++)
            {
                if (tb[i, 0] == ID)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
        // ham lay ra n phan tu lon nhat trong cot col o bang tb
        public void getmax(int col, int n)
        {
            if (col == 0)
            {
                int[,] array = new int[2, 200];
                for (int i = 0; i < 200; i++)
                {
                    array[0, i] = i;
                    array[1, i] = tp_vc[i, 0];
                }
                for (int i = 0; i < 200; i++)
                {
                    for (int j = i + 1; j < 200; j++)
                    {
                        if (array[1, i] < array[1, j])
                        {
                            int tmp1 = array[0, i];
                            int tmp2 = array[1, i];
                            array[0, i] = array[0, j];
                            array[1, i] = array[1, j];
                            array[0, j] = tmp1;
                            array[1, j] = tmp2;
                        }
                    }
                }
                for (int i = 0; i < 200; i++)
                {
                    pro[i] = array[0, i];
                }
            }
            else if (col == 1)
            {
                int[,] array = new int[2, 200];
                for (int i = 0; i < 200; i++)
                {
                    array[0, i] = i;
                    array[1, i] = tp_vc[i, 1];
                }
                for (int i = 0; i < 200; i++)
                {
                    for (int j = i + 1; j < 200; j++)
                    {
                        if (array[1, i] < array[1, j])
                        {
                            int tmp1 = array[0, i];
                            int tmp2 = array[1, i];
                            array[0, i] = array[0, j];
                            array[1, i] = array[1, j];
                            array[0, j] = tmp1;
                            array[1, j] = tmp2;
                        }
                    }
                }
                for (int i = 0; i < 200; i++)
                {
                    lip[i] = array[0, i];
                }
            }
            else if (col == 2)
            {
                int[,] array = new int[2, 200];
                for (int i = 0; i < 200; i++)
                {
                    array[0, i] = i;
                    array[1, i] = tp_vc[i, 2];
                }
                for (int i = 0; i < 200; i++)
                {
                    for (int j = i + 1; j < 200; j++)
                    {
                        if (array[1, i] < array[1, j])
                        {
                            int tmp1 = array[0, i];
                            int tmp2 = array[1, i];
                            array[0, i] = array[0, j];
                            array[1, i] = array[1, j];
                            array[0, j] = tmp1;
                            array[1, j] = tmp2;
                        }
                    }
                }
                for (int i = 0; i < 200; i++)
                {
                    glu[i] = array[0, i];
                }
            }
            else if (col == 3)
            {
                int[,] array = new int[2, 200];
                for (int i = 0; i < 200; i++)
                {
                    array[0, i] = i;
                    array[1, i] = tp_vc[i, 3];
                }
                for (int i = 0; i < 200; i++)
                {
                    for (int j = i + 1; j < 200; j++)
                    {
                        if (array[1, i] < array[1, j])
                        {
                            int tmp1 = array[0, i];
                            int tmp2 = array[1, i];
                            array[0, i] = array[0, j];
                            array[1, i] = array[1, j];
                            array[0, j] = tmp1;
                            array[1, j] = tmp2;
                        }
                    }
                }
                for (int i = 0; i < 200; i++)
                {
                    cal[i] = array[0, i];
                }
            }
        }
	/*
	public void xuatfile()
        {
            FileInfo f1 = new FileInfo("data/database/thucpham.dat");
            if (f1.Exists == true)
            {
                f1.CopyTo("data/database/thucpham-" + DateTime.Now.Date + ".bak", true);
            }
            FileInfo f2 = new FileInfo("data/database/monan_thucpham.dat");
            if (f2.Exists == true)
            {
                f2.CopyTo("data/database/monan_thucpham-" + DateTime.Now.Date + ".bak", true);
            }
            FileInfo f3 = new FileInfo("data/database/kho.dat");
            if (f3.Exists == true)
            {
                f3.CopyTo("data/database/kho-" + DateTime.Now.Date + ".bak", true);
            }
            FileInfo f4 = new FileInfo("data/database/thucdon_monan.dat");
            if (f4.Exists == true)
            {
                f4.CopyTo("data/database/thucdon_monan-" + DateTime.Now.Date + ".bak", true);
            }

            string str = null;
            for (int i = 0; i < count_MA_TD; i++)
            {
                //str += td_ma[i];
                for (int j = 0; j < 200; j++)
                {
                    if (ma_tp[i, j] > 0)
                    {
                        str += td_ma[i];
                        str += "/";
                        str += j;
                        str += "/";
                        str += ma_tp[i, j];
                        str += "\n";
                    }
                }
            }

            File.WriteAllText("data/database/monan_thucpham.dat", str);
        }
	*/
	
	public void xuathopdong()
        {
            FileInfo hopdong = new FileInfo("data/database/hopdong.dat");
            if (hopdong.Exists == true)
            {
                string newfilename = "data/database/hopdong-"
                    + DateTime.Now.Day + "-"
                    + DateTime.Now.Month + "-"
                    + DateTime.Now.Year + ".dat";
                hopdong.CopyTo(newfilename, true);
            }
            string str_hopdong = null;
            for (int i = 0; i < quanli_HDTP.count_TP_t; i++)
            {
                str_hopdong += quanli_HDTP.ID_TP_t[i] + "/";
                str_hopdong += quanli_HDTP.name_TP_t[i] + "/";
                str_hopdong += quanli_HDTP.dongia_TP_kho_new_t[i] + "/";
                str_hopdong += quanli_HDTP.nhaphanphoi[i] + "/";
                str_hopdong += quanli_HDTP.ngaybatdau[i] + "/";
                str_hopdong += quanli_HDTP.ngayketthuc[i] + "/";
                str_hopdong += "\n";
            }
            File.WriteAllText("data/database/hopdong.dat", str_hopdong);
        }
    }

    public class modun_quanli_hocsinh
    {
        public int hs_mg = 0;
        public int hs_nt = 0;
        public int td_homnay = 0;
        public int count_ma_used = 0;
        public int[] td_ma = new int[20];
        public double[,] ma_tp = new double[20, 200];
        public double[,] tb_dutru_mg = new double[20, 200];
        public double[,] tb_dutru_nt = new double[20, 200];
        public double[,] tb_chinhthuc_mg = new double[20, 200];
        public double[,] tb_chinhthuc_nt = new double[20, 200];
        public double[,] tb_dutru = new double[20, 200];
        public double[,] tb_chinhthuc = new double[20, 200];
        public double[,] tb_tp_thua = new double[20, 200];

        public modun_quanli_hocsinh() 
        {
            query_hs();
            query_td();
            query_td_ma();
            query_ma_tp();
            dutru();
        }

        public void query_td()
        {
            FileInfo file = new FileInfo("data/database/thucdon.dat");
            if (file.Exists == true)
            {
                
            }
        }

        public void query_hs()
        {
            FileInfo file = new FileInfo("data/database/hocsinh_hangngay.dat");
            if (file.Exists == true)
            {
                StreamReader sr = File.OpenText("data/database/hocsinh_hangngay.dat");
                string[] filter = sr.ReadLine().Split("/".ToCharArray());
                
                hs_mg = Convert.ToInt32(filter[0]);
                hs_nt = Convert.ToInt32(filter[1]);
                /*
                int td_homqua = Convert.ToInt32(filter[2]);
                if (td_homqua < 9) td_homnay = td_homqua + 1;
                else td_homnay = 0;
                 */
            }
        }

        public void luu_hocsinh()
        {
            FileInfo file = new FileInfo("data/database/hocsinh_hangngay.dat");
            if (file.Exists == true)
            {
                StreamReader sr = File.OpenText("data/database/hocsinh_hangngay.dat");
                string str = null;
                str += hs_mg + "/" + hs_nt + "/" + "\n";
                str += sr.ReadToEnd();
                sr.Close();
                File.WriteAllText("data/database/hocsinh_hangngay.dat", str);
            }
        }

        public void query_td_ma()
        {
            count_ma_used = 0;
            FileInfo file = new FileInfo("data/database/thucdon_monan.dat");
            if (file.Exists == true)
            {
                StreamReader sr = File.OpenText("data/database/thucdon_monan.dat");
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    string[] filter = input.Split("/".ToCharArray());
                    int ID_TD = Convert.ToInt32(filter[0]);
                    int ID_MA = Convert.ToInt32(filter[1]);
                    int luong_MA = Convert.ToInt32(filter[2]);

                    if (ID_TD == td_homnay && luong_MA > 0)
                    {
                        td_ma[count_ma_used] = ID_MA;
                        count_ma_used++;
                    }
                }
            }
        }

        public void query_ma_tp()
        {
            FileInfo file = new FileInfo("data/database/monan_thucpham.dat");
            if (file.Exists == true)
            {
                StreamReader sr = File.OpenText("data/database/monan_thucpham.dat");
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    string[] filter = input.Split("/".ToCharArray());
                    int ID_MA = Convert.ToInt32(filter[0]);
                    int ID_TP = Convert.ToInt32(filter[1]);
                    double luong_TP = Convert.ToDouble(filter[2]);

                    for (int i = 0; i < count_ma_used; i++)
                    {
                        if (ID_MA == td_ma[i])
                        {
                            ma_tp[i, ID_TP] = luong_TP;
                        }
                    }
                }
            }
        }
        // dự trù thực phẩm cho ngày hôm nay theo số học sinh hôm trước
        public void dutru()
        {
            nhan_so_hs(hs_mg, ma_tp, tb_dutru_mg);
            nhan_so_hs(hs_nt, ma_tp, tb_dutru_nt);
            cong_matran(tb_dutru_mg, tb_dutru_nt, tb_dutru);
        }
        // tính thực phẩm chính thức của hôm nay theo số học sinh thực tế
        public void chinhthuc()
        {
            nhan_so_hs(hs_mg, ma_tp, tb_chinhthuc_mg);
            nhan_so_hs(hs_nt, ma_tp, tb_chinhthuc_nt);
            cong_matran(tb_chinhthuc_mg, tb_chinhthuc_nt, tb_chinhthuc);
        }
        // tính thực phẩm dư thừa
        public void tinh_tp_thua()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 200; j++)
                {
                    tb_tp_thua[i, j] = tb_dutru[i, j] - tb_chinhthuc[i, j];
                }
            }
        }

        public void nhan_so_hs(int number, double[,] ma, double[,] ketqua)
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 200; j++)
                {
                    ketqua[i, j] = ma[i, j] * number;
                }
            }
        }

        public void cong_matran(double[,] mt1, double[,] mt2, double[,] ketqua)
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 200; j++)
                {
                    ketqua[i, j] = mt1[i, j] + mt2[i, j];
                }
            }

        }
	
    }
}