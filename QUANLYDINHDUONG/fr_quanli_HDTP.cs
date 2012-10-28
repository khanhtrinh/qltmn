using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class bt_fixtd : Form
    {
        modun_canbang_dinhduong cbdd = new modun_canbang_dinhduong();
        public string mess = "";
        public string[] mess_line = new string[1000];
        public string[] buffer_line = new string[1000];
        public int count_line = 0;

        public bt_fixtd()
        {
            InitializeComponent();
            create_items();
            create_form();
            this.bt_submit.Enabled = false;
            this.button12.Enabled = false;
            //this.radioButton2.Checked = true;
        }

        private void create_items()
        {
            for (int i = 0; i < 300; i++)
            {
                this.tb_ID_TP[i] = new System.Windows.Forms.TextBox();
                this.tb_Name_TP[i] = new TextBox();

                this.tb_DonGia_TP_new[i] = new System.Windows.Forms.TextBox();
                this.tb_DonVi_TP[i] = new System.Windows.Forms.TextBox();

                this.tb_Date_TP[i] = new System.Windows.Forms.TextBox();
                this.tb_nhaphanphoi[i] = new System.Windows.Forms.TextBox();
            }
        }

        private void create_form()
        {

            for (int i = 0; i < cbdd.quanli_HDTP.count_TP_hn; i++)
            {
                // 
                // tb_ID_TP
                // 
                this.tb_ID_TP[i].Location = new System.Drawing.Point(3, 32);
                this.tb_ID_TP[i].Name = "tb_ID_TP";
                this.tb_ID_TP[i].Size = new System.Drawing.Size(45, 23);
                this.tb_ID_TP[i].TabIndex = 0;
                this.tb_ID_TP[i].Text = "" + cbdd.quanli_HDTP.ID_TP_hn[i];
                this.tb_ID_TP[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                //
                // tb_Name_TP
                //
                this.tb_Name_TP[i].Location = new System.Drawing.Point(15, 32);
                this.tb_Name_TP[i].Name = "tb_Name_TP";
                this.tb_Name_TP[i].Size = new System.Drawing.Size(205, 23);
                this.tb_Name_TP[i].TabIndex = 1;
                this.tb_Name_TP[i].Text = cbdd.quanli_HDTP.name_TP_hn[i];
                this.tb_Name_TP[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_DonVi_TP
                // 
                this.tb_DonVi_TP[i].Location = new System.Drawing.Point(133, 32);
                this.tb_DonVi_TP[i].Name = "tb_DonVi_TP";
                this.tb_DonVi_TP[i].Size = new System.Drawing.Size(100, 23);
                this.tb_DonVi_TP[i].TabIndex = 3;
                this.tb_DonVi_TP[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.tb_DonVi_TP[i].Text = cbdd.quanli_HDTP.unit_TP_hn[i] + "";

                // 
                // tb_DonGia_TP_new
                // 
                this.tb_DonGia_TP_new[i].Location = new System.Drawing.Point(38, 32);
                this.tb_DonGia_TP_new[i].Name = "tb_DonGia_TP_new";
                this.tb_DonGia_TP_new[i].Size = new System.Drawing.Size(110, 23);
                this.tb_DonGia_TP_new[i].TabIndex = 6;
                this.tb_DonGia_TP_new[i].Text = cbdd.quanli_HDTP.dongia_TP_kho_new_hn[i] + "";
                this.tb_DonGia_TP_new[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                // 
                // tb_Date_TP
                // 
                this.tb_Date_TP[i].Location = new System.Drawing.Point(270, 32);
                this.tb_Date_TP[i].Name = "tb_Date_TP";
                this.tb_Date_TP[i].Size = new System.Drawing.Size(146, 23);
                this.tb_Date_TP[i].TabIndex = 10;
                this.tb_Date_TP[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.tb_Date_TP[i].Text = DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;
                this.tb_Date_TP[i].ReadOnly = true;
                // 
                // cb_NhaCC_TP
                // 
                this.tb_nhaphanphoi[i].Location = new System.Drawing.Point(361, 32);
                this.tb_nhaphanphoi[i].Name = "cb_NhaCC_TP";
                this.tb_nhaphanphoi[i].Size = new System.Drawing.Size(176, 23);
                this.tb_nhaphanphoi[i].TabIndex = 5;
            }
            for (int i = 0; i < cbdd.quanli_HDTP.count_TP_hn; i++)
            {
                this.flp1.Controls.Add(this.tb_ID_TP[i]);
                this.flp1.Controls.Add(this.tb_Name_TP[i]);
                this.flp1.Controls.Add(this.tb_DonVi_TP[i]);
                this.flp1.Controls.Add(this.tb_DonGia_TP_new[i]);

                this.flp1.Controls.Add(this.tb_nhaphanphoi[i]);
                this.flp1.Controls.Add(this.tb_Date_TP[i]);
            }

            for (int i = 0; i < cbdd.quanli_HDTP.count_TP_hn; i++)
            {
                this.listBox1.Items.Add(cbdd.quanli_HDTP.name_TP_hn[i]);
            }
        }

        private void lb_changeText(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;

            this.tb_ID.Text = cbdd.quanli_HDTP.ID_TP_hn[index] + "";
            this.tb_dv.Text = cbdd.quanli_HDTP.unit_TP_hn[index];
            this.tb_dg_new.Text = cbdd.quanli_HDTP.dongia_TP_kho_new_hn[index] + "";
            this.tb_date.Text = DateTime.Now.ToShortDateString();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                this.flp1.Visible = true;
                this.flp2.Visible = false;
                this.panel1.Visible = false;
                this.Refresh();
            }
            else if (this.radioButton2.Checked)
            {
                this.flp1.Visible = false;
                this.flp2.Visible = true;
                this.panel1.Visible = true;
                this.Refresh();
            }
            else { }
        }


        private void fr_quanli_HDTP_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            FileInfo filematp = new FileInfo("data/database/monan_thucpham.dat");
            if (filematp.Exists == true)
            {
                filematp.CopyTo("data/database/monan_thucpham.bak", true);
            }
            cbdd.balanceTD_mg();
            //cbdd.balanceTD_nt();
            //cbdd.luumonan();
            //MessageBox.Show("pro " + cbdd.vichat[0] + " lip " + cbdd.vichat[1] + " glu " + cbdd.vichat[2] + " cal " + cbdd.vichat[3]);
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            Int64 giamoi = Convert.ToInt64(this.tb_dg_new.Text);
            int id = Convert.ToInt32(this.tb_ID.Text);
            string dv = this.tb_dv.Text;

            int index = cbdd.locate(id, cbdd.ID_TP, cbdd.countTP);
            if (giamoi >= 0)
            {
                cbdd.gia_new[index] = giamoi;
                int index2 = cbdd.quanli_HDTP.locate(id, cbdd.quanli_HDTP.ID_TP_hn, 200);
                MessageBox.Show("Ðã nhập giá mới thành công.");
                cbdd.quanli_HDTP.dongia_TP_kho_new_hn[index2] = giamoi;
                cbdd.quanli_HDTP.ngayketthuc_hn[index2] = this.monthCalendar1.SelectionRange.Start.Day + "-" + this.monthCalendar1.SelectionRange.Start.Month + "-" + this.monthCalendar1.SelectionRange.Start.Year;
                cbdd.xuathopdong();
            }
            else
            {
                this.tb_dg_new.Text = cbdd.gia_new[index] + "";
                MessageBox.Show("Giá thực phẩm phải là số và lớn hơn 0.");
            }
        }

        private void tb_dg_new_TextChanged(object sender, EventArgs e)
        {
            bt_submit.Enabled = true;
            button12.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.count_mb++;
            Program.th_mb[Program.count_mb].Start();
        }

        //Cân bằng mẫu giáo
        public void balanceTD_mg()
        {
            for (int count = 0; count < 10; count++)
            {
                cbdd.get_TD_MA(count, "data/database/thucdon_monan1.dat");
                cbdd.get_MA_TP(cbdd.td_ma, cbdd.count_MA_TD);
                cbdd.tinhvc();
                //MessageBox.Show("Thuc don ban dau: " + count + "\n" + "Gia tien MG: " + compute_gia_thucdon(count_MA_TD) + "\n" + "calo " + vichat[3]);
                while (true)
                {
                    if ((cbdd.compute_gia_thucdon(cbdd.count_MA_TD) < 20050) && (cbdd.compute_gia_thucdon(cbdd.count_MA_TD) > 19950) && (cbdd.checkvc() == 0)) break;
                    cbdd.cb_tien(20000);
                }
                cbdd.xuat_ma_tp();

            }
            MessageBox.Show("MG successfully");
            //xuat_ma_tp();
        }

        //Cân bằng nhà trẻ
        public void balanceTD_nt()
        {
            for (int count = 0; count < 10; count++)
            {
                cbdd.get_TD_MA(count, "data/database/thucdon_monan.dat");
                cbdd.get_MA_TP(cbdd.td_ma, cbdd.count_MA_TD);
                cbdd.tinhvc();
                //MessageBox.Show("Thuc don ban dau: " + count + "\n" + "Gia tien MG: " + compute_gia_thucdon(count_MA_TD) + "\n" + "calo " + vichat[3]);
                while (true)
                {
                    if ((cbdd.compute_gia_thucdon(cbdd.count_MA_TD) < 20050) && (cbdd.compute_gia_thucdon(cbdd.count_MA_TD) > 19950) && (cbdd.checkvc() == 0)) break;
                    cbdd.cb_tien(20000);
                }
                cbdd.xuat_ma_tp();

            }
            MessageBox.Show("MG successfully");
            //xuat_ma_tp();
        }

        //Kiem tra xem a có trong b không
        public int check_in(string a, string[] b, int n)
        {
            int check = 0;
            for (int i = 0; i < n; i++)
            {
                if (a.CompareTo(b[i]) == 0)
                {
                    check = 1;
                    break;
                }
            }
            return check;
        }

        //Chen vao vi tri tr?ng
        public void insert_line(string a, string[] b, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (b[i].CompareTo("") == 0)
                {
                    b[i] = a;
                    break;
                }
            }
        }
        //----------
        //End
        //----------
    }
}
