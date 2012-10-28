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
    partial class fr_thongke_monan
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
            this.head_line_nhap = new System.Windows.Forms.Label();
            this.bt_sumit = new System.Windows.Forms.Button();
            this.bt_main_form = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_id_monan = new System.Windows.Forms.Button();
            this.bt_tp_monan = new System.Windows.Forms.Button();
            this.bt_name_buaan = new System.Windows.Forms.Button();
            this.bt_luong_monan = new System.Windows.Forms.Button();
            this.bt_name_monan = new System.Windows.Forms.Button();
            this.flp_nhap_monan = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.pn_head = new System.Windows.Forms.Panel();
            this.headline_title = new System.Windows.Forms.Label();
            this.headline_mainboard = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.go = new System.Windows.Forms.Button();
            this.pn_head.SuspendLayout();
            this.SuspendLayout();
            // 
            // head_line_nhap
            // 
            this.head_line_nhap.Location = new System.Drawing.Point(0, 0);
            this.head_line_nhap.Name = "head_line_nhap";
            this.head_line_nhap.Size = new System.Drawing.Size(100, 23);
            this.head_line_nhap.TabIndex = 12;
            // 
            // bt_sumit
            // 
            this.bt_sumit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sumit.Location = new System.Drawing.Point(564, 589);
            this.bt_sumit.Name = "bt_sumit";
            this.bt_sumit.Size = new System.Drawing.Size(104, 30);
            this.bt_sumit.TabIndex = 2;
            this.bt_sumit.Text = "CẬP NHẬP";
            this.bt_sumit.UseVisualStyleBackColor = true;
            // 
            // bt_main_form
            // 
            this.bt_main_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_main_form.Location = new System.Drawing.Point(674, 589);
            this.bt_main_form.Name = "bt_main_form";
            this.bt_main_form.Size = new System.Drawing.Size(104, 30);
            this.bt_main_form.TabIndex = 3;
            this.bt_main_form.Text = "NHẬP MỚI";
            this.bt_main_form.UseVisualStyleBackColor = true;
            this.bt_main_form.Click += new System.EventHandler(this.bt_main_form_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.Location = new System.Drawing.Point(454, 590);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(104, 30);
            this.bt_delete.TabIndex = 4;
            this.bt_delete.Text = "HỦY";
            this.bt_delete.UseVisualStyleBackColor = true;
            // 
            // bt_id_monan
            // 
            this.bt_id_monan.Location = new System.Drawing.Point(12, 139);
            this.bt_id_monan.Name = "bt_id_monan";
            this.bt_id_monan.Size = new System.Drawing.Size(35, 23);
            this.bt_id_monan.TabIndex = 5;
            this.bt_id_monan.Text = "T.T";
            this.bt_id_monan.UseVisualStyleBackColor = true;
            // 
            // bt_tp_monan
            // 
            this.bt_tp_monan.Location = new System.Drawing.Point(403, 139);
            this.bt_tp_monan.Name = "bt_tp_monan";
            this.bt_tp_monan.Size = new System.Drawing.Size(788, 23);
            this.bt_tp_monan.TabIndex = 7;
            this.bt_tp_monan.Text = "THÀNH PHẦN THỰC PHẨM SỬ DỤNG";
            this.bt_tp_monan.UseVisualStyleBackColor = true;
            // 
            // bt_name_buaan
            // 
            this.bt_name_buaan.Location = new System.Drawing.Point(195, 139);
            this.bt_name_buaan.Name = "bt_name_buaan";
            this.bt_name_buaan.Size = new System.Drawing.Size(81, 23);
            this.bt_name_buaan.TabIndex = 8;
            this.bt_name_buaan.Text = "BỮA ĂN";
            this.bt_name_buaan.UseVisualStyleBackColor = true;
            // 
            // bt_luong_monan
            // 
            this.bt_luong_monan.Location = new System.Drawing.Point(282, 139);
            this.bt_luong_monan.Name = "bt_luong_monan";
            this.bt_luong_monan.Size = new System.Drawing.Size(81, 23);
            this.bt_luong_monan.TabIndex = 9;
            this.bt_luong_monan.Text = "S.LƯỢNG";
            this.bt_luong_monan.UseVisualStyleBackColor = true;
            // 
            // bt_name_monan
            // 
            this.bt_name_monan.Location = new System.Drawing.Point(53, 139);
            this.bt_name_monan.Name = "bt_name_monan";
            this.bt_name_monan.Size = new System.Drawing.Size(136, 23);
            this.bt_name_monan.TabIndex = 10;
            this.bt_name_monan.Text = "TÊN MÓN ĂN";
            this.bt_name_monan.UseVisualStyleBackColor = true;
            // 
            // flp_nhap_monan
            // 
            this.flp_nhap_monan.AutoScroll = true;
            this.flp_nhap_monan.Location = new System.Drawing.Point(12, 168);
            this.flp_nhap_monan.Name = "flp_nhap_monan";
            this.flp_nhap_monan.Size = new System.Drawing.Size(1203, 385);
            this.flp_nhap_monan.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(784, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 30);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pn_head
            // 
            this.pn_head.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_head.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bg_menu_top_1x33;
            this.pn_head.Controls.Add(this.headline_title);
            this.pn_head.Controls.Add(this.headline_mainboard);
            this.pn_head.Location = new System.Drawing.Point(12, 12);
            this.pn_head.Name = "pn_head";
            this.pn_head.Size = new System.Drawing.Size(1203, 72);
            this.pn_head.TabIndex = 14;
            // 
            // headline_title
            // 
            this.headline_title.AutoSize = true;
            this.headline_title.BackColor = System.Drawing.Color.Transparent;
            this.headline_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headline_title.ForeColor = System.Drawing.Color.AliceBlue;
            this.headline_title.Location = new System.Drawing.Point(248, 10);
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
            this.headline_mainboard.Location = new System.Drawing.Point(421, 44);
            this.headline_mainboard.Name = "headline_mainboard";
            this.headline_mainboard.Size = new System.Drawing.Size(361, 24);
            this.headline_mainboard.TabIndex = 0;
            this.headline_mainboard.Text = "PHẦN MỀM QUẢN LÍ DINH DƯỠNG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(276, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(680, 26);
            this.label7.TabIndex = 26;
            this.label7.Text = "BẢNG THỐNG KÊ CHI TIẾT MÓN ĂN ĐƯỢC SỬ DỤNG MỚI";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(12, 559);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(35, 23);
            this.back.TabIndex = 27;
            this.back.Text = "<--";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // go
            // 
            this.go.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go.Location = new System.Drawing.Point(1181, 559);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(34, 23);
            this.go.TabIndex = 28;
            this.go.Text = "-->";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // fr_thongke_monan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1232, 632);
            this.Controls.Add(this.go);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pn_head);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flp_nhap_monan);
            this.Controls.Add(this.bt_name_monan);
            this.Controls.Add(this.bt_luong_monan);
            this.Controls.Add(this.bt_name_buaan);
            this.Controls.Add(this.bt_tp_monan);
            this.Controls.Add(this.bt_id_monan);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_main_form);
            this.Controls.Add(this.bt_sumit);
            this.Name = "fr_thongke_monan";
            this.Text = "Nhập thông tin cho Thực đơn trong trường";
            this.pn_head.ResumeLayout(false);
            this.pn_head.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label head_line_nhap;
        private System.Windows.Forms.Button bt_sumit;
        private System.Windows.Forms.Button bt_main_form;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_id_monan;
        private System.Windows.Forms.Button bt_tp_monan;
        private System.Windows.Forms.Button bt_name_buaan;
        private System.Windows.Forms.Button bt_luong_monan;
        private System.Windows.Forms.Button bt_name_monan;
        private System.Windows.Forms.FlowLayoutPanel flp_nhap_monan;
        private System.Windows.Forms.FlowLayoutPanel[] flp_monan = new System.Windows.Forms.FlowLayoutPanel[150];
        private System.Windows.Forms.TextBox[] tb_id_monan = new System.Windows.Forms.TextBox[150];
        private System.Windows.Forms.ComboBox[] cb_buaan = new System.Windows.Forms.ComboBox[150];
        private System.Windows.Forms.TextBox[] tb_luong_monan = new System.Windows.Forms.TextBox[150];
        private System.Windows.Forms.Panel[,] pn_thucpham = new System.Windows.Forms.Panel[150, 80];
        private System.Windows.Forms.TextBox[,] tb_luong_thucpham = new System.Windows.Forms.TextBox[150, 80];
        private System.Windows.Forms.ComboBox[,] cb_name_thucpham = new System.Windows.Forms.ComboBox[150, 80];
        private System.Windows.Forms.TextBox[] tb_name_monan = new System.Windows.Forms.TextBox[150];
        private System.Windows.Forms.Panel[] pn_control_thucpham = new System.Windows.Forms.Panel[150];
        private System.Windows.Forms.Button[] bt_remove_thucpham = new System.Windows.Forms.Button[150];
        private System.Windows.Forms.Button[] bt_add_thucpham = new System.Windows.Forms.Button[150];
        private System.Windows.Forms.Panel[] panel9 = new System.Windows.Forms.Panel[150];
        private System.Windows.Forms.Button[] bt_remove_monan = new System.Windows.Forms.Button[150];
        private System.Windows.Forms.Button[] bt_add_monan = new System.Windows.Forms.Button[150];
        private int[] number_thucpham = new int[8];
        private Button button1;
        private Panel pn_head;
        private Label headline_title;
        private Label headline_mainboard;
        private Label label7;
        private Button back;
        private Button go;
    }
}