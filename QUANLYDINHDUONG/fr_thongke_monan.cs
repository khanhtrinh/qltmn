using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class fr_thongke_monan : Form
    {
        public modun_quanli_thucdon_dinhduong nhap_monan_tronghoa = new modun_quanli_thucdon_dinhduong();
        public int current_page = 0;

        public fr_thongke_monan()
        {
            nhap_monan_tronghoa.query_monan();
            nhap_monan_tronghoa.query_vichat();
            nhap_monan_tronghoa.query_thucpham();
            nhap_monan_tronghoa.query_join_monan_thucpham();
            nhap_monan_tronghoa.query_join_thucpham_vichat();
            
            InitializeComponent();
            create_dynamic_module();
        }

        private void create_dynamic_module()
        {
            for (int i = 0; i < 150; i++)
            {
                this.pn_control_thucpham[i] = new System.Windows.Forms.Panel();
                this.bt_remove_thucpham[i] = new System.Windows.Forms.Button();
                this.bt_add_thucpham[i] = new System.Windows.Forms.Button();
                this.flp_monan[i] = new System.Windows.Forms.FlowLayoutPanel();
                this.tb_id_monan[i] = new System.Windows.Forms.TextBox();
                this.tb_name_monan[i] = new System.Windows.Forms.TextBox();
                this.cb_buaan[i] = new System.Windows.Forms.ComboBox();
                this.tb_luong_monan[i] = new System.Windows.Forms.TextBox();
                for (int j = 0; j < 20; j++)
                {
                    this.pn_thucpham[i, j] = new System.Windows.Forms.Panel();
                    this.pn_thucpham[i, j].SuspendLayout();
                    this.tb_luong_thucpham[i, j] = new System.Windows.Forms.TextBox();
                    this.cb_name_thucpham[i, j] = new System.Windows.Forms.ComboBox();
                }
                this.panel9[i] = new System.Windows.Forms.Panel();
                this.bt_remove_monan[i] = new System.Windows.Forms.Button();
                this.bt_add_monan[i] = new System.Windows.Forms.Button();
                this.pn_control_thucpham[i].SuspendLayout();
                this.panel9[i].SuspendLayout();
                this.flp_monan[i].SuspendLayout();
            }
            this.flp_nhap_monan.AutoScroll = true;
            for (int i = 0; i < nhap_monan_tronghoa.count_MA; i++)
            {
                // 
                // flp_monan
                // 
                this.flp_monan[i].Controls.Add(this.tb_id_monan[i]);
                this.flp_monan[i].Controls.Add(this.tb_name_monan[i]);
                this.flp_monan[i].Controls.Add(this.cb_buaan[i]);
                this.flp_monan[i].Controls.Add(this.tb_luong_monan[i]);
                this.flp_monan[i].Controls.Add(this.pn_control_thucpham[i]);
               
                // 
                // tb_id_monan
                // 
                this.tb_id_monan[i].Enabled = false;
                this.tb_id_monan[i].Location = new System.Drawing.Point(3, 3 + 65 * i);
                this.tb_id_monan[i].Name = "tb_id_monan";
                this.tb_id_monan[i].Size = new System.Drawing.Size(29, 20);
                this.tb_id_monan[i].TabIndex = i;
                this.tb_id_monan[i].Text = "" + i;
                // 
                // tb_name_monan
                // 
                this.tb_name_monan[i].Location = new System.Drawing.Point(38, 3);
                this.tb_name_monan[i].Name = "tb_name_monan";
                this.tb_name_monan[i].Size = new System.Drawing.Size(136, 20);
                this.tb_name_monan[i].TabIndex = 12 + i;
                this.tb_name_monan[i].Text = nhap_monan_tronghoa.name_MA[i];
                // 
                // cb_buaan
                // 
                this.cb_buaan[i].FormattingEnabled = true;
                this.cb_buaan[i].Location = new System.Drawing.Point(180, 3);
                this.cb_buaan[i].Name = "cb_buaan";
                this.cb_buaan[i].Size = new System.Drawing.Size(81, 21);
                this.cb_buaan[i].TabIndex = 2;
                this.cb_buaan[i].Text = "" + nhap_monan_tronghoa.type_MA[i];
                this.cb_buaan[i].Items.Add("Sáng chính");
                this.cb_buaan[i].Items.Add("Sáng phụ");
                this.cb_buaan[i].Items.Add("Trưa - Mặn");
                this.cb_buaan[i].Items.Add("Trưa - Canh");
                this.cb_buaan[i].Items.Add("Trưa - TBột");
                this.cb_buaan[i].Items.Add("Chiều phụ");
                // 
                // tb_luong_monan
                // 
                this.tb_luong_monan[i].Location = new System.Drawing.Point(267, 3);
                this.tb_luong_monan[i].Name = "tb_luong_monan";
                this.tb_luong_monan[i].Size = new System.Drawing.Size(81, 20);
                this.tb_luong_monan[i].TabIndex = 3;
                // 
                // pn_control_thucpham
                // 
                this.pn_control_thucpham[i].Controls.Add(this.bt_remove_thucpham[i]);
                this.pn_control_thucpham[i].Controls.Add(this.bt_add_thucpham[i]);
                this.pn_control_thucpham[i].Location = new System.Drawing.Point(354, 3);
                this.pn_control_thucpham[i].Name = "pn_control_thucpham";
                this.pn_control_thucpham[i].Size = new System.Drawing.Size(27, 54);
                this.pn_control_thucpham[i].TabIndex = 13;
                // 
                // bt_remove_thucpham
                // 
                this.bt_remove_thucpham[i].Location = new System.Drawing.Point(4, 30);
                this.bt_remove_thucpham[i].Name = "bt_remove_thucpham";
                this.bt_remove_thucpham[i].Size = new System.Drawing.Size(20, 20);
                this.bt_remove_thucpham[i].TabIndex = 1;
                this.bt_remove_thucpham[i].Text = "-";
                this.bt_remove_thucpham[i].UseVisualStyleBackColor = true;
                this.bt_remove_thucpham[i].Click += new System.EventHandler(this.bt_remove_thucpham_Click);
                // 
                // bt_add_thucpham
                // 
                this.bt_add_thucpham[i].Location = new System.Drawing.Point(4, 3);
                this.bt_add_thucpham[i].Name = "bt_add_thucpham";
                this.bt_add_thucpham[i].Size = new System.Drawing.Size(20, 21);
                this.bt_add_thucpham[i].TabIndex = 0;
                this.bt_add_thucpham[i].Text = "+";
                this.bt_add_thucpham[i].UseVisualStyleBackColor = true;
                this.bt_add_thucpham[i].Click += new System.EventHandler(this.bt_add_thucpham_Click);

                int count_tp = 0;
                for (int j = 0; j < nhap_monan_tronghoa.count_TP; j++)
                {
                    if (nhap_monan_tronghoa.luong_MA_TP[i, j] != 0)
                    {
                        // 
                        // pn_thucpham
                        // 
                        this.pn_thucpham[i, count_tp].Controls.Add(this.tb_luong_thucpham[i, count_tp]);
                        this.pn_thucpham[i, count_tp].Controls.Add(this.cb_name_thucpham[i, count_tp]);
                        this.pn_thucpham[i, count_tp].Location = new System.Drawing.Point(387, 3);
                        this.pn_thucpham[i, count_tp].Name = "pn_thucpham";
                        this.pn_thucpham[i, count_tp].Size = new System.Drawing.Size(88, 54);
                        this.pn_thucpham[i, count_tp].TabIndex = 4;
                        // 
                        // tb_luong_thucpham
                        // 
                        this.tb_luong_thucpham[i, count_tp].Location = new System.Drawing.Point(4, 30);
                        this.tb_luong_thucpham[i, count_tp].Name = "tb_luong_thucpham";
                        this.tb_luong_thucpham[i, count_tp].Size = new System.Drawing.Size(81, 20);
                        this.tb_luong_thucpham[i, count_tp].TabIndex = 4;
                        this.tb_luong_thucpham[i, count_tp].Text = nhap_monan_tronghoa.luong_MA_TP[i, j] + "";
                        // 
                        // cb_name_thucpham
                        // 
                        this.cb_name_thucpham[i, count_tp].FormattingEnabled = true;
                        this.cb_name_thucpham[i, count_tp].Location = new System.Drawing.Point(3, 3);
                        this.cb_name_thucpham[i, count_tp].Name = "cb_name_thucpham";
                        this.cb_name_thucpham[i, count_tp].Size = new System.Drawing.Size(81, 21);
                        this.cb_name_thucpham[i, count_tp].TabIndex = 3;
                        this.cb_name_thucpham[i, count_tp].Text = nhap_monan_tronghoa.name_TP[j];
                        for (int t = 0; t < nhap_monan_tronghoa.count_TP; t++)
                        {
                            this.cb_name_thucpham[i, count_tp].Items.Add(nhap_monan_tronghoa.name_TP[t]);
                        }
                        this.flp_monan[i].Controls.Add(this.pn_thucpham[i, count_tp]);
                        count_tp++;
                        //MessageBox.Show(nhap_monan_tronghoa.name_TP[j]);
                    }

                }
                //MessageBox.Show(count_tp + "");
                // 
                // panel9
                // 
                this.panel9[i].Controls.Add(this.bt_remove_monan[i]);
                this.panel9[i].Controls.Add(this.bt_add_monan[i]);
                this.panel9[i].Location = new System.Drawing.Point(1152, 3 + 65 * i);
                this.panel9[i].Name = "panel9";
                this.panel9[i].Size = new System.Drawing.Size(27, 60);
                this.panel9[i].TabIndex = 1;
                // 
                // bt_remove_monan
                // 
                this.bt_remove_monan[i].Location = new System.Drawing.Point(3, 34);
                this.bt_remove_monan[i].Name = "bt_remove_monan";
                this.bt_remove_monan[i].Size = new System.Drawing.Size(20, 23);
                this.bt_remove_monan[i].TabIndex = 2;
                this.bt_remove_monan[i].Text = "-";
                this.bt_remove_monan[i].UseVisualStyleBackColor = true;
                this.bt_remove_monan[i].Click += new System.EventHandler(this.bt_remove_monan_Click);
                // 
                // bt_add_monan
                // 
                this.bt_add_monan[i].Location = new System.Drawing.Point(3, 6);
                this.bt_add_monan[i].Name = "bt_add_monan";
                this.bt_add_monan[i].Size = new System.Drawing.Size(20, 23);
                this.bt_add_monan[i].TabIndex = 1;
                this.bt_add_monan[i].Text = "+";
                this.bt_add_monan[i].UseVisualStyleBackColor = true;
                this.bt_add_monan[i].Click += new System.EventHandler(this.bt_add_monan_Click);
                this.flp_monan[i].ResumeLayout(false);
                this.flp_monan[i].PerformLayout();
                this.pn_control_thucpham[i].ResumeLayout(false);
                for (int j = 0; j < count_tp; j++)
                {
                    this.pn_thucpham[i, j].ResumeLayout(false);
                    this.pn_thucpham[i, j].PerformLayout();
                }
                this.panel9[i].ResumeLayout(false);
                this.flp_nhap_monan.Controls.Add(this.flp_monan[i]);
                //MessageBox.Show("Thông tin đã được lưu" + i, "Thông báo");
                this.flp_nhap_monan.Controls.Add(this.panel9[i]);
                /* for (int j = 0; j < count_tp; j++)
                {
                    this.flp_monan[i].Controls.Add(this.pn_thucpham[i, j]);
                }*/
                this.flp_monan[i].Location = new System.Drawing.Point(3, 3 + 65 * i);
                this.flp_monan[i].Name = "flp_monan";
                this.flp_monan[i].Size = new System.Drawing.Size(1143, 60);
                this.flp_monan[i].TabIndex = i;
                
            }

            // 
            // head_line_nhap
            // 
            this.head_line_nhap.AutoSize = true;
            this.head_line_nhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head_line_nhap.ForeColor = System.Drawing.Color.Brown;
            this.head_line_nhap.Location = new System.Drawing.Point(385, 9);
            this.head_line_nhap.Name = "head_line_nhap";
            this.head_line_nhap.Size = new System.Drawing.Size(449, 19);
            this.head_line_nhap.TabIndex = 0;
            this.head_line_nhap.Text = "NHẬP THÔNG TIN CHO CÁC THỰC ĐƠN TRONG TRƯỜNG";
        }

        private void bt_remove_thucpham_Click(object sender, EventArgs e)
        {

        }

        private void bt_remove_monan_Click(object sender, EventArgs e)
        {

        }

        private void bt_add_thucpham_Click(object sender, EventArgs e)
        {

        }

        private void bt_add_monan_Click(object sender, EventArgs e)
        {

        }

        private void bt_main_form_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.count_nhap_td++;
            Program.th_nhap_td[Program.count_nhap_td].Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.count_mb++;
            Program.th_mb[Program.count_mb].Start();
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (current_page != 0)
            {
                current_page--;
            }
        }

        private void go_Click(object sender, EventArgs e)
        {
            if (current_page != nhap_monan_tronghoa.count_MA)
            {
                current_page++;
            }
        }

    }

}
