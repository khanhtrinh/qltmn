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
    public partial class fr_import : Form
    {
        public int num_item = 0;
        public modun_quanli_thucdon_dinhduong import = new modun_quanli_thucdon_dinhduong();
        public datakho dtkho;

        public fr_import()
        {
            import.query_thucpham();
            InitializeComponent();
            create_dynamic_item();
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            dtkho = new datakho();
            string s = "";
            for (int i = 0; i < dtkho.count; i++)
            {
                s = s + dtkho.buffer[i] + "\n";
            }
            for (int i = 0; i < (this.num_item + 1); i++)
            {
                int ID = import.findIDThucPham(cb_name_thucpham[i].SelectedItem.ToString());
                int Price = Int32.Parse(tb_price_thucpham[i].Text);
                int Quanlity = Int32.Parse(tb_num_thucpham[i].Text);
                for (int j = 0; j < import.count_TP; j++)
                {
                    if (ID == import.ID_TP[j])
                    {
                        import.dongia_TP_kho_new[j] = Price;
                        import.luong_TP_kho_new[j] = Quanlity;
                    }
                }
                s = dtkho.reload(s, ID, Price, Quanlity);
            }
            if (s != "")dtkho.updateData(s);
            string update_tp = "";
            for (int i = 0; i < import.count_TP; i++)
            {
                update_tp = update_tp + "" + import.ID_TP[i] + "/" + import.name_TP[i] + "/" + import.type_TP[i] + "/" + import.unit_TP[i]  + "/" + import.luong_TP_kho_new[i] + "/" + import.dongia_TP_kho_new[i] + "/" + import.luong_TP_kho_old[i] + "/" + import.dongia_TP_kho_old[i] + "\n";
            }
            if (update_tp != "") dtkho.updateDataTP(update_tp);
            this.Close();
            Program.count_info_kho++;
            Program.th_infor_kho[Program.count_info_kho].Start();
        }

        private void bt_change_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_add_items_Click(object sender, EventArgs e)
        {
            this.tb_sum_value.Text = "";
            Int64 sum2 = 0;
            for (int i = 0; i < num_item; i++)
            {
                sum2 = sum2 + Int64.Parse(this.tb_num_thucpham[i].Text) * Int64.Parse(this.tb_price_thucpham[i].Text);
            }
            this.tb_sum_value.Text = sum2 + "";
            this.num_item++;
            this.flp_infor.Controls.Add(this.tb_stt[num_item]);
            this.flp_infor.Controls.Add(this.cb_name_thucpham[num_item]);
            this.flp_infor.Controls.Add(this.tb_num_thucpham[num_item]);
            this.flp_infor.Controls.Add(this.tb_price_thucpham[num_item]);
            this.flp_infor.Controls.Add(this.cb_unit_thucpham[num_item]);
            // 
            // tb_stt
            // 
            this.tb_stt[num_item].Location = new System.Drawing.Point(3, 3);
            this.tb_stt[num_item].Name = "tb_stt";
            this.tb_stt[num_item].Size = new System.Drawing.Size(37, 20);
            this.tb_stt[num_item].TabIndex = 0;
            this.tb_stt[num_item].Text = (num_item + 1) + "";
            this.tb_stt[num_item].Enabled = false;
            // 
            // tb_num_thucpham
            // 
            this.tb_num_thucpham[num_item].Location = new System.Drawing.Point(257, 3);
            this.tb_num_thucpham[num_item].Name = "tb_num_thucpham";
            this.tb_num_thucpham[num_item].Size = new System.Drawing.Size(113, 20);
            this.tb_num_thucpham[num_item].TabIndex = 2;
            // 
            // tb_price_thucpham
            // 
            this.tb_price_thucpham[num_item].Location = new System.Drawing.Point(376, 3);
            this.tb_price_thucpham[num_item].Name = "tb_price_thucpham";
            this.tb_price_thucpham[num_item].Size = new System.Drawing.Size(113, 20);
            this.tb_price_thucpham[num_item].TabIndex = 3;
            // 
            // cb_name_thucpham
            // 
            this.cb_name_thucpham[num_item].FormattingEnabled = true;
            this.cb_name_thucpham[num_item].Location = new System.Drawing.Point(46, 3);
            this.cb_name_thucpham[num_item].Name = "cb_name_thucpham";
            this.cb_name_thucpham[num_item].Size = new System.Drawing.Size(205, 21);
            this.cb_name_thucpham[num_item].TabIndex = 5; 
            for (int i = 0; i < import.count_TP; i++)
            {
                if (import.type_TP[i] == "có sẵn")
                cb_name_thucpham[num_item].Items.Add(import.name_TP[i]);
            }
            // 
            // cb_unit_thucpham
            // 
            this.cb_unit_thucpham[num_item].FormattingEnabled = true;
            this.cb_unit_thucpham[num_item].Location = new System.Drawing.Point(495, 3);
            this.cb_unit_thucpham[num_item].Name = "cb_unit_thucpham";
            this.cb_unit_thucpham[num_item].Size = new System.Drawing.Size(113, 21);
            this.cb_unit_thucpham[num_item].TabIndex = 6;
            this.cb_unit_thucpham[num_item].Items.Add("kg");
            this.cb_unit_thucpham[num_item].Items.Add("lit");
            
        }

        public void create_dynamic_item()
        {
            for (int i = 0; i < 20; i++)
            {
                this.tb_num_thucpham[i] = new System.Windows.Forms.TextBox();
                this.tb_stt[i] = new System.Windows.Forms.TextBox();
                this.tb_price_thucpham[i] = new System.Windows.Forms.TextBox();
                this.cb_name_thucpham[i] = new System.Windows.Forms.ComboBox();
                this.cb_unit_thucpham[i] = new System.Windows.Forms.ComboBox();
            }

            // 
            // tb_stt
            // 
            this.tb_stt[0].Location = new System.Drawing.Point(3, 3);
            this.tb_stt[0].Name = "tb_stt";
            this.tb_stt[0].Size = new System.Drawing.Size(37, 20);
            this.tb_stt[0].TabIndex = 0;
            this.tb_stt[0].Text = 1 + "";
            this.tb_stt[0].Enabled = false;
            // 
            // tb_num_thucpham
            // 
            this.tb_num_thucpham[0].Location = new System.Drawing.Point(257, 3);
            this.tb_num_thucpham[0].Name = "tb_num_thucpham";
            this.tb_num_thucpham[0].Size = new System.Drawing.Size(113, 20);
            this.tb_num_thucpham[0].TabIndex = 2;
            // 
            // tb_price_thucpham
            // 
            this.tb_price_thucpham[0].Location = new System.Drawing.Point(376, 3);
            this.tb_price_thucpham[0].Name = "tb_price_thucpham";
            this.tb_price_thucpham[0].Size = new System.Drawing.Size(113, 20);
            this.tb_price_thucpham[0].TabIndex = 3;
            // 
            // cb_name_thucpham
            // 
            this.cb_name_thucpham[0].FormattingEnabled = true;
            this.cb_name_thucpham[0].Location = new System.Drawing.Point(46, 3);
            this.cb_name_thucpham[0].Name = "cb_name_thucpham";
            this.cb_name_thucpham[0].Size = new System.Drawing.Size(205, 21);
            this.cb_name_thucpham[0].TabIndex = 5;

            // 
            // cb_unit_thucpham
            // 
            this.cb_unit_thucpham[0].FormattingEnabled = true;
            this.cb_unit_thucpham[0].Location = new System.Drawing.Point(495, 3);
            this.cb_unit_thucpham[0].Name = "cb_unit_thucpham";
            this.cb_unit_thucpham[0].Size = new System.Drawing.Size(113, 21);
            this.cb_unit_thucpham[0].TabIndex = 6;
            this.cb_unit_thucpham[0].Items.Add("kg");
            this.cb_unit_thucpham[0].Items.Add("lit");
            
            for (int i = 0; i < import.count_TP; i++)
            {
                if (import.type_TP[i] == "có sẵn")
                cb_name_thucpham[0].Items.Add(import.name_TP[i]);
            }

            
            this.flp_infor.Controls.Add(this.tb_stt[0]);
            this.flp_infor.Controls.Add(this.cb_name_thucpham[0]);
            this.flp_infor.Controls.Add(this.tb_num_thucpham[0]);
            this.flp_infor.Controls.Add(this.tb_price_thucpham[0]);
            this.flp_infor.Controls.Add(this.cb_unit_thucpham[0]);
            
        }

        private void bt_stt_Click(object sender, EventArgs e)
        {

        }
    }
}
