using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApplication1
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pn_head = new System.Windows.Forms.Panel();
            this.headline_title = new System.Windows.Forms.Label();
            this.headline_mainboard = new System.Windows.Forms.Label();
            this.pn_thucpham_luonghs = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_mainboard = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_chiphi = new System.Windows.Forms.Button();
            this.bt_td_vc = new System.Windows.Forms.Button();
            this.bt_left_tp = new System.Windows.Forms.Button();
            this.pn_thucpham_maugiao = new System.Windows.Forms.Panel();
            this.label2_tp = new System.Windows.Forms.Label();
            this.bt_luonghs_maugiao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_luonghs_maugiao = new System.Windows.Forms.TextBox();
            this.bt_luongsd_mg = new System.Windows.Forms.Button();
            this.bt_stt_thucpham_mg = new System.Windows.Forms.Button();
            this.bt_name_monan_mg = new System.Windows.Forms.Button();
            this.bt_donvi_tp_mg = new System.Windows.Forms.Button();
            this.bt_type_mg = new System.Windows.Forms.Button();
            this.flp_thucpham_maugiao = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_trongkho_mg = new System.Windows.Forms.Button();
            this.pn_thucpham_nhatre = new System.Windows.Forms.Panel();
            this.label1_tp = new System.Windows.Forms.Label();
            this.bt_luonghs_nhatre = new System.Windows.Forms.Button();
            this.luonghs_nhatre = new System.Windows.Forms.Label();
            this.tb_luonghs_nhatre = new System.Windows.Forms.TextBox();
            this.bt_luongsd_nt = new System.Windows.Forms.Button();
            this.bt_stt_thucpham_nt = new System.Windows.Forms.Button();
            this.bt_name_monan_nt = new System.Windows.Forms.Button();
            this.bt_donvi_tp_nt = new System.Windows.Forms.Button();
            this.bt_type_nt = new System.Windows.Forms.Button();
            this.flp_thucpham_nhatre = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_trongkho_nt = new System.Windows.Forms.Button();
            this.pn_td_dd = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_left = new System.Windows.Forms.Button();
            this.bt_right = new System.Windows.Forms.Button();
            this.pn_vichat = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.flp_vichat = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_hl_nt = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_hl_mg = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_thucdon = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.flp_thucdon = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_midle = new System.Windows.Forms.Button();
            this.bt_median_thucdon = new System.Windows.Forms.Button();
            this.bt_link_thucdon = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_buasang_chinh = new System.Windows.Forms.Button();
            this.bt_buasang_phu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pn_mua_thucpham = new System.Windows.Forms.Panel();
            this.bt_sum_cp = new System.Windows.Forms.Button();
            this.bt_dv_dg = new System.Windows.Forms.Button();
            this.bt_tonkho = new System.Windows.Forms.Button();
            this.lb_donvi = new System.Windows.Forms.Label();
            this.tb_sum = new System.Windows.Forms.TextBox();
            this.lb_tong_tien = new System.Windows.Forms.Label();
            this.bt_back_tp = new System.Windows.Forms.Button();
            this.bt_export = new System.Windows.Forms.Button();
            this.bt_comp = new System.Windows.Forms.Button();
            this.bt_comment_cp = new System.Windows.Forms.Button();
            this.bt_dongia_thucpham_cp = new System.Windows.Forms.Button();
            this.bt_soluong_thucpham_cp = new System.Windows.Forms.Button();
            this.bt_unit_thucpham_cp = new System.Windows.Forms.Button();
            this.bt_name_thucpham_cp = new System.Windows.Forms.Button();
            this.bt_stt_cp = new System.Windows.Forms.Button();
            this.flp_mua_thucpham = new System.Windows.Forms.FlowLayoutPanel();
            this.headline_phieu_mua = new System.Windows.Forms.Label();
            this.pn_thongke_end = new System.Windows.Forms.Panel();
            this.bt_print = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.bt_export_end = new System.Windows.Forms.Button();
            this.pn_luonghs_end = new System.Windows.Forms.Panel();
            this.bt_nhatre = new System.Windows.Forms.Button();
            this.bt_maugiao = new System.Windows.Forms.Button();
            this.tb_chiphi_nhatre = new System.Windows.Forms.TextBox();
            this.tb_chiphi_maugiao = new System.Windows.Forms.TextBox();
            this.bt_tong_chiphi = new System.Windows.Forms.Button();
            this.pn_thucpham_end = new System.Windows.Forms.Panel();
            this.bt_price_tp_end = new System.Windows.Forms.Button();
            this.bt_stt_end = new System.Windows.Forms.Button();
            this.bt_name_monan_end = new System.Windows.Forms.Button();
            this.bt_luong_tp_sd_end = new System.Windows.Forms.Button();
            this.flp_thucpham = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_thanhtien_end = new System.Windows.Forms.Button();
            this.bt_donvi_end = new System.Windows.Forms.Button();
            this.headline_end = new System.Windows.Forms.Label();
            this.pn_head.SuspendLayout();
            this.pn_thucpham_luonghs.SuspendLayout();
            this.pn_thucpham_maugiao.SuspendLayout();
            this.pn_thucpham_nhatre.SuspendLayout();
            this.pn_td_dd.SuspendLayout();
            this.pn_vichat.SuspendLayout();
            this.flp_vichat.SuspendLayout();
            this.pn_hl_nt.SuspendLayout();
            this.pn_hl_mg.SuspendLayout();
            this.pn_thucdon.SuspendLayout();
            this.pn_mua_thucpham.SuspendLayout();
            this.pn_thongke_end.SuspendLayout();
            this.pn_luonghs_end.SuspendLayout();
            this.pn_thucpham_end.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_head
            // 
            this.pn_head.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_head.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bg_menu_top_1x33;
            this.pn_head.Controls.Add(this.headline_title);
            this.pn_head.Controls.Add(this.headline_mainboard);
            this.pn_head.Location = new System.Drawing.Point(12, 5);
            this.pn_head.Name = "pn_head";
            this.pn_head.Size = new System.Drawing.Size(1025, 72);
            this.pn_head.TabIndex = 2;
            // 
            // headline_title
            // 
            this.headline_title.AutoSize = true;
            this.headline_title.BackColor = System.Drawing.Color.Transparent;
            this.headline_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headline_title.ForeColor = System.Drawing.Color.AliceBlue;
            this.headline_title.Location = new System.Drawing.Point(157, 10);
            this.headline_title.Name = "headline_title";
            this.headline_title.Size = new System.Drawing.Size(707, 25);
            this.headline_title.TabIndex = 1;
            this.headline_title.Text = "TRƯỜNG MẦM NON DỊCH VỌNG HẬU - Q.CẦU GIẤY  - TP.HÀ NỘI";
            // 
            // headline_mainboard
            // 
            this.headline_mainboard.AutoSize = true;
            this.headline_mainboard.BackColor = System.Drawing.Color.Transparent;
            this.headline_mainboard.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headline_mainboard.ForeColor = System.Drawing.Color.AliceBlue;
            this.headline_mainboard.Location = new System.Drawing.Point(330, 44);
            this.headline_mainboard.Name = "headline_mainboard";
            this.headline_mainboard.Size = new System.Drawing.Size(361, 24);
            this.headline_mainboard.TabIndex = 0;
            this.headline_mainboard.Text = "PHẦN MỀM QUẢN LÍ DINH DƯỠNG";
            // 
            // pn_thucpham_luonghs
            // 
            this.pn_thucpham_luonghs.BackColor = System.Drawing.Color.AliceBlue;
            this.pn_thucpham_luonghs.Controls.Add(this.label6);
            this.pn_thucpham_luonghs.Controls.Add(this.bt_mainboard);
            this.pn_thucpham_luonghs.Controls.Add(this.label5);
            this.pn_thucpham_luonghs.Controls.Add(this.label4);
            this.pn_thucpham_luonghs.Controls.Add(this.bt_chiphi);
            this.pn_thucpham_luonghs.Controls.Add(this.bt_td_vc);
            this.pn_thucpham_luonghs.Controls.Add(this.bt_left_tp);
            this.pn_thucpham_luonghs.Controls.Add(this.pn_thucpham_maugiao);
            this.pn_thucpham_luonghs.Controls.Add(this.pn_thucpham_nhatre);
            this.pn_thucpham_luonghs.Location = new System.Drawing.Point(12, 76);
            this.pn_thucpham_luonghs.Name = "pn_thucpham_luonghs";
            this.pn_thucpham_luonghs.Size = new System.Drawing.Size(1025, 496);
            this.pn_thucpham_luonghs.TabIndex = 0;
            this.pn_thucpham_luonghs.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(147, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(731, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "BẢNG THỐNG KÊ LƯỢNG THỰC PHẨM SỬ DỤNG VÀ LƯỢNG HỌC SINH";
            // 
            // bt_mainboard
            // 
            this.bt_mainboard.Location = new System.Drawing.Point(676, 449);
            this.bt_mainboard.Name = "bt_mainboard";
            this.bt_mainboard.Size = new System.Drawing.Size(21, 27);
            this.bt_mainboard.TabIndex = 23;
            this.bt_mainboard.UseVisualStyleBackColor = true;
            this.bt_mainboard.Click += new System.EventHandler(this.bt_mainboard_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(514, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "SỬ DỤNG CHO LỚP MẪU GIÁO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(11, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "SỬ DỤNG CHO LỚP NHÀ TRẺ:";
            // 
            // bt_chiphi
            // 
            this.bt_chiphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chiphi.Location = new System.Drawing.Point(569, 449);
            this.bt_chiphi.Name = "bt_chiphi";
            this.bt_chiphi.Size = new System.Drawing.Size(101, 27);
            this.bt_chiphi.TabIndex = 19;
            this.bt_chiphi.Text = "MUA TP -->";
            this.bt_chiphi.UseVisualStyleBackColor = true;
            this.bt_chiphi.Click += new System.EventHandler(this.bt_chiphi_Click);
            // 
            // bt_td_vc
            // 
            this.bt_td_vc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_td_vc.Location = new System.Drawing.Point(353, 449);
            this.bt_td_vc.Name = "bt_td_vc";
            this.bt_td_vc.Size = new System.Drawing.Size(101, 27);
            this.bt_td_vc.TabIndex = 18;
            this.bt_td_vc.Text = "<-- THỰC ĐƠN";
            this.bt_td_vc.UseVisualStyleBackColor = true;
            this.bt_td_vc.Click += new System.EventHandler(this.bt_td_vc_Click);
            // 
            // bt_left_tp
            // 
            this.bt_left_tp.Enabled = false;
            this.bt_left_tp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_left_tp.Location = new System.Drawing.Point(462, 449);
            this.bt_left_tp.Name = "bt_left_tp";
            this.bt_left_tp.Size = new System.Drawing.Size(101, 27);
            this.bt_left_tp.TabIndex = 17;
            this.bt_left_tp.Text = "CẬP NHẬT";
            this.bt_left_tp.UseVisualStyleBackColor = true;
            this.bt_left_tp.Click += new System.EventHandler(this.bt_left_Click);
            // 
            // pn_thucpham_maugiao
            // 
            this.pn_thucpham_maugiao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_thucpham_maugiao.Controls.Add(this.label2_tp);
            this.pn_thucpham_maugiao.Controls.Add(this.bt_luonghs_maugiao);
            this.pn_thucpham_maugiao.Controls.Add(this.label3);
            this.pn_thucpham_maugiao.Controls.Add(this.tb_luonghs_maugiao);
            this.pn_thucpham_maugiao.Controls.Add(this.bt_luongsd_mg);
            this.pn_thucpham_maugiao.Controls.Add(this.bt_stt_thucpham_mg);
            this.pn_thucpham_maugiao.Controls.Add(this.bt_name_monan_mg);
            this.pn_thucpham_maugiao.Controls.Add(this.bt_donvi_tp_mg);
            this.pn_thucpham_maugiao.Controls.Add(this.bt_type_mg);
            this.pn_thucpham_maugiao.Controls.Add(this.flp_thucpham_maugiao);
            this.pn_thucpham_maugiao.Controls.Add(this.bt_trongkho_mg);
            this.pn_thucpham_maugiao.Location = new System.Drawing.Point(517, 76);
            this.pn_thucpham_maugiao.Name = "pn_thucpham_maugiao";
            this.pn_thucpham_maugiao.Size = new System.Drawing.Size(504, 367);
            this.pn_thucpham_maugiao.TabIndex = 2;
            // 
            // label2_tp
            // 
            this.label2_tp.AutoSize = true;
            this.label2_tp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_tp.Location = new System.Drawing.Point(343, 341);
            this.label2_tp.Name = "label2_tp";
            this.label2_tp.Size = new System.Drawing.Size(54, 16);
            this.label2_tp.TabIndex = 11;
            this.label2_tp.Text = "CHÁU ";
            // 
            // bt_luonghs_maugiao
            // 
            this.bt_luonghs_maugiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luonghs_maugiao.Location = new System.Drawing.Point(415, 338);
            this.bt_luonghs_maugiao.Name = "bt_luonghs_maugiao";
            this.bt_luonghs_maugiao.Size = new System.Drawing.Size(66, 23);
            this.bt_luonghs_maugiao.TabIndex = 10;
            this.bt_luonghs_maugiao.Text = "NHẬP";
            this.bt_luonghs_maugiao.UseVisualStyleBackColor = true;
            this.bt_luonghs_maugiao.Click += new System.EventHandler(this.bt_luonghs_maugiao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "SỐ LƯỢNG HS MẪU GIÁO:";
            // 
            // tb_luonghs_maugiao
            // 
            this.tb_luonghs_maugiao.Location = new System.Drawing.Point(199, 340);
            this.tb_luonghs_maugiao.Name = "tb_luonghs_maugiao";
            this.tb_luonghs_maugiao.Size = new System.Drawing.Size(138, 20);
            this.tb_luonghs_maugiao.TabIndex = 8;
            this.tb_luonghs_maugiao.Text = "01";
            this.tb_luonghs_maugiao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_luonghs_maugiao.TextChanged += new System.EventHandler(this.tb_luonghs_maugiao_TextChanged);
            // 
            // bt_luongsd_mg
            // 
            this.bt_luongsd_mg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luongsd_mg.Location = new System.Drawing.Point(343, 4);
            this.bt_luongsd_mg.Name = "bt_luongsd_mg";
            this.bt_luongsd_mg.Size = new System.Drawing.Size(66, 23);
            this.bt_luongsd_mg.TabIndex = 6;
            this.bt_luongsd_mg.Text = "S.LƯỢNG";
            this.bt_luongsd_mg.UseVisualStyleBackColor = true;
            // 
            // bt_stt_thucpham_mg
            // 
            this.bt_stt_thucpham_mg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_stt_thucpham_mg.Location = new System.Drawing.Point(5, 4);
            this.bt_stt_thucpham_mg.Name = "bt_stt_thucpham_mg";
            this.bt_stt_thucpham_mg.Size = new System.Drawing.Size(36, 23);
            this.bt_stt_thucpham_mg.TabIndex = 0;
            this.bt_stt_thucpham_mg.Text = "STT";
            this.bt_stt_thucpham_mg.UseVisualStyleBackColor = true;
            // 
            // bt_name_monan_mg
            // 
            this.bt_name_monan_mg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_name_monan_mg.Location = new System.Drawing.Point(47, 4);
            this.bt_name_monan_mg.Name = "bt_name_monan_mg";
            this.bt_name_monan_mg.Size = new System.Drawing.Size(146, 23);
            this.bt_name_monan_mg.TabIndex = 1;
            this.bt_name_monan_mg.Text = "TÊN THỰC PHẨM";
            this.bt_name_monan_mg.UseVisualStyleBackColor = true;
            // 
            // bt_donvi_tp_mg
            // 
            this.bt_donvi_tp_mg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_donvi_tp_mg.Location = new System.Drawing.Point(271, 4);
            this.bt_donvi_tp_mg.Name = "bt_donvi_tp_mg";
            this.bt_donvi_tp_mg.Size = new System.Drawing.Size(66, 23);
            this.bt_donvi_tp_mg.TabIndex = 5;
            this.bt_donvi_tp_mg.Text = "ĐƠN VỊ";
            this.bt_donvi_tp_mg.UseVisualStyleBackColor = true;
            // 
            // bt_type_mg
            // 
            this.bt_type_mg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_type_mg.Location = new System.Drawing.Point(199, 4);
            this.bt_type_mg.Name = "bt_type_mg";
            this.bt_type_mg.Size = new System.Drawing.Size(66, 23);
            this.bt_type_mg.TabIndex = 2;
            this.bt_type_mg.Text = "LOẠI TP";
            this.bt_type_mg.UseVisualStyleBackColor = true;
            // 
            // flp_thucpham_maugiao
            // 
            this.flp_thucpham_maugiao.AutoScroll = true;
            this.flp_thucpham_maugiao.Location = new System.Drawing.Point(3, 32);
            this.flp_thucpham_maugiao.Name = "flp_thucpham_maugiao";
            this.flp_thucpham_maugiao.Size = new System.Drawing.Size(497, 300);
            this.flp_thucpham_maugiao.TabIndex = 0;
            // 
            // bt_trongkho_mg
            // 
            this.bt_trongkho_mg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_trongkho_mg.Location = new System.Drawing.Point(415, 4);
            this.bt_trongkho_mg.Name = "bt_trongkho_mg";
            this.bt_trongkho_mg.Size = new System.Drawing.Size(60, 23);
            this.bt_trongkho_mg.TabIndex = 3;
            this.bt_trongkho_mg.Text = "KHO TP";
            this.bt_trongkho_mg.UseVisualStyleBackColor = true;
            // 
            // pn_thucpham_nhatre
            // 
            this.pn_thucpham_nhatre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_thucpham_nhatre.Controls.Add(this.label1_tp);
            this.pn_thucpham_nhatre.Controls.Add(this.bt_luonghs_nhatre);
            this.pn_thucpham_nhatre.Controls.Add(this.luonghs_nhatre);
            this.pn_thucpham_nhatre.Controls.Add(this.tb_luonghs_nhatre);
            this.pn_thucpham_nhatre.Controls.Add(this.bt_luongsd_nt);
            this.pn_thucpham_nhatre.Controls.Add(this.bt_stt_thucpham_nt);
            this.pn_thucpham_nhatre.Controls.Add(this.bt_name_monan_nt);
            this.pn_thucpham_nhatre.Controls.Add(this.bt_donvi_tp_nt);
            this.pn_thucpham_nhatre.Controls.Add(this.bt_type_nt);
            this.pn_thucpham_nhatre.Controls.Add(this.flp_thucpham_nhatre);
            this.pn_thucpham_nhatre.Controls.Add(this.bt_trongkho_nt);
            this.pn_thucpham_nhatre.Location = new System.Drawing.Point(10, 76);
            this.pn_thucpham_nhatre.Name = "pn_thucpham_nhatre";
            this.pn_thucpham_nhatre.Size = new System.Drawing.Size(504, 367);
            this.pn_thucpham_nhatre.TabIndex = 1;
            // 
            // label1_tp
            // 
            this.label1_tp.AutoSize = true;
            this.label1_tp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_tp.Location = new System.Drawing.Point(343, 341);
            this.label1_tp.Name = "label1_tp";
            this.label1_tp.Size = new System.Drawing.Size(54, 16);
            this.label1_tp.TabIndex = 11;
            this.label1_tp.Text = "CHÁU ";
            // 
            // bt_luonghs_nhatre
            // 
            this.bt_luonghs_nhatre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luonghs_nhatre.Location = new System.Drawing.Point(415, 338);
            this.bt_luonghs_nhatre.Name = "bt_luonghs_nhatre";
            this.bt_luonghs_nhatre.Size = new System.Drawing.Size(66, 23);
            this.bt_luonghs_nhatre.TabIndex = 10;
            this.bt_luonghs_nhatre.Text = "NHẬP";
            this.bt_luonghs_nhatre.UseVisualStyleBackColor = true;
            this.bt_luonghs_nhatre.Click += new System.EventHandler(this.bt_luonghs_nhatre_Click);
            // 
            // luonghs_nhatre
            // 
            this.luonghs_nhatre.AutoSize = true;
            this.luonghs_nhatre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luonghs_nhatre.Location = new System.Drawing.Point(8, 341);
            this.luonghs_nhatre.Name = "luonghs_nhatre";
            this.luonghs_nhatre.Size = new System.Drawing.Size(185, 16);
            this.luonghs_nhatre.TabIndex = 9;
            this.luonghs_nhatre.Text = "SỐ LƯỢNG HS NHÀ TRẺ:";
            // 
            // tb_luonghs_nhatre
            // 
            this.tb_luonghs_nhatre.Location = new System.Drawing.Point(199, 340);
            this.tb_luonghs_nhatre.Name = "tb_luonghs_nhatre";
            this.tb_luonghs_nhatre.Size = new System.Drawing.Size(138, 20);
            this.tb_luonghs_nhatre.TabIndex = 8;
            this.tb_luonghs_nhatre.Text = "01";
            this.tb_luonghs_nhatre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_luonghs_nhatre.TextChanged += new System.EventHandler(this.tb_luonghs_nhatre_TextChanged);
            // 
            // bt_luongsd_nt
            // 
            this.bt_luongsd_nt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luongsd_nt.Location = new System.Drawing.Point(343, 4);
            this.bt_luongsd_nt.Name = "bt_luongsd_nt";
            this.bt_luongsd_nt.Size = new System.Drawing.Size(66, 23);
            this.bt_luongsd_nt.TabIndex = 6;
            this.bt_luongsd_nt.Text = "S.LƯỢNG";
            this.bt_luongsd_nt.UseVisualStyleBackColor = true;
            // 
            // bt_stt_thucpham_nt
            // 
            this.bt_stt_thucpham_nt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_stt_thucpham_nt.Location = new System.Drawing.Point(5, 4);
            this.bt_stt_thucpham_nt.Name = "bt_stt_thucpham_nt";
            this.bt_stt_thucpham_nt.Size = new System.Drawing.Size(36, 23);
            this.bt_stt_thucpham_nt.TabIndex = 0;
            this.bt_stt_thucpham_nt.Text = "STT";
            this.bt_stt_thucpham_nt.UseVisualStyleBackColor = true;
            // 
            // bt_name_monan_nt
            // 
            this.bt_name_monan_nt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_name_monan_nt.Location = new System.Drawing.Point(47, 4);
            this.bt_name_monan_nt.Name = "bt_name_monan_nt";
            this.bt_name_monan_nt.Size = new System.Drawing.Size(146, 23);
            this.bt_name_monan_nt.TabIndex = 1;
            this.bt_name_monan_nt.Text = "TÊN THỰC PHẨM";
            this.bt_name_monan_nt.UseVisualStyleBackColor = true;
            // 
            // bt_donvi_tp_nt
            // 
            this.bt_donvi_tp_nt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_donvi_tp_nt.Location = new System.Drawing.Point(271, 4);
            this.bt_donvi_tp_nt.Name = "bt_donvi_tp_nt";
            this.bt_donvi_tp_nt.Size = new System.Drawing.Size(66, 23);
            this.bt_donvi_tp_nt.TabIndex = 5;
            this.bt_donvi_tp_nt.Text = "ĐƠN VỊ";
            this.bt_donvi_tp_nt.UseVisualStyleBackColor = true;
            // 
            // bt_type_nt
            // 
            this.bt_type_nt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_type_nt.Location = new System.Drawing.Point(199, 4);
            this.bt_type_nt.Name = "bt_type_nt";
            this.bt_type_nt.Size = new System.Drawing.Size(66, 23);
            this.bt_type_nt.TabIndex = 2;
            this.bt_type_nt.Text = "LOẠI TP";
            this.bt_type_nt.UseVisualStyleBackColor = true;
            // 
            // flp_thucpham_nhatre
            // 
            this.flp_thucpham_nhatre.AutoScroll = true;
            this.flp_thucpham_nhatre.Location = new System.Drawing.Point(3, 32);
            this.flp_thucpham_nhatre.Name = "flp_thucpham_nhatre";
            this.flp_thucpham_nhatre.Size = new System.Drawing.Size(497, 300);
            this.flp_thucpham_nhatre.TabIndex = 0;
            // 
            // bt_trongkho_nt
            // 
            this.bt_trongkho_nt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_trongkho_nt.Location = new System.Drawing.Point(415, 4);
            this.bt_trongkho_nt.Name = "bt_trongkho_nt";
            this.bt_trongkho_nt.Size = new System.Drawing.Size(60, 23);
            this.bt_trongkho_nt.TabIndex = 3;
            this.bt_trongkho_nt.Text = "KHO TP";
            this.bt_trongkho_nt.UseVisualStyleBackColor = true;
            // 
            // pn_td_dd
            // 
            this.pn_td_dd.BackColor = System.Drawing.Color.AliceBlue;
            this.pn_td_dd.Controls.Add(this.button1);
            this.pn_td_dd.Controls.Add(this.bt_left);
            this.pn_td_dd.Controls.Add(this.bt_right);
            this.pn_td_dd.Controls.Add(this.pn_vichat);
            this.pn_td_dd.Controls.Add(this.pn_thucdon);
            this.pn_td_dd.Controls.Add(this.bt_midle);
            this.pn_td_dd.Location = new System.Drawing.Point(12, 76);
            this.pn_td_dd.Name = "pn_td_dd";
            this.pn_td_dd.Size = new System.Drawing.Size(1025, 493);
            this.pn_td_dd.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(676, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 27);
            this.button1.TabIndex = 17;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_left
            // 
            this.bt_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_left.Location = new System.Drawing.Point(355, 449);
            this.bt_left.Name = "bt_left";
            this.bt_left.Size = new System.Drawing.Size(101, 27);
            this.bt_left.TabIndex = 16;
            this.bt_left.Text = "HỦY LỆNH";
            this.bt_left.UseVisualStyleBackColor = true;
            this.bt_left.Click += new System.EventHandler(this.bt_left_Click_1);
            // 
            // bt_right
            // 
            this.bt_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_right.Location = new System.Drawing.Point(569, 449);
            this.bt_right.Name = "bt_right";
            this.bt_right.Size = new System.Drawing.Size(101, 27);
            this.bt_right.TabIndex = 15;
            this.bt_right.Text = "LƯỢNG HS -->";
            this.bt_right.UseVisualStyleBackColor = true;
            this.bt_right.Click += new System.EventHandler(this.bt_right_Click);
            // 
            // pn_vichat
            // 
            this.pn_vichat.Controls.Add(this.label7);
            this.pn_vichat.Controls.Add(this.flp_vichat);
            this.pn_vichat.Location = new System.Drawing.Point(9, 9);
            this.pn_vichat.Name = "pn_vichat";
            this.pn_vichat.Size = new System.Drawing.Size(1002, 240);
            this.pn_vichat.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(248, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(507, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "BẢNG THỐNG KÊ LƯỢNG THÀNH PHẦN VI CHẤT";
            // 
            // flp_vichat
            // 
            this.flp_vichat.BackColor = System.Drawing.Color.AliceBlue;
            this.flp_vichat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_vichat.Controls.Add(this.panel1);
            this.flp_vichat.Controls.Add(this.pn_hl_nt);
            this.flp_vichat.Controls.Add(this.pn_hl_mg);
            this.flp_vichat.Location = new System.Drawing.Point(39, 28);
            this.flp_vichat.Name = "flp_vichat";
            this.flp_vichat.Size = new System.Drawing.Size(919, 209);
            this.flp_vichat.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 23);
            this.panel1.TabIndex = 16;
            // 
            // pn_hl_nt
            // 
            this.pn_hl_nt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.top_hover;
            this.pn_hl_nt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_hl_nt.Controls.Add(this.label1);
            this.pn_hl_nt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_hl_nt.Location = new System.Drawing.Point(101, 3);
            this.pn_hl_nt.Name = "pn_hl_nt";
            this.pn_hl_nt.Size = new System.Drawing.Size(402, 23);
            this.pn_hl_nt.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(74, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG THỐNG KÊ DANH CHO NHÀ TRẺ";
            // 
            // pn_hl_mg
            // 
            this.pn_hl_mg.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.top_hover;
            this.pn_hl_mg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_hl_mg.Controls.Add(this.label2);
            this.pn_hl_mg.Location = new System.Drawing.Point(509, 3);
            this.pn_hl_mg.Name = "pn_hl_mg";
            this.pn_hl_mg.Size = new System.Drawing.Size(402, 23);
            this.pn_hl_mg.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(74, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "BẢNG THỐNG KÊ DANH CHO MẪU GIÁO";
            // 
            // pn_thucdon
            // 
            this.pn_thucdon.Controls.Add(this.label8);
            this.pn_thucdon.Controls.Add(this.flp_thucdon);
            this.pn_thucdon.Location = new System.Drawing.Point(48, 255);
            this.pn_thucdon.Name = "pn_thucdon";
            this.pn_thucdon.Size = new System.Drawing.Size(919, 188);
            this.pn_thucdon.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(292, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(334, 24);
            this.label8.TabIndex = 26;
            this.label8.Text = "BẢNG THỰC ĐƠN TRONG NGÀY";
            // 
            // flp_thucdon
            // 
            this.flp_thucdon.BackColor = System.Drawing.Color.AliceBlue;
            this.flp_thucdon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_thucdon.Location = new System.Drawing.Point(6, 23);
            this.flp_thucdon.Name = "flp_thucdon";
            this.flp_thucdon.Size = new System.Drawing.Size(913, 157);
            this.flp_thucdon.TabIndex = 2;
            // 
            // bt_midle
            // 
            this.bt_midle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_midle.Location = new System.Drawing.Point(462, 449);
            this.bt_midle.Name = "bt_midle";
            this.bt_midle.Size = new System.Drawing.Size(101, 27);
            this.bt_midle.TabIndex = 14;
            this.bt_midle.Text = "CẬP NHẬT";
            this.bt_midle.UseVisualStyleBackColor = true;
            this.bt_midle.Click += new System.EventHandler(this.button14_Click);
            // 
            // bt_median_thucdon
            // 
            this.bt_median_thucdon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_median_thucdon.Location = new System.Drawing.Point(3, 3);
            this.bt_median_thucdon.Name = "bt_median_thucdon";
            this.bt_median_thucdon.Size = new System.Drawing.Size(102, 23);
            this.bt_median_thucdon.TabIndex = 1;
            this.bt_median_thucdon.Text = "BỮA ĂN";
            this.bt_median_thucdon.UseVisualStyleBackColor = true;
            // 
            // bt_link_thucdon
            // 
            this.bt_link_thucdon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_link_thucdon.Location = new System.Drawing.Point(111, 3);
            this.bt_link_thucdon.Name = "bt_link_thucdon";
            this.bt_link_thucdon.Size = new System.Drawing.Size(395, 23);
            this.bt_link_thucdon.TabIndex = 2;
            this.bt_link_thucdon.Text = "THỰC ĐƠN CỦA LỚP NHÀ TRẺ";
            this.bt_link_thucdon.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(512, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(395, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "THỰC ĐƠN TRONG NGÀY CỦA LỚP MẪU GIÁO";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bt_buasang_chinh
            // 
            this.bt_buasang_chinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buasang_chinh.Location = new System.Drawing.Point(3, 32);
            this.bt_buasang_chinh.Name = "bt_buasang_chinh";
            this.bt_buasang_chinh.Size = new System.Drawing.Size(102, 23);
            this.bt_buasang_chinh.TabIndex = 3;
            this.bt_buasang_chinh.Text = "Bữa sáng chính";
            this.bt_buasang_chinh.UseVisualStyleBackColor = true;
            // 
            // bt_buasang_phu
            // 
            this.bt_buasang_phu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buasang_phu.Location = new System.Drawing.Point(3, 61);
            this.bt_buasang_phu.Name = "bt_buasang_phu";
            this.bt_buasang_phu.Size = new System.Drawing.Size(102, 23);
            this.bt_buasang_phu.TabIndex = 5;
            this.bt_buasang_phu.Text = "Bữa sáng phụ";
            this.bt_buasang_phu.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Bữa trưa chính";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Bữa chiều phụ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pn_mua_thucpham
            // 
            this.pn_mua_thucpham.BackColor = System.Drawing.Color.AliceBlue;
            this.pn_mua_thucpham.Controls.Add(this.bt_sum_cp);
            this.pn_mua_thucpham.Controls.Add(this.bt_dv_dg);
            this.pn_mua_thucpham.Controls.Add(this.bt_tonkho);
            this.pn_mua_thucpham.Controls.Add(this.lb_donvi);
            this.pn_mua_thucpham.Controls.Add(this.tb_sum);
            this.pn_mua_thucpham.Controls.Add(this.lb_tong_tien);
            this.pn_mua_thucpham.Controls.Add(this.bt_back_tp);
            this.pn_mua_thucpham.Controls.Add(this.bt_export);
            this.pn_mua_thucpham.Controls.Add(this.bt_comp);
            this.pn_mua_thucpham.Controls.Add(this.bt_comment_cp);
            this.pn_mua_thucpham.Controls.Add(this.bt_dongia_thucpham_cp);
            this.pn_mua_thucpham.Controls.Add(this.bt_soluong_thucpham_cp);
            this.pn_mua_thucpham.Controls.Add(this.bt_unit_thucpham_cp);
            this.pn_mua_thucpham.Controls.Add(this.bt_name_thucpham_cp);
            this.pn_mua_thucpham.Controls.Add(this.bt_stt_cp);
            this.pn_mua_thucpham.Controls.Add(this.flp_mua_thucpham);
            this.pn_mua_thucpham.Controls.Add(this.headline_phieu_mua);
            this.pn_mua_thucpham.Location = new System.Drawing.Point(12, 76);
            this.pn_mua_thucpham.Name = "pn_mua_thucpham";
            this.pn_mua_thucpham.Size = new System.Drawing.Size(1026, 496);
            this.pn_mua_thucpham.TabIndex = 4;
            this.pn_mua_thucpham.Visible = false;
            // 
            // bt_sum_cp
            // 
            this.bt_sum_cp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sum_cp.Location = new System.Drawing.Point(703, 42);
            this.bt_sum_cp.Name = "bt_sum_cp";
            this.bt_sum_cp.Size = new System.Drawing.Size(93, 23);
            this.bt_sum_cp.TabIndex = 8;
            this.bt_sum_cp.Text = "THÀNH TIỀN";
            this.bt_sum_cp.UseVisualStyleBackColor = true;
            // 
            // bt_dv_dg
            // 
            this.bt_dv_dg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dv_dg.Location = new System.Drawing.Point(505, 42);
            this.bt_dv_dg.Name = "bt_dv_dg";
            this.bt_dv_dg.Size = new System.Drawing.Size(93, 23);
            this.bt_dv_dg.TabIndex = 17;
            this.bt_dv_dg.Text = "Đ.VỊ Đ.GIÁ";
            this.bt_dv_dg.UseVisualStyleBackColor = true;
            // 
            // bt_tonkho
            // 
            this.bt_tonkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tonkho.Location = new System.Drawing.Point(604, 42);
            this.bt_tonkho.Name = "bt_tonkho";
            this.bt_tonkho.Size = new System.Drawing.Size(93, 23);
            this.bt_tonkho.TabIndex = 16;
            this.bt_tonkho.Text = "TỒN KHO";
            this.bt_tonkho.UseVisualStyleBackColor = true;
            // 
            // lb_donvi
            // 
            this.lb_donvi.AutoSize = true;
            this.lb_donvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_donvi.Location = new System.Drawing.Point(604, 379);
            this.lb_donvi.Name = "lb_donvi";
            this.lb_donvi.Size = new System.Drawing.Size(99, 20);
            this.lb_donvi.TabIndex = 15;
            this.lb_donvi.Text = "ngàn đồng.";
            this.lb_donvi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_sum
            // 
            this.tb_sum.Location = new System.Drawing.Point(505, 382);
            this.tb_sum.Name = "tb_sum";
            this.tb_sum.Size = new System.Drawing.Size(93, 20);
            this.tb_sum.TabIndex = 14;
            // 
            // lb_tong_tien
            // 
            this.lb_tong_tien.AutoSize = true;
            this.lb_tong_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tong_tien.Location = new System.Drawing.Point(292, 379);
            this.lb_tong_tien.Name = "lb_tong_tien";
            this.lb_tong_tien.Size = new System.Drawing.Size(207, 20);
            this.lb_tong_tien.TabIndex = 13;
            this.lb_tong_tien.Text = "Tổng tiền chi trong ngày:";
            this.lb_tong_tien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_back_tp
            // 
            this.bt_back_tp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back_tp.Location = new System.Drawing.Point(352, 443);
            this.bt_back_tp.Name = "bt_back_tp";
            this.bt_back_tp.Size = new System.Drawing.Size(102, 29);
            this.bt_back_tp.TabIndex = 12;
            this.bt_back_tp.Text = "<-- LƯỢNG TP";
            this.bt_back_tp.UseVisualStyleBackColor = true;
            this.bt_back_tp.Click += new System.EventHandler(this.bt_back_tp_Click);
            // 
            // bt_export
            // 
            this.bt_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_export.Location = new System.Drawing.Point(570, 443);
            this.bt_export.Name = "bt_export";
            this.bt_export.Size = new System.Drawing.Size(102, 29);
            this.bt_export.TabIndex = 11;
            this.bt_export.Text = "CHI PHÍ -->";
            this.bt_export.UseVisualStyleBackColor = true;
            this.bt_export.Click += new System.EventHandler(this.bt_export_Click);
            // 
            // bt_comp
            // 
            this.bt_comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_comp.Location = new System.Drawing.Point(462, 443);
            this.bt_comp.Name = "bt_comp";
            this.bt_comp.Size = new System.Drawing.Size(102, 29);
            this.bt_comp.TabIndex = 10;
            this.bt_comp.Text = "XUẤT PHIẾU";
            this.bt_comp.UseVisualStyleBackColor = true;
            this.bt_comp.Click += new System.EventHandler(this.bt_comp_Click);
            // 
            // bt_comment_cp
            // 
            this.bt_comment_cp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_comment_cp.Location = new System.Drawing.Point(802, 42);
            this.bt_comment_cp.Name = "bt_comment_cp";
            this.bt_comment_cp.Size = new System.Drawing.Size(220, 23);
            this.bt_comment_cp.TabIndex = 9;
            this.bt_comment_cp.Text = "GHI CHÚ";
            this.bt_comment_cp.UseVisualStyleBackColor = true;
            // 
            // bt_dongia_thucpham_cp
            // 
            this.bt_dongia_thucpham_cp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dongia_thucpham_cp.Location = new System.Drawing.Point(406, 42);
            this.bt_dongia_thucpham_cp.Name = "bt_dongia_thucpham_cp";
            this.bt_dongia_thucpham_cp.Size = new System.Drawing.Size(93, 23);
            this.bt_dongia_thucpham_cp.TabIndex = 7;
            this.bt_dongia_thucpham_cp.Text = "ĐƠN GIÁ";
            this.bt_dongia_thucpham_cp.UseVisualStyleBackColor = true;
            // 
            // bt_soluong_thucpham_cp
            // 
            this.bt_soluong_thucpham_cp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_soluong_thucpham_cp.Location = new System.Drawing.Point(307, 42);
            this.bt_soluong_thucpham_cp.Name = "bt_soluong_thucpham_cp";
            this.bt_soluong_thucpham_cp.Size = new System.Drawing.Size(93, 23);
            this.bt_soluong_thucpham_cp.TabIndex = 6;
            this.bt_soluong_thucpham_cp.Text = "S.LƯỢNG";
            this.bt_soluong_thucpham_cp.UseVisualStyleBackColor = true;
            // 
            // bt_unit_thucpham_cp
            // 
            this.bt_unit_thucpham_cp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_unit_thucpham_cp.Location = new System.Drawing.Point(208, 42);
            this.bt_unit_thucpham_cp.Name = "bt_unit_thucpham_cp";
            this.bt_unit_thucpham_cp.Size = new System.Drawing.Size(93, 23);
            this.bt_unit_thucpham_cp.TabIndex = 5;
            this.bt_unit_thucpham_cp.Text = "ĐƠN VỊ";
            this.bt_unit_thucpham_cp.UseVisualStyleBackColor = true;
            // 
            // bt_name_thucpham_cp
            // 
            this.bt_name_thucpham_cp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_name_thucpham_cp.Location = new System.Drawing.Point(46, 42);
            this.bt_name_thucpham_cp.Name = "bt_name_thucpham_cp";
            this.bt_name_thucpham_cp.Size = new System.Drawing.Size(156, 23);
            this.bt_name_thucpham_cp.TabIndex = 4;
            this.bt_name_thucpham_cp.Text = "TÊN THỰC PHẨM";
            this.bt_name_thucpham_cp.UseVisualStyleBackColor = true;
            // 
            // bt_stt_cp
            // 
            this.bt_stt_cp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_stt_cp.Location = new System.Drawing.Point(6, 43);
            this.bt_stt_cp.Name = "bt_stt_cp";
            this.bt_stt_cp.Size = new System.Drawing.Size(34, 23);
            this.bt_stt_cp.TabIndex = 3;
            this.bt_stt_cp.Text = "T.T";
            this.bt_stt_cp.UseVisualStyleBackColor = true;
            // 
            // flp_mua_thucpham
            // 
            this.flp_mua_thucpham.AllowDrop = true;
            this.flp_mua_thucpham.AutoScroll = true;
            this.flp_mua_thucpham.Location = new System.Drawing.Point(6, 71);
            this.flp_mua_thucpham.Name = "flp_mua_thucpham";
            this.flp_mua_thucpham.Size = new System.Drawing.Size(1015, 305);
            this.flp_mua_thucpham.TabIndex = 2;
            // 
            // headline_phieu_mua
            // 
            this.headline_phieu_mua.AutoSize = true;
            this.headline_phieu_mua.BackColor = System.Drawing.Color.Transparent;
            this.headline_phieu_mua.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headline_phieu_mua.ForeColor = System.Drawing.Color.Black;
            this.headline_phieu_mua.Location = new System.Drawing.Point(353, 4);
            this.headline_phieu_mua.Name = "headline_phieu_mua";
            this.headline_phieu_mua.Size = new System.Drawing.Size(325, 24);
            this.headline_phieu_mua.TabIndex = 1;
            this.headline_phieu_mua.Text = "PHIẾU MUA HÀNG - XUẤT KHO";
            // 
            // pn_thongke_end
            // 
            this.pn_thongke_end.BackColor = System.Drawing.Color.AliceBlue;
            this.pn_thongke_end.Controls.Add(this.bt_print);
            this.pn_thongke_end.Controls.Add(this.bt_back);
            this.pn_thongke_end.Controls.Add(this.bt_export_end);
            this.pn_thongke_end.Controls.Add(this.pn_luonghs_end);
            this.pn_thongke_end.Controls.Add(this.pn_thucpham_end);
            this.pn_thongke_end.Controls.Add(this.headline_end);
            this.pn_thongke_end.Location = new System.Drawing.Point(12, 76);
            this.pn_thongke_end.Name = "pn_thongke_end";
            this.pn_thongke_end.Size = new System.Drawing.Size(1025, 489);
            this.pn_thongke_end.TabIndex = 4;
            this.pn_thongke_end.Visible = false;
            // 
            // bt_print
            // 
            this.bt_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_print.Location = new System.Drawing.Point(563, 432);
            this.bt_print.Name = "bt_print";
            this.bt_print.Size = new System.Drawing.Size(107, 32);
            this.bt_print.TabIndex = 8;
            this.bt_print.Text = "IN (.doc)";
            this.bt_print.UseVisualStyleBackColor = true;
            this.bt_print.Click += new System.EventHandler(this.bt_print_Click);
            // 
            // bt_back
            // 
            this.bt_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back.Location = new System.Drawing.Point(337, 432);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(107, 32);
            this.bt_back.TabIndex = 7;
            this.bt_back.Text = "<-- XEM LẠI";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // bt_export_end
            // 
            this.bt_export_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_export_end.Location = new System.Drawing.Point(450, 432);
            this.bt_export_end.Name = "bt_export_end";
            this.bt_export_end.Size = new System.Drawing.Size(107, 32);
            this.bt_export_end.TabIndex = 6;
            this.bt_export_end.Text = "PHIẾU THU";
            this.bt_export_end.UseVisualStyleBackColor = true;
            this.bt_export_end.Click += new System.EventHandler(this.bt_export_end_Click);
            // 
            // pn_luonghs_end
            // 
            this.pn_luonghs_end.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_luonghs_end.Controls.Add(this.bt_nhatre);
            this.pn_luonghs_end.Controls.Add(this.bt_maugiao);
            this.pn_luonghs_end.Controls.Add(this.tb_chiphi_nhatre);
            this.pn_luonghs_end.Controls.Add(this.tb_chiphi_maugiao);
            this.pn_luonghs_end.Controls.Add(this.bt_tong_chiphi);
            this.pn_luonghs_end.Location = new System.Drawing.Point(622, 48);
            this.pn_luonghs_end.Name = "pn_luonghs_end";
            this.pn_luonghs_end.Size = new System.Drawing.Size(381, 367);
            this.pn_luonghs_end.TabIndex = 4;
            // 
            // bt_nhatre
            // 
            this.bt_nhatre.Location = new System.Drawing.Point(122, 4);
            this.bt_nhatre.Name = "bt_nhatre";
            this.bt_nhatre.Size = new System.Drawing.Size(110, 23);
            this.bt_nhatre.TabIndex = 21;
            this.bt_nhatre.Text = "NHÀ TRẺ";
            this.bt_nhatre.UseVisualStyleBackColor = true;
            // 
            // bt_maugiao
            // 
            this.bt_maugiao.Location = new System.Drawing.Point(252, 4);
            this.bt_maugiao.Name = "bt_maugiao";
            this.bt_maugiao.Size = new System.Drawing.Size(107, 23);
            this.bt_maugiao.TabIndex = 20;
            this.bt_maugiao.Text = "MẪU GIÁO";
            this.bt_maugiao.UseVisualStyleBackColor = true;
            // 
            // tb_chiphi_nhatre
            // 
            this.tb_chiphi_nhatre.Location = new System.Drawing.Point(122, 34);
            this.tb_chiphi_nhatre.Name = "tb_chiphi_nhatre";
            this.tb_chiphi_nhatre.Size = new System.Drawing.Size(110, 20);
            this.tb_chiphi_nhatre.TabIndex = 16;
            // 
            // tb_chiphi_maugiao
            // 
            this.tb_chiphi_maugiao.Location = new System.Drawing.Point(252, 34);
            this.tb_chiphi_maugiao.Name = "tb_chiphi_maugiao";
            this.tb_chiphi_maugiao.Size = new System.Drawing.Size(107, 20);
            this.tb_chiphi_maugiao.TabIndex = 15;
            // 
            // bt_tong_chiphi
            // 
            this.bt_tong_chiphi.Location = new System.Drawing.Point(31, 32);
            this.bt_tong_chiphi.Name = "bt_tong_chiphi";
            this.bt_tong_chiphi.Size = new System.Drawing.Size(85, 23);
            this.bt_tong_chiphi.TabIndex = 0;
            this.bt_tong_chiphi.Text = "Chi phí";
            this.bt_tong_chiphi.UseVisualStyleBackColor = true;
            // 
            // pn_thucpham_end
            // 
            this.pn_thucpham_end.AllowDrop = true;
            this.pn_thucpham_end.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_thucpham_end.Controls.Add(this.bt_price_tp_end);
            this.pn_thucpham_end.Controls.Add(this.bt_stt_end);
            this.pn_thucpham_end.Controls.Add(this.bt_name_monan_end);
            this.pn_thucpham_end.Controls.Add(this.bt_luong_tp_sd_end);
            this.pn_thucpham_end.Controls.Add(this.flp_thucpham);
            this.pn_thucpham_end.Controls.Add(this.bt_thanhtien_end);
            this.pn_thucpham_end.Controls.Add(this.bt_donvi_end);
            this.pn_thucpham_end.Location = new System.Drawing.Point(3, 48);
            this.pn_thucpham_end.Name = "pn_thucpham_end";
            this.pn_thucpham_end.Size = new System.Drawing.Size(613, 367);
            this.pn_thucpham_end.TabIndex = 3;
            // 
            // bt_price_tp_end
            // 
            this.bt_price_tp_end.Location = new System.Drawing.Point(308, 4);
            this.bt_price_tp_end.Name = "bt_price_tp_end";
            this.bt_price_tp_end.Size = new System.Drawing.Size(79, 23);
            this.bt_price_tp_end.TabIndex = 6;
            this.bt_price_tp_end.Text = "GIÁ TIỀN";
            this.bt_price_tp_end.UseVisualStyleBackColor = true;
            // 
            // bt_stt_end
            // 
            this.bt_stt_end.Location = new System.Drawing.Point(5, 4);
            this.bt_stt_end.Name = "bt_stt_end";
            this.bt_stt_end.Size = new System.Drawing.Size(36, 23);
            this.bt_stt_end.TabIndex = 0;
            this.bt_stt_end.Text = "STT";
            this.bt_stt_end.UseVisualStyleBackColor = true;
            // 
            // bt_name_monan_end
            // 
            this.bt_name_monan_end.Location = new System.Drawing.Point(47, 4);
            this.bt_name_monan_end.Name = "bt_name_monan_end";
            this.bt_name_monan_end.Size = new System.Drawing.Size(171, 23);
            this.bt_name_monan_end.TabIndex = 1;
            this.bt_name_monan_end.Text = "Tên Thực Phẩm";
            this.bt_name_monan_end.UseVisualStyleBackColor = true;
            // 
            // bt_luong_tp_sd_end
            // 
            this.bt_luong_tp_sd_end.Location = new System.Drawing.Point(224, 4);
            this.bt_luong_tp_sd_end.Name = "bt_luong_tp_sd_end";
            this.bt_luong_tp_sd_end.Size = new System.Drawing.Size(78, 23);
            this.bt_luong_tp_sd_end.TabIndex = 5;
            this.bt_luong_tp_sd_end.Text = "S.LƯỢNG";
            this.bt_luong_tp_sd_end.UseVisualStyleBackColor = true;
            // 
            // flp_thucpham
            // 
            this.flp_thucpham.AllowDrop = true;
            this.flp_thucpham.AutoScroll = true;
            this.flp_thucpham.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.flp_thucpham.Location = new System.Drawing.Point(3, 32);
            this.flp_thucpham.Name = "flp_thucpham";
            this.flp_thucpham.Size = new System.Drawing.Size(606, 330);
            this.flp_thucpham.TabIndex = 0;
            // 
            // bt_thanhtien_end
            // 
            this.bt_thanhtien_end.Location = new System.Drawing.Point(492, 4);
            this.bt_thanhtien_end.Name = "bt_thanhtien_end";
            this.bt_thanhtien_end.Size = new System.Drawing.Size(95, 23);
            this.bt_thanhtien_end.TabIndex = 4;
            this.bt_thanhtien_end.Text = "THÀNH TIỀN";
            this.bt_thanhtien_end.UseVisualStyleBackColor = true;
            // 
            // bt_donvi_end
            // 
            this.bt_donvi_end.Location = new System.Drawing.Point(393, 4);
            this.bt_donvi_end.Name = "bt_donvi_end";
            this.bt_donvi_end.Size = new System.Drawing.Size(93, 23);
            this.bt_donvi_end.TabIndex = 3;
            this.bt_donvi_end.Text = "ĐƠN VỊ";
            this.bt_donvi_end.UseVisualStyleBackColor = true;
            // 
            // headline_end
            // 
            this.headline_end.AutoSize = true;
            this.headline_end.BackColor = System.Drawing.Color.Transparent;
            this.headline_end.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headline_end.ForeColor = System.Drawing.Color.Crimson;
            this.headline_end.Location = new System.Drawing.Point(243, 4);
            this.headline_end.Name = "headline_end";
            this.headline_end.Size = new System.Drawing.Size(538, 24);
            this.headline_end.TabIndex = 2;
            this.headline_end.Text = "PHIẾU MUA HÀNG VÀ CHI PHÍ CỦA TỪNG HỌC SINH";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 573);
            this.Controls.Add(this.pn_mua_thucpham);
            this.Controls.Add(this.pn_td_dd);
            this.Controls.Add(this.pn_thongke_end);
            this.Controls.Add(this.pn_head);
            this.Controls.Add(this.pn_thucpham_luonghs);
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.pn_head.ResumeLayout(false);
            this.pn_head.PerformLayout();
            this.pn_thucpham_luonghs.ResumeLayout(false);
            this.pn_thucpham_luonghs.PerformLayout();
            this.pn_thucpham_maugiao.ResumeLayout(false);
            this.pn_thucpham_maugiao.PerformLayout();
            this.pn_thucpham_nhatre.ResumeLayout(false);
            this.pn_thucpham_nhatre.PerformLayout();
            this.pn_td_dd.ResumeLayout(false);
            this.pn_vichat.ResumeLayout(false);
            this.pn_vichat.PerformLayout();
            this.flp_vichat.ResumeLayout(false);
            this.pn_hl_nt.ResumeLayout(false);
            this.pn_hl_nt.PerformLayout();
            this.pn_hl_mg.ResumeLayout(false);
            this.pn_hl_mg.PerformLayout();
            this.pn_thucdon.ResumeLayout(false);
            this.pn_thucdon.PerformLayout();
            this.pn_mua_thucpham.ResumeLayout(false);
            this.pn_mua_thucpham.PerformLayout();
            this.pn_thongke_end.ResumeLayout(false);
            this.pn_thongke_end.PerformLayout();
            this.pn_luonghs_end.ResumeLayout(false);
            this.pn_luonghs_end.PerformLayout();
            this.pn_thucpham_end.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_head;
        private System.Windows.Forms.Label headline_title;
        private System.Windows.Forms.Label headline_mainboard;
        //FORM PHIEU MUA THUC PHAM
        private System.Windows.Forms.Panel pn_mua_thucpham;
        private System.Windows.Forms.Label headline_phieu_mua;
        private System.Windows.Forms.FlowLayoutPanel flp_mua_thucpham;
        private System.Windows.Forms.Button bt_stt_cp;
        private System.Windows.Forms.Button bt_name_thucpham_cp;
        private System.Windows.Forms.Button bt_unit_thucpham_cp;
        private System.Windows.Forms.Button bt_comment_cp;
        private System.Windows.Forms.Button bt_sum_cp;
        private System.Windows.Forms.Button bt_dongia_thucpham_cp;
        private System.Windows.Forms.Button bt_soluong_thucpham_cp;
        private System.Windows.Forms.Button bt_export;
        private System.Windows.Forms.Button bt_comp;
        private System.Windows.Forms.Button bt_back_tp;
        private System.Windows.Forms.Label lb_tong_tien;
        private System.Windows.Forms.TextBox tb_sum;
        private System.Windows.Forms.Label lb_donvi;
        private System.Windows.Forms.TextBox[] tb_stt_cp = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_name_tp_cp = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_unit_tp_cp = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_luong_tp_cp = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_price_tp_cp = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_donvi_dongia_cp = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_tonkho_cp = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_comp_tp_cp = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_comment_tp_cp = new TextBox[100];
        //FORM THUCPHAM - LUONGHS
        private System.Windows.Forms.Panel pn_thucpham_luonghs;
        private System.Windows.Forms.Panel pn_thucpham_nhatre;
        private System.Windows.Forms.Button bt_luongsd_nt;
        private System.Windows.Forms.Button bt_stt_thucpham_nt;
        private System.Windows.Forms.Button bt_donvi_tp_nt;
        private System.Windows.Forms.Button bt_type_nt;
        private System.Windows.Forms.FlowLayoutPanel flp_thucpham_nhatre;
        private System.Windows.Forms.TextBox[] tb_stt_nt = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_name_thucpham_nt = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_type_nt = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_donvi_tp_nt = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_luongsd_nt = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_trongkho_nt = new TextBox[100];
        private System.Windows.Forms.Button bt_trongkho_nt;
        private System.Windows.Forms.TextBox tb_luonghs_nhatre;
        private System.Windows.Forms.Button bt_name_monan_nt;
        private System.Windows.Forms.Label luonghs_nhatre;
        private System.Windows.Forms.Button bt_luonghs_nhatre;
        private System.Windows.Forms.Label label1_tp;
        private System.Windows.Forms.Panel pn_thucpham_maugiao;
        private System.Windows.Forms.Label label2_tp;
        private System.Windows.Forms.Button bt_luonghs_maugiao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_luonghs_maugiao;
        private System.Windows.Forms.Button bt_luongsd_mg;
        private System.Windows.Forms.Button bt_stt_thucpham_mg;
        private System.Windows.Forms.Button bt_name_monan_mg;
        private System.Windows.Forms.Button bt_donvi_tp_mg;
        private System.Windows.Forms.Button bt_type_mg;
        private System.Windows.Forms.FlowLayoutPanel flp_thucpham_maugiao;
        private System.Windows.Forms.TextBox[] tb_stt_mg = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_name_thucpham_mg = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_type_mg = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_donvi_tp_mg = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_luongsd_mg = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_trongkho_mg = new TextBox[100];
        private System.Windows.Forms.Button bt_trongkho_mg;
        private System.Windows.Forms.Button bt_chiphi;
        private System.Windows.Forms.Button bt_td_vc;
        private System.Windows.Forms.Button bt_left_tp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_mainboard;
        //FORM THUCDON - VICHAT
        private System.Windows.Forms.Panel pn_td_dd;
        private System.Windows.Forms.Panel pn_thucdon;
        private System.Windows.Forms.FlowLayoutPanel flp_thucdon;
        private System.Windows.Forms.Button bt_median_thucdon;
        private System.Windows.Forms.Button bt_link_thucdon;
        private System.Windows.Forms.Button bt_buasang_chinh;
        private System.Windows.Forms.Button bt_buasang_phu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pn_vichat;
        private System.Windows.Forms.FlowLayoutPanel flp_vichat;
        private System.Windows.Forms.Button[] bt_name_vichat = new Button[12];
        private System.Windows.Forms.Button[] bt_buaan = new Button[6];
        private System.Windows.Forms.Button bt_midle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox[] cb_monan = new ComboBox[12];
        private System.Windows.Forms.Panel pn_hl_nt;
        private System.Windows.Forms.Panel pn_hl_mg;
        private System.Windows.Forms.TextBox[,] tb_luong_vichat = new TextBox[6, 12];
        private System.Windows.Forms.Button bt_left;
        private System.Windows.Forms.Button bt_right;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private modun_quanli_thucdon_dinhduong nhatre = new modun_quanli_thucdon_dinhduong();
        private modun_quanli_thucdon_dinhduong maugiao = new modun_quanli_thucdon_dinhduong();
        public int count_tp_buy = 0;
        public int count_tp_kho = 0;

        public int[] luong_tp_kho = new int[100];
        public string[] name_tp_kho = new string[100];
        public int[] dongia_kho = new int[100];
        
        public int[] luong_tp_buy = new int[100];
        public string[] name_tp_buy = new string[100];
        public int[] dongia_buy = new int[100];

        public int[] luongsd_nhatre = new int[100];
        public int[] dongia_nhatre = new int[100];

        public int[] luongsd_maugiao = new int[100];
        public int[] dongia_maugiao = new int[100];

        private Button button1;
        private Label label6;
        private Label label7;
        private Label label8;
        //BANG THONG KE CUOI
        private System.Windows.Forms.Panel pn_thongke_end;
        private System.Windows.Forms.Label headline_end;
        private System.Windows.Forms.Panel pn_thucpham_end;
        private System.Windows.Forms.Button bt_price_tp_end;
        private System.Windows.Forms.Button bt_stt_end;
        private System.Windows.Forms.Button bt_name_monan_end;
        private System.Windows.Forms.Button bt_luong_tp_sd_end;
        private System.Windows.Forms.FlowLayoutPanel flp_thucpham;
        private System.Windows.Forms.Button bt_thanhtien_end;
        private System.Windows.Forms.Button bt_donvi_end;
        private System.Windows.Forms.Panel pn_luonghs_end;
        private System.Windows.Forms.Button bt_nhatre;
        private System.Windows.Forms.Button bt_maugiao;
        private System.Windows.Forms.TextBox tb_chiphi_nhatre;
        private System.Windows.Forms.TextBox tb_chiphi_maugiao;
        private System.Windows.Forms.Button bt_tong_chiphi;
        private System.Windows.Forms.Button bt_print;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Button bt_export_end;
        private System.Windows.Forms.TextBox[] tb_stt_end = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_name_tp_end = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_luong_tp_end = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_price_tp_end = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_unit_tp_end = new TextBox[100];
        private System.Windows.Forms.TextBox[] tb_thanhtien_end = new TextBox[100];
        private Button bt_tonkho;
        private Button bt_dv_dg;
        private Panel pn_kho;
        private Label lb_kho;
        private int[] luong_tonkho = new int[1000];
        //private int countThucPhamNeed = 0;
        private int[] IDTPNeed = new int[500];
        private int[] LuongTPNeed = new int[500];
        private modun_quanli_kho MD_qlk;
    }
}