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
    public partial class fr_dutru : Form
    {
        public modun_quanli_hocsinh qlhs = new modun_quanli_hocsinh();
        public modun_quanli_thucdon_dinhduong qldd = new modun_quanli_thucdon_dinhduong();
        public fr_dutru()
        {
            InitializeComponent();
            qlhs.query_hs();
            MessageBox.Show(qlhs.ID_td_homnay + " " + qlhs.hs_mg + " " + qlhs.hs_nt);
            qlhs.query_td_ma();
            qlhs.query_ma_tp();
            qlhs.dutru();
            this.tb_luong_hs_maugiao.Text = this.qlhs.hs_mg + "";
            this.tb_luong_hs_nhatre.Text = this.qlhs.hs_nt + "";
            this.confirm_textbox.Text = "Hôm qua:\n\tHọc sinh mẫu giáo: " + qlhs.hs_mg + "\n\tHọc sinh nhà trẻ: " + qlhs.hs_nt;
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tronghoa");
            int tmp_hs_mg = Convert.ToInt32(this.tb_luong_hs_maugiao.Text);
            int tmp_hs_nt = Convert.ToInt32(this.tb_luong_hs_nhatre.Text);

            if (tmp_hs_mg > 0 && tmp_hs_nt > 0)
            {
                qlhs.hs_mg = tmp_hs_mg;
                qlhs.hs_nt = tmp_hs_nt;
                qlhs.chinhthuc();
                qlhs.luu_hocsinh();
                MessageBox.Show("Đã cập nhật lượng học sinh trong ngày.");
                qldd.query_thucpham();
                String result = "";
                for (int i = 0; i < qldd.count_TP; i++)
                {
                    result = result + qldd.ID_TP[i] + "/" + qldd.name_TP[i] + "/" + qlhs.tb_tp_thua[i] + "\n";
                }
                this.confirm_textbox.Text = result;
            }
            else
            {
                MessageBox.Show("Lượng học sinh cần phải lớn hơn 0.");
                this.tb_luong_hs_maugiao.Text = tmp_hs_mg + "";
                this.tb_luong_hs_nhatre.Text = tmp_hs_nt + "";
            }
			FileInfo kho = new FileInfo("data/database/tmp_kho.dat");
            if (kho.Exists == true)
            {
                kho.CopyTo("data/database/kho.dat", true);
                // xuat kho du tru
            }
            this.Close();
            Program.count_form5++;
            Program.th_form5[Program.count_form5].Start();
        }

        private void bt_mainboard_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.count_mb++;
            Program.th_mb[Program.count_mb].Start();
        }
    }
}
