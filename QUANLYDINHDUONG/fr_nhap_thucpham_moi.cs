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
    public partial class fr_nhap_thucpham_moi : Form
    {
        private int count_tp = 0;

        public fr_nhap_thucpham_moi()
        {
            thucpham1.query_monan();
            thucpham1.query_vichat();
            thucpham1.query_thucpham();
            thucpham1.query_join_thucpham_vichat();
            InitializeComponent();
            create_dynamic_items();
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

            for (int i = 0; i < 1; i++)
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

            for (int i = 0; i < 1; i++)
            {
                // 
                // tb_id_thucpham
                // 
                this.tb_id_thucpham[i].Location = new System.Drawing.Point(3, 3);
                this.tb_id_thucpham[i].Name = "tb_id_thucpham";
                this.tb_id_thucpham[i].Size = new System.Drawing.Size(47, 20);
                this.tb_id_thucpham[i].TabIndex = 0;
                // 
                // tb_name_thucpham
                // 
                this.tb_name_thucpham[i].Location = new System.Drawing.Point(56, 3);
                this.tb_name_thucpham[i].Name = "tb_name_thucpham";
                this.tb_name_thucpham[i].Size = new System.Drawing.Size(112, 20);
                this.tb_name_thucpham[i].TabIndex = 1;
                // 
                // cb_type_thucpham
                // 
                this.cb_type_thucpham[i].FormattingEnabled = true;
                this.cb_type_thucpham[i].Location = new System.Drawing.Point(174, 3);
                this.cb_type_thucpham[i].Name = "cb_type_thucpham";
                this.cb_type_thucpham[i].Size = new System.Drawing.Size(70, 21);
                this.cb_type_thucpham[i].TabIndex = 2;
                for (int j = 0; j < 2; j++)
                {
                    this.cb_type_thucpham[i].Items.Add("Có sẵn");
                    this.cb_type_thucpham[i].Items.Add("Hàng ngày");
                }

                for (int j = 0; j < 10; j++)
                {
                    // 
                    // tb_luong_thucpham
                    // 
                    this.tb_luong_thucpham[i, j].Location = new System.Drawing.Point(250, 3);
                    this.tb_luong_thucpham[i, j].Name = "tb_luong_thucpham";
                    this.tb_luong_thucpham[i, j].Size = new System.Drawing.Size(75, 20);
                    this.tb_luong_thucpham[i, j].TabIndex = 3;
                }
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.count_mb++;
            Program.th_mb[Program.count_mb].Start();
        }

        private void bt_chuyen_thucpham_Click(object sender, EventArgs e)
        {
            count_tp++;
            this.flp_information_thucpham.Controls.Add(this.tb_id_thucpham[count_tp]);
            this.flp_information_thucpham.Controls.Add(this.tb_name_thucpham[count_tp]);
            this.flp_information_thucpham.Controls.Add(this.cb_type_thucpham[count_tp]);
            for (int j = 0; j < 10; j++)
            {
                this.tb_luong_thucpham[count_tp, j] = new System.Windows.Forms.TextBox();
                this.flp_information_thucpham.Controls.Add(this.tb_luong_thucpham[count_tp, j]);
            }
            // 
            // tb_id_thucpham
            // 
            this.tb_id_thucpham[count_tp].Location = new System.Drawing.Point(3, 3);
            this.tb_id_thucpham[count_tp].Name = "tb_id_thucpham";
            this.tb_id_thucpham[count_tp].Size = new System.Drawing.Size(47, 20);
            this.tb_id_thucpham[count_tp].TabIndex = 0;
            // 
            // tb_name_thucpham
            // 
            this.tb_name_thucpham[count_tp].Location = new System.Drawing.Point(56, 3);
            this.tb_name_thucpham[count_tp].Name = "tb_name_thucpham";
            this.tb_name_thucpham[count_tp].Size = new System.Drawing.Size(112, 20);
            this.tb_name_thucpham[count_tp].TabIndex = 1;
            // 
            // cb_type_thucpham
            // 
            this.cb_type_thucpham[count_tp].FormattingEnabled = true;
            this.cb_type_thucpham[count_tp].Location = new System.Drawing.Point(174, 3);
            this.cb_type_thucpham[count_tp].Name = "cb_type_thucpham";
            this.cb_type_thucpham[count_tp].Size = new System.Drawing.Size(70, 21);
            this.cb_type_thucpham[count_tp].TabIndex = 2;
            for (int j = 0; j < 2; j++)
            {
                this.cb_type_thucpham[count_tp].Items.Add("Có sẵn");
                this.cb_type_thucpham[count_tp].Items.Add("Hàng ngày");
            }

            for (int j = 0; j < 10; j++)
            {
                // 
                // tb_luong_thucpham
                // 
                this.tb_luong_thucpham[count_tp, j].Location = new System.Drawing.Point(250, 3);
                this.tb_luong_thucpham[count_tp, j].Name = "tb_luong_thucpham";
                this.tb_luong_thucpham[count_tp, j].Size = new System.Drawing.Size(75, 20);
                this.tb_luong_thucpham[count_tp, j].TabIndex = 3;
            }
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            string result_thucpham_vichat= "";
            FileInfo f6 = new FileInfo("data/database/thucpham_vichat.dat");
            if (f6.Exists == true)
            {
                StreamReader sr6 = File.OpenText("data/database/thucpham_vichat.dat");
                string input = null;
                while ((input = sr6.ReadLine()) != null)
                {
                    result_thucpham_vichat = result_thucpham_vichat + input + "\n";
                }
                sr6.Close();
            }
            
            //Creating some new stream-writer and opening the file.

            TextWriter tsw_monan_thucpham2 = new StreamWriter("data/database/thucpham.dat");

            TextWriter tsw_monan_thucpham1 = new StreamWriter("data/database/thucpham_vichat.dat");
            
            string results_thucpham = "";

            for (int i = 0; i < thucpham1.count_TP; i++)
            {
                results_thucpham = results_thucpham + thucpham1.ID_TP[i] + "/" + thucpham1.name_TP[i] + "/" + thucpham1.type_TP[i] + "/" + thucpham1.unit_TP[i] + "/" + thucpham1.luong_TP_kho_new[i] + "/" + thucpham1.dongia_TP_kho_new[i] + "/" + thucpham1.luong_TP_kho_old[i] + "/" + thucpham1.dongia_TP_kho_old[i] + "\n";
            }

            int[,] id_tp_use = new int[100, 100];
            //MessageBox.Show("" + results_thucpham);
            for (int i = 0; i <= count_tp; i++)
            {
                int id_thucpham = thucpham1.ID_TP[thucpham1.count_TP - 1] + i + 1;
                //MessageBox.Show("" + thucpham1.name_MA[0]);
                results_thucpham = results_thucpham + id_thucpham + "/" + tb_name_thucpham[i].Text + "/";
                results_thucpham = results_thucpham + cb_type_thucpham[i].Text + "/kg/40000/2000/10000/2344" + "\n";
                for (int j = 0; j < thucpham1.count_VC; j++)
                {
                    result_thucpham_vichat = result_thucpham_vichat + id_thucpham + "/" + thucpham1.ID_VC[j] + "/" + tb_luong_thucpham[i, j].Text + "\n";
                }
            }
            //Writing text to the file.
            tsw_monan_thucpham1.Write(result_thucpham_vichat);
            //Close the file.

            tsw_monan_thucpham1.Close();

            tsw_monan_thucpham2.Write(results_thucpham);

            tsw_monan_thucpham2.Close();

            MessageBox.Show("Thông tin đã được lưu, xin cảm ơn !!!");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
