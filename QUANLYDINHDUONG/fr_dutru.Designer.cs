namespace WindowsFormsApplication1
{
    partial class fr_dutru
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
            this.pn_dutru = new System.Windows.Forms.Panel();
            this.bt_mainboard = new System.Windows.Forms.Button();
            this.bt_submit = new System.Windows.Forms.Button();
            this.confirm_textbox = new System.Windows.Forms.RichTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tb_luong_hs_maugiao = new System.Windows.Forms.TextBox();
            this.tb_luong_hs_nhatre = new System.Windows.Forms.TextBox();
            this.lb_luong_hs_maugiao = new System.Windows.Forms.Label();
            this.lb_luong_hs_nhatre = new System.Windows.Forms.Label();
            this.lb_head_dutru = new System.Windows.Forms.Label();
            this.pn_dutru.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_dutru
            // 
            this.pn_dutru.BackColor = System.Drawing.Color.AliceBlue;
            this.pn_dutru.Controls.Add(this.bt_mainboard);
            this.pn_dutru.Controls.Add(this.bt_submit);
            this.pn_dutru.Controls.Add(this.confirm_textbox);
            this.pn_dutru.Controls.Add(this.monthCalendar1);
            this.pn_dutru.Controls.Add(this.tb_luong_hs_maugiao);
            this.pn_dutru.Controls.Add(this.tb_luong_hs_nhatre);
            this.pn_dutru.Controls.Add(this.lb_luong_hs_maugiao);
            this.pn_dutru.Controls.Add(this.lb_luong_hs_nhatre);
            this.pn_dutru.Controls.Add(this.lb_head_dutru);
            this.pn_dutru.Location = new System.Drawing.Point(-2, 6);
            this.pn_dutru.Name = "pn_dutru";
            this.pn_dutru.Size = new System.Drawing.Size(925, 459);
            this.pn_dutru.TabIndex = 0;
            // 
            // bt_mainboard
            // 
            this.bt_mainboard.Location = new System.Drawing.Point(290, 417);
            this.bt_mainboard.Name = "bt_mainboard";
            this.bt_mainboard.Size = new System.Drawing.Size(28, 34);
            this.bt_mainboard.TabIndex = 8;
            this.bt_mainboard.UseVisualStyleBackColor = true;
            this.bt_mainboard.Click += new System.EventHandler(this.bt_mainboard_Click);
            // 
            // bt_submit
            // 
            this.bt_submit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_submit.Location = new System.Drawing.Point(170, 417);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(99, 34);
            this.bt_submit.TabIndex = 7;
            this.bt_submit.Text = "Nhập";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // confirm_textbox
            // 
            this.confirm_textbox.Location = new System.Drawing.Point(508, 134);
            this.confirm_textbox.Name = "confirm_textbox";
            this.confirm_textbox.Size = new System.Drawing.Size(386, 251);
            this.confirm_textbox.TabIndex = 6;
            this.confirm_textbox.Text = "";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(104, 222);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // tb_luong_hs_maugiao
            // 
            this.tb_luong_hs_maugiao.Location = new System.Drawing.Point(267, 190);
            this.tb_luong_hs_maugiao.Name = "tb_luong_hs_maugiao";
            this.tb_luong_hs_maugiao.Size = new System.Drawing.Size(100, 20);
            this.tb_luong_hs_maugiao.TabIndex = 4;
            // 
            // tb_luong_hs_nhatre
            // 
            this.tb_luong_hs_nhatre.Location = new System.Drawing.Point(267, 135);
            this.tb_luong_hs_nhatre.Name = "tb_luong_hs_nhatre";
            this.tb_luong_hs_nhatre.Size = new System.Drawing.Size(100, 20);
            this.tb_luong_hs_nhatre.TabIndex = 3;
            // 
            // lb_luong_hs_maugiao
            // 
            this.lb_luong_hs_maugiao.AutoSize = true;
            this.lb_luong_hs_maugiao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_luong_hs_maugiao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_luong_hs_maugiao.Location = new System.Drawing.Point(101, 189);
            this.lb_luong_hs_maugiao.Name = "lb_luong_hs_maugiao";
            this.lb_luong_hs_maugiao.Size = new System.Drawing.Size(143, 19);
            this.lb_luong_hs_maugiao.TabIndex = 2;
            this.lb_luong_hs_maugiao.Text = "Số học sinh Mẫu giáo:";
            // 
            // lb_luong_hs_nhatre
            // 
            this.lb_luong_hs_nhatre.AutoSize = true;
            this.lb_luong_hs_nhatre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_luong_hs_nhatre.Location = new System.Drawing.Point(100, 134);
            this.lb_luong_hs_nhatre.Name = "lb_luong_hs_nhatre";
            this.lb_luong_hs_nhatre.Size = new System.Drawing.Size(132, 19);
            this.lb_luong_hs_nhatre.TabIndex = 1;
            this.lb_luong_hs_nhatre.Text = "Số học sinh Nhà trẻ:";
            // 
            // lb_head_dutru
            // 
            this.lb_head_dutru.AutoSize = true;
            this.lb_head_dutru.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_head_dutru.Location = new System.Drawing.Point(318, 44);
            this.lb_head_dutru.Name = "lb_head_dutru";
            this.lb_head_dutru.Size = new System.Drawing.Size(343, 27);
            this.lb_head_dutru.TabIndex = 0;
            this.lb_head_dutru.Text = "Quản lý lượng học sinh trong ngày";
            // 
            // fr_dutru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 469);
            this.Controls.Add(this.pn_dutru);
            this.Name = "fr_dutru";
            this.Text = "pp";
            this.pn_dutru.ResumeLayout(false);
            this.pn_dutru.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_dutru;
        private System.Windows.Forms.TextBox tb_luong_hs_maugiao;
        private System.Windows.Forms.TextBox tb_luong_hs_nhatre;
        private System.Windows.Forms.Label lb_luong_hs_maugiao;
        private System.Windows.Forms.Label lb_luong_hs_nhatre;
        private System.Windows.Forms.Label lb_head_dutru;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button bt_mainboard;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.RichTextBox confirm_textbox;
    }
}