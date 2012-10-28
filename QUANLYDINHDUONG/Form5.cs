using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        private modun_quanli_thucdon_dinhduong tronghoa_nt = new modun_quanli_thucdon_dinhduong();
        private modun_quanli_thucdon_dinhduong tronghoa_mg = new modun_quanli_thucdon_dinhduong();
        private modun_quanli_hocsinh md2 = new modun_quanli_hocsinh();
        
        public Form5()
        {
            md2.query_hs();
            
            //Thread.CurrentThread.SetApartmentState(ApartmentState.STA);
            tronghoa_nt.query_thucdon(md2.ID_td_homnay);
            tronghoa_nt.query_monan();
            tronghoa_nt.query_thucpham();
            tronghoa_nt.query_vichat();
            tronghoa_nt.query_join_thucdon_monan();
            tronghoa_nt.query_join_monan_thucpham();
            tronghoa_nt.query_join_thucpham_vichat();
            tronghoa_nt.compute_table_luong_BA_MA();
            tronghoa_nt.compute_table_luong_BA_TP();
            tronghoa_nt.compute_table_luong_BA_VC();

            tronghoa_mg.query_thucdon(md2.ID_td_homnay);
            tronghoa_mg.query_monan();
            tronghoa_mg.query_thucpham();
            tronghoa_mg.query_vichat();
            tronghoa_mg.query_join_thucdon_monan_mg();
            tronghoa_mg.query_join_monan_thucpham();
            tronghoa_mg.query_join_thucpham_vichat();
            tronghoa_mg.compute_table_luong_BA_MA();
            tronghoa_mg.compute_table_luong_BA_TP();
            tronghoa_mg.compute_table_luong_BA_VC();
            InitializeComponent();

            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            string file_name = "" + day + "-" + month + "-" + year;
            this.Text = "THỰC ĐƠN TRONG NGÀY " + file_name + " - Bảng thực đơn và thông tin vi chất";
            create_dynamic_code();
            create_end_form();
            create_items();
            create_buy_export_form();
            chiphi_nhatre_maugiao();
            this.tb_luonghs_maugiao.Text = md2.hs_mg + "";
            this.tb_luonghs_nhatre.Text = md2.hs_nt + "";
            //MessageBox.Show("thành công");
        }
        private void cb_Select_nt(object sender, EventArgs e)
        {
            //MessageBox.Show("trongho");
            int test;
            if (sender == cb_monan[0])
            {
                for (int j = 0; j < tronghoa_nt.count_MA; j++)
                {
                    if (cb_monan[0].SelectedItem.ToString() == tronghoa_nt.name_MA[j])
                    {
                        tronghoa_nt.change_monan(0, tronghoa_nt.ID_MA[j]);

                        test = tronghoa_nt.luong_BA_MA_use[0, 0];

                    }
                }
            }

            if (sender == cb_monan[2])
            {
                for (int j = 0; j < tronghoa_nt.count_MA; j++)
                {
                    if (cb_monan[2].SelectedItem.ToString() == tronghoa_nt.name_MA[j])
                    {
                        tronghoa_nt.change_monan(1, tronghoa_nt.ID_MA[j]);

                        test = tronghoa_nt.luong_BA_MA_use[1, 0];

                    }
                }
            }

            if (sender == cb_monan[4])
            {
                for (int j = 0; j < tronghoa_nt.count_MA; j++)
                {
                    if (cb_monan[4].SelectedItem.ToString() == tronghoa_nt.name_MA[j])
                    {
                        tronghoa_nt.change_monan(2, tronghoa_nt.ID_MA[j]);

                        test = tronghoa_nt.luong_BA_MA_use[2, 0];

                    }
                }
            }

            if (sender == cb_monan[5])
            {
                for (int j = 0; j < tronghoa_nt.count_MA; j++)
                {
                    if (cb_monan[5].SelectedItem.ToString() == tronghoa_nt.name_MA[j])
                    {
                        tronghoa_nt.change_monan(3, tronghoa_nt.ID_MA[j]);

                        test = tronghoa_nt.luong_BA_MA_use[2, 1];

                    }
                }
            }

            if (sender == cb_monan[6])
            {
                for (int j = 0; j < tronghoa_nt.count_MA; j++)
                {
                    if (cb_monan[6].SelectedItem.ToString() == tronghoa_nt.name_MA[j])
                    {
                        tronghoa_nt.change_monan(4, tronghoa_nt.ID_MA[j]);
                        test = tronghoa_nt.luong_BA_MA_use[2, 2];
                    }
                }
            }

            if (sender == cb_monan[10])
            {
                for (int j = 0; j < tronghoa_nt.count_MA; j++)
                {
                    if (cb_monan[10].SelectedItem.ToString() == tronghoa_nt.name_MA[j])
                    {
                        tronghoa_nt.change_monan(5, tronghoa_nt.ID_MA[j]);
                        test = tronghoa_nt.luong_BA_MA_use[3, 0];
                    }
                }
            }

            for (int i = 0; i < this.tronghoa_nt.count_TP_use; i++)
            {
                // 
                // tb_stt_nt
                // 
                this.tb_stt_nt[i].Enabled = false;
                this.tb_stt_nt[i].Location = new System.Drawing.Point(3, 3 + 29 * i);
                this.tb_stt_nt[i].Name = "tb_stt_nt";
                this.tb_stt_nt[i].Size = new System.Drawing.Size(36, 20);
                this.tb_stt_nt[i].Text = "" + (i + 1);
                this.tb_stt_nt[i].TabIndex = 5;
                this.tb_stt_nt[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_name_thucpham_nt
                // 
                this.tb_name_thucpham_nt[i].Location = new System.Drawing.Point(45, 3 + 29 * i);
                this.tb_name_thucpham_nt[i].Name = "tb_name_thucpham_nt";
                this.tb_name_thucpham_nt[i].Size = new System.Drawing.Size(145, 20);
                this.tb_name_thucpham_nt[i].TabIndex = 6;
                this.tb_name_thucpham_nt[i].Text = tronghoa_nt.name_TP_use[i];
                // 
                // tb_type_nt
                // 
                this.tb_type_nt[i].Location = new System.Drawing.Point(196, 3 + 29 * i);
                this.tb_type_nt[i].Name = "tb_type_nt";
                this.tb_type_nt[i].Size = new System.Drawing.Size(66, 20);
                this.tb_type_nt[i].TabIndex = 7;
                this.tb_type_nt[i].Text = tronghoa_nt.type_TP_use[i];
                this.tb_type_nt[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_donvi_tp_nt
                // 
                this.tb_donvi_tp_nt[i].Location = new System.Drawing.Point(268, 3 + 29 * i);
                this.tb_donvi_tp_nt[i].Name = "tb_donvi_tp_nt";
                this.tb_donvi_tp_nt[i].Size = new System.Drawing.Size(66, 20);
                this.tb_donvi_tp_nt[i].TabIndex = 11;
                this.tb_donvi_tp_nt[i].Text = tronghoa_nt.unit_TP[i];
                this.tb_donvi_tp_nt[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_luongsd_nt
                // 
                this.tb_luongsd_nt[i].Location = new System.Drawing.Point(340, 3 + 29 * i);
                this.tb_luongsd_nt[i].Name = "tb_luongsd_nt";
                this.tb_luongsd_nt[i].Size = new System.Drawing.Size(66, 20);
                this.tb_luongsd_nt[i].TabIndex = 12;
                this.tb_luongsd_nt[i].Text = tronghoa_nt.luong_TD_TP_use[i] + "";
                this.tb_luongsd_nt[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_trongkho_nt
                // 
                this.tb_trongkho_nt[i].Location = new System.Drawing.Point(412, 3 + 29 * i);
                this.tb_trongkho_nt[i].Name = "tb_trongkho_nt";
                this.tb_trongkho_nt[i].Size = new System.Drawing.Size(60, 20);
                this.tb_trongkho_nt[i].TabIndex = 8;
                this.tb_trongkho_nt[i].Text = tronghoa_nt.luong_TP_kho_new[i] + "";
                this.tb_trongkho_nt[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                if (this.tb_type_nt[i].Text == "có sẵn")
                {
                    this.tb_trongkho_nt[i].Text = tronghoa_mg.luong_TP_kho_new[i] + "";
                }
                else
                {
                    this.tb_trongkho_nt[i].Text = "--";
                }
                this.flp_thucpham_nhatre.Controls.Add(this.tb_stt_nt[i]);
                this.flp_thucpham_nhatre.Controls.Add(this.tb_name_thucpham_nt[i]);
                this.flp_thucpham_nhatre.Controls.Add(this.tb_type_nt[i]);
                this.flp_thucpham_nhatre.Controls.Add(this.tb_donvi_tp_nt[i]);
                this.flp_thucpham_nhatre.Controls.Add(this.tb_luongsd_nt[i]);
                this.flp_thucpham_nhatre.Controls.Add(this.tb_trongkho_nt[i]);
            }

            tronghoa_nt.luong_BA_VC_use = tronghoa_nt.sup_matrix(tronghoa_nt.luong_BA_TP_use, tronghoa_nt.luong_TP_VC, 4, tronghoa_nt.count_VC, tronghoa_nt.count_TP);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    tb_luong_vichat[i, j].Text = tronghoa_nt.luong_BA_VC_use[i, j] + "";
                }
            }

            for (int i = 0; i < 6; i++)
            {
                tb_luong_vichat[4, i].Text = (Int32.Parse(tb_luong_vichat[0, i].Text) + Int32.Parse(tb_luong_vichat[1, i].Text) + Int32.Parse(tb_luong_vichat[2, i].Text) + Int32.Parse(tb_luong_vichat[3, i].Text)) + "";
            }

            evalue_nuti_rulebase();
            
            create_buy_export_form();
            chiphi_nhatre_maugiao();
        }

        private void cb_Select_mg(object sender, EventArgs e)
        {
            int test;
            if (sender == cb_monan[1])
            {
                for (int j = 0; j < tronghoa_mg.count_MA; j++)
                {
                    if (cb_monan[1].SelectedItem.ToString() == tronghoa_mg.name_MA[j])
                    {
                        tronghoa_mg.change_monan(0, tronghoa_mg.ID_MA[j]);

                        test = tronghoa_mg.luong_BA_MA_use[0, 0];

                    }
                }
            }

            if (sender == cb_monan[3])
            {
                for (int j = 0; j < tronghoa_mg.count_MA; j++)
                {
                    if (cb_monan[3].SelectedItem.ToString() == tronghoa_mg.name_MA[j])
                    {
                        tronghoa_mg.change_monan(1, tronghoa_mg.ID_MA[j]);

                        test = tronghoa_mg.luong_BA_MA_use[1, 0];

                    }
                }
            }

            if (sender == cb_monan[7])
            {
                for (int j = 0; j < tronghoa_mg.count_MA; j++)
                {
                    if (cb_monan[7].SelectedItem.ToString() == tronghoa_mg.name_MA[j])
                    {
                        tronghoa_mg.change_monan(2, tronghoa_mg.ID_MA[j]);

                        test = tronghoa_mg.luong_BA_MA_use[2, 0];

                    }
                }
            }

            if (sender == cb_monan[8])
            {
                for (int j = 0; j < tronghoa_mg.count_MA; j++)
                {
                    if (cb_monan[8].SelectedItem.ToString() == tronghoa_mg.name_MA[j])
                    {
                        tronghoa_mg.change_monan(3, tronghoa_mg.ID_MA[j]);

                        test = tronghoa_mg.luong_BA_MA_use[2, 1];

                    }
                }
            }

            if (sender == cb_monan[9])
            {
                for (int j = 0; j < tronghoa_mg.count_MA; j++)
                {
                    if (cb_monan[9].SelectedItem.ToString() == tronghoa_mg.name_MA[j])
                    {
                        tronghoa_mg.change_monan(4, tronghoa_mg.ID_MA[j]);

                        test = tronghoa_mg.luong_BA_MA_use[2, 2];

                    }
                }
            }

            if (sender == cb_monan[11])
            {
                for (int j = 0; j < tronghoa_mg.count_MA; j++)
                {
                    if (cb_monan[11].SelectedItem.ToString() == tronghoa_mg.name_MA[j])
                    {
                        tronghoa_mg.change_monan(5, tronghoa_mg.ID_MA[j]);

                        test = tronghoa_mg.luong_BA_MA_use[3, 0];

                    }
                }
            }

            for (int i = 0; i < this.tronghoa_mg.count_TP_use; i++)
            {
                // 
                // tb_stt_mg
                // 
                this.tb_stt_mg[i].Enabled = false;
                this.tb_stt_mg[i].Location = new System.Drawing.Point(3, 3 + 29 * i);
                this.tb_stt_mg[i].Name = "tb_stt_mg";
                this.tb_stt_mg[i].Size = new System.Drawing.Size(36, 20);
                this.tb_stt_mg[i].Text = "" + (i + 1);
                this.tb_stt_mg[i].TabIndex = 5;
                this.tb_stt_mg[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_name_thucpham_mg
                // 
                this.tb_name_thucpham_mg[i].Location = new System.Drawing.Point(45, 3 + 29 * i);
                this.tb_name_thucpham_mg[i].Name = "tb_name_thucpham_mg";
                this.tb_name_thucpham_mg[i].Size = new System.Drawing.Size(145, 20);
                this.tb_name_thucpham_mg[i].TabIndex = 6;
                this.tb_name_thucpham_mg[i].Text = tronghoa_mg.name_TP_use[i];
                // 
                // tb_type_mg
                // 
                this.tb_type_mg[i].Location = new System.Drawing.Point(196, 3 + 29 * i);
                this.tb_type_mg[i].Name = "tb_type_mg";
                this.tb_type_mg[i].Size = new System.Drawing.Size(66, 20);
                this.tb_type_mg[i].TabIndex = 7;
                this.tb_type_mg[i].Text = tronghoa_mg.type_TP_use[i];
                this.tb_type_mg[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_donvi_tp_mg
                // 
                this.tb_donvi_tp_mg[i].Location = new System.Drawing.Point(268, 3 + 29 * i);
                this.tb_donvi_tp_mg[i].Name = "tb_donvi_tp_mg";
                this.tb_donvi_tp_mg[i].Size = new System.Drawing.Size(66, 20);
                this.tb_donvi_tp_mg[i].TabIndex = 11;
                this.tb_donvi_tp_mg[i].Text = tronghoa_mg.unit_TP[i];
                this.tb_donvi_tp_mg[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_luongsd_mg
                // 
                this.tb_luongsd_mg[i].Location = new System.Drawing.Point(340, 3 + 29 * i);
                this.tb_luongsd_mg[i].Name = "tb_luongsd_mg";
                this.tb_luongsd_mg[i].Size = new System.Drawing.Size(66, 20);
                this.tb_luongsd_mg[i].TabIndex = 12;
                this.tb_luongsd_mg[i].Text = tronghoa_mg.luong_TD_TP_use[i] + "";
                this.tb_luongsd_mg[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_trongkho_mg
                // 
                this.tb_trongkho_mg[i].Location = new System.Drawing.Point(412, 3 + 29 * i);
                this.tb_trongkho_mg[i].Name = "tb_trongkho_mg";
                this.tb_trongkho_mg[i].Size = new System.Drawing.Size(60, 20);
                this.tb_trongkho_mg[i].TabIndex = 8;
                this.tb_trongkho_mg[i].Text = tronghoa_mg.luong_TP_kho_new[i] + "";
                this.tb_trongkho_mg[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                if (this.tb_type_mg[i].Text == "có sẵn")
                {
                    this.tb_trongkho_mg[i].Text = tronghoa_mg.luong_TP_kho_new[i] + "";
                }
                else
                {
                    this.tb_trongkho_mg[i].Text = "--";
                }

                this.flp_thucpham_maugiao.Controls.Add(this.tb_stt_mg[i]);
                this.flp_thucpham_maugiao.Controls.Add(this.tb_name_thucpham_mg[i]);
                this.flp_thucpham_maugiao.Controls.Add(this.tb_type_mg[i]);
                this.flp_thucpham_maugiao.Controls.Add(this.tb_donvi_tp_mg[i]);
                this.flp_thucpham_maugiao.Controls.Add(this.tb_luongsd_mg[i]);
                this.flp_thucpham_maugiao.Controls.Add(this.tb_trongkho_mg[i]);
            }

            tronghoa_mg.luong_BA_VC_use = tronghoa_mg.sup_matrix(tronghoa_mg.luong_BA_TP_use, tronghoa_mg.luong_TP_VC, 4, tronghoa_mg.count_VC, tronghoa_mg.count_TP);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    tb_luong_vichat[i, j + 6].Text = tronghoa_mg.luong_BA_VC_use[i, j] + "";
                }
            }
            for (int i = 0; i < 6; i++)
            {
                tb_luong_vichat[4, i + 6].Text = (Int32.Parse(tb_luong_vichat[0, i + 6].Text) + Int32.Parse(tb_luong_vichat[1, i + 6].Text) + Int32.Parse(tb_luong_vichat[2, i + 6].Text) + Int32.Parse(tb_luong_vichat[3, i + 6].Text)) + "";
            }

            evalue_nuti_rulebase();
            
            create_buy_export_form();
            chiphi_nhatre_maugiao();
        }

        private void bt_luonghs_nhatre_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tronghoa_nt.count_TP_use; i++)
            {
                tb_luongsd_nt[i].Text = tronghoa_nt.luong_TD_TP_use[i] * Int32.Parse(tb_luonghs_nhatre.Text) + "";
            }
        }

        private void bt_luonghs_maugiao_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tronghoa_mg.count_TP_use; i++)
            {
                tb_luongsd_mg[i].Text = tronghoa_mg.luong_TD_TP_use[i] * Int32.Parse(tb_luonghs_maugiao.Text) + "";
            }
        }
        // ve giao doen chinh cua chuong trinh
        private void bt_mainboard_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.count_mb++;
            Program.th_mb[Program.count_mb].Start();

        }

        private void bt_chiphi_Click(object sender, EventArgs e)
        {
            this.pn_mua_thucpham.Visible = true;
            this.pn_thucpham_luonghs.Visible = false;
            int sum1 = 0;
            if (MD_qlk.check_satify == 1)
            {
                MessageBox.Show("Hiện tại lượng thực phẩm không để có thể xây dựn thực đơn trong ngày\nXin hãy nhập thực đơn vào kho");
                this.Close();
                Program.count_mb++;
                Program.th_mb[Program.count_mb].Start();
            }
            for (int i = 0; i < (count_tp_buy + MD_qlk.count_export); i++)
            {
                sum1 = sum1 + Int32.Parse(this.tb_comp_tp_cp[i].Text);
            }
            this.tb_sum.Text = sum1 + "";
        }

        private void bt_back_tp_Click(object sender, EventArgs e)
        {
            this.pn_mua_thucpham.Visible = false;
            this.pn_thucpham_luonghs.Visible = true;
        }

        private void bt_td_vc_Click(object sender, EventArgs e)
        {
            this.pn_td_dd.Visible = true;
            this.pn_thucpham_luonghs.Visible = false;
        }

        private void bt_left_Click(object sender, EventArgs e)
        {

        }

        private void bt_right_Click(object sender, EventArgs e)
        {
            this.pn_td_dd.Visible = false;
            this.pn_thucpham_luonghs.Visible = true;
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            string file_name = "" + day + "-" + month + "-" + year;
            this.Text = "THỰC ĐƠN TRONG NGÀY " + file_name + " - Bảng điểm danh và tính lượng thực phẩm sử dụng trong toàn trường";
        }

        private void headline_vichat_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();

            string workbookPath = "C:/Users/tronghoa/Desktop/tpl_bchangngay.xls";

            COMExcel.Workbook exBook = exApp.Workbooks.Open(workbookPath,
                    0, false, 5, "", "", false, COMExcel.XlPlatform.xlWindows, "",
                    true, false, 0, true, false, false);

            // Lấy sheet 1.
            COMExcel.Worksheet exSheet = (COMExcel.Worksheet)exBook.Worksheets[1];

            // Range là ô [1,1] (A1)

            //COMExcel.Range r;

            for (int i = 1; i < 19; i++)
            {

                COMExcel.Range r = (COMExcel.Range)exSheet.Cells[i, 1];

                // Ghi dữ liệu
                r.Value2 = "Demo excel value " + 1;

                // Giãn cột
                r.Columns.AutoFit();
            }
                // Hiển thị chương trình excel
            exApp.Visible = true;
            
            // Đóng chương trình excel

            //r = (COMExcel.Range)exSheet.get_Range("A1", "A4");

            exApp.Visible = false;
            
            // Save file
            exBook.SaveAs("C:\\file.xls", COMExcel.XlFileFormat.xlWorkbookNormal, null, null, false, false, COMExcel.XlSaveAsAccessMode.xlExclusive, false, false, false, false, false);
             
           

            exBook.Close(false, false, false);
            exApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);
        }
        // create_items: tao textbox, etc. ...
        private void create_items()
        {
            for (int i = 0; i < 100; i++)
            {
                this.tb_stt_cp[i] = new System.Windows.Forms.TextBox();
                this.tb_name_tp_cp[i] = new System.Windows.Forms.TextBox();
                this.tb_unit_tp_cp[i] = new System.Windows.Forms.TextBox();
                this.tb_luong_tp_cp[i] = new System.Windows.Forms.TextBox();
                this.tb_price_tp_cp[i] = new System.Windows.Forms.TextBox();
                this.tb_donvi_dongia_cp[i] = new System.Windows.Forms.TextBox();
                this.tb_tonkho_cp[i] = new System.Windows.Forms.TextBox();
                this.tb_comp_tp_cp[i] = new System.Windows.Forms.TextBox();
                this.tb_comment_tp_cp[i] = new System.Windows.Forms.TextBox();
            }

            this.lb_kho = new System.Windows.Forms.Label();
            this.pn_kho = new System.Windows.Forms.Panel();
            

        }

        private void key_press_tb_price_tp_cp(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < count_tp_buy; i++)
            {
                if (sender == this.tb_price_tp_cp[i])
                {
                    if (e.KeyChar == (char)13 && Control.ModifierKeys != Keys.Shift)
                    {
                        //MessageBox.Show("forward" + e.KeyChar);
                        this.tb_price_tp_cp[i + 1].Focus();
                    }
                    if (e.KeyChar == (char)13 && Control.ModifierKeys == Keys.Shift)
                    {
                        //MessageBox.Show("back" + e.KeyChar);
                        this.tb_price_tp_cp[i - 1].Focus();
                    }
                }
            }
        }

        private void create_buy_export_form()
        {
            
            count_tp_buy = 0;
            for (int i = 0; i < tronghoa_mg.count_TP_use; i++)
            {
                if (this.tb_type_mg[i].Text == "Hàng ngày")
                {
                    //MessageBox.Show(this.tb_luongsd_mg[i].Text);
                    luong_tp_buy[count_tp_buy] = Int32.Parse(this.tb_luongsd_mg[i].Text);
                    name_tp_buy[count_tp_buy] = tronghoa_mg.name_TP_use[i];
                    count_tp_buy++;
                }
            }

            for (int i = 0; i < tronghoa_nt.count_TP_use; i++)
            {
                int check = 0;
                
                for (int j = 0; j < count_tp_buy; j++)
                {
                    if (tronghoa_nt.name_TP_use[i] == name_tp_buy[j])
                    {
                        check = 1;
                        //MessageBox.Show(this.tb_luongsd_nt[i].Text);
                        luong_tp_buy[j] = luong_tp_buy[j] + Int32.Parse(this.tb_luongsd_nt[i].Text);
                        //MessageBox.Show("" + i);
                    }
                }

                if (check == 0 && this.tb_type_nt[i].Text == "Hàng ngày")
                {
                    //MessageBox.Show(this.tb_luongsd_nt[i].Text);
                    luong_tp_buy[count_tp_buy] = Int32.Parse(this.tb_luongsd_nt[i].Text);
                    name_tp_buy[count_tp_buy] = tronghoa_nt.name_TP_use[i];
                    count_tp_buy++;
                }
            }
            //MessageBox.Show("" + count_tp_buy);
            for (int i = 0; i < count_tp_buy; i++)
            {
                // 
                // tb_stt_cp
                // 
                this.tb_stt_cp[i].Location = new System.Drawing.Point(3, 3);
                this.tb_stt_cp[i].Name = "tb_stt_cp";
                this.tb_stt_cp[i].Size = new System.Drawing.Size(31, 20);
                this.tb_stt_cp[i].TabIndex = 0;
                this.tb_stt_cp[i].Text = (i + 1) + "";
                this.tb_stt_cp[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_name_tp_cp
                // 
                this.tb_name_tp_cp[i].Location = new System.Drawing.Point(40, 3);
                this.tb_name_tp_cp[i].Name = "tb_name_tp_cp";
                this.tb_name_tp_cp[i].Size = new System.Drawing.Size(156, 20);
                this.tb_name_tp_cp[i].TabIndex = 1;
                this.tb_name_tp_cp[i].Text = "" + name_tp_buy[i];
                // 
                // tb_unit_tp_cp
                // 
                this.tb_unit_tp_cp[i].Location = new System.Drawing.Point(202, 3);
                this.tb_unit_tp_cp[i].Name = "tb_unit_tp_cp";
                this.tb_unit_tp_cp[i].Size = new System.Drawing.Size(93, 20);
                this.tb_unit_tp_cp[i].TabIndex = 2;
                this.tb_unit_tp_cp[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.tb_unit_tp_cp[i].Text = "g";
                // 
                // tb_luong_tp_cp
                // 
                this.tb_luong_tp_cp[i].Location = new System.Drawing.Point(301, 3);
                this.tb_luong_tp_cp[i].Name = "tb_luong_tp_cp";
                this.tb_luong_tp_cp[i].Size = new System.Drawing.Size(93, 20);
                this.tb_luong_tp_cp[i].TabIndex = 3;
                this.tb_luong_tp_cp[i].Text = luong_tp_buy[i] + "";
                this.tb_luong_tp_cp[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_price_tp_cp
                // 
                this.tb_price_tp_cp[i].Location = new System.Drawing.Point(400, 3);
                this.tb_price_tp_cp[i].Name = "tb_price_tp_cp";
                this.tb_price_tp_cp[i].Size = new System.Drawing.Size(93, 20);
                this.tb_price_tp_cp[i].TabIndex = 4;
                int id_tp_buffer = tronghoa_nt.findIDThucPham(name_tp_buy[i]);
                this.tb_price_tp_cp[i].Text = tronghoa_nt.findPriceThucPham(id_tp_buffer) + "";
                this.tb_price_tp_cp[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.tb_price_tp_cp[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press_tb_price_tp_cp);
                // 
                // tb_donvi_dongia_cp
                // 
                this.tb_donvi_dongia_cp[i].Location = new System.Drawing.Point(400, 3);
                this.tb_donvi_dongia_cp[i].Name = "tb_price_tp_cp";
                this.tb_donvi_dongia_cp[i].Size = new System.Drawing.Size(93, 20);
                this.tb_donvi_dongia_cp[i].TabIndex = 4;
                this.tb_donvi_dongia_cp[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.tb_donvi_dongia_cp[i].Text = "đ/" + tb_unit_tp_cp[i].Text;
                // 
                // tb_tonkho_cp
                // 
                this.tb_tonkho_cp[i].Location = new System.Drawing.Point(400, 3);
                this.tb_tonkho_cp[i].Name = "tb_price_tp_cp";
                this.tb_tonkho_cp[i].Size = new System.Drawing.Size(93, 20);
                this.tb_tonkho_cp[i].TabIndex = 4;
                this.tb_tonkho_cp[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.tb_tonkho_cp[i].Text = "--";
                // 
                // tb_comp_tp_cp
                // 
                this.tb_comp_tp_cp[i].Location = new System.Drawing.Point(499, 3);
                this.tb_comp_tp_cp[i].Name = "tb_comp_tp_cp";
                this.tb_comp_tp_cp[i].Size = new System.Drawing.Size(93, 20);
                this.tb_comp_tp_cp[i].TabIndex = 5;
                this.tb_comp_tp_cp[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                if (tb_price_tp_cp[i].Text == "") tb_price_tp_cp[i].Text = 0 + "";
                if (tb_luong_tp_cp[i].Text == "") tb_luong_tp_cp[i].Text = 0 + "";
                this.tb_comp_tp_cp[i].Text = (Int32.Parse(tb_price_tp_cp[i].Text) * luong_tp_buy[i]) + "";
                //MessageBox.Show(this.tb_comp_tp_cp[i].Text + "/" + this.tb_name_tp_cp[i].Text);
                this.tb_price_tp_cp[i].TextChanged += new EventHandler(tb_price_tp_cp_TextChanged);
                // 
                // tb_comment_tp_cp
                // 
                this.tb_comment_tp_cp[i].Location = new System.Drawing.Point(598, 3);
                this.tb_comment_tp_cp[i].Name = "tb_comment_tp_cp";
                this.tb_comment_tp_cp[i].Size = new System.Drawing.Size(189, 20);
                this.tb_comment_tp_cp[i].TabIndex = 6;
                this.tb_comment_tp_cp[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.tb_comment_tp_cp[i].Text = "mua hàng ngày";
            }
            for (int i = 0; i < count_tp_buy; i++)
            {
                this.flp_mua_thucpham.Controls.Add(this.tb_stt_cp[i]);
                this.flp_mua_thucpham.Controls.Add(this.tb_name_tp_cp[i]);
                this.flp_mua_thucpham.Controls.Add(this.tb_unit_tp_cp[i]);
                this.flp_mua_thucpham.Controls.Add(this.tb_luong_tp_cp[i]);
                this.flp_mua_thucpham.Controls.Add(this.tb_price_tp_cp[i]);
                this.flp_mua_thucpham.Controls.Add(this.tb_donvi_dongia_cp[i]);
                this.flp_mua_thucpham.Controls.Add(this.tb_tonkho_cp[i]);
                this.flp_mua_thucpham.Controls.Add(this.tb_comp_tp_cp[i]);
                this.flp_mua_thucpham.Controls.Add(this.tb_comment_tp_cp[i]);
            }

            // 
            // lb_kho
            // 
            this.lb_kho.AutoSize = true;
            this.lb_kho.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kho.Location = new System.Drawing.Point(4, 5);
            this.lb_kho.Name = "lb_kho";
            this.lb_kho.Size = new System.Drawing.Size(202, 16);
            this.lb_kho.TabIndex = 14;
            this.lb_kho.Text = "* Thực phẩm có sẵn trong kho:";
            this.lb_kho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            this.pn_kho.SuspendLayout();
            this.pn_kho.Name = "pn_kho";
            this.pn_kho.Size = new System.Drawing.Size(1009, 26);
            this.pn_kho.TabIndex = 16;
            this.pn_kho.ResumeLayout(false);
            this.pn_kho.PerformLayout();

            count_tp_kho = 0;
            for (int i = 0; i < tronghoa_mg.count_TP_use; i++)
            {
                if (this.tb_type_mg[i].Text == "có sẵn")
                {
                    //MessageBox.Show(tb_type_mg[i].Text + "->" + i);
                    if (this.tb_luongsd_mg[i].Text == "") this.tb_luongsd_mg[i].Text = 0 + "";
                    luong_tp_kho[count_tp_kho] = Int32.Parse(this.tb_luongsd_mg[i].Text);
                    name_tp_kho[count_tp_kho] = tronghoa_mg.name_TP_use[i];
                    dongia_kho[count_tp_kho] = tronghoa_mg.dongia_TP_kho_new[i];
                    luong_tonkho[count_tp_kho] = tronghoa_mg.luong_TP_kho_new[i];
                    count_tp_kho++;
                }
            }
            for (int i = 0; i < tronghoa_nt.count_TP_use; i++)
            {
                int check = 0;

                for (int j = 0; j < count_tp_kho; j++)
                {
                    if (tronghoa_nt.name_TP_use[i] == name_tp_kho[j])
                    {
                        check = 1;
                        if (this.tb_luongsd_nt[i].Text == "") this.tb_luongsd_nt[i].Text = 0 + "";
                        luong_tp_kho[j] = luong_tp_kho[j] + Int32.Parse(this.tb_luongsd_nt[i].Text);
                    }
                }

                if (check == 0 && this.tb_type_nt[i].Text == "có sẵn")
                {
                    if (this.tb_luongsd_nt[i].Text == "") this.tb_luongsd_nt[i].Text = 0 + "";
                    //MessageBox.Show(this.tb_luongsd_nt[i].Text);
                    luong_tp_kho[count_tp_kho] = Int32.Parse(this.tb_luongsd_nt[i].Text);
                    name_tp_kho[count_tp_kho] = tronghoa_nt.name_TP_use[i];
                    dongia_kho[count_tp_kho] = tronghoa_nt.dongia_TP_kho_new[i];
                    luong_tonkho[count_tp_kho] = tronghoa_nt.luong_TP_kho_new[i];
                    count_tp_kho++;
                }
            }
            //countThucPhamNeed = 0;
            for (int i = 0;i < count_tp_kho;i++)
            {
                IDTPNeed[i] = tronghoa_nt.findIDThucPham(name_tp_kho[i]);
                LuongTPNeed[i] = luong_tp_kho[i];
                //MessageBox.Show("" + IDTPNeed[i] + "/" + LuongTPNeed[i]);
            }
            MD_qlk = new modun_quanli_kho(IDTPNeed, LuongTPNeed, count_tp_kho);


            for (int i = count_tp_buy; i < (count_tp_buy + MD_qlk.count_export); i++)
            {
                // 
                // tb_stt_cp
                // 
                this.tb_stt_cp[i].Location = new System.Drawing.Point(3, 3);
                this.tb_stt_cp[i].Name = "tb_stt_cp";
                this.tb_stt_cp[i].Size = new System.Drawing.Size(31, 20);
                this.tb_stt_cp[i].TabIndex = 0;
                this.tb_stt_cp[i].Text = (i + 1) + "";
                this.tb_stt_cp[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_name_tp_cp
                // 
                this.tb_name_tp_cp[i].Location = new System.Drawing.Point(40, 3);
                this.tb_name_tp_cp[i].Name = "tb_name_tp_cp";
                this.tb_name_tp_cp[i].Size = new System.Drawing.Size(156, 20);
                this.tb_name_tp_cp[i].TabIndex = 1;
                //MessageBox.Show("" + (i - MD_qlk.count_export));
                this.tb_name_tp_cp[i].Text = "" + tronghoa_nt.findNameThucPham(MD_qlk.IDTPexport[i - count_tp_buy]);
                // 
                // tb_unit_tp_cp
                // 
                this.tb_unit_tp_cp[i].Location = new System.Drawing.Point(202, 3);
                this.tb_unit_tp_cp[i].Name = "tb_unit_tp_cp";
                this.tb_unit_tp_cp[i].Size = new System.Drawing.Size(93, 20);
                this.tb_unit_tp_cp[i].TabIndex = 2;
                this.tb_unit_tp_cp[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.tb_unit_tp_cp[i].Text = "g";
                // 
                // tb_luong_tp_cp
                // 
                this.tb_luong_tp_cp[i].Location = new System.Drawing.Point(301, 3);
                this.tb_luong_tp_cp[i].Name = "tb_luong_tp_cp";
                this.tb_luong_tp_cp[i].Size = new System.Drawing.Size(93, 20);
                this.tb_luong_tp_cp[i].TabIndex = 3;
                this.tb_luong_tp_cp[i].Text = MD_qlk.LuongTPExport[i - count_tp_buy] + "";
                this.tb_luong_tp_cp[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_price_tp_cp
                // 
                this.tb_price_tp_cp[i].Location = new System.Drawing.Point(400, 3);
                this.tb_price_tp_cp[i].Name = "tb_price_tp_cp";
                this.tb_price_tp_cp[i].Size = new System.Drawing.Size(93, 20);
                this.tb_price_tp_cp[i].TabIndex = 4;
                this.tb_price_tp_cp[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.tb_price_tp_cp[i].Text = "" + MD_qlk.PriceTPExport[i - count_tp_buy];
                // 
                // tb_price_tp_cp
                // 
                this.tb_donvi_dongia_cp[i].Location = new System.Drawing.Point(400, 3);
                this.tb_donvi_dongia_cp[i].Name = "tb_price_tp_cp";
                this.tb_donvi_dongia_cp[i].Size = new System.Drawing.Size(93, 20);
                this.tb_donvi_dongia_cp[i].TabIndex = 4;
                this.tb_donvi_dongia_cp[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.tb_donvi_dongia_cp[i].Text = "đ/" + this.tb_unit_tp_cp[i].Text;
                // 
                // tb_price_tp_cp
                // 
                this.tb_tonkho_cp[i].Location = new System.Drawing.Point(400, 3);
                this.tb_tonkho_cp[i].Name = "tb_price_tp_cp";
                this.tb_tonkho_cp[i].Size = new System.Drawing.Size(93, 20);
                this.tb_tonkho_cp[i].TabIndex = 4;
                this.tb_tonkho_cp[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                if (tb_luong_tp_cp[i].Text == "") tb_luong_tp_cp[i].Text = 0 + "";
                // MessageBox.Show(luong_tonkho[i] + "/" + tb_luong_tp_cp[i].Text);
                this.tb_tonkho_cp[i].Text = MD_qlk.LuongTon[i - count_tp_buy] + "";
                
                // 
                // tb_comp_tp_cp
                // 
                this.tb_comp_tp_cp[i].Location = new System.Drawing.Point(499, 3);
                this.tb_comp_tp_cp[i].Name = "tb_comp_tp_cp";
                this.tb_comp_tp_cp[i].Size = new System.Drawing.Size(93, 20);
                this.tb_comp_tp_cp[i].TabIndex = 5;
                this.tb_comp_tp_cp[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                this.tb_comp_tp_cp[i].Text = (Int32.Parse(tb_price_tp_cp[i].Text) * Int32.Parse(tb_luong_tp_cp[i].Text)) + "";
                this.tb_price_tp_cp[i].TextChanged += new EventHandler(tb_price_tp_cp_TextChanged);
                
                // 
                // tb_comment_tp_cp
                // 
                
                this.tb_comment_tp_cp[i].Location = new System.Drawing.Point(598, 3);
                this.tb_comment_tp_cp[i].Name = "tb_comment_tp_cp";
                this.tb_comment_tp_cp[i].Size = new System.Drawing.Size(189, 20);
                this.tb_comment_tp_cp[i].TabIndex = 6;
                this.tb_comment_tp_cp[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.tb_comment_tp_cp[i].Text = "trong kho nhập ngày " + MD_qlk.NgayCapNhat[i];

            }

            for (int i = count_tp_buy; i < (count_tp_buy + MD_qlk.count_export); i++)
            {
                this.flp_mua_thucpham.Controls.Add(this.tb_stt_cp[i]);
                this.flp_mua_thucpham.Controls.Add(this.tb_name_tp_cp[i]);
                this.flp_mua_thucpham.Controls.Add(this.tb_unit_tp_cp[i]);
                this.flp_mua_thucpham.Controls.Add(this.tb_luong_tp_cp[i]);
                this.flp_mua_thucpham.Controls.Add(this.tb_price_tp_cp[i]);
                this.flp_mua_thucpham.Controls.Add(this.tb_donvi_dongia_cp[i]);
                this.flp_mua_thucpham.Controls.Add(this.tb_tonkho_cp[i]);
                this.flp_mua_thucpham.Controls.Add(this.tb_comp_tp_cp[i]);
                this.flp_mua_thucpham.Controls.Add(this.tb_comment_tp_cp[i]);
            }

        }

        private void create_dynamic_code()
        {
            this.bt_buaan[0] = new System.Windows.Forms.Button();

            for (int i = 0; i < 100; i++)
            {
                this.tb_stt_nt[i] = new System.Windows.Forms.TextBox();
                this.tb_name_thucpham_nt[i] = new System.Windows.Forms.TextBox();
                this.tb_type_nt[i] = new System.Windows.Forms.TextBox();
                this.tb_donvi_tp_nt[i] = new System.Windows.Forms.TextBox();
                this.tb_luongsd_nt[i] = new System.Windows.Forms.TextBox();
                this.tb_trongkho_nt[i] = new System.Windows.Forms.TextBox();
            }

            for (int i = 0; i < 100; i++)
            {
                this.tb_stt_mg[i] = new System.Windows.Forms.TextBox();
                this.tb_name_thucpham_mg[i] = new System.Windows.Forms.TextBox();
                this.tb_type_mg[i] = new System.Windows.Forms.TextBox();
                this.tb_donvi_tp_mg[i] = new System.Windows.Forms.TextBox();
                this.tb_luongsd_mg[i] = new System.Windows.Forms.TextBox();
                this.tb_trongkho_mg[i] = new System.Windows.Forms.TextBox();
            }

            for (int i = 0; i < tronghoa_nt.count_TP_use; i++)
            {
                this.flp_thucpham_nhatre.Controls.Add(this.tb_stt_nt[i]);
                this.flp_thucpham_nhatre.Controls.Add(this.tb_name_thucpham_nt[i]);
                this.flp_thucpham_nhatre.Controls.Add(this.tb_type_nt[i]);
                this.flp_thucpham_nhatre.Controls.Add(this.tb_donvi_tp_nt[i]);
                this.flp_thucpham_nhatre.Controls.Add(this.tb_luongsd_nt[i]);
                this.flp_thucpham_nhatre.Controls.Add(this.tb_trongkho_nt[i]);
            }

            for (int i = 0; i < tronghoa_nt.count_TP_use; i++)
            {
                // 
                // tb_stt_nt
                // 
                this.tb_stt_nt[i].Enabled = false;
                this.tb_stt_nt[i].Location = new System.Drawing.Point(3, 3 + 29 * i);
                this.tb_stt_nt[i].Name = "tb_stt_nt";
                this.tb_stt_nt[i].Size = new System.Drawing.Size(36, 20);
                this.tb_stt_nt[i].Text = "" + (i + 1);
                this.tb_stt_nt[i].TabIndex = 5;
                this.tb_stt_nt[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_name_thucpham_nt
                // 
                this.tb_name_thucpham_nt[i].Location = new System.Drawing.Point(45, 3 + 29 * i);
                this.tb_name_thucpham_nt[i].Name = "tb_name_thucpham_nt";
                this.tb_name_thucpham_nt[i].Size = new System.Drawing.Size(145, 20);
                this.tb_name_thucpham_nt[i].TabIndex = 6;
                this.tb_name_thucpham_nt[i].Text = tronghoa_nt.name_TP_use[i];
                // 
                // tb_type_nt
                // 
                this.tb_type_nt[i].Location = new System.Drawing.Point(196, 3 + 29 * i);
                this.tb_type_nt[i].Name = "tb_type_nt";
                this.tb_type_nt[i].Size = new System.Drawing.Size(66, 20);
                this.tb_type_nt[i].TabIndex = 7;
                this.tb_type_nt[i].Text = tronghoa_nt.type_TP_use[i];
                this.tb_type_nt[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_donvi_tp_nt
                // 
                this.tb_donvi_tp_nt[i].Location = new System.Drawing.Point(268, 3 + 29 * i);
                this.tb_donvi_tp_nt[i].Name = "tb_donvi_tp_nt";
                this.tb_donvi_tp_nt[i].Size = new System.Drawing.Size(66, 20);
                this.tb_donvi_tp_nt[i].TabIndex = 11;
                this.tb_donvi_tp_nt[i].Text = tronghoa_nt.unit_TP[i];
                this.tb_donvi_tp_nt[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_luongsd_nt
                // 
                this.tb_luongsd_nt[i].Location = new System.Drawing.Point(340, 3 + 29 * i);
                this.tb_luongsd_nt[i].Name = "tb_luongsd_nt";
                this.tb_luongsd_nt[i].Size = new System.Drawing.Size(66, 20);
                this.tb_luongsd_nt[i].TabIndex = 12;
                this.tb_luongsd_nt[i].Text = tronghoa_nt.luong_TD_TP_use[i] + "";
                this.tb_luongsd_nt[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_trongkho_nt
                // 
                this.tb_trongkho_nt[i].Location = new System.Drawing.Point(412, 3 + 29 * i);
                this.tb_trongkho_nt[i].Name = "tb_trongkho_nt";
                this.tb_trongkho_nt[i].Size = new System.Drawing.Size(60, 20);
                this.tb_trongkho_nt[i].TabIndex = 8;
                this.tb_trongkho_nt[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                if (this.tb_type_nt[i].Text == "có sẵn")
                {
                    this.tb_trongkho_nt[i].Text = tronghoa_nt.luong_TP_kho_new[i] + "";
                }
                else
                {
                    this.tb_trongkho_nt[i].Text = "--";
                }
            }

            for (int i = 0; i < tronghoa_mg.count_TP_use; i++)
            {
                this.flp_thucpham_maugiao.Controls.Add(this.tb_stt_mg[i]);
                this.flp_thucpham_maugiao.Controls.Add(this.tb_name_thucpham_mg[i]);
                this.flp_thucpham_maugiao.Controls.Add(this.tb_type_mg[i]);
                this.flp_thucpham_maugiao.Controls.Add(this.tb_donvi_tp_mg[i]);
                this.flp_thucpham_maugiao.Controls.Add(this.tb_luongsd_mg[i]);
                this.flp_thucpham_maugiao.Controls.Add(this.tb_trongkho_mg[i]);
            }

            for (int i = 0; i < tronghoa_mg.count_TP_use; i++)
            {
                // 
                // tb_stt_mg
                // 
                this.tb_stt_mg[i].Enabled = false;
                this.tb_stt_mg[i].Location = new System.Drawing.Point(3, 3 + 29 * i);
                this.tb_stt_mg[i].Name = "tb_stt_mg";
                this.tb_stt_mg[i].Size = new System.Drawing.Size(36, 20);
                this.tb_stt_mg[i].TabIndex = 5;
                this.tb_stt_mg[i].Text = "" + (i + 1);
                this.tb_stt_mg[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_name_thucpham_mg
                // 
                this.tb_name_thucpham_mg[i].Location = new System.Drawing.Point(45, 3 + 29 * i);
                this.tb_name_thucpham_mg[i].Name = "tb_name_thucpham_mg";
                this.tb_name_thucpham_mg[i].Size = new System.Drawing.Size(145, 20);
                this.tb_name_thucpham_mg[i].TabIndex = 6;
                this.tb_name_thucpham_mg[i].Text = tronghoa_mg.name_TP_use[i];
                // 
                // tb_type_mg
                // 
                this.tb_type_mg[i].Location = new System.Drawing.Point(196, 3 + 29 * i);
                this.tb_type_mg[i].Name = "tb_type_mg";
                this.tb_type_mg[i].Size = new System.Drawing.Size(66, 20);
                this.tb_type_mg[i].TabIndex = 7;
                this.tb_type_mg[i].Text = tronghoa_mg.type_TP_use[i];
                //MessageBox.Show(tronghoa_mg.name_TP_use[i] + "->" + tronghoa_mg.type_TP[i]);
                this.tb_type_mg[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_donvi_tp_mg
                // 
                this.tb_donvi_tp_mg[i].Location = new System.Drawing.Point(268, 3 + 29 * i);
                this.tb_donvi_tp_mg[i].Name = "tb_donvi_tp_mg";
                this.tb_donvi_tp_mg[i].Size = new System.Drawing.Size(66, 20);
                this.tb_donvi_tp_mg[i].TabIndex = 11;
                this.tb_donvi_tp_mg[i].Text = tronghoa_mg.unit_TP[i];
                this.tb_donvi_tp_mg[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_luongsd_mg
                // 
                this.tb_luongsd_mg[i].Location = new System.Drawing.Point(340, 3 + 29 * i);
                this.tb_luongsd_mg[i].Name = "tb_luongsd_mg";
                this.tb_luongsd_mg[i].Size = new System.Drawing.Size(66, 20);
                this.tb_luongsd_mg[i].TabIndex = 12;
                this.tb_luongsd_mg[i].Text = tronghoa_mg.luong_TD_TP_use[i] + "";
                this.tb_luongsd_mg[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_trongkho_mg
                // 
                this.tb_trongkho_mg[i].Location = new System.Drawing.Point(412, 3 + 29 * i);
                this.tb_trongkho_mg[i].Name = "tb_trongkho_mg";
                this.tb_trongkho_mg[i].Size = new System.Drawing.Size(60, 20);
                this.tb_trongkho_mg[i].TabIndex = 8;
                this.tb_trongkho_mg[i].Text = tronghoa_mg.luong_TP_kho_new[i] + "";
                this.tb_trongkho_mg[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                if (this.tb_type_mg[i].Text == "có sẵn")
                {
                    this.tb_trongkho_mg[i].Text = tronghoa_mg.luong_TP_kho_new[i] + "";
                }
                else
                {
                    this.tb_trongkho_mg[i].Text = "--";
                }
            }

            for (int i = 0; i < 5; i++)
            {
                this.bt_buaan[i + 1] = new System.Windows.Forms.Button();
                for (int j = 0; j < 12; j++)
                {
                    this.tb_luong_vichat[i, j] = new System.Windows.Forms.TextBox();
                }
            }
            for (int i = 0; i < 12; i++)
            {
                this.bt_name_vichat[i] = new System.Windows.Forms.Button();
            }

            for (int i = 0; i < 12; i++)
            {
                this.cb_monan[i] = new System.Windows.Forms.ComboBox();
            }

            // 
            // bt_buaan
            // 
            this.bt_buaan[0].AllowDrop = true;
            this.bt_buaan[0].Location = new System.Drawing.Point(3, 32 + 29 * 0);
            this.bt_buaan[0].Name = "bt_buaan";
            this.bt_buaan[0].Size = new System.Drawing.Size(92, 23);
            this.bt_buaan[0].TabIndex = 4;
            this.bt_buaan[0].Text = "BỮA ĂN";
            this.bt_buaan[0].UseVisualStyleBackColor = true;
            this.flp_vichat.Controls.Add(this.bt_buaan[0]);
            for (int i = 0; i < 12; i++)
            {
                this.flp_vichat.Controls.Add(this.bt_name_vichat[i]);
            }

            for (int i = 0; i < 5; i++)
            {
                this.flp_vichat.Controls.Add(this.bt_buaan[i + 1]);
                for (int j = 0; j < 12; j++)
                {
                    this.flp_vichat.Controls.Add(this.tb_luong_vichat[i, j]);
                }
            }
            string[] name_ba = { "Sáng chính", "Sáng phụ", "Trưa chính", "Chiều phụ", "Tổng" };
            for (int i = 0; i < 5; i++)
            {
                // 
                // bt_buaan
                // 
                this.bt_buaan[i + 1].AllowDrop = true;
                this.bt_buaan[i + 1].Location = new System.Drawing.Point(3, 32 + 29 * (i + 1));
                this.bt_buaan[i + 1].Name = "bt_buaan";
                this.bt_buaan[i + 1].Size = new System.Drawing.Size(92, 23);
                this.bt_buaan[i + 1].TabIndex = 4;
                this.bt_buaan[i + 1].Text = name_ba[i];
                this.bt_buaan[i + 1].UseVisualStyleBackColor = true;
                for (int j = 0; j < 12; j++)
                {
                    // 
                    // tb_luong_vichat
                    // 
                    this.tb_luong_vichat[i, j].Location = new System.Drawing.Point(101 + 68 * j, 61 + 29 * i);
                    this.tb_luong_vichat[i, j].Name = "tb_luong_vichat";
                    this.tb_luong_vichat[i, j].Size = new System.Drawing.Size(62, 20);
                    this.tb_luong_vichat[i, j].TabIndex = 35;
                    this.tb_luong_vichat[i, j].TextAlign = HorizontalAlignment.Center;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    this.tb_luong_vichat[i, j].Text = "" + tronghoa_nt.luong_BA_VC_use[i, j];
                    this.bt_name_vichat[j].Text = tronghoa_nt.name_VC[j];
                }
                for (int j = 6; j < 12; j++)
                {
                    this.tb_luong_vichat[i, j].Text = "" + tronghoa_mg.luong_BA_VC_use[i, j - 6];
                    this.bt_name_vichat[j].Text = tronghoa_mg.name_VC[j - 6];
                }
            }
            for (int i = 0; i < 6; i++)
            {
                //this.tb_luong_vichat[2, i].Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.tb_luong_vichat[4, i].Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.tb_luong_vichat[4, i].Text = "" + (tronghoa_nt.luong_BA_VC_use[0, i] + tronghoa_nt.luong_BA_VC_use[1, i] + tronghoa_nt.luong_BA_VC_use[2, i] + tronghoa_nt.luong_BA_VC_use[3, i]);
            }
            for (int i = 6; i < 12; i++)
            {
                //this.tb_luong_vichat[2, i].Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.tb_luong_vichat[4, i].Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.tb_luong_vichat[4, i].Text = "" + (tronghoa_mg.luong_BA_VC_use[0, i - 6] + tronghoa_mg.luong_BA_VC_use[1, i - 6] + tronghoa_mg.luong_BA_VC_use[2, i - 6] + tronghoa_mg.luong_BA_VC_use[3, i - 6]);
            }


            for (int i = 0; i < 4; i++)
            {
                this.tb_luong_vichat[i, 5].Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.tb_luong_vichat[i, 11].Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }



            evalue_nuti_rulebase();
            for (int i = 0; i < 12; i++)
            {
                // 
                // bt_name_vichat
                // 
                this.bt_name_vichat[i].AllowDrop = true;
                this.bt_name_vichat[i].Location = new System.Drawing.Point(101 + 68 * i, 32);
                this.bt_name_vichat[i].Name = "bt_name_vichat";
                this.bt_name_vichat[i].Size = new System.Drawing.Size(62, 23);
                this.bt_name_vichat[i].TabIndex = 0;
                //this.bt_name_vichat[i].Text = "BỮA ĂN";
                this.bt_name_vichat[i].UseVisualStyleBackColor = true;
            }

            for (int i = 0; i < 12; i++)
            {
                // 
                // cb_monan
                // 
                this.cb_monan[i].FormattingEnabled = true;
                this.cb_monan[i].Location = new System.Drawing.Point(512, 119);
                this.cb_monan[i].Name = "comboBox12";
                this.cb_monan[i].Size = new System.Drawing.Size(395, 21);
                this.cb_monan[i].TabIndex = 23;
                this.cb_monan[i].Text = i + "";
                //.cb_monan[i].SelectedIndexChanged += new System.EventHandler(cb_Select);
            }
            this.cb_monan[0].Location = new System.Drawing.Point(111, 32);
            this.cb_monan[0].Size = new System.Drawing.Size(395, 21);
            this.cb_monan[0].SelectedIndexChanged += new System.EventHandler(cb_Select_nt);
            this.cb_monan[0].Text = "" + tronghoa_nt.name_MA_use[0];
            for (int i = 0; i < tronghoa_nt.count_MA_BA[0]; i++)
            {
                this.cb_monan[0].Items.Add(tronghoa_nt.name_MA_BA[0, i]);
            }
            //MessageBox.Show("" + tronghoa_nt.name_MA_use[0]);

            this.cb_monan[1].Location = new System.Drawing.Point(512, 32);
            this.cb_monan[1].Size = new System.Drawing.Size(395, 21);
            this.cb_monan[1].SelectedIndexChanged += new System.EventHandler(cb_Select_mg);
            this.cb_monan[1].Text = "" + tronghoa_mg.name_MA_use[0];
            for (int i = 0; i < tronghoa_mg.count_MA_BA[0]; i++)
            {
                this.cb_monan[1].Items.Add(tronghoa_mg.name_MA_BA[0, i]);
            }

            this.cb_monan[2].Location = new System.Drawing.Point(111, 61);
            this.cb_monan[2].Size = new System.Drawing.Size(395, 21);
            this.cb_monan[2].SelectedIndexChanged += new System.EventHandler(cb_Select_nt);
            this.cb_monan[2].Text = "" + tronghoa_nt.name_MA_use[1];
            for (int i = 0; i < tronghoa_nt.count_MA_BA[1]; i++)
            {
                this.cb_monan[2].Items.Add(tronghoa_nt.name_MA_BA[1, i]);
            }

            this.cb_monan[3].Location = new System.Drawing.Point(512, 61);
            this.cb_monan[3].Size = new System.Drawing.Size(395, 21);
            this.cb_monan[3].SelectedIndexChanged += new System.EventHandler(cb_Select_mg);
            this.cb_monan[3].Text = "" + tronghoa_mg.name_MA_use[1];
            for (int i = 0; i < tronghoa_mg.count_MA_BA[1]; i++)
            {
                this.cb_monan[3].Items.Add(tronghoa_mg.name_MA_BA[1, i]);
            }

            this.cb_monan[4].Location = new System.Drawing.Point(111, 90);
            this.cb_monan[4].Size = new System.Drawing.Size(127, 21);
            this.cb_monan[4].SelectedIndexChanged += new System.EventHandler(cb_Select_nt);
            this.cb_monan[4].Text = "" + tronghoa_nt.name_MA_use[2];
            for (int i = 0; i < tronghoa_nt.count_MA_BA[2]; i++)
            {
                this.cb_monan[4].Items.Add(tronghoa_nt.name_MA_BA[2, i]);
            }

            this.cb_monan[5].Location = new System.Drawing.Point(244, 90);
            this.cb_monan[5].Size = new System.Drawing.Size(127, 21);
            this.cb_monan[5].SelectedIndexChanged += new System.EventHandler(cb_Select_nt);
            this.cb_monan[5].Text = "" + tronghoa_nt.name_MA_use[3];
            for (int i = 0; i < tronghoa_nt.count_MA_BA[3]; i++)
            {
                this.cb_monan[5].Items.Add(tronghoa_nt.name_MA_BA[3, i]);
            }

            this.cb_monan[6].Location = new System.Drawing.Point(376, 90);
            this.cb_monan[6].Size = new System.Drawing.Size(129, 21);
            this.cb_monan[6].SelectedIndexChanged += new System.EventHandler(cb_Select_nt);
            this.cb_monan[6].Text = "" + tronghoa_nt.name_MA_use[4];
            for (int i = 0; i < tronghoa_nt.count_MA_BA[4]; i++)
            {
                this.cb_monan[6].Items.Add(tronghoa_nt.name_MA_BA[4, i]);
            }

            this.cb_monan[7].Location = new System.Drawing.Point(512, 90);
            this.cb_monan[7].Size = new System.Drawing.Size(127, 21);
            this.cb_monan[7].SelectedIndexChanged += new System.EventHandler(cb_Select_mg);
            this.cb_monan[7].Text = "" + tronghoa_mg.name_MA_use[2];
            for (int i = 0; i < tronghoa_mg.count_MA_BA[2]; i++)
            {
                this.cb_monan[7].Items.Add(tronghoa_mg.name_MA_BA[2, i]);
            }

            this.cb_monan[8].Location = new System.Drawing.Point(644, 90);
            this.cb_monan[8].Size = new System.Drawing.Size(127, 21);
            this.cb_monan[8].SelectedIndexChanged += new System.EventHandler(cb_Select_mg);
            this.cb_monan[8].Text = "" + tronghoa_mg.name_MA_use[3];
            for (int i = 0; i < tronghoa_mg.count_MA_BA[3]; i++)
            {
                this.cb_monan[8].Items.Add(tronghoa_mg.name_MA_BA[3, i]);
            }

            this.cb_monan[9].Location = new System.Drawing.Point(776, 90);
            this.cb_monan[9].Size = new System.Drawing.Size(129, 21);
            this.cb_monan[9].SelectedIndexChanged += new System.EventHandler(cb_Select_mg);
            this.cb_monan[9].Text = "" + tronghoa_mg.name_MA_use[4];
            for (int i = 0; i < tronghoa_mg.count_MA_BA[4]; i++)
            {
                this.cb_monan[9].Items.Add(tronghoa_mg.name_MA_BA[4, i]);
            }

            this.cb_monan[10].Location = new System.Drawing.Point(111, 119);
            this.cb_monan[10].Size = new System.Drawing.Size(395, 21);
            this.cb_monan[10].SelectedIndexChanged += new System.EventHandler(cb_Select_nt);
            this.cb_monan[10].Text = "" + tronghoa_nt.name_MA_use[5];
            for (int i = 0; i < tronghoa_nt.count_MA_BA[5]; i++)
            {
                this.cb_monan[10].Items.Add(tronghoa_nt.name_MA_BA[5, i]);
            }

            this.cb_monan[11].Location = new System.Drawing.Point(512, 119);
            this.cb_monan[11].Size = new System.Drawing.Size(395, 21);
            this.cb_monan[11].SelectedIndexChanged += new System.EventHandler(cb_Select_mg);
            this.cb_monan[11].Text = "" + tronghoa_mg.name_MA_use[5];
            for (int i = 0; i < tronghoa_mg.count_MA_BA[5]; i++)
            {
                this.cb_monan[11].Items.Add(tronghoa_mg.name_MA_BA[5, i]);
            }

            this.flp_thucdon.Controls.Add(this.bt_median_thucdon);
            this.flp_thucdon.Controls.Add(this.bt_link_thucdon);
            this.flp_thucdon.Controls.Add(this.button2);
            this.flp_thucdon.Controls.Add(this.bt_buasang_chinh);
            this.flp_thucdon.Controls.Add(this.cb_monan[0]);
            this.flp_thucdon.Controls.Add(this.cb_monan[1]);
            this.flp_thucdon.Controls.Add(this.bt_buasang_phu);
            this.flp_thucdon.Controls.Add(this.cb_monan[2]);
            this.flp_thucdon.Controls.Add(this.cb_monan[3]);
            this.flp_thucdon.Controls.Add(this.button3);
            this.flp_thucdon.Controls.Add(this.cb_monan[4]);
            this.flp_thucdon.Controls.Add(this.cb_monan[5]);
            this.flp_thucdon.Controls.Add(this.cb_monan[6]);
            this.flp_thucdon.Controls.Add(this.cb_monan[7]);
            this.flp_thucdon.Controls.Add(this.cb_monan[8]);
            this.flp_thucdon.Controls.Add(this.cb_monan[9]);
            this.flp_thucdon.Controls.Add(this.button4);
            this.flp_thucdon.Controls.Add(this.cb_monan[10]);
            this.flp_thucdon.Controls.Add(this.cb_monan[11]);
        }

        private void bt_comp_Click(object sender, EventArgs e)
        {
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            string file_name = "" + day + "-" + month + "-" + year;
            FileInfo f1 = new FileInfo("C:\\DailyReport\\Report\\phieu_tong_mua_hang_trong_ngay(" + file_name + ").xls");
            if (f1.Exists)
            {
                f1.CopyTo("C:\\DailyReport\\Report\\phieu_tong_mua_hang_trong_ngay(" + file_name + ")_nhaptruoc.xls", true);
                // 
                modun_quanli_thucdon_dinhduong md1 = new modun_quanli_thucdon_dinhduong();
                md1.query_thucpham();

                string filename = DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;
                //--cho xuất kho thêm
                // Khởi động chtr Excell
                COMExcel.Application exAppxt = new COMExcel.Application();

                string workbookPathxt = "C:/DailyReport/TemplateDailyReport/tpl_bcxuatthemhangngay.xls";

                COMExcel.Workbook exBookxt = exAppxt.Workbooks.Open(workbookPathxt,
                        0, false, 5, "", "", false, COMExcel.XlPlatform.xlWindows, "",
                        true, false, 0, true, false, false);

                // Lấy sheet 1.
                COMExcel.Worksheet exSheetxt = (COMExcel.Worksheet)exBookxt.Worksheets[1];

                // Range là ô [1,1] (A1)

                //COMExcel.Range r;
                exSheetxt.Name = "Phiếu xuất kho thêm trong ngày";


                for (int i = 1; i < md2.count_thieu + 1; i++)
                {
                    COMExcel.Range r_stt_kho = (COMExcel.Range)exSheetxt.Cells[i + 6, 1];

                    // Ghi dữ liệu
                    r_stt_kho.Value2 = "" + i;
                    //r_stt_buy.ColumnWidth = 299;

                    // Giãn cột
                    //r_stt_kho.Columns.AutoFit();
                    COMExcel.Range r_name_kho = (COMExcel.Range)exSheetxt.Cells[i + 6, 2];

                    // Ghi dữ liệu
                    r_name_kho.Value2 = md1.findNameThucPham(md2.id_thieu[i - 1]);

                    // Giãn cột
                    r_name_kho.Columns.AutoFit();

                    COMExcel.Range r_name_type = (COMExcel.Range)exSheetxt.Cells[i + 6, 4];

                    // Ghi dữ liệu
                    r_name_type.Value2 = "Thực phẩm kho";

                    // Giãn cột
                    r_name_kho.Columns.AutoFit();

                    COMExcel.Range r_donvi_kho = (COMExcel.Range)exSheetxt.Cells[i + 6, 6];

                    // Ghi dữ liệu
                    r_donvi_kho.Value2 = "kg";

                    COMExcel.Range r_soluong_kho = (COMExcel.Range)exSheetxt.Cells[i + 6, 8];

                    // Ghi dữ liệu
                    r_soluong_kho.Value2 = md2.tp_thieu[i - 1];

                    // Giãn cột
                    //r_soluong_buy.Columns.AutoFit();

                    COMExcel.Range r_gia_kho = (COMExcel.Range)exSheetxt.Cells[i + 6, 7];

                    // Ghi dữ liệu
                    r_gia_kho.Value2 = md1.findPriceThucPham(md2.id_thieu[i - 1]);

                    // Giãn cột
                    //r_gia_buy.Columns.AutoFit();




                    // Giãn cột
                    //r_donvi_buy.Columns.AutoFit();


                    COMExcel.Range r_thanhtien_kho = (COMExcel.Range)exSheetxt.Cells[i + 6, 9];

                    // Ghi dữ liệu
                    r_thanhtien_kho.Value2 = md1.findPriceThucPham(md2.id_thieu[i - 1]) * md2.tp_thieu[i - 1];

                    // Giãn cột
                    //r_donvi_buy.Columns.AutoFit();

                    COMExcel.Range r_tonkho = (COMExcel.Range)exSheetxt.Cells[i + 6, 10];
                    r_tonkho.Value2 = "";

                }

                // --hết xuất kho
                // Hiển thị chương trình excel

                exAppxt.Visible = false;

                // Đóng chương trình excel

                //r = (COMExcel.Range)exSheet.get_Range("A1", "A4");


                // Save file

                exBookxt.SaveAs("C:\\DailyReport\\Report\\phieu_tong_xuat_hang_them_trong_ngay(" + filename + ").xls", COMExcel.XlFileFormat.xlWorkbookNormal, null, null, false, false, COMExcel.XlSaveAsAccessMode.xlExclusive, true, true, true, true, true);




                exBookxt.Close(false, false, false);

                exAppxt.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(exBookxt);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(exAppxt);

                //--cho xuất trả lại kho
                // Khởi động chtr Excell
                COMExcel.Application exApptk = new COMExcel.Application();

                string workbookPathtk = "C:/DailyReport/TemplateDailyReport/tpl_bctrakhohangngay.xls";

                COMExcel.Workbook exBooktk = exApptk.Workbooks.Open(workbookPathtk,
                        0, false, 5, "", "", false, COMExcel.XlPlatform.xlWindows, "",
                        true, false, 0, true, false, false);

                // Lấy sheet 1.
                COMExcel.Worksheet exSheettk = (COMExcel.Worksheet)exBooktk.Worksheets[1];

                // Range là ô [1,1] (A1)

                //COMExcel.Range r;
                exSheettk.Name = "Phiếu trả lại kho trong ngày";


                for (int i = 1; i < md2.count_thua + 1; i++)
                {
                    COMExcel.Range r_stt_kho = (COMExcel.Range)exSheettk.Cells[i + 6, 1];

                    // Ghi dữ liệu
                    r_stt_kho.Value2 = "" + i;
                    //r_stt_buy.ColumnWidth = 299;

                    // Giãn cột
                    //r_stt_kho.Columns.AutoFit();
                    COMExcel.Range r_name_kho = (COMExcel.Range)exSheettk.Cells[i + 6, 2];

                    // Ghi dữ liệu
                    r_name_kho.Value2 = md1.findNameThucPham(md2.id_thua[i - 1]);

                    // Giãn cột
                    r_name_kho.Columns.AutoFit();

                    COMExcel.Range r_name_type = (COMExcel.Range)exSheettk.Cells[i + 6, 4];

                    // Ghi dữ liệu
                    r_name_type.Value2 = "Thực phẩm kho";

                    // Giãn cột
                    r_name_kho.Columns.AutoFit();

                    COMExcel.Range r_donvi_kho = (COMExcel.Range)exSheettk.Cells[i + 6, 6];

                    // Ghi dữ liệu
                    r_donvi_kho.Value2 = "kg";

                    COMExcel.Range r_soluong_kho = (COMExcel.Range)exSheettk.Cells[i + 6, 8];

                    // Ghi dữ liệu
                    r_soluong_kho.Value2 = md2.tp_thieu[i - 1];

                    // Giãn cột
                    //r_soluong_buy.Columns.AutoFit();

                    COMExcel.Range r_gia_kho = (COMExcel.Range)exSheettk.Cells[i + 6, 7];

                    // Ghi dữ liệu
                    r_gia_kho.Value2 = md1.findPriceThucPham(md2.id_thua[i - 1]);

                    // Giãn cột
                    //r_gia_buy.Columns.AutoFit();

                    // Giãn cột
                    //r_donvi_buy.Columns.AutoFit();


                    COMExcel.Range r_thanhtien_kho = (COMExcel.Range)exSheettk.Cells[i + 6, 9];

                    // Ghi dữ liệu
                    r_thanhtien_kho.Value2 = md1.findPriceThucPham(md2.id_thieu[i - 1]) * md2.tp_thua[i - 1];

                    // Giãn cột
                    //r_donvi_buy.Columns.AutoFit();

                    COMExcel.Range r_tonkho = (COMExcel.Range)exSheettk.Cells[i + 6, 10];
                    r_tonkho.Value2 = "";

                }

                // --hết xuất kho
                // Hiển thị chương trình excel

                exApptk.Visible = false;

                // Đóng chương trình excel

                //r = (COMExcel.Range)exSheet.get_Range("A1", "A4");
                // Save file

                exBooktk.SaveAs("C:\\DailyReport\\Report\\phieu_tong_tra_kho_trong_ngay(" + filename + ").xls", COMExcel.XlFileFormat.xlWorkbookNormal, null, null, false, false, COMExcel.XlSaveAsAccessMode.xlExclusive, true, true, true, true, true);
                
                exBooktk.Close(false, false, false);

                exApptk.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(exBooktk);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(exApptk);

                MessageBox.Show("ĐÃ XUẤT PHIẾU CHỈNH SỬA.");
                //MessageBox.Show("tronghoa");
            }
            // Khởi động chtr Excell
            COMExcel.Application exApp = new COMExcel.Application();
            exApp.StandardFont = "Times New Roman";
            exApp.StandardFontSize = 12;
            string workbookPath = "C:/DailyReport/TemplateDailyReport/tpl_bcmuahangngay.xls";

            COMExcel.Workbook exBook = exApp.Workbooks.Open(workbookPath,
                    0, false, 5, "", "", false, COMExcel.XlPlatform.xlWindows, "",
                    true, false, 0, true, false, false);

            // Lấy sheet 1.
            COMExcel.Worksheet exSheet1 = (COMExcel.Worksheet)exBook.Worksheets[1];

            // Range là ô [1,1] (A1)

            //COMExcel.Range r;
            exSheet1.Name = "Phiếu mua hàng trong ngày";
            COMExcel.Range r_name_buy1 = (COMExcel.Range)exSheet1.Cells[6, 1];

            for (int i = 1; i < this.count_tp_buy + 1; i++)
            {

                COMExcel.Range r_stt_buy = (COMExcel.Range)exSheet1.Cells[i + 6, 1];

                // Ghi dữ liệu
                r_stt_buy.Value2 = "" + i;
                //r_stt_buy.ColumnWidth = 299;

                // Giãn cột
                //r_stt_buy.Columns.AutoFit();
                COMExcel.Range r_name_buy = (COMExcel.Range)exSheet1.Cells[i + 6, 2];

                // Ghi dữ liệu
                r_name_buy.Value2 = tb_name_tp_cp[i - 1].Text;

                // Giãn cột
                r_name_buy.Columns.AutoFit();

                COMExcel.Range r_type = (COMExcel.Range)exSheet1.Cells[i + 6, 4];
                r_type.Value2 = "Mua hàng ngày";

                COMExcel.Range r_donvi_buy = (COMExcel.Range)exSheet1.Cells[i + 6, 6];

                // Ghi dữ liệu
                r_donvi_buy.Value2 = tb_donvi_dongia_cp[i - 1].Text;

                // Giãn cột
                //r_donvi_buy.Columns.AutoFit();

                COMExcel.Range r_soluong_buy = (COMExcel.Range)exSheet1.Cells[i + 6, 8];

                // Ghi dữ liệu
                r_soluong_buy.Value2 = tb_luong_tp_cp[i - 1].Text;

                // Giãn cột
                //r_soluong_buy.Columns.AutoFit();

                COMExcel.Range r_gia_buy = (COMExcel.Range)exSheet1.Cells[i + 6, 7];

                // Ghi dữ liệu
                r_gia_buy.Value2 = tb_price_tp_cp[i - 1].Text;

                // Giãn cột
                //r_gia_buy.Columns.AutoFit();

                COMExcel.Range r_thanhtien_buy = (COMExcel.Range)exSheet1.Cells[i + 6, 9];

                // Ghi dữ liệu
                r_thanhtien_buy.Value2 = tb_comp_tp_cp[i - 1].Text;

                // Giãn cột
                //r_donvi_buy.Columns.AutoFit();

            }

            //--cho xuất kho
            // Khởi động chtr Excell
            COMExcel.Application exApp1 = new COMExcel.Application();
            // thiết lập font

            exApp1.StandardFont = "Times New Roman";
            exApp1.StandardFontSize = 12;
            string workbookPath1 = "C:/DailyReport/TemplateDailyReport/tpl_bcxuathangngay.xls";

            COMExcel.Workbook exBook1 = exApp.Workbooks.Open(workbookPath1,
                    0, false, 5, "", "", false, COMExcel.XlPlatform.xlWindows, "",
                    true, false, 0, true, false, false);

            // Lấy sheet 1.
            COMExcel.Worksheet exSheet2 = (COMExcel.Worksheet)exBook1.Worksheets[1];

            //COMExcel.Application exApp1 = new COMExcel.Application();

            // Thêm file temp xls
            //COMExcel.Workbook exBook1 = exApp1.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);

            // Lấy sheet 1.
            //COMExcel.Worksheet exSheet2 = (COMExcel.Worksheet)exBook1.Worksheets[1];


            // Range là ô [1,1] (A1)

            //COMExcel.Range r;
            exSheet2.Name = "Phiếu xuất kho trong ngày";
            COMExcel.Range r_name_kho1 = (COMExcel.Range)exSheet2.Cells[6, 1];

            // Ghi dữ liệu
            r_name_kho1.Value2 = "STT";

            COMExcel.Range r_name_kho2 = (COMExcel.Range)exSheet2.Cells[6, 2];

            for (int i = 1; i < this.MD_qlk.count_export + 1; i++)
            {
                COMExcel.Range r_stt_kho = (COMExcel.Range)exSheet2.Cells[i + 6, 1];
                // Ghi dữ liệu
                r_stt_kho.Value2 = "" + i;
                //r_stt_buy.ColumnWidth = 299;

                // Giãn cột
                //r_stt_kho.Columns.AutoFit();
                COMExcel.Range r_name_kho = (COMExcel.Range)exSheet2.Cells[i + 6, 2];

                // Ghi dữ liệu
                r_name_kho.Value2 = tb_name_tp_cp[i - 1 + this.count_tp_buy].Text;

                // Giãn cột
                r_name_kho.Columns.AutoFit();

                COMExcel.Range r_name_type = (COMExcel.Range)exSheet2.Cells[i + 6, 4];

                // Ghi dữ liệu
                r_name_type.Value2 = "Thực phẩm kho";

                // Giãn cột
                r_name_kho.Columns.AutoFit();

                COMExcel.Range r_donvi_kho = (COMExcel.Range)exSheet2.Cells[i + 6, 6];

                // Ghi dữ liệu
                r_donvi_kho.Value2 = tb_donvi_dongia_cp[i - 1 + this.count_tp_buy].Text;

                COMExcel.Range r_soluong_kho = (COMExcel.Range)exSheet2.Cells[i + 6, 7];

                // Ghi dữ liệu
                r_soluong_kho.Value2 = tb_luong_tp_cp[i - 1 + this.count_tp_buy].Text;

                // Giãn cột
                //r_soluong_buy.Columns.AutoFit();

                COMExcel.Range r_gia_kho = (COMExcel.Range)exSheet2.Cells[i + 6, 8];

                // Ghi dữ liệu
                r_gia_kho.Value2 = tb_price_tp_cp[i - 1 + this.count_tp_buy].Text;

                // Giãn cột
                //r_gia_buy.Columns.AutoFit();




                // Giãn cột
                //r_donvi_buy.Columns.AutoFit();


                COMExcel.Range r_thanhtien_kho = (COMExcel.Range)exSheet2.Cells[i + 6, 9];

                // Ghi dữ liệu
                r_thanhtien_kho.Value2 = tb_comp_tp_cp[i - 1 + this.count_tp_buy].Text;

                // Giãn cột
                //r_donvi_buy.Columns.AutoFit();

                COMExcel.Range r_tonkho = (COMExcel.Range)exSheet2.Cells[i + 6, 10];
                r_tonkho.Value2 = "";

            }
            // đặt mặc định là ngang
            exSheet1.PageSetup.Orientation = COMExcel.XlPageOrientation.xlLandscape;
            exSheet2.PageSetup.Orientation = COMExcel.XlPageOrientation.xlLandscape;
            // cỡ giấy A4
            exSheet1.PageSetup.PaperSize = COMExcel.XlPaperSize.xlPaperA4;
            exSheet2.PageSetup.PaperSize = COMExcel.XlPaperSize.xlPaperA4;


            // --hết xuất kho
            // Hiển thị chương trình excel
            exApp.Visible = false;
            exApp1.Visible = false;

            // Đóng chương trình excel

            // Save file
            exBook.SaveAs("C:\\DailyReport\\Report\\phieu_tong_mua_hang_trong_ngay(" + file_name + ").xls", COMExcel.XlFileFormat.xlWorkbookNormal, null, null, false, false, COMExcel.XlSaveAsAccessMode.xlExclusive, true, true, true, true, true);
            exBook1.SaveAs("C:\\DailyReport\\Report\\phieu_tong_xuat_hang_trong_ngay(" + file_name + ").xls", COMExcel.XlFileFormat.xlWorkbookNormal, null, null, false, false, COMExcel.XlSaveAsAccessMode.xlExclusive, true, true, true, true, true);



            exBook.Close(false, false, false);
            exBook1.Close(false, false, false);
            exApp.Quit();
            exApp1.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook1);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp1);
            datakho dtk = new datakho();
            dtk.updateData(MD_qlk.update_infor);
            MessageBox.Show("ĐÃ XUẤT PHIẾU XUẤT KHO VÀ PHIẾU MUA HÀNG");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.count_mb++;
            Program.th_mb[Program.count_mb].Start();
        }

        private void tb_price_tp_cp_TextChanged(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < count_tp_buy + MD_qlk.count_export; i++)
            {
                if (sender == tb_price_tp_cp[i])
                {
                    if (tb_price_tp_cp[i].Text != "")
                    {
                        this.tb_comp_tp_cp[i].Text = (Int32.Parse(tb_luong_tp_cp[i].Text) * Int32.Parse(this.tb_price_tp_cp[i].Text)) + "";
                    }
                    else
                    {
                        MessageBox.Show("Không xóa số 0 đầu!!!");
                        this.tb_price_tp_cp[i].Text = "0";
                    }
                    //MessageBox.Show(i + "");
                    for (int j = 0; j < tronghoa_nt.count_TP_use; j++)
                    {
                        if (tb_name_tp_cp[i].Text == tb_name_thucpham_nt[j].Text) dongia_nhatre[j] = Int32.Parse(this.tb_price_tp_cp[i].Text);
                    }

                    for (int j = 0; j < tronghoa_mg.count_TP_use; j++)
                    {
                        if (tb_name_tp_cp[i].Text == tb_name_thucpham_mg[j].Text) dongia_maugiao[j] = Int32.Parse(this.tb_price_tp_cp[i].Text);
                    }
                }
                //sum = sum + Int32.Parse(this.tb_comp_tp_cp[i].Text);
            }
            
            this.tb_sum.Text = sum + " 000 VND";
        }

        private void evalue_nuti_rulebase()
        {

            double sum_pro_glu_lip_nt = Int32.Parse(tb_luong_vichat[4, 0].Text) + Int32.Parse(tb_luong_vichat[4, 1].Text) + Int32.Parse(tb_luong_vichat[4, 2].Text);
            double x_pro_nt = (double)Int32.Parse(tb_luong_vichat[4, 0].Text) / sum_pro_glu_lip_nt;
            if (x_pro_nt >= 0.07 && x_pro_nt <= 0.2)
            {
                this.tb_luong_vichat[4, 0].ForeColor = Color.Green;
            }
            else if (x_pro_nt < 0.07)
            {
                this.tb_luong_vichat[4, 0].ForeColor = Color.Red;
            }
            else
            {
                this.tb_luong_vichat[4, 0].ForeColor = Color.Yellow;
            }
            double x_lip_nt = (double)Int32.Parse(tb_luong_vichat[4, 1].Text) / sum_pro_glu_lip_nt;
            if (x_lip_nt >= 0.1 && x_lip_nt <= 0.35)
            {
                this.tb_luong_vichat[4, 1].ForeColor = Color.Green;
            }
            else if (x_lip_nt < 0.1)
            {
                this.tb_luong_vichat[4, 1].ForeColor = Color.Red;
            }
            else
            {
                this.tb_luong_vichat[4, 1].ForeColor = Color.Yellow;
            }

            double x_glu_nt = (double)Int32.Parse(tb_luong_vichat[4, 2].Text) / sum_pro_glu_lip_nt;
            if (x_glu_nt >= 0.5 && x_glu_nt <= 0.8)
            {
                this.tb_luong_vichat[4, 2].ForeColor = Color.YellowGreen;
            }
            else if (x_glu_nt < 0.5)
            {
                this.tb_luong_vichat[4, 2].ForeColor = Color.Red;
                //this.tb_luong_vichat[4, 2].Text = this.tb_luong_vichat[4, 2].Text + x_glu_nt;
            }
            else
            {
                this.tb_luong_vichat[4, 2].ForeColor = Color.Orange;
                //this.tb_luong_vichat[4, 2].Text = this.tb_luong_vichat[4, 2].Text + "/" + x_glu_nt;
            }

            double x_capp_nt = (double)Int32.Parse(tb_luong_vichat[4, 3].Text) / sum_pro_glu_lip_nt;
            if (x_capp_nt >= 0.2 && x_capp_nt <= 0.5)
            {
                this.tb_luong_vichat[4, 3].ForeColor = Color.YellowGreen;
            }
            else if (x_glu_nt <= 0.2)
            {
                this.tb_luong_vichat[4, 3].ForeColor = Color.Red;
            }
            else
            {
                this.tb_luong_vichat[4, 3].ForeColor = Color.Orange;
            }

            //

            double sum_pro_glu_lip_mg = Int32.Parse(tb_luong_vichat[4, 6].Text) + Int32.Parse(tb_luong_vichat[4, 7].Text) + Int32.Parse(tb_luong_vichat[4, 8].Text);
            double x_pro_mg = (double)Int32.Parse(tb_luong_vichat[4, 6].Text) / sum_pro_glu_lip_mg;
            if (x_pro_mg >= 0.07 && x_pro_mg <= 0.2)
            {
                this.tb_luong_vichat[4, 6].ForeColor = Color.Green;
            }
            else if (x_pro_mg <= 0.07)
            {
                this.tb_luong_vichat[4, 6].ForeColor = Color.Red;
            }
            else
            {
                this.tb_luong_vichat[4, 6].ForeColor = Color.Yellow;
            }
            double x_lip_mg = (double)Int32.Parse(tb_luong_vichat[4, 7].Text) / sum_pro_glu_lip_mg;
            if (x_lip_mg >= 0.15 && x_lip_mg <= 0.3)
            {
                this.tb_luong_vichat[4, 7].ForeColor = Color.Green;
            }
            else if (x_lip_mg < 0.15)
            {
                this.tb_luong_vichat[4, 7].ForeColor = Color.Red;
            }
            else
            {
                this.tb_luong_vichat[4, 7].ForeColor = Color.Yellow;
            }

            double x_glu_mg = (double)Int32.Parse(tb_luong_vichat[4, 8].Text) / sum_pro_glu_lip_mg;
            if (x_glu_mg >= 0.5 && x_glu_mg <= 0.8)
            {
                this.tb_luong_vichat[4, 8].ForeColor = Color.YellowGreen;
            }
            else if (x_glu_mg <= 0.5)
            {
                this.tb_luong_vichat[4, 8].ForeColor = Color.Red;
            }
            else
            {
                this.tb_luong_vichat[4, 8].ForeColor = Color.Orange;
            }

            double x_capp_mg = (double)Int32.Parse(tb_luong_vichat[4, 9].Text) / sum_pro_glu_lip_mg;
            if (x_capp_mg >= 0.02 && x_capp_mg <= 0.15)
            {
                this.tb_luong_vichat[4, 9].ForeColor = Color.YellowGreen;
            }
            else if (x_glu_mg <= 0.02)
            {
                this.tb_luong_vichat[4, 9].ForeColor = Color.Red;
            }
            else
            {
                this.tb_luong_vichat[4, 9].ForeColor = Color.Orange;
            }

            double pcent_pri_noon_nt = (double)Int32.Parse(tb_luong_vichat[2, 5].Text) / Int32.Parse(tb_luong_vichat[4, 5].Text);
            if (pcent_pri_noon_nt <= 0.25 && pcent_pri_noon_nt >= 0.4)
            {
                tb_luong_vichat[2, 5].ForeColor = Color.YellowGreen;
            }
            else if (pcent_pri_noon_nt < 0.25)
            {
                tb_luong_vichat[2, 5].ForeColor = Color.Red;
            }
            else
            {
                tb_luong_vichat[2, 5].ForeColor = Color.Orange;
            }

            double pcent_ext_noon_nt = (double)Int32.Parse(tb_luong_vichat[3, 5].Text) / Int32.Parse(tb_luong_vichat[4, 5].Text);
            if (pcent_ext_noon_nt <= 0.15 && pcent_ext_noon_nt >= 0.34)
            {
                tb_luong_vichat[3, 5].ForeColor = Color.YellowGreen;
            }
            else if (pcent_ext_noon_nt < 0.14)
            {
                tb_luong_vichat[3, 5].ForeColor = Color.Red;
            }
            else
            {
                tb_luong_vichat[3, 5].ForeColor = Color.Orange;
            }

            double pcent_ext_mor_nt = (double)Int32.Parse(tb_luong_vichat[1, 5].Text) / Int32.Parse(tb_luong_vichat[4, 5].Text);
            if (pcent_ext_mor_nt <= 0.25 && pcent_ext_mor_nt >= 0.02)
            {
                tb_luong_vichat[1, 5].ForeColor = Color.YellowGreen;
            }
            else if (pcent_ext_mor_nt < 0.02)
            {
                tb_luong_vichat[1, 5].ForeColor = Color.Red;
            }
            else
            {
                tb_luong_vichat[1, 5].ForeColor = Color.Orange;
            }

            double pcent_pri_noon_mg = (double)Int32.Parse(tb_luong_vichat[2, 11].Text) / Int32.Parse(tb_luong_vichat[4, 11].Text);
            if (pcent_pri_noon_mg <= 0.5 && pcent_pri_noon_mg >= 0.2)
            {
                tb_luong_vichat[2, 11].ForeColor = Color.YellowGreen;
            }
            else if (pcent_pri_noon_mg < 0.2)
            {
                tb_luong_vichat[2, 11].ForeColor = Color.Red;
            }
            else
            {
                tb_luong_vichat[2, 11].ForeColor = Color.Orange;
            }

            double pcent_ext_mor_mg = (double)Int32.Parse(tb_luong_vichat[1, 11].Text) / Int32.Parse(tb_luong_vichat[1, 11].Text);
            if (pcent_ext_mor_mg <= 0.25 && pcent_ext_mor_mg >= 0.05)
            {
                tb_luong_vichat[1, 11].ForeColor = Color.YellowGreen;
            }
            else if (pcent_ext_mor_mg < 0.05)
            {
                tb_luong_vichat[1, 11].ForeColor = Color.Red;
            }
            else
            {
                tb_luong_vichat[1, 11].ForeColor = Color.Orange;
            }

            if (Int32.Parse(tb_luong_vichat[4, 5].Text) <= 750000 && Int32.Parse(tb_luong_vichat[4, 5].Text) >= 450000)
            {
                tb_luong_vichat[4, 5].BackColor = Color.YellowGreen;
            }
            else if (Int32.Parse(tb_luong_vichat[4, 5].Text) < 450000)
            {
                tb_luong_vichat[4, 5].BackColor = Color.Red;
            }
            else
            {
                tb_luong_vichat[4, 5].BackColor = Color.Orange;
            }

            if (Int32.Parse(tb_luong_vichat[4, 11].Text) <= 750000 && Int32.Parse(tb_luong_vichat[4, 11].Text) >= 450000)
            {
                tb_luong_vichat[4, 11].BackColor = Color.YellowGreen;
            }
            else if (Int32.Parse(tb_luong_vichat[4, 11].Text) < 450000)
            {
                tb_luong_vichat[4, 11].BackColor = Color.Red;
            }
            else
            {
                tb_luong_vichat[4, 11].BackColor = Color.Orange;
            }
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.pn_mua_thucpham.Visible = true;
            this.pn_thucpham_luonghs.Visible = false;
            this.pn_thongke_end.Visible = false;
        }

        private void bt_export_end_Click(object sender, EventArgs e)
        {

        }

        private void bt_print_Click(object sender, EventArgs e)
        {

        }

        private void create_end_form()
        {
            for (int i = 0; i < 30; i++)
            {
                this.tb_stt_end[i] = new System.Windows.Forms.TextBox();
                this.tb_name_tp_end[i] = new System.Windows.Forms.TextBox();
                this.tb_luong_tp_end[i] = new System.Windows.Forms.TextBox();
                this.tb_price_tp_end[i] = new System.Windows.Forms.TextBox();
                this.tb_unit_tp_end[i] = new System.Windows.Forms.TextBox();
                this.tb_thanhtien_end[i] = new System.Windows.Forms.TextBox();
            }
        }

        private void add_items_into_end_form()
        {

            for (int i = 0; i < count_tp_buy; i++)
            {
                // 
                // tb_stt_end
                // 
                this.tb_stt_end[i].Location = new System.Drawing.Point(3, 3);
                this.tb_stt_end[i].Name = "tb_stt_end";
                this.tb_stt_end[i].Size = new System.Drawing.Size(35, 20);
                this.tb_stt_end[i].TabIndex = 0;
                this.tb_stt_end[i].Text = (i + 1) + "";
                // 
                // tb_name_tp_end
                // 
                this.tb_name_tp_end[i].Location = new System.Drawing.Point(44, 3);
                this.tb_name_tp_end[i].Name = "tb_name_tp_end";
                this.tb_name_tp_end[i].Size = new System.Drawing.Size(171, 20);
                this.tb_name_tp_end[i].TabIndex = 1;
                this.tb_name_tp_end[i].Text = name_tp_buy[i];
                // 
                // tb_luong_tp_end
                // 
                this.tb_luong_tp_end[i].Location = new System.Drawing.Point(221, 3);
                this.tb_luong_tp_end[i].Name = "tb_luong_tp_end";
                this.tb_luong_tp_end[i].Size = new System.Drawing.Size(78, 20);
                this.tb_luong_tp_end[i].TabIndex = 2;
                this.tb_luong_tp_end[i].Text = this.tb_luong_tp_cp[i].Text;
                // 
                // tb_price_tp_end
                // 
                this.tb_price_tp_end[i].Location = new System.Drawing.Point(305, 3);
                this.tb_price_tp_end[i].Name = "tb_price_tp_end";
                this.tb_price_tp_end[i].Size = new System.Drawing.Size(79, 20);
                this.tb_price_tp_end[i].TabIndex = 3;
                this.tb_price_tp_end[i].Text = this.tb_price_tp_cp[i].Text;
                // 
                // tb_unit_tp_end
                // 
                this.tb_unit_tp_end[i].Location = new System.Drawing.Point(390, 3);
                this.tb_unit_tp_end[i].Name = "tb_unit_tp_end";
                this.tb_unit_tp_end[i].Size = new System.Drawing.Size(93, 20);
                this.tb_unit_tp_end[i].TabIndex = 4;
                this.tb_unit_tp_end[i].Text = "g";
                // 
                // tb_thanhtien_end
                // 
                this.tb_thanhtien_end[i].Location = new System.Drawing.Point(489, 3);
                this.tb_thanhtien_end[i].Name = "tb_thanhtien_end";
                this.tb_thanhtien_end[i].Size = new System.Drawing.Size(95, 20);
                this.tb_thanhtien_end[i].TabIndex = 5;
                this.tb_thanhtien_end[i].Text = this.tb_comp_tp_cp[i].Text;

                this.flp_thucpham.Controls.Add(this.tb_stt_end[i]);
                this.flp_thucpham.Controls.Add(this.tb_name_tp_end[i]);
                this.flp_thucpham.Controls.Add(this.tb_luong_tp_end[i]);
                this.flp_thucpham.Controls.Add(this.tb_price_tp_end[i]);
                this.flp_thucpham.Controls.Add(this.tb_unit_tp_end[i]);
                this.flp_thucpham.Controls.Add(this.tb_thanhtien_end[i]);
            }

        }

        private void bt_export_Click(object sender, EventArgs e)
        {
            this.pn_mua_thucpham.Visible = false;
            this.pn_thongke_end.Visible = true;
            add_items_into_end_form();
            int sum = 0;
            for (int i = 0; i < tronghoa_nt.count_TP_use; i++)
            {
                sum = sum + luongsd_nhatre[i] * dongia_nhatre[i];
            }
            this.tb_chiphi_nhatre.Text = sum/100 + " đ";
            sum = 0;
            for (int i = 0; i < tronghoa_mg.count_TP_use; i++)
            {
                sum = sum + luongsd_maugiao[i] * dongia_maugiao[i];
            }
            this.tb_chiphi_maugiao.Text = sum/1000 + " đ";
            
        }

        private void tb_luonghs_nhatre_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < tronghoa_nt.count_TP_use; i++)
            {
                if (tb_luonghs_nhatre.Text != "")
                {
                    tb_luongsd_nt[i].Text = tronghoa_nt.luong_TD_TP_use[i] * Int32.Parse(tb_luonghs_nhatre.Text) + "";
                }
                else
                {
                    MessageBox.Show("Không xóa số 0 ở đầu !!!");
                    tb_luonghs_nhatre.Text = "0";
                }
            }

            for (int i = 0; i < tronghoa_mg.count_TP_use; i++)
            {
                luong_tp_buy[i] = tronghoa_mg.luong_TD_TP_use[i] * Int32.Parse(tb_luonghs_nhatre.Text);
                name_tp_buy[i] = tronghoa_mg.name_TP_use[i];
            }

            for (int i = 0; i < tronghoa_nt.count_TP_use; i++)
            {
                int check = 0;
                for (int j = 0; j < tronghoa_mg.count_TP_use; j++)
                {
                    if (tronghoa_nt.name_TP_use[i] == tronghoa_mg.name_TP_use[j])
                    {
                        check = 1;
                        luong_tp_buy[i] = luong_tp_buy[i] + tronghoa_mg.luong_TD_TP_use[j] * Int32.Parse(tb_luonghs_maugiao.Text);
                    }
                }

                if (check == 0)
                {
                    luong_tp_buy[count_tp_buy] = tronghoa_nt.luong_TD_TP_use[i];
                    name_tp_buy[count_tp_buy] = tronghoa_nt.name_TP_use[i];
                    count_tp_buy++;
                }
            }
            /*
            for (int i = 0; i < count_tp_buy; i++)
            {
                this.tb_luong_tp_cp[i].Text = luong_tp_buy[i] + "";
            }
            */
            create_buy_export_form();
        }

        private void tb_luonghs_maugiao_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < tronghoa_mg.count_TP_use; i++)
            {
                if (tb_luonghs_maugiao.Text != "")
                {
                    tb_luongsd_mg[i].Text = tronghoa_mg.luong_TD_TP_use[i] * Int32.Parse(tb_luonghs_maugiao.Text) + "";
                }
                else
                {
                    MessageBox.Show("Không xóa số 0 ở đầu");
                    tb_luonghs_maugiao.Text = "0";
                }
            }

            for (int i = 0; i < tronghoa_mg.count_TP_use; i++)
            {
                luong_tp_buy[i] = tronghoa_mg.luong_TD_TP_use[i] * Int32.Parse(tb_luonghs_nhatre.Text);
                name_tp_buy[i] = tronghoa_mg.name_TP_use[i];
            }

            for (int i = 0; i < tronghoa_nt.count_TP_use; i++)
            {
                int check = 0;
                for (int j = 0; j < tronghoa_mg.count_TP_use; j++)
                {
                    if (tronghoa_nt.name_TP_use[i] == tronghoa_mg.name_TP_use[j])
                    {
                        check = 1;
                        luong_tp_buy[i] = luong_tp_buy[i] + tronghoa_mg.luong_TD_TP_use[j] * Int32.Parse(tb_luonghs_maugiao.Text);
                    }
                }

                if (check == 0)
                {
                    luong_tp_buy[count_tp_buy] = tronghoa_nt.luong_TD_TP_use[i];
                    name_tp_buy[count_tp_buy] = tronghoa_nt.name_TP_use[i];
                    count_tp_buy++;
                }
            }
            create_buy_export_form();
        }

        private void chiphi_nhatre_maugiao()
        {
            for (int i = 0; i < tronghoa_nt.count_TP_use; i++)
            {
                luongsd_nhatre[i] = Int32.Parse(tb_luongsd_nt[i].Text);
                if (this.tb_type_nt[i].Text == "có sẵn") dongia_nhatre[i] = tronghoa_nt.dongia_TP_kho_new[i];
            }
            //MessageBox.Show("nhà trẻ" + tronghoa_nt.count_TP_use);
            for (int i = 0; i < tronghoa_mg.count_TP_use; i++)
            {
                luongsd_maugiao[i] = Int32.Parse(tb_luongsd_mg[i].Text);
                if (this.tb_type_mg[i].Text == "có sẵn") dongia_maugiao[i] = tronghoa_mg.dongia_TP_kho_new[i];
            }
            //MessageBox.Show("Mẫu giáo" + tronghoa_mg.count_TP_use);
        }

        private void bt_left_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã hủy bỏ thực đơn thành công. Chương trình sẽ tạm dừng trong giây lát !!!");
            this.Close();
            
        }

        private void tb_sum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
