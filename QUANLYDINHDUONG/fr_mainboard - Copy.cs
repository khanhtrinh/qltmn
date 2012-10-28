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
    public partial class fr_mainboard : Form
    {
        public fr_mainboard()
        {
            InitializeComponent();
        }
        private void current_menu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Program.count_ql_td_continuos++;
            Program.th_ql_td_continous[Program.count_ql_td_continuos].Start();
        }

        private void bt_quanli_thucdon_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("tronghoa");
            this.Close();
            Program.count_form5++;
            Program.th_form5[Program.count_form5].Start();
        }

        private void bt_enter_new_infor_Click(object sender, EventArgs e)
        {
            Program.count_thongke_mon++;
            Program.th_thongke_monan[Program.count_thongke_mon].Start();
            this.Close();
        }

        private void bt_quanli_kho_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.count_info_kho++;
            Program.th_infor_kho[Program.count_info_kho].Start();
            datakho dt = new datakho();
            dt.queryData();
        }

        private void bt_xem_dulieu_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.count_nhap_tp++;
            Program.th_nhap_tp[Program.count_nhap_tp].Start();

        }

        private void bt_test_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ngon");
            /*
            this.Close();
            Program.count_Form6++;
            Program.th_Form6[Program.count_Form6].Start();
             */
        }

        private void bt_xem_thucdoncu_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Program.count_thongke_mon++;
            Program.th_thongke_monan[Program.count_thongke_mon].Start();
        }

        private void flp_warning_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void bt_quanli_HDTP_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.count_quanli_HDTP++;
            Program.th_quanli_HDTP[Program.count_quanli_HDTP].Start();
        }

        private void other_menu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String date = DateTime.Now.ToString();
            DateTime date1 = Convert.ToDateTime(date);
            //MessageBox.Show("Thu :"+ date1.DayOfWeek.ToString() + "tronghoa");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.count_dutru++;
            Program.th_dutru[Program.count_dutru].Start();
        }
    }
}
