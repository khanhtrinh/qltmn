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
    public partial class fr_nhap_thucdon : Form
    {
        public modun_quanli_thucdon_dinhduong nhap_monan_tronghoa = new modun_quanli_thucdon_dinhduong();

        public fr_nhap_thucdon()
        {
            nhap_monan_tronghoa.query_monan();
            nhap_monan_tronghoa.query_vichat();
            nhap_monan_tronghoa.query_thucpham();
            
            InitializeComponent();
            //this.tb_name_monan[0].Focus();
            create_dynamic_module();
            this.tb_name_monan[0].Focus();
            //this.bt_sumit.Focused = false;
        }

        private void bt_add_thucpham_Click(object sender, EventArgs e)
        {
            if (this.cb_name_thucpham[num_monan, number_thucpham[num_monan]].Text != "" && this.tb_luong_thucpham[num_monan, number_thucpham[num_monan]].Text != "")
            {
                number_thucpham[num_monan]++;
                // 
                // pn_thucpham
                // 
                this.pn_thucpham[num_monan, number_thucpham[num_monan]].Controls.Add(this.tb_luong_thucpham[num_monan, number_thucpham[num_monan]]);
                this.pn_thucpham[num_monan, number_thucpham[num_monan]].Controls.Add(this.cb_name_thucpham[num_monan, number_thucpham[num_monan]]);
                this.pn_thucpham[num_monan, number_thucpham[num_monan]].Location = new System.Drawing.Point(387, 3);
                this.pn_thucpham[num_monan, number_thucpham[num_monan]].Name = "pn_thucpham";
                this.pn_thucpham[num_monan, number_thucpham[num_monan]].Size = new System.Drawing.Size(88, 54);
                this.pn_thucpham[num_monan, number_thucpham[num_monan]].TabIndex = 4;
                // 
                // tb_luong_thucpham        
                // 
                this.tb_luong_thucpham[num_monan, number_thucpham[num_monan]].Location = new System.Drawing.Point(4, 30);
                this.tb_luong_thucpham[num_monan, number_thucpham[num_monan]].Name = "tb_luong_thucpham";
                this.tb_luong_thucpham[num_monan, number_thucpham[num_monan]].Size = new System.Drawing.Size(81, 20);
                this.tb_luong_thucpham[num_monan, number_thucpham[num_monan]].Text = 0 + "";
                this.tb_luong_thucpham[num_monan, number_thucpham[num_monan]].TabIndex = 4;
                this.tb_luong_thucpham[num_monan, number_thucpham[num_monan]].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press_addnew_tb);
                // 
                // cb_name_thucpham
                // 
                this.cb_name_thucpham[num_monan, number_thucpham[num_monan]].FormattingEnabled = true;
                this.cb_name_thucpham[num_monan, number_thucpham[num_monan]].Location = new System.Drawing.Point(3, 3);
                this.cb_name_thucpham[num_monan, number_thucpham[num_monan]].Name = "cb_name_thucpham";
                this.cb_name_thucpham[num_monan, number_thucpham[num_monan]].Size = new System.Drawing.Size(81, 21);
                this.cb_name_thucpham[num_monan, number_thucpham[num_monan]].TabIndex = 3;
                this.cb_name_thucpham[num_monan, number_thucpham[num_monan]].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press_addnew_cb);
                for (int t = 0; t < nhap_monan_tronghoa.count_TP; t++)
                {
                    this.cb_name_thucpham[num_monan, number_thucpham[num_monan]].Items.Add(nhap_monan_tronghoa.name_TP[t]);
                }
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin trước khi thêm mới !!!");
            }
        }

        private void bt_remove_thucpham_Click(object sender, EventArgs e)
        {

        }

        private void bt_add_monan_Click(object sender, EventArgs e)
        {
            if (this.tb_name_monan[num_monan].Text != "")
            {
                this.bt_add_monan[num_monan].Enabled = false;
                this.bt_add_thucpham[num_monan].Enabled = false;
                this.bt_remove_thucpham[num_monan].Enabled = false;
                num_monan++;
                this.flp_nhap_monan.Controls.Add(this.flp_monan[num_monan]);
                //MessageBox.Show("Thông tin đã được lưu" + i, "Thông báo");
                this.flp_nhap_monan.Controls.Add(this.panel9[num_monan]);
                // 
                // flp_monan
                // 
                this.flp_monan[num_monan].Controls.Add(this.tb_id_monan[num_monan]);
                this.flp_monan[num_monan].Controls.Add(this.tb_name_monan[num_monan]);
                this.flp_monan[num_monan].Controls.Add(this.cb_buaan[num_monan]);
                this.flp_monan[num_monan].Controls.Add(this.tb_luong_monan[num_monan]);
                this.flp_monan[num_monan].Controls.Add(this.pn_control_thucpham[num_monan]);
                for (int j = 0; j < 8; j++) { this.flp_monan[num_monan].Controls.Add(this.pn_thucpham[num_monan, j]); }
                this.flp_monan[num_monan].Location = new System.Drawing.Point(3, 3 + 65 * num_monan);
                this.flp_monan[num_monan].Name = "flp_monan";
                this.flp_monan[num_monan].Size = new System.Drawing.Size(1143, 60);
                this.flp_monan[num_monan].TabIndex = num_monan;
                // 
                // tb_id_monan
                // 
                this.tb_id_monan[num_monan].Enabled = false;
                this.tb_id_monan[num_monan].Location = new System.Drawing.Point(3, 3 + 65 * num_monan);
                this.tb_id_monan[num_monan].Name = "tb_id_monan";
                this.tb_id_monan[num_monan].Size = new System.Drawing.Size(29, 20);
                this.tb_id_monan[num_monan].TabIndex = num_monan;
                this.tb_id_monan[num_monan].Text = "" + num_monan;
                // 
                // tb_name_monan
                // 
                this.tb_name_monan[num_monan].Location = new System.Drawing.Point(38, 3);
                this.tb_name_monan[num_monan].Name = "tb_name_monan";
                this.tb_name_monan[num_monan].Size = new System.Drawing.Size(136, 20);
                this.tb_name_monan[num_monan].TabIndex = 12 + num_monan;
                // 
                // cb_buaan
                // 
                this.cb_buaan[num_monan].FormattingEnabled = true;
                this.cb_buaan[num_monan].Location = new System.Drawing.Point(180, 3);
                this.cb_buaan[num_monan].Name = "cb_buaan";
                this.cb_buaan[num_monan].Size = new System.Drawing.Size(81, 21);
                this.cb_buaan[num_monan].TabIndex = 2;
                this.cb_buaan[num_monan].Items.Add("Sáng chính");
                this.cb_buaan[num_monan].Items.Add("Sáng phụ");
                this.cb_buaan[num_monan].Items.Add("Trưa - Mặn");
                this.cb_buaan[num_monan].Items.Add("Trưa - Canh");
                this.cb_buaan[num_monan].Items.Add("Trưa - TBột");
                this.cb_buaan[num_monan].Items.Add("Chiều phụ");
                // 
                // tb_luong_monan
                // 
                this.tb_luong_monan[num_monan].Location = new System.Drawing.Point(267, 3);
                this.tb_luong_monan[num_monan].Name = "tb_luong_monan";
                this.tb_luong_monan[num_monan].Size = new System.Drawing.Size(81, 20);
                this.tb_luong_monan[num_monan].TabIndex = 3;
                
                // 
                // pn_control_thucpham
                // 
                this.pn_control_thucpham[num_monan].Controls.Add(this.bt_remove_thucpham[num_monan]);
                this.pn_control_thucpham[num_monan].Controls.Add(this.bt_add_thucpham[num_monan]);
                this.pn_control_thucpham[num_monan].Location = new System.Drawing.Point(354, 3);
                this.pn_control_thucpham[num_monan].Name = "pn_control_thucpham";
                this.pn_control_thucpham[num_monan].Size = new System.Drawing.Size(27, 54);
                this.pn_control_thucpham[num_monan].TabIndex = 13;
                // 
                // bt_remove_thucpham
                // 
                this.bt_remove_thucpham[num_monan].Location = new System.Drawing.Point(4, 30);
                this.bt_remove_thucpham[num_monan].Name = "bt_remove_thucpham";
                this.bt_remove_thucpham[num_monan].Size = new System.Drawing.Size(20, 20);
                this.bt_remove_thucpham[num_monan].TabIndex = 1;
                this.bt_remove_thucpham[num_monan].Text = "-";
                this.bt_remove_thucpham[num_monan].UseVisualStyleBackColor = true;
                this.bt_remove_thucpham[num_monan].Click += new System.EventHandler(this.bt_remove_thucpham_Click);
                // 
                // bt_add_thucpham
                // 
                this.bt_add_thucpham[num_monan].Location = new System.Drawing.Point(4, 3);
                this.bt_add_thucpham[num_monan].Name = "bt_add_thucpham";
                this.bt_add_thucpham[num_monan].Size = new System.Drawing.Size(20, 21);
                this.bt_add_thucpham[num_monan].TabIndex = 0;
                this.bt_add_thucpham[num_monan].Text = "+";
                this.bt_add_thucpham[num_monan].UseVisualStyleBackColor = true;
                this.bt_add_thucpham[num_monan].Click += new System.EventHandler(this.bt_add_thucpham_Click);
                for (int j = 0; j < 1; j++)
                {
                    // 
                    // pn_thucpham
                    // 
                    this.pn_thucpham[num_monan, j].Controls.Add(this.tb_luong_thucpham[num_monan, j]);
                    this.pn_thucpham[num_monan, j].Controls.Add(this.cb_name_thucpham[num_monan, j]);
                    this.pn_thucpham[num_monan, j].Location = new System.Drawing.Point(387, 3);
                    this.pn_thucpham[num_monan, j].Name = "pn_thucpham";
                    this.pn_thucpham[num_monan, j].Size = new System.Drawing.Size(88, 54);
                    this.pn_thucpham[num_monan, j].TabIndex = 4;
                    // 
                    // tb_luong_thucpham
                    // 
                    this.tb_luong_thucpham[num_monan, j].Location = new System.Drawing.Point(4, 30);
                    this.tb_luong_thucpham[num_monan, j].Name = "tb_luong_thucpham";
                    this.tb_luong_thucpham[num_monan, j].Size = new System.Drawing.Size(81, 20);
                    this.tb_luong_thucpham[num_monan, j].TabIndex = 4;
                    this.tb_luong_thucpham[num_monan, j].Text = 0 + "";
                    this.tb_luong_thucpham[num_monan, j].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press_addnew_tb);
                    // 
                    // cb_name_thucpham
                    // 
                    this.cb_name_thucpham[num_monan, j].FormattingEnabled = true;
                    this.cb_name_thucpham[num_monan, j].Location = new System.Drawing.Point(3, 3);
                    this.cb_name_thucpham[num_monan, j].Name = "cb_name_thucpham";
                    this.cb_name_thucpham[num_monan, j].Size = new System.Drawing.Size(81, 21);
                    this.cb_name_thucpham[num_monan, j].TabIndex = 3;
                    this.cb_name_thucpham[num_monan, j].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press_addnew_cb);
                
                    for (int t = 0; t < nhap_monan_tronghoa.count_TP; t++)
                    {
                        this.cb_name_thucpham[num_monan, j].Items.Add(nhap_monan_tronghoa.name_TP[t]);
                    }
                }

                // 
                // panel9
                // 
                this.panel9[num_monan].Controls.Add(this.bt_remove_monan[num_monan]);
                this.panel9[num_monan].Controls.Add(this.bt_add_monan[num_monan]);
                this.panel9[num_monan].Location = new System.Drawing.Point(1152, 3 + 65 * num_monan);
                this.panel9[num_monan].Name = "panel9";
                this.panel9[num_monan].Size = new System.Drawing.Size(27, 60);
                this.panel9[num_monan].TabIndex = 1;
                // 
                // bt_remove_monan
                // 
                this.bt_remove_monan[num_monan].Location = new System.Drawing.Point(3, 34);
                this.bt_remove_monan[num_monan].Name = "bt_remove_monan";
                this.bt_remove_monan[num_monan].Size = new System.Drawing.Size(20, 23);
                this.bt_remove_monan[num_monan].TabIndex = 2;
                this.bt_remove_monan[num_monan].Text = "-";
                this.bt_remove_monan[num_monan].UseVisualStyleBackColor = true;
                this.bt_remove_monan[num_monan].Click += new System.EventHandler(this.bt_remove_monan_Click);
                // 
                // bt_add_monan
                // 
                this.bt_add_monan[num_monan].Location = new System.Drawing.Point(3, 6);
                this.bt_add_monan[num_monan].Name = "bt_add_monan";
                this.bt_add_monan[num_monan].Size = new System.Drawing.Size(20, 23);
                this.bt_add_monan[num_monan].TabIndex = 1;
                this.bt_add_monan[num_monan].Text = "+";
                this.bt_add_monan[num_monan].UseVisualStyleBackColor = true;
                this.bt_add_monan[num_monan].Click += new System.EventHandler(this.bt_add_monan_Click);
                this.flp_monan[num_monan].ResumeLayout(false);
                this.flp_monan[num_monan].PerformLayout();
                this.pn_control_thucpham[num_monan].ResumeLayout(false);
                for (int j = 0; j < 8; j++)
                {
                    this.pn_thucpham[num_monan, j].ResumeLayout(false);
                    this.pn_thucpham[num_monan, j].PerformLayout();
                }
                this.panel9[num_monan].ResumeLayout(false);
            }
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin trước khi thêm mới");
            }
        }

        private void bt_remove_monan_Click(object sender, EventArgs e)
        {

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {

        }

        private void bt_sumit_Click(object sender, EventArgs e)
        {
            if (this.tb_name_monan[this.num_monan].Text != "" && this.tb_luong_monan[this.num_monan].Text != "")
            {
                string result_monan_thucpham = "";
                FileInfo f6 = new FileInfo("data/database/monan_thucpham.dat");
                if (f6.Exists == true)
                {
                    StreamReader sr6 = File.OpenText("data/database/monan_thucpham.dat");
                    string input = null;
                    while ((input = sr6.ReadLine()) != null)
                    {
                        result_monan_thucpham = result_monan_thucpham + input + "\n";
                    }
                    sr6.Close();
                }

                //Creating some new stream-writer and opening the file.

                string results_monan = "";
                for (int i = 0; i < nhap_monan_tronghoa.count_MA; i++)
                {
                    results_monan = results_monan + nhap_monan_tronghoa.ID_MA[i] + "/" + nhap_monan_tronghoa.name_MA[i] + "/" + nhap_monan_tronghoa.type_MA[i] + "/" + nhap_monan_tronghoa.luong_MA_chuan[i] + "\n";
                }

                int[,] id_tp_use = new int[100, 100];
                //MessageBox.Show("" + nhap_monan_tronghoa.count_MA);
                for (int i = 0; i <= num_monan; i++)
                {
                    int id_monan = nhap_monan_tronghoa.ID_MA[nhap_monan_tronghoa.count_MA - 1] + i + 1;
                    //MessageBox.Show("" + nhap_monan_tronghoa.name_MA[0]);
                    results_monan = results_monan + id_monan + "/" + tb_name_monan[i].Text + "/";
                    string type_monan = "";
                    if (cb_buaan[i].Text == "Sáng chính")
                    {
                        type_monan = "pam";
                    }
                    else if (cb_buaan[i].Text == "Sáng phụ")
                    {
                        type_monan = "eam";
                    }
                    else if (cb_buaan[i].Text == "Trưa - Mặn")
                    {
                        type_monan = "ppm1";
                    }
                    else if (cb_buaan[i].Text == "Trưa - Canh")
                    {
                        type_monan = "ppm2";
                    }
                    else if (cb_buaan[i].Text == "Trưa - TBột")
                    {
                        type_monan = "ppm3";
                    }
                    if (cb_buaan[i].Text == "Chiều phụ")
                    {
                        type_monan = "epm";
                    }
                    results_monan = results_monan + type_monan + "/" + tb_luong_monan[i].Text + "\n";
                    for (int j = 0; j <= number_thucpham[i]; j++)
                    {
                        for (int t = 0; t < nhap_monan_tronghoa.count_TP; t++)
                        {
                            //MessageBox.Show(nhap_monan_tronghoa.name_TP[t], cb_name_thucpham[i, j].SelectedItem.ToString());
                            if (nhap_monan_tronghoa.name_TP[t] == cb_name_thucpham[i, j].SelectedItem.ToString())
                            {
                                result_monan_thucpham = result_monan_thucpham + id_monan + "/" + nhap_monan_tronghoa.ID_TP[t] + "/" + tb_luong_thucpham[i, j].Text + "\n";
                            }
                        }
                    }
                }

                TextWriter tsw_monan_thucpham2 = new StreamWriter("data/database/monan.dat");

                TextWriter tsw_monan_thucpham1 = new StreamWriter("data/database/monan_thucpham.dat");

                //Writing text to the file.
                if (result_monan_thucpham != null)
                {
                    tsw_monan_thucpham1.Write(result_monan_thucpham);
                }
                //Close the file.

                tsw_monan_thucpham1.Close();

                tsw_monan_thucpham2.Write(results_monan);

                tsw_monan_thucpham2.Close();

                MessageBox.Show("Thông tin đã được lưu, xin cảm ơn !!!");
                Program.count_thongke_mon++;
                Program.th_thongke_monan[Program.count_thongke_mon].Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Không thể lưu vì chưa nhập thông tin nào cho chương trình !!!");
                this.tb_name_monan[num_monan].Focus();
            }
        }

        private void create_dynamic_module()
        {
            for (int i = 0; i < 15; i++)
            {
                this.pn_control_thucpham[i] = new System.Windows.Forms.Panel();
                this.bt_remove_thucpham[i] = new System.Windows.Forms.Button();
                this.bt_add_thucpham[i] = new System.Windows.Forms.Button();
                this.flp_monan[i] = new System.Windows.Forms.FlowLayoutPanel();
                this.tb_id_monan[i] = new System.Windows.Forms.TextBox();
                this.tb_name_monan[i] = new System.Windows.Forms.TextBox();
                this.cb_buaan[i] = new System.Windows.Forms.ComboBox();
                this.tb_luong_monan[i] = new System.Windows.Forms.TextBox();
                for (int j = 0; j < 8; j++)
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
            for (int i = 0; i < 1; i++)
            {
                this.flp_nhap_monan.Controls.Add(this.flp_monan[i]);
                //MessageBox.Show("Thông tin đã được lưu" + i, "Thông báo");
                this.flp_nhap_monan.Controls.Add(this.panel9[i]);
                // 
                // flp_monan
                // 
                this.flp_monan[i].Controls.Add(this.tb_id_monan[i]);
                this.flp_monan[i].Controls.Add(this.tb_name_monan[i]);
                this.flp_monan[i].Controls.Add(this.cb_buaan[i]);
                this.flp_monan[i].Controls.Add(this.tb_luong_monan[i]);
                this.flp_monan[i].Controls.Add(this.pn_control_thucpham[i]);
                for (int j = 0; j < 8; j++) { this.flp_monan[i].Controls.Add(this.pn_thucpham[i, j]); }
                this.flp_monan[i].Location = new System.Drawing.Point(3, 3 + 65 * i);
                this.flp_monan[i].Name = "flp_monan";
                this.flp_monan[i].Size = new System.Drawing.Size(1143, 60);
                this.flp_monan[i].TabIndex = i;
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
                // 
                // cb_buaan
                // 
                this.cb_buaan[i].FormattingEnabled = true;
                this.cb_buaan[i].Location = new System.Drawing.Point(180, 3);
                this.cb_buaan[i].Name = "cb_buaan";
                this.cb_buaan[i].Size = new System.Drawing.Size(81, 21);
                this.cb_buaan[i].TabIndex = 2;
                this.cb_buaan[i].Text = "Sáng chính";
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
                for (int j = 0; j < 1; j++)
                {
                    // 
                    // pn_thucpham
                    // 
                    this.pn_thucpham[i, j].Controls.Add(this.tb_luong_thucpham[i, j]);
                    this.pn_thucpham[i, j].Controls.Add(this.cb_name_thucpham[i, j]);
                    this.pn_thucpham[i, j].Location = new System.Drawing.Point(387, 3);
                    this.pn_thucpham[i, j].Name = "pn_thucpham";
                    this.pn_thucpham[i, j].Size = new System.Drawing.Size(88, 54);
                    this.pn_thucpham[i, j].TabIndex = 4;
                    // 
                    // tb_luong_thucpham
                    // 
                    this.tb_luong_thucpham[i, j].Location = new System.Drawing.Point(4, 30);
                    this.tb_luong_thucpham[i, j].Name = "tb_luong_thucpham";
                    this.tb_luong_thucpham[i, j].Size = new System.Drawing.Size(81, 20);
                    this.tb_luong_thucpham[i, j].TabIndex = 4;
                    this.tb_luong_thucpham[i, j].Text = 0 + "";
                    this.tb_luong_thucpham[i, j].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press_addnew_tb);
                    // 
                    // cb_name_thucpham
                    // 
                    this.cb_name_thucpham[i, j].FormattingEnabled = true;
                    this.cb_name_thucpham[i, j].Location = new System.Drawing.Point(3, 3);
                    this.cb_name_thucpham[i, j].Name = "cb_name_thucpham";
                    this.cb_name_thucpham[i, j].Size = new System.Drawing.Size(81, 21);
                    this.cb_name_thucpham[i, j].TabIndex = 3;
                    this.cb_name_thucpham[i, j].Text = nhap_monan_tronghoa.name_TP[0];
                    this.cb_name_thucpham[i, j].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press_addnew_cb);
                
                    for (int t = 0; t < nhap_monan_tronghoa.count_TP; t++)
                    {
                        this.cb_name_thucpham[i, j].Items.Add(nhap_monan_tronghoa.name_TP[t]);
                    }
                }

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
                for (int j = 0; j < 8; j++)
                {
                    this.pn_thucpham[i, j].ResumeLayout(false);
                    this.pn_thucpham[i, j].PerformLayout();
                }
                this.panel9[i].ResumeLayout(true);
                this.tb_name_monan[0].Focus();

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

        private void bt_main_form_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.count_mb++;
            Program.th_mb[Program.count_mb].Start();
        }

        private void key_press_addnew_cb(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13 && Control.ModifierKeys != Keys.Shift)
            {
                this.tb_luong_thucpham[num_monan, number_thucpham[num_monan]].Focus();
            }
        }

        private void key_press_addnew_tb(object sender, KeyPressEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift && e.KeyChar == (char)13)
            {
                if (this.tb_name_monan[num_monan].Text != "")
                {
                    this.bt_add_monan[num_monan].Enabled = false;
                    this.bt_add_thucpham[num_monan].Enabled = false;
                    this.bt_remove_thucpham[num_monan].Enabled = false;
                    num_monan++;
                    this.flp_nhap_monan.Controls.Add(this.flp_monan[num_monan]);
                    //MessageBox.Show("Thông tin đã được lưu" + i, "Thông báo");
                    this.flp_nhap_monan.Controls.Add(this.panel9[num_monan]);
                    // 
                    // flp_monan
                    // 
                    this.flp_monan[num_monan].Controls.Add(this.tb_id_monan[num_monan]);
                    this.flp_monan[num_monan].Controls.Add(this.tb_name_monan[num_monan]);
                    this.flp_monan[num_monan].Controls.Add(this.cb_buaan[num_monan]);
                    this.flp_monan[num_monan].Controls.Add(this.tb_luong_monan[num_monan]);
                    this.flp_monan[num_monan].Controls.Add(this.pn_control_thucpham[num_monan]);
                    for (int j = 0; j < 8; j++) { this.flp_monan[num_monan].Controls.Add(this.pn_thucpham[num_monan, j]); }
                    this.flp_monan[num_monan].Location = new System.Drawing.Point(3, 3 + 65 * num_monan);
                    this.flp_monan[num_monan].Name = "flp_monan";
                    this.flp_monan[num_monan].Size = new System.Drawing.Size(1143, 60);
                    this.flp_monan[num_monan].TabIndex = num_monan;
                    // 
                    // tb_id_monan
                    // 
                    this.tb_id_monan[num_monan].Enabled = false;
                    this.tb_id_monan[num_monan].Location = new System.Drawing.Point(3, 3 + 65 * num_monan);
                    this.tb_id_monan[num_monan].Name = "tb_id_monan";
                    this.tb_id_monan[num_monan].Size = new System.Drawing.Size(29, 20);
                    this.tb_id_monan[num_monan].TabIndex = num_monan;
                    this.tb_id_monan[num_monan].Text = "" + num_monan;
                    // 
                    // tb_name_monan
                    // 
                    this.tb_name_monan[num_monan].Location = new System.Drawing.Point(38, 3);
                    this.tb_name_monan[num_monan].Name = "tb_name_monan";
                    this.tb_name_monan[num_monan].Size = new System.Drawing.Size(136, 20);
                    this.tb_name_monan[num_monan].TabIndex = 12 + num_monan;
                    // 
                    // cb_buaan
                    // 
                    this.cb_buaan[num_monan].FormattingEnabled = true;
                    this.cb_buaan[num_monan].Location = new System.Drawing.Point(180, 3);
                    this.cb_buaan[num_monan].Name = "cb_buaan";
                    this.cb_buaan[num_monan].Size = new System.Drawing.Size(81, 21);
                    this.cb_buaan[num_monan].TabIndex = 2;
                    this.cb_buaan[num_monan].Items.Add("Sáng chính");
                    this.cb_buaan[num_monan].Items.Add("Sáng phụ");
                    this.cb_buaan[num_monan].Items.Add("Trưa - Mặn");
                    this.cb_buaan[num_monan].Items.Add("Trưa - Canh");
                    this.cb_buaan[num_monan].Items.Add("Trưa - TBột");
                    this.cb_buaan[num_monan].Items.Add("Chiều phụ");
                    // 
                    // tb_luong_monan
                    // 
                    this.tb_luong_monan[num_monan].Location = new System.Drawing.Point(267, 3);
                    this.tb_luong_monan[num_monan].Name = "tb_luong_monan";
                    this.tb_luong_monan[num_monan].Size = new System.Drawing.Size(81, 20);
                    this.tb_luong_monan[num_monan].TabIndex = 3;
                    // 
                    // pn_control_thucpham
                    // 
                    this.pn_control_thucpham[num_monan].Controls.Add(this.bt_remove_thucpham[num_monan]);
                    this.pn_control_thucpham[num_monan].Controls.Add(this.bt_add_thucpham[num_monan]);
                    this.pn_control_thucpham[num_monan].Location = new System.Drawing.Point(354, 3);
                    this.pn_control_thucpham[num_monan].Name = "pn_control_thucpham";
                    this.pn_control_thucpham[num_monan].Size = new System.Drawing.Size(27, 54);
                    this.pn_control_thucpham[num_monan].TabIndex = 13;
                    // 
                    // bt_remove_thucpham
                    // 
                    this.bt_remove_thucpham[num_monan].Location = new System.Drawing.Point(4, 30);
                    this.bt_remove_thucpham[num_monan].Name = "bt_remove_thucpham";
                    this.bt_remove_thucpham[num_monan].Size = new System.Drawing.Size(20, 20);
                    this.bt_remove_thucpham[num_monan].TabIndex = 1;
                    this.bt_remove_thucpham[num_monan].Text = "-";
                    this.bt_remove_thucpham[num_monan].UseVisualStyleBackColor = true;
                    this.bt_remove_thucpham[num_monan].Click += new System.EventHandler(this.bt_remove_thucpham_Click);
                    // 
                    // bt_add_thucpham
                    // 
                    this.bt_add_thucpham[num_monan].Location = new System.Drawing.Point(4, 3);
                    this.bt_add_thucpham[num_monan].Name = "bt_add_thucpham";
                    this.bt_add_thucpham[num_monan].Size = new System.Drawing.Size(20, 21);
                    this.bt_add_thucpham[num_monan].TabIndex = 0;
                    this.bt_add_thucpham[num_monan].Text = "+";
                    this.bt_add_thucpham[num_monan].UseVisualStyleBackColor = true;
                    this.bt_add_thucpham[num_monan].Click += new System.EventHandler(this.bt_add_thucpham_Click);
                    for (int j = 0; j < 1; j++)
                    {
                        // 
                        // pn_thucpham
                        // 
                        this.pn_thucpham[num_monan, j].Controls.Add(this.tb_luong_thucpham[num_monan, j]);
                        this.pn_thucpham[num_monan, j].Controls.Add(this.cb_name_thucpham[num_monan, j]);
                        this.pn_thucpham[num_monan, j].Location = new System.Drawing.Point(387, 3);
                        this.pn_thucpham[num_monan, j].Name = "pn_thucpham";
                        this.pn_thucpham[num_monan, j].Size = new System.Drawing.Size(88, 54);
                        this.pn_thucpham[num_monan, j].TabIndex = 4;
                        // 
                        // tb_luong_thucpham
                        // 
                        this.tb_luong_thucpham[num_monan, j].Location = new System.Drawing.Point(4, 30);
                        this.tb_luong_thucpham[num_monan, j].Name = "tb_luong_thucpham";
                        this.tb_luong_thucpham[num_monan, j].Size = new System.Drawing.Size(81, 20);
                        this.tb_luong_thucpham[num_monan, j].TabIndex = 4;
                        this.tb_luong_thucpham[num_monan, j].Text = 0 + "";
                        this.tb_luong_thucpham[num_monan, j].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press_addnew_tb);
                        // 
                        // cb_name_thucpham
                        // 
                        this.cb_name_thucpham[num_monan, j].FormattingEnabled = true;
                        this.cb_name_thucpham[num_monan, j].Location = new System.Drawing.Point(3, 3);
                        this.cb_name_thucpham[num_monan, j].Name = "cb_name_thucpham";
                        this.cb_name_thucpham[num_monan, j].Size = new System.Drawing.Size(81, 21);
                        this.cb_name_thucpham[num_monan, j].Text = nhap_monan_tronghoa.name_TP[0];
                        this.cb_name_thucpham[num_monan, j].TabIndex = 3;
                        this.cb_name_thucpham[num_monan, j].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press_addnew_cb);

                        for (int t = 0; t < nhap_monan_tronghoa.count_TP; t++)
                        {
                            this.cb_name_thucpham[num_monan, j].Items.Add(nhap_monan_tronghoa.name_TP[t]);
                        }
                    }

                    // 
                    // panel9
                    // 
                    this.panel9[num_monan].Controls.Add(this.bt_remove_monan[num_monan]);
                    this.panel9[num_monan].Controls.Add(this.bt_add_monan[num_monan]);
                    this.panel9[num_monan].Location = new System.Drawing.Point(1152, 3 + 65 * num_monan);
                    this.panel9[num_monan].Name = "panel9";
                    this.panel9[num_monan].Size = new System.Drawing.Size(27, 60);
                    this.panel9[num_monan].TabIndex = 1;
                    // 
                    // bt_remove_monan
                    // 
                    this.bt_remove_monan[num_monan].Location = new System.Drawing.Point(3, 34);
                    this.bt_remove_monan[num_monan].Name = "bt_remove_monan";
                    this.bt_remove_monan[num_monan].Size = new System.Drawing.Size(20, 23);
                    this.bt_remove_monan[num_monan].TabIndex = 2;
                    this.bt_remove_monan[num_monan].Text = "-";
                    this.bt_remove_monan[num_monan].UseVisualStyleBackColor = true;
                    this.bt_remove_monan[num_monan].Click += new System.EventHandler(this.bt_remove_monan_Click);
                    // 
                    // bt_add_monan
                    // 
                    this.bt_add_monan[num_monan].Location = new System.Drawing.Point(3, 6);
                    this.bt_add_monan[num_monan].Name = "bt_add_monan";
                    this.bt_add_monan[num_monan].Size = new System.Drawing.Size(20, 23);
                    this.bt_add_monan[num_monan].TabIndex = 1;
                    this.bt_add_monan[num_monan].Text = "+";
                    this.bt_add_monan[num_monan].UseVisualStyleBackColor = true;
                    this.bt_add_monan[num_monan].Click += new System.EventHandler(this.bt_add_monan_Click);
                    this.flp_monan[num_monan].ResumeLayout(false);
                    this.flp_monan[num_monan].PerformLayout();
                    this.pn_control_thucpham[num_monan].ResumeLayout(false);
                    for (int j = 0; j < 8; j++)
                    {
                        this.pn_thucpham[num_monan, j].ResumeLayout(false);
                        this.pn_thucpham[num_monan, j].PerformLayout();
                    }
                    this.panel9[num_monan].ResumeLayout(false);
                }
                else
                {
                    MessageBox.Show("Điền đầy đủ thông tin trước khi thêm mới");
                }
            }



            if (e.KeyChar == (char)13 && Control.ModifierKeys != Keys.Shift)
            {
                if (this.cb_name_thucpham[num_monan, number_thucpham[num_monan]].Text != "" && this.tb_luong_thucpham[num_monan, number_thucpham[num_monan]].Text != "")
                {
                    number_thucpham[num_monan]++;
                    // 
                    // pn_thucpham
                    // 
                    this.pn_thucpham[num_monan, number_thucpham[num_monan]].Controls.Add(this.tb_luong_thucpham[num_monan, number_thucpham[num_monan]]);
                    this.pn_thucpham[num_monan, number_thucpham[num_monan]].Controls.Add(this.cb_name_thucpham[num_monan, number_thucpham[num_monan]]);
                    this.pn_thucpham[num_monan, number_thucpham[num_monan]].Location = new System.Drawing.Point(387, 3);
                    this.pn_thucpham[num_monan, number_thucpham[num_monan]].Name = "pn_thucpham";
                    this.pn_thucpham[num_monan, number_thucpham[num_monan]].Size = new System.Drawing.Size(88, 54);
                    this.pn_thucpham[num_monan, number_thucpham[num_monan]].TabIndex = 4;
                    // 
                    // tb_luong_thucpham        
                    // 
                    this.tb_luong_thucpham[num_monan, number_thucpham[num_monan]].Location = new System.Drawing.Point(4, 30);
                    this.tb_luong_thucpham[num_monan, number_thucpham[num_monan]].Name = "tb_luong_thucpham";
                    this.tb_luong_thucpham[num_monan, number_thucpham[num_monan]].Size = new System.Drawing.Size(81, 20);
                    this.tb_luong_thucpham[num_monan, number_thucpham[num_monan]].Text = 0 + "";
                    this.tb_luong_thucpham[num_monan, number_thucpham[num_monan]].TabIndex = 4;
                    this.tb_luong_thucpham[num_monan, number_thucpham[num_monan]].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press_addnew_tb);
                    // 
                    // cb_name_thucpham
                    // 
                    this.cb_name_thucpham[num_monan, number_thucpham[num_monan]].FormattingEnabled = true;
                    this.cb_name_thucpham[num_monan, number_thucpham[num_monan]].Location = new System.Drawing.Point(3, 3);
                    this.cb_name_thucpham[num_monan, number_thucpham[num_monan]].Name = "cb_name_thucpham";
                    this.cb_name_thucpham[num_monan, number_thucpham[num_monan]].Size = new System.Drawing.Size(81, 21);
                    this.cb_name_thucpham[num_monan, number_thucpham[num_monan]].Text = nhap_monan_tronghoa.name_TP[0];
                    this.cb_name_thucpham[num_monan, number_thucpham[num_monan]].TabIndex = 3;
                    this.cb_name_thucpham[num_monan, number_thucpham[num_monan]].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_press_addnew_cb);
                    for (int t = 0; t < nhap_monan_tronghoa.count_TP; t++)
                    {
                        this.cb_name_thucpham[num_monan, number_thucpham[num_monan]].Items.Add(nhap_monan_tronghoa.name_TP[t]);
                    }
                    this.cb_name_thucpham[num_monan, number_thucpham[num_monan]].Focus();
                }
                else
                {
                    MessageBox.Show("Nhập đầy đủ thông tin trước khi thêm mới !!!");
                }
            }
        }
    }
}
