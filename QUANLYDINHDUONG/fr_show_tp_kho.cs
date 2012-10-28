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
    public partial class fr_show_tp_kho : Form
    {
        public modun_quanli_thucdon_dinhduong quanlikho = new modun_quanli_thucdon_dinhduong();
        public datakho dtkho = new datakho();
        public fr_show_tp_kho()
        {
            quanlikho.query_thucpham();
            InitializeComponent();
            create_dynamic_item();
        }

        private void bt_import_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.count_import++;
            Program.th_import[Program.count_import].Start();
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {

        }

        private void bt_export_Click(object sender, EventArgs e)
        {

        }

        private void bt_mainboard_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.count_mb++;
            Program.th_mb[Program.count_mb].Start();
        }

        private void create_dynamic_item()
        {
            //declare dynamic item
            for (int i = 0; i < dtkho.count; i++)
            {
                this.tb_stt[i] = new System.Windows.Forms.TextBox();
                this.tb_name[i] = new System.Windows.Forms.TextBox();
                this.tb_type[i] = new System.Windows.Forms.TextBox();
                this.tb_unit[i] = new System.Windows.Forms.TextBox();
                this.tb_luongcon[i] = new System.Windows.Forms.TextBox();
                this.tb_dongia_new[i] = new System.Windows.Forms.TextBox();
                this.tb_luongton[i] = new System.Windows.Forms.TextBox();
                this.tb_dongia_old[i] = new System.Windows.Forms.TextBox();
                this.bt_stt = new System.Windows.Forms.Button();
            }

            //setup the properties item
            for (int i = 0; i < dtkho.count; i++)
            {
                // 
                // tb_stt
                // 
                this.tb_stt[i].Location = new System.Drawing.Point(3, 3);
                this.tb_stt[i].Name = "tb_stt";
                this.tb_stt[i].Size = new System.Drawing.Size(31, 20);
                this.tb_stt[i].TabIndex = 0;
                this.tb_stt[i].Text = dtkho.id_thucpham[i] + "";
                //this.tb_stt[i].Enabled = false;
                // 
                // tb_name
                // 
                this.tb_name[i].Location = new System.Drawing.Point(40, 3);
                this.tb_name[i].Name = "tb_name";
                this.tb_name[i].Size = new System.Drawing.Size(129, 20);
                this.tb_name[i].TabIndex = 1;
                this.tb_name[i].Text = quanlikho.findNameThucPham(dtkho.id_thucpham[i]);
                //this.tb_name[i].Enabled = false;
                // 
                // tb_type
                // 
                this.tb_type[i].Location = new System.Drawing.Point(175, 3);
                this.tb_type[i].Name = "tb_type";
                this.tb_type[i].Size = new System.Drawing.Size(83, 20);
                this.tb_type[i].TabIndex = 2;
                this.tb_type[i].Text = "trongkho";
                //this.tb_type[i].Enabled = false;
                // 
                // tb_unit
                // 
                this.tb_unit[i].Location = new System.Drawing.Point(264, 3);
                this.tb_unit[i].Name = "tb_unit";
                this.tb_unit[i].Size = new System.Drawing.Size(83, 20);
                this.tb_unit[i].TabIndex = 3;
                this.tb_unit[i].Text = "kg";
                //this.tb_unit[i].Enabled = false;
                // 
                // tb_luongcon
                // 
                this.tb_luongcon[i].Location = new System.Drawing.Point(353, 3);
                this.tb_luongcon[i].Name = "tb_luongcon";
                this.tb_luongcon[i].Size = new System.Drawing.Size(83, 20);
                this.tb_luongcon[i].TabIndex = 4;
                this.tb_luongcon[i].Text = dtkho.luongthucpham[i] + "";
                //this.tb_luongcon[i].Enabled = false;
                // 
                // tb_dongia_new
                // 
                this.tb_dongia_new[i].Location = new System.Drawing.Point(442, 3);
                this.tb_dongia_new[i].Name = "tb_dongia_new";
                this.tb_dongia_new[i].Size = new System.Drawing.Size(83, 20);
                this.tb_dongia_new[i].TabIndex = 5;
                this.tb_dongia_new[i].Text = dtkho.gia_thucpham[i] + "";
                //this.tb_dongia_new[i].Enabled = false;
                // 
                // tb_luongton
                // 
                this.tb_luongton[i].Location = new System.Drawing.Point(531, 3);
                this.tb_luongton[i].Name = "tb_luongton";
                this.tb_luongton[i].Size = new System.Drawing.Size(83, 20);
                this.tb_luongton[i].TabIndex = 6;
                this.tb_luongton[i].Text = dtkho.ngay_cap_nhat[i];
                //this.tb_luongton[i].Enabled = false;
                // 
                // tb_dongia_old
                // 
                this.tb_dongia_old[i].Location = new System.Drawing.Point(620, 3);
                this.tb_dongia_old[i].Name = "tb_dongia_old";
                this.tb_dongia_old[i].Size = new System.Drawing.Size(83, 20);
                this.tb_dongia_old[i].TabIndex = 7;
                this.tb_dongia_old[i].Text = "...";
                //this.tb_dongia_old[i].Enabled = false;
            }

            //add item into form
            for (int i = 0; i < dtkho.count; i++)
            {
                this.flp_show_hang.Controls.Add(this.tb_stt[i]);
                this.flp_show_hang.Controls.Add(this.tb_name[i]);
                this.flp_show_hang.Controls.Add(this.tb_type[i]);
                this.flp_show_hang.Controls.Add(this.tb_unit[i]);
                this.flp_show_hang.Controls.Add(this.tb_luongcon[i]);
                this.flp_show_hang.Controls.Add(this.tb_dongia_new[i]);
                this.flp_show_hang.Controls.Add(this.tb_luongton[i]);
                this.flp_show_hang.Controls.Add(this.tb_dongia_old[i]);
            }

        }

    }
}
