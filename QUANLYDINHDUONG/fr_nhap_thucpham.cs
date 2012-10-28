using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class fr_nhap_thucpham : Form
    {
        private int current_count = 0;
        private int limit_value;

        public fr_nhap_thucpham()
        {
            thucpham1.query_vichat();
            thucpham1.query_thucpham();
            thucpham1.query_join_thucpham_vichat();
            limit_value = (int)thucpham1.count_TP/17;
            InitializeComponent();
            create_dynamic_items();
           // MessageBox.Show("Hiện có " + thucpham1.count_TP + " thực phẩm đang được sử dụng trong nhà trường");
            
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.count_mb++;
            Program.th_mb[Program.count_mb].Start();
        }
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private void bt_bt_chuyen_thucpham_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.count_nhap_tp_moi++;
            Program.th_nhap_thucpham_moi[Program.count_nhap_tp_moi].Start();
        }

        private void create_dynamic_items()
        {
            for (int i = 0; i < 1000; i++)
            {
                this.tb_id_thucpham[i] = new System.Windows.Forms.TextBox();
                this.tb_name_thucpham[i] = new System.Windows.Forms.TextBox();
                this.cb_type_thucpham[i] = new System.Windows.Forms.ComboBox();
            }
            for (int i = 0; i < 10; i++)
            {
                this.bt_name_vichat[i] = new System.Windows.Forms.Button();
                this.flp_title_thucpham.Controls.Add(this.bt_name_vichat[i]);
            }
            for (int i = 0; i < thucpham1.count_VC; i++)
            {
                // 
                // bt_name_vichat
                // 
                this.bt_name_vichat[i].Location = new System.Drawing.Point(250, 3);
                this.bt_name_vichat[i].Name = "bt_name_vichat";
                this.bt_name_vichat[i].Size = new System.Drawing.Size(75, 23);
                this.bt_name_vichat[i].TabIndex = 5;
                this.bt_name_vichat[i].Text = thucpham1.name_VC[i];
                this.bt_name_vichat[i].UseVisualStyleBackColor = true;
            }
            for (int i = 0; i < 17; i++)
            {
                this.flp_information_thucpham.Controls.Add(this.tb_id_thucpham[i]);
                this.flp_information_thucpham.Controls.Add(this.tb_name_thucpham[i]);
                this.flp_information_thucpham.Controls.Add(this.cb_type_thucpham[i]);
                for (int j = 0; j < 10; j++)
                {
                    this.tb_luong_thucpham[i, j] = new System.Windows.Forms.TextBox();
                    this.flp_information_thucpham.Controls.Add(this.tb_luong_thucpham[i, j]);
                }
            }
            for (int i = 0; i < 17; i++)
            {
                // 
                // tb_id_thucpham
                // 
                this.tb_id_thucpham[i].Location = new System.Drawing.Point(3, 3);
                this.tb_id_thucpham[i].Name = "tb_id_thucpham";
                this.tb_id_thucpham[i].Size = new System.Drawing.Size(47, 20);
                this.tb_id_thucpham[i].TabIndex = 0;
                this.tb_id_thucpham[i].Text = "" + (i + 1);
                // 
                // tb_name_thucpham
                // 
                this.tb_name_thucpham[i].Location = new System.Drawing.Point(56, 3);
                this.tb_name_thucpham[i].Name = "tb_name_thucpham";
                this.tb_name_thucpham[i].Size = new System.Drawing.Size(112, 20);
                this.tb_name_thucpham[i].TabIndex = 1;
                this.tb_name_thucpham[i].Text = thucpham1.name_TP[i];
                // 
                // cb_type_thucpham
                // 
                this.cb_type_thucpham[i].FormattingEnabled = true;
                this.cb_type_thucpham[i].Location = new System.Drawing.Point(174, 3);
                this.cb_type_thucpham[i].Name = "cb_type_thucpham";
                this.cb_type_thucpham[i].Size = new System.Drawing.Size(70, 21);
                this.cb_type_thucpham[i].TabIndex = 2;
                this.cb_type_thucpham[i].Text = thucpham1.type_TP[i];
                for (int j = 0; j < 10; j++)
                {
                    // 
                    // tb_luong_thucpham
                    // 
                    this.tb_luong_thucpham[i, j].Location = new System.Drawing.Point(250, 3);
                    this.tb_luong_thucpham[i, j].Name = "tb_luong_thucpham";
                    this.tb_luong_thucpham[i, j].Size = new System.Drawing.Size(75, 20);
                    this.tb_luong_thucpham[i, j].TabIndex = 3;
                    this.tb_luong_thucpham[i, j].Text = thucpham1.luong_TP_VC[i, j] + "";
                }
            }
            
        }

        private void comeback_Click(object sender, EventArgs e)
        {
            if (current_count != 0) 
            {
                current_count--;
            }
            for (int i = 0; i < 17; i++)
            {
                // 
                // tb_id_thucpham
                // 
                this.tb_id_thucpham[i].Text = "" + (i + 1 + 17 * current_count);
                // 
                // tb_name_thucpham
                // 
                this.tb_name_thucpham[i].Text = thucpham1.name_TP[i + 17 * current_count];
                // 
                // cb_type_thucpham
                // 
                this.cb_type_thucpham[i].Text = thucpham1.type_TP[i + 17 * current_count];
                for (int j = 0; j < 10; j++)
                {
                    // 
                    // tb_luong_thucpham
                    // 
                    this.tb_luong_thucpham[i, j].Text = thucpham1.luong_TP_VC[i + 17 * current_count, j] + "";
                }
            }
        }

        private void comeon_Click(object sender, EventArgs e)
        {
            if (current_count < limit_value)
            {
                current_count++;
            }
            for (int i = 0; i < 17; i++)
            {
                // 
                // tb_id_thucpham
                // 
                this.tb_id_thucpham[i].Text = "" + (i + 1 + 17 * current_count);
                // 
                // tb_name_thucpham
                // 
                this.tb_name_thucpham[i].Text = thucpham1.name_TP[i + 17 * current_count];
                // 
                // cb_type_thucpham
                // 
                this.cb_type_thucpham[i].Text = thucpham1.type_TP[i + 17 * current_count];
                for (int j = 0; j < 10; j++)
                {
                    // 
                    // tb_luong_thucpham
                    // 
                    this.tb_luong_thucpham[i, j].Text = thucpham1.luong_TP_VC[i + 17 * current_count, j] + "";
                }
            }
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("" + current_count);
            string output_thucpham = "";
            string output_thucpham_vichat = "";

            for (int i = 0; i < 17; i++)
            {
                thucpham1.name_TP[17 * current_count + i] = tb_name_thucpham[i].Text;
                thucpham1.type_TP[17 * current_count + i] = cb_type_thucpham[i].Text;
                for (int j = 0; j < thucpham1.count_VC; j++)
                {
                    thucpham1.luong_TP_VC[17 * current_count + i, j] = Int32.Parse(tb_luong_thucpham[i, j].Text);
                }
            }

            for (int i = 0; i < thucpham1.count_TP; i++)
            {
                output_thucpham = output_thucpham + thucpham1.ID_TP[i] + "/" + thucpham1.name_TP[i] + "/" + thucpham1.type_TP[i] + "/" + thucpham1.unit_TP[i] + "/" + thucpham1.luong_TP_kho_new[i] + "/" + thucpham1.dongia_TP_kho_new[i] + "/" + thucpham1.luong_TP_kho_old[i] + "/" + thucpham1.dongia_TP_kho_old[i] + "\n";
                for (int j = 0; j < thucpham1.count_VC; j++)
                {
                    output_thucpham_vichat = output_thucpham_vichat + thucpham1.ID_TP[i] + "/" + thucpham1.ID_VC[j] + "/" + thucpham1.luong_TP_VC[i, j] + "\n";
                }
            }

            //MessageBox.Show("" + output_thucpham);
            //MessageBox.Show("" + output_thucpham_vichat);

            TextWriter tsw_monan_thucpham = new StreamWriter("data/database/thucpham.dat");

            TextWriter tsw_monan_thucpham_vichat = new StreamWriter("data/database/thucpham_vichat.dat");

            tsw_monan_thucpham.Write(output_thucpham);
            tsw_monan_thucpham.Close();

            tsw_monan_thucpham_vichat.Write(output_thucpham_vichat);
            tsw_monan_thucpham_vichat.Close();

            MessageBox.Show("Cập nhật thành công");
        }
    }
}
