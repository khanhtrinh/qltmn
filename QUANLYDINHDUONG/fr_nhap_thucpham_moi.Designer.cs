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
    partial class fr_nhap_thucpham_moi
    {/// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.bt_id_thucpham = new System.Windows.Forms.Button();
            this.bt_type_thucpham = new System.Windows.Forms.Button();
            this.bt_name_thucpham = new System.Windows.Forms.Button();
            this.flp_title_thucpham = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_information_thucpham = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_submit = new System.Windows.Forms.Button();
            this.bt_chuyen_thucpham = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pn_head = new System.Windows.Forms.Panel();
            this.headline_title = new System.Windows.Forms.Label();
            this.headline_mainboard = new System.Windows.Forms.Label();
            this.flp_title_thucpham.SuspendLayout();
            this.pn_head.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_id_thucpham
            // 
            this.bt_id_thucpham.Location = new System.Drawing.Point(3, 3);
            this.bt_id_thucpham.Name = "bt_id_thucpham";
            this.bt_id_thucpham.Size = new System.Drawing.Size(47, 23);
            this.bt_id_thucpham.TabIndex = 1;
            this.bt_id_thucpham.Text = "Mã TP";
            this.bt_id_thucpham.UseVisualStyleBackColor = true;
            // 
            // bt_type_thucpham
            // 
            this.bt_type_thucpham.Location = new System.Drawing.Point(174, 3);
            this.bt_type_thucpham.Name = "bt_type_thucpham";
            this.bt_type_thucpham.Size = new System.Drawing.Size(70, 23);
            this.bt_type_thucpham.TabIndex = 3;
            this.bt_type_thucpham.Text = "LOẠI TP";
            this.bt_type_thucpham.UseVisualStyleBackColor = true;
            // 
            // bt_name_thucpham
            // 
            this.bt_name_thucpham.Location = new System.Drawing.Point(56, 3);
            this.bt_name_thucpham.Name = "bt_name_thucpham";
            this.bt_name_thucpham.Size = new System.Drawing.Size(112, 23);
            this.bt_name_thucpham.TabIndex = 4;
            this.bt_name_thucpham.Text = "TÊN THỰC PHẨM";
            this.bt_name_thucpham.UseVisualStyleBackColor = true;
            // 
            // flp_title_thucpham
            // 
            this.flp_title_thucpham.Controls.Add(this.bt_id_thucpham);
            this.flp_title_thucpham.Controls.Add(this.bt_name_thucpham);
            this.flp_title_thucpham.Controls.Add(this.bt_type_thucpham);
            this.flp_title_thucpham.Location = new System.Drawing.Point(12, 125);
            this.flp_title_thucpham.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.flp_title_thucpham.Name = "flp_title_thucpham";
            this.flp_title_thucpham.Size = new System.Drawing.Size(1058, 29);
            this.flp_title_thucpham.TabIndex = 5;
            // 
            // flp_information_thucpham
            // 
            this.flp_information_thucpham.AutoScroll = true;
            this.flp_information_thucpham.Location = new System.Drawing.Point(12, 160);
            this.flp_information_thucpham.Name = "flp_information_thucpham";
            this.flp_information_thucpham.Size = new System.Drawing.Size(1076, 470);
            this.flp_information_thucpham.TabIndex = 6;
            // 
            // bt_submit
            // 
            this.bt_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_submit.Location = new System.Drawing.Point(487, 636);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(126, 31);
            this.bt_submit.TabIndex = 7;
            this.bt_submit.Text = "NHẬP TP";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // bt_chuyen_thucpham
            // 
            this.bt_chuyen_thucpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chuyen_thucpham.Location = new System.Drawing.Point(619, 636);
            this.bt_chuyen_thucpham.Name = "bt_chuyen_thucpham";
            this.bt_chuyen_thucpham.Size = new System.Drawing.Size(128, 31);
            this.bt_chuyen_thucpham.TabIndex = 8;
            this.bt_chuyen_thucpham.Text = "THÊM";
            this.bt_chuyen_thucpham.UseVisualStyleBackColor = true;
            this.bt_chuyen_thucpham.Click += new System.EventHandler(this.bt_chuyen_thucpham_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(753, 636);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(25, 31);
            this.bt_delete.TabIndex = 9;
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(252, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(597, 26);
            this.label7.TabIndex = 27;
            this.label7.Text = "BẢNG THÔNG TIN DINH DƯỠNG CỦA THỰC PHẨM";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(353, 636);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 31);
            this.button1.TabIndex = 28;
            this.button1.Text = "THÊM";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pn_head
            // 
            this.pn_head.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_head.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bg_menu_top_1x33;
            this.pn_head.Controls.Add(this.headline_title);
            this.pn_head.Controls.Add(this.headline_mainboard);
            this.pn_head.Location = new System.Drawing.Point(12, -1);
            this.pn_head.Name = "pn_head";
            this.pn_head.Size = new System.Drawing.Size(1076, 72);
            this.pn_head.TabIndex = 15;
            // 
            // headline_title
            // 
            this.headline_title.AutoSize = true;
            this.headline_title.BackColor = System.Drawing.Color.Transparent;
            this.headline_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headline_title.ForeColor = System.Drawing.Color.AliceBlue;
            this.headline_title.Location = new System.Drawing.Point(185, 10);
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
            this.headline_mainboard.Location = new System.Drawing.Point(358, 44);
            this.headline_mainboard.Name = "headline_mainboard";
            this.headline_mainboard.Size = new System.Drawing.Size(361, 24);
            this.headline_mainboard.TabIndex = 0;
            this.headline_mainboard.Text = "PHẦN MỀM QUẢN LÍ DINH DƯỠNG";
            // 
            // fr_nhap_thucpham_moi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1100, 679);
            this.Controls.Add(this.pn_head);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_chuyen_thucpham);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.flp_information_thucpham);
            this.Controls.Add(this.flp_title_thucpham);
            this.MaximizeBox = false;
            this.Name = "fr_nhap_thucpham_moi";
            this.Text = "Nhập thông tin về Thực phẩm mới được sử dụng";
            this.flp_title_thucpham.ResumeLayout(false);
            this.pn_head.ResumeLayout(false);
            this.pn_head.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_id_thucpham;
        private System.Windows.Forms.Button bt_type_thucpham;
        private System.Windows.Forms.Button bt_name_thucpham;
        private System.Windows.Forms.FlowLayoutPanel flp_title_thucpham;
        private System.Windows.Forms.Button[] bt_name_vichat = new System.Windows.Forms.Button[10];
        private System.Windows.Forms.FlowLayoutPanel flp_information_thucpham;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Button bt_chuyen_thucpham;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.TextBox[] tb_id_thucpham = new System.Windows.Forms.TextBox[1000];
        private System.Windows.Forms.TextBox[] tb_name_thucpham = new System.Windows.Forms.TextBox[1000];
        private System.Windows.Forms.ComboBox[] cb_type_thucpham = new System.Windows.Forms.ComboBox[1000];
        private System.Windows.Forms.TextBox[,] tb_luong_thucpham = new System.Windows.Forms.TextBox[1000, 10];
        public modun_quanli_thucdon_dinhduong thucpham1 = new modun_quanli_thucdon_dinhduong();
        private Label label7;
        private Button button1;
        private Panel pn_head;
        private Label headline_title;
        private Label headline_mainboard;
    }
}