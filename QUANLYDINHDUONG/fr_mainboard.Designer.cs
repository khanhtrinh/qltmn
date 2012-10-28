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
    partial class fr_mainboard
    {
        ///
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
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
            this.flp_menu_mainboard = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_quanli_thucdon = new System.Windows.Forms.Button();
            this.bt_enter_new_infor = new System.Windows.Forms.Button();
            this.bt_xem_dulieu = new System.Windows.Forms.Button();
            this.bt_quanli_kho = new System.Windows.Forms.Button();
            this.bt_quanli_HDTP = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pn_new_menu = new System.Windows.Forms.Panel();
            this.flp_warning = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_head_current = new System.Windows.Forms.Panel();
            this.current_menu = new System.Windows.Forms.LinkLabel();
            this.headline_curent_menu = new System.Windows.Forms.Label();
            this.flp_new_menu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pn_head = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.headline_mainboard = new System.Windows.Forms.Label();
            this.flp_menu_mainboard.SuspendLayout();
            this.pn_new_menu.SuspendLayout();
            this.flp_warning.SuspendLayout();
            this.pn_head_current.SuspendLayout();
            this.flp_new_menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pn_head.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_menu_mainboard
            // 
            this.flp_menu_mainboard.BackColor = System.Drawing.Color.AliceBlue;
            this.flp_menu_mainboard.Controls.Add(this.bt_quanli_thucdon);
            this.flp_menu_mainboard.Controls.Add(this.bt_enter_new_infor);
            this.flp_menu_mainboard.Controls.Add(this.bt_xem_dulieu);
            this.flp_menu_mainboard.Controls.Add(this.bt_quanli_kho);
            this.flp_menu_mainboard.Controls.Add(this.bt_quanli_HDTP);
            this.flp_menu_mainboard.Controls.Add(this.button2);
            this.flp_menu_mainboard.Location = new System.Drawing.Point(12, 87);
            this.flp_menu_mainboard.Name = "flp_menu_mainboard";
            this.flp_menu_mainboard.Size = new System.Drawing.Size(878, 39);
            this.flp_menu_mainboard.TabIndex = 1;
            // 
            // bt_quanli_thucdon
            // 
            this.bt_quanli_thucdon.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.top_hover;
            this.bt_quanli_thucdon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_quanli_thucdon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quanli_thucdon.ForeColor = System.Drawing.Color.Black;
            this.bt_quanli_thucdon.Location = new System.Drawing.Point(3, 3);
            this.bt_quanli_thucdon.Name = "bt_quanli_thucdon";
            this.bt_quanli_thucdon.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bt_quanli_thucdon.Size = new System.Drawing.Size(143, 33);
            this.bt_quanli_thucdon.TabIndex = 0;
            this.bt_quanli_thucdon.Text = "T.ĐƠN H.NGÀY";
            this.bt_quanli_thucdon.UseVisualStyleBackColor = true;
            this.bt_quanli_thucdon.Click += new System.EventHandler(this.bt_quanli_thucdon_Click);
            // 
            // bt_enter_new_infor
            // 
            this.bt_enter_new_infor.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.top_hover;
            this.bt_enter_new_infor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_enter_new_infor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_enter_new_infor.ForeColor = System.Drawing.Color.Black;
            this.bt_enter_new_infor.Location = new System.Drawing.Point(152, 3);
            this.bt_enter_new_infor.Name = "bt_enter_new_infor";
            this.bt_enter_new_infor.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bt_enter_new_infor.Size = new System.Drawing.Size(139, 33);
            this.bt_enter_new_infor.TabIndex = 1;
            this.bt_enter_new_infor.Text = "Q.LÝ MÓN ĂN";
            this.bt_enter_new_infor.UseVisualStyleBackColor = true;
            this.bt_enter_new_infor.Click += new System.EventHandler(this.bt_enter_new_infor_Click);
            // 
            // bt_xem_dulieu
            // 
            this.bt_xem_dulieu.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.top_hover;
            this.bt_xem_dulieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xem_dulieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xem_dulieu.ForeColor = System.Drawing.Color.Black;
            this.bt_xem_dulieu.Location = new System.Drawing.Point(297, 3);
            this.bt_xem_dulieu.Name = "bt_xem_dulieu";
            this.bt_xem_dulieu.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bt_xem_dulieu.Size = new System.Drawing.Size(134, 33);
            this.bt_xem_dulieu.TabIndex = 4;
            this.bt_xem_dulieu.Text = "Q.LÝ T.PHẨM";
            this.bt_xem_dulieu.UseVisualStyleBackColor = true;
            this.bt_xem_dulieu.Click += new System.EventHandler(this.bt_xem_dulieu_Click);
            // 
            // bt_quanli_kho
            // 
            this.bt_quanli_kho.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.top_hover;
            this.bt_quanli_kho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_quanli_kho.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quanli_kho.ForeColor = System.Drawing.Color.Black;
            this.bt_quanli_kho.Location = new System.Drawing.Point(437, 3);
            this.bt_quanli_kho.Name = "bt_quanli_kho";
            this.bt_quanli_kho.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bt_quanli_kho.Size = new System.Drawing.Size(104, 33);
            this.bt_quanli_kho.TabIndex = 2;
            this.bt_quanli_kho.Text = "Q.LÝ KHO";
            this.bt_quanli_kho.UseVisualStyleBackColor = true;
            this.bt_quanli_kho.Click += new System.EventHandler(this.bt_quanli_kho_Click);
            // 
            // bt_quanli_HDTP
            // 
            this.bt_quanli_HDTP.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.top_hover;
            this.bt_quanli_HDTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_quanli_HDTP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quanli_HDTP.ForeColor = System.Drawing.Color.Black;
            this.bt_quanli_HDTP.Location = new System.Drawing.Point(547, 3);
            this.bt_quanli_HDTP.Name = "bt_quanli_HDTP";
            this.bt_quanli_HDTP.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.bt_quanli_HDTP.Size = new System.Drawing.Size(116, 33);
            this.bt_quanli_HDTP.TabIndex = 5;
            this.bt_quanli_HDTP.Text = "Q.LÝ HĐTP";
            this.bt_quanli_HDTP.UseVisualStyleBackColor = true;
            this.bt_quanli_HDTP.Click += new System.EventHandler(this.bt_quanli_HDTP_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.top_hover;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(669, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.button2.Size = new System.Drawing.Size(124, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Q.LÝ H.SINH";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pn_new_menu
            // 
            this.pn_new_menu.BackColor = System.Drawing.Color.AliceBlue;
            this.pn_new_menu.Controls.Add(this.flp_warning);
            this.pn_new_menu.Controls.Add(this.flp_new_menu);
            this.pn_new_menu.Location = new System.Drawing.Point(12, 125);
            this.pn_new_menu.Name = "pn_new_menu";
            this.pn_new_menu.Size = new System.Drawing.Size(878, 339);
            this.pn_new_menu.TabIndex = 2;
            // 
            // flp_warning
            // 
            this.flp_warning.AutoScroll = true;
            this.flp_warning.BackColor = System.Drawing.Color.AliceBlue;
            this.flp_warning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_warning.Controls.Add(this.pn_head_current);
            this.flp_warning.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.flp_warning.Location = new System.Drawing.Point(3, 3);
            this.flp_warning.Name = "flp_warning";
            this.flp_warning.Size = new System.Drawing.Size(578, 331);
            this.flp_warning.TabIndex = 1;
            this.flp_warning.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_warning_Paint);
            // 
            // pn_head_current
            // 
            this.pn_head_current.Controls.Add(this.current_menu);
            this.pn_head_current.Controls.Add(this.headline_curent_menu);
            this.pn_head_current.Location = new System.Drawing.Point(3, 3);
            this.pn_head_current.Name = "pn_head_current";
            this.pn_head_current.Size = new System.Drawing.Size(558, 37);
            this.pn_head_current.TabIndex = 4;
            // 
            // current_menu
            // 
            this.current_menu.AutoSize = true;
            this.current_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_menu.Location = new System.Drawing.Point(15, 18);
            this.current_menu.Name = "current_menu";
            this.current_menu.Size = new System.Drawing.Size(52, 16);
            this.current_menu.TabIndex = 1;
            this.current_menu.TabStop = true;
            this.current_menu.Text = "Ngày --";
            // 
            // headline_curent_menu
            // 
            this.headline_curent_menu.AutoSize = true;
            this.headline_curent_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headline_curent_menu.ForeColor = System.Drawing.Color.Green;
            this.headline_curent_menu.Location = new System.Drawing.Point(3, 0);
            this.headline_curent_menu.Name = "headline_curent_menu";
            this.headline_curent_menu.Size = new System.Drawing.Size(147, 18);
            this.headline_curent_menu.TabIndex = 0;
            this.headline_curent_menu.Text = "Thực đơn trong ngày:";
            // 
            // flp_new_menu
            // 
            this.flp_new_menu.AutoScroll = true;
            this.flp_new_menu.BackColor = System.Drawing.Color.AliceBlue;
            this.flp_new_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_new_menu.Controls.Add(this.panel2);
            this.flp_new_menu.Location = new System.Drawing.Point(590, 3);
            this.flp_new_menu.Name = "flp_new_menu";
            this.flp_new_menu.Size = new System.Drawing.Size(288, 331);
            this.flp_new_menu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 124);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(170, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên truy cập:";
            // 
            // pn_head
            // 
            this.pn_head.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_head.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bg_menu_top_1x33;
            this.pn_head.Controls.Add(this.label2);
            this.pn_head.Controls.Add(this.headline_mainboard);
            this.pn_head.Location = new System.Drawing.Point(12, 1);
            this.pn_head.Name = "pn_head";
            this.pn_head.Size = new System.Drawing.Size(878, 85);
            this.pn_head.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(86, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(707, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "TRƯỜNG MẦM NON DỊCH VỌNG HẬU - Q.CẦU GIẤY  - TP.HÀ NỘI";
            // 
            // headline_mainboard
            // 
            this.headline_mainboard.AutoSize = true;
            this.headline_mainboard.BackColor = System.Drawing.Color.Transparent;
            this.headline_mainboard.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headline_mainboard.ForeColor = System.Drawing.Color.AliceBlue;
            this.headline_mainboard.Location = new System.Drawing.Point(259, 44);
            this.headline_mainboard.Name = "headline_mainboard";
            this.headline_mainboard.Size = new System.Drawing.Size(361, 24);
            this.headline_mainboard.TabIndex = 0;
            this.headline_mainboard.Text = "PHẦN MỀM QUẢN LÍ DINH DƯỠNG";
            // 
            // fr_mainboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(904, 481);
            this.Controls.Add(this.pn_new_menu);
            this.Controls.Add(this.flp_menu_mainboard);
            this.Controls.Add(this.pn_head);
            this.MaximumSize = new System.Drawing.Size(912, 508);
            this.MinimumSize = new System.Drawing.Size(912, 508);
            this.Name = "fr_mainboard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PHẦN MỀM QUẢN LÍ DINH DƯỠNG TRONG TRƯỜNG MẦM NON";
            this.flp_menu_mainboard.ResumeLayout(false);
            this.pn_new_menu.ResumeLayout(false);
            this.flp_warning.ResumeLayout(false);
            this.pn_head_current.ResumeLayout(false);
            this.pn_head_current.PerformLayout();
            this.flp_new_menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pn_head.ResumeLayout(false);
            this.pn_head.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_head;
        private System.Windows.Forms.Label headline_mainboard;
        private System.Windows.Forms.FlowLayoutPanel flp_menu_mainboard;
        private System.Windows.Forms.Button bt_quanli_thucdon;
        private System.Windows.Forms.Button bt_enter_new_infor;
        private System.Windows.Forms.Button bt_quanli_kho;
        private System.Windows.Forms.Button bt_xem_dulieu;
        private System.Windows.Forms.Panel pn_new_menu;
        private System.Windows.Forms.FlowLayoutPanel flp_new_menu;
        private System.Windows.Forms.FlowLayoutPanel flp_warning;
        private Label label2;
        private Panel pn_head_current;
        private LinkLabel current_menu;
        private Label headline_curent_menu;
        private Panel panel2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Button button1;
        private WebBrowser webBrowser1;
        private Button bt_quanli_HDTP;
        private Button button2;
    }
}