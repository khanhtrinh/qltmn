using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    static class Program
    {
        public static Thread[] th_mb = new Thread[100];
        public static Thread[] th_ql_td = new Thread[100];
        public static Thread[] th_nhap_td = new Thread[100];
        public static Thread[] th_nhap_tp = new Thread[100];
        public static Thread[] th_ql_td_continous = new Thread[100];
        public static Thread[] th_infor_kho = new Thread[100];
        public static Thread[] th_import = new Thread[100];
        public static Thread[] th_form5 = new Thread[100];
        public static Thread[] th_thongke_monan = new Thread[100];
        public static Thread[] th_nhap_thucpham_moi = new Thread[100];
        public static Thread[] th_quanli_HDTP = new Thread[100];
        public static Thread[] th_try = new Thread[1000];
        public static Thread[] th_dutru = new Thread[1000]; 
        public static int count_mb = 0;
        public static int count_ql_td = 0;
        public static int count_nhap_td = 0;
        public static int count_nhap_tp = 0;
        public static int count_ql_td_continuos = 0;
        public static int count_info_kho = 0;
        public static int count_import = 0;
        public static int count_form5 = 0;
        public static int count_thongke_mon = 0;
        public static int count_nhap_tp_moi = 0;
        public static int count_quanli_HDTP = 0;
        public static int count_try_form = 0;
        public static int count_dutru = 0;
        [STAThread]
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                th_mb[i] = new Thread(new ThreadStart(openform_mb));
                th_ql_td[i] = new Thread(new ThreadStart(openform_ql_td));
                th_nhap_td[i] = new Thread(new ThreadStart(openform_nhap_td));
                th_nhap_tp[i] = new Thread(new ThreadStart(openform_nhap_tp));
                th_ql_td_continous[i] = new Thread(new ThreadStart(openform_ql_td_continous));
                th_infor_kho[i] = new Thread(new ThreadStart(openform_infor_kho));
                th_import[i] = new Thread(new ThreadStart(openform_import));
                th_form5[i] = new Thread(new ThreadStart(openform5));
                th_form5[i].SetApartmentState(ApartmentState.STA);
                th_thongke_monan[i] = new Thread(new ThreadStart(open_thongke_monan));
                th_nhap_thucpham_moi[i] = new Thread(new ThreadStart(open_nhap_tp_moi));
                th_quanli_HDTP[i] = new Thread(new ThreadStart(openform_quanli_HDTP));
                th_try[i] = new Thread(new ThreadStart(openform_try_form));
                th_dutru[i] = new Thread(new ThreadStart(openform_dutru));
            }
            th_mb[0].Start();
        }

        static void openform_dutru()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fr_dutru());
        }

        static void openform_mb()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fr_mainboard());
        }

        static void openform_ql_td()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
//            Application.Run(new fr_quanli_thucdon(0));
        }

        static void openform_ql_td_continous()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
//            Application.Run(new fr_quanli_thucdon(1));
        }

        static void openform_nhap_td()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fr_nhap_thucdon());
        }

        static void openform_nhap_tp()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fr_nhap_thucpham());
        }

        static void openform_infor_kho()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fr_show_tp_kho());
        }

        static void openform_import()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fr_import());
        }

        static void openform5()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form5());
        }

        static void open_thongke_monan()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fr_thongke_monan());
        }

        static void open_nhap_tp_moi()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fr_nhap_thucpham_moi());
        }

        static void openform_quanli_HDTP()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new bt_fixtd());
        }
        
        static void openform_try_form()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
