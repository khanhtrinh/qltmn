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
        public bt_fixtd()
        {
            InitializeComponent();
            create_items();
            create_form();
            this.bt_submit.Enabled = false;
            this.button12.Enabled = false;
            //this.radioButton2.Checked = true;
        }
        /*
        private void bt_xls_Click(object sender, System.EventArgs e)
        {
            quanli_HDTP.xuatXls();
        }
         */

        /*
        private void bt_store_Click(object sender, System.EventArgs e)
        {
            string str = quanli_HDTP.genStr();
            quanli_HDTP.store(str);

            MessageBox.Show("Đã lưu dữ liệu thành công.");
        }
         */

        private void create_items()
        {
            for (int i = 0; i < 100; i++)
            {
                this.tb_ID_TP[i] = new System.Windows.Forms.TextBox();
                this.tb_Name_TP[i] = new TextBox();
                this.tb_DonGia_TP_old[i] = new System.Windows.Forms.TextBox();
                this.tb_DonGia_TP_new[i] = new System.Windows.Forms.TextBox();
                this.tb_DonVi_TP[i] = new System.Windows.Forms.TextBox();
                this.tb_SL_TP_old[i] = new System.Windows.Forms.TextBox();
                this.tb_SL_TP_new[i] = new System.Windows.Forms.TextBox();
                this.tb_SL[i] = new System.Windows.Forms.TextBox();
                this.tb_ttien[i] = new TextBox();
                this.tb_Date_TP[i] = new System.Windows.Forms.TextBox();
                this.cb_NhaCC_TP[i] = new System.Windows.Forms.TextBox();
            }
        }

        private void create_form()
        {
            
            for (int i = 0; i < cbdd.quanli_HDTP.count_TP_t; i++)
            {
                // 
                // tb_ID_TP
                // 
                this.tb_ID_TP[i].Location = new System.Drawing.Point(3, 32);
                this.tb_ID_TP[i].Name = "tb_ID_TP";
                this.tb_ID_TP[i].Size = new System.Drawing.Size(33, 23);
                this.tb_ID_TP[i].TabIndex = 0;
                this.tb_ID_TP[i].Text = "" + cbdd.quanli_HDTP.ID_TP_t[i];
                this.tb_ID_TP[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                //
                // tb_Name_TP
                //
                this.tb_Name_TP[i].Location = new System.Drawing.Point(15, 32);
                this.tb_Name_TP[i].Name = "tb_Name_TP";
                this.tb_Name_TP[i].Size = new System.Drawing.Size(94, 33);
                this.tb_Name_TP[i].TabIndex = 1;
                this.tb_Name_TP[i].Text = cbdd.quanli_HDTP.name_TP_t[i];
                this.tb_Name_TP[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_DonVi_TP
                // 
                this.tb_DonVi_TP[i].Location = new System.Drawing.Point(133, 32);
                this.tb_DonVi_TP[i].Name = "tb_DonVi_TP";
                this.tb_DonVi_TP[i].Size = new System.Drawing.Size(49, 23);
                this.tb_DonVi_TP[i].TabIndex = 3;
                this.tb_DonVi_TP[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.tb_DonVi_TP[i].Text = cbdd.quanli_HDTP.unit_TP_t[i] + "";
                // 
                // tb_DonGia_TP_old
                // 
                this.tb_DonGia_TP_old[i].Location = new System.Drawing.Point(39, 32);
                this.tb_DonGia_TP_old[i].Name = "tb_DonGia_TP_old";
                this.tb_DonGia_TP_old[i].Size = new System.Drawing.Size(75, 23);
                this.tb_DonGia_TP_old[i].TabIndex = 4;
                this.tb_DonGia_TP_old[i].Text = cbdd.quanli_HDTP.dongia_TP_kho_old_t[i] + "";
                this.tb_DonGia_TP_old[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_SL_TP_old
                // 
                this.tb_SL_TP_old[i].Location = new System.Drawing.Point(189, 32);
                this.tb_SL_TP_old[i].Name = "tb_SL_TP_old";
                this.tb_SL_TP_old[i].Size = new System.Drawing.Size(84, 23);
                this.tb_SL_TP_old[i].TabIndex = 5;
                this.tb_SL_TP_old[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.tb_SL_TP_old[i].Text = cbdd.quanli_HDTP.luong_TP_kho_old_t[i] + "";
                // 
                // tb_DonGia_TP_new
                // 
                this.tb_DonGia_TP_new[i].Location = new System.Drawing.Point(38, 32);
                this.tb_DonGia_TP_new[i].Name = "tb_DonGia_TP_new";
                this.tb_DonGia_TP_new[i].Size = new System.Drawing.Size(75, 23);
                this.tb_DonGia_TP_new[i].TabIndex = 6;
                this.tb_DonGia_TP_new[i].Text = cbdd.quanli_HDTP.dongia_TP_kho_new_t[i] + "";
                this.tb_DonGia_TP_new[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // tb_SL_TP_new
                // 
                this.tb_SL_TP_new[i].Location = new System.Drawing.Point(189, 32);
                this.tb_SL_TP_new[i].Name = "tb_SL_TP_new";
                this.tb_SL_TP_new[i].Size = new System.Drawing.Size(85, 23);
                this.tb_SL_TP_new[i].TabIndex = 7;
                this.tb_SL_TP_new[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.tb_SL_TP_new[i].Text = cbdd.quanli_HDTP.luong_TP_kho_new_t[i] + "";
                //
                // tb_luong_nhap
                //
                this.tb_SL[i].Location = new System.Drawing.Point(190, 32);
                this.tb_SL[i].Name = "tb_luong";
                this.tb_SL[i].Size = new System.Drawing.Size(86, 23);
                this.tb_SL[i].TabIndex = 8;
                this.tb_SL[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.tb_SL[i].Text = cbdd.quanli_HDTP.luong_TP_kho_new_t[i] - cbdd.quanli_HDTP.luong_TP_kho_old_t[i] + "";
                //
                // tb_ttien
                //
                this.tb_ttien[i].Location = new System.Drawing.Point(189, 32);
                this.tb_ttien[i].Name = "tb_ttien";
                this.tb_ttien[i].Size = new System.Drawing.Size(99, 23);
                this.tb_ttien[i].TabIndex = 9;
                this.tb_ttien[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.tb_ttien[i].Text = (cbdd.quanli_HDTP.luong_TP_kho_new_t[i] - cbdd.quanli_HDTP.luong_TP_kho_old_t[i]) * cbdd.quanli_HDTP.dongia_TP_kho_new_t[i] + "";
                this.tb_ttien[i].ReadOnly = true;
                // 
                // tb_Date_TP
                // 
                this.tb_Date_TP[i].Location = new System.Drawing.Point(270, 32);
                this.tb_Date_TP[i].Name = "tb_Date_TP";
                this.tb_Date_TP[i].Size = new System.Drawing.Size(92, 23);
                this.tb_Date_TP[i].TabIndex = 10;
                this.tb_Date_TP[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.tb_Date_TP[i].Text = "xx/xx/xxxx";
                this.tb_Date_TP[i].ReadOnly = true;
                // 
                // cb_NhaCC_TP
                // 
                this.cb_NhaCC_TP[i].Location = new System.Drawing.Point(361, 32);
                this.cb_NhaCC_TP[i].Name = "cb_NhaCC_TP";
                this.cb_NhaCC_TP[i].Size = new System.Drawing.Size(108, 23);
                this.cb_NhaCC_TP[i].TabIndex = 5;
            }
            for (int i = 0; i < cbdd.quanli_HDTP.count_TP_t; i++)
            {
                this.flp1.Controls.Add(this.tb_ID_TP[i]);
                this.flp1.Controls.Add(this.tb_Name_TP[i]);
                this.flp1.Controls.Add(this.tb_DonVi_TP[i]);
                this.flp1.Controls.Add(this.tb_DonGia_TP_old[i]);
                this.flp1.Controls.Add(this.tb_SL_TP_old[i]);
                this.flp1.Controls.Add(this.tb_DonGia_TP_new[i]);
                this.flp1.Controls.Add(this.tb_SL_TP_new[i]);
                this.flp1.Controls.Add(this.tb_SL[i]);
                this.flp1.Controls.Add(this.tb_ttien[i]);
                this.flp1.Controls.Add(this.tb_Date_TP[i]);
            }

            for (int i = 0; i < cbdd.quanli_HDTP.count_TP_t; i++)
            {
                this.listBox1.Items.Add(cbdd.quanli_HDTP.name_TP_t[i]);
            }
            //this.listBox1.SelectedIndex = 1;
            
        }

        private void lb_changeText(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;

            this.tb_ID.Text = cbdd.quanli_HDTP.ID_TP_t[index] + "";
            this.tb_dv.Text = cbdd.quanli_HDTP.unit_TP_t[index];
            this.tb_dg_new.Text = cbdd.quanli_HDTP.dongia_TP_kho_new_t[index] + "";
            //this.tb_dg_old.Text = quanli_HDTP.dongia_TP_kho_old_t[index] + "";
            //this.tb_kho_new.Text = quanli_HDTP.luong_TP_kho_new_t[index] + "";
            //this.tb_kho_old.Text = quanli_HDTP.luong_TP_kho_old_t[index] + "";
            //this.tb_luong_nhap.Text = "0";
            //this.tb_luong_nhap.Text = quanli_HDTP.luong_TP_kho_new_t[index] - quanli_HDTP.luong_TP_kho_old_t[index] + "";
            //this.tb_tien.Text = (Convert.ToInt64(this.tb_luong_nhap.Text) * Convert.ToInt64(this.tb_dg_new.Text)) + "";
            this.tb_date.Text = Convert.ToString(DateTime.Today);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                this.flp1.Visible = false;
                this.flp2.Visible = true;
                this.panel1.Visible = true;
                this.Refresh();
            }
            else if (this.radioButton2.Checked)
            {
                this.flp1.Visible = true;
                this.flp2.Visible = false;
                this.panel1.Visible = false;
                this.Refresh();
            }
            else { }
        }

        //list ra nhung thuc pham co trong mon an
        //Tim ra nhung thuc pham co gia cao nhat, thap nhat trong mon an

        /*public void capnhat_gia_monan()
        {
            Int64 giamoi = Convert.ToInt64(this.tb_dg_new.Text);
            int id = Convert.ToInt32(this.tb_ID.Text);
            string dv = this.tb_dv.Text;
            //string test = "";
            //string test1 = "";

            int index = cbdd.locate(id, cbdd.ID_TP, cbdd.countTP);
            //Doi don vi kg va g
            if (dv.CompareTo("kg") == 0)
            {
                cbdd.dv_TP[index] = 1000;
            }
            else if (dv.CompareTo("g") == 0)
            {
                cbdd.dv_TP[index] = 1;
            }

            cbdd.gia_new[index] = giamoi;
            cbdd.ID_TP[index] = id;

            MessageBox.Show(cbdd.ID_TP[index] + "/" + cbdd.gia_new[index]);
        }*/
        //Tinh do bien thien gia cua tung thuc pham
        //Return ve 1 neu duong, -1 neu am
        //Viet ham dinh luong dua vao viec return
        /*
        private int[] bien_thien(Int64[] b_old, Int64[] b_new, int num_hs)
        {
            System.Int64[] delta = new Int64[200];
            int[] result = new int[200];
            for (int i = 0; i < quanli_HDTP.count_TP_t; i++)
            {
                delta[i] = (b_new[i] - b_old[i]);
                if (delta[i] > 0)
                {
                    result[i] = 1;
                }
                else if (delta[i] < 0)
                {
                    result[i] = -1;
                }
                else
                {
                    result[i] = 0;
                }
            }

            return result;
        }        
        */
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fr_quanli_HDTP_Load(object sender, EventArgs e)
        {

        }

        private void capnhat_gia()
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            cbdd.balanceTD();
            //MessageBox.Show("pro " + cbdd.vichat[0] + " lip " + cbdd.vichat[1] + " glu " + cbdd.vichat[2] + " cal " + cbdd.vichat[3]);
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            
            Int64 giamoi = Convert.ToInt64(this.tb_dg_new.Text);
            int id = Convert.ToInt32(this.tb_ID.Text);
            string dv = this.tb_dv.Text;
            /* 
            string test = "";
            string test1 = "";
            */
            
            /*
            MessageBox.Show("Bang mon an - thuc pham:");
            for (int i = 0; i < cbdd.count_MA_TD; i++)
            {
                for (int j = 0; j < cbdd.countTP; j++)
                {
                    test += cbdd.ma_tp[i,j] + " ";
                }
                test += "\n";
            }
            //richTextBox1.Text = test;
             */

            /*
            MessageBox.Show("text box 2 in ra mang IDTP");
            for (int i = 0; i < cbdd.countTP; i++)
            {
                test1 += cbdd.ID_TP[i] + " ";
            }
            //richTextBox2.Text = test1;
             */

            //capnhat_gia_monan();
            
            int index = cbdd.locate(id, cbdd.ID_TP, cbdd.countTP);
            if (giamoi >= 0)
            {
                cbdd.gia_new[index] = giamoi;
                //cbdd.ID_TP[index] = id;
                int index2 = cbdd.quanli_HDTP.locate(id, cbdd.quanli_HDTP.ID_TP_t, 200);
                MessageBox.Show("Đã nhập giá mới thành công.");
                cbdd.quanli_HDTP.dongia_TP_kho_new_t[index2] = giamoi;
                cbdd.xuathopdong();
            }
            else
            {
                this.tb_dg_new.Text = cbdd.gia_new[index] + "";
                MessageBox.Show("Giá thực phẩm phải là số và lớn hơn 0.");
            }             
            //MessageBox.Show(cbdd.ID_TP[index] + "/" + cbdd.gia_new[index]);
        }

        private void tb_dg_new_TextChanged(object sender, EventArgs e)
        {
            bt_submit.Enabled = true;
            button12.Enabled = true;
        }
    }
}
