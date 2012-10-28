namespace WindowsFormsApplication1
{
    partial class fr_import
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

        /// 
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            this.headline_phieu_plkho = new System.Windows.Forms.Label();
            this.flp_infor = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_submit = new System.Windows.Forms.Button();
            this.bt_add_items = new System.Windows.Forms.Button();
            this.bt_change = new System.Windows.Forms.Button();
            this.bt_stt = new System.Windows.Forms.Button();
            this.bt_name_thucpham = new System.Windows.Forms.Button();
            this.bt_luongtp = new System.Windows.Forms.Button();
            this.bt_dongia = new System.Windows.Forms.Button();
            this.bt_unit = new System.Windows.Forms.Button();
            this.tb_sum_value = new System.Windows.Forms.TextBox();
            this.sum_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headline_phieu_plkho
            // 
            this.headline_phieu_plkho.AutoSize = true;
            this.headline_phieu_plkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headline_phieu_plkho.ForeColor = System.Drawing.Color.Black;
            this.headline_phieu_plkho.Location = new System.Drawing.Point(250, 20);
            this.headline_phieu_plkho.Name = "headline_phieu_plkho";
            this.headline_phieu_plkho.Size = new System.Drawing.Size(328, 24);
            this.headline_phieu_plkho.TabIndex = 0;
            this.headline_phieu_plkho.Text = "PHIẾU NHẬP HÀNG TRONG KHO";
            // 
            // flp_infor
            // 
            this.flp_infor.AutoScroll = true;
            this.flp_infor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_infor.Location = new System.Drawing.Point(110, 96);
            this.flp_infor.Name = "flp_infor";
            this.flp_infor.Size = new System.Drawing.Size(631, 362);
            this.flp_infor.TabIndex = 1;
            // 
            // bt_submit
            // 
            this.bt_submit.Location = new System.Drawing.Point(363, 521);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(103, 32);
            this.bt_submit.TabIndex = 2;
            this.bt_submit.Text = "NHẬP";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // bt_add_items
            // 
            this.bt_add_items.Location = new System.Drawing.Point(472, 521);
            this.bt_add_items.Name = "bt_add_items";
            this.bt_add_items.Size = new System.Drawing.Size(103, 32);
            this.bt_add_items.TabIndex = 3;
            this.bt_add_items.Text = "THÊM ";
            this.bt_add_items.UseVisualStyleBackColor = true;
            this.bt_add_items.Click += new System.EventHandler(this.bt_add_items_Click);
            // 
            // bt_change
            // 
            this.bt_change.Location = new System.Drawing.Point(254, 521);
            this.bt_change.Name = "bt_change";
            this.bt_change.Size = new System.Drawing.Size(103, 32);
            this.bt_change.TabIndex = 4;
            this.bt_change.Text = "CHUYỂN ";
            this.bt_change.UseVisualStyleBackColor = true;
            this.bt_change.Click += new System.EventHandler(this.bt_change_Click);
            // 
            // bt_stt
            // 
            this.bt_stt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_stt.Location = new System.Drawing.Point(113, 67);
            this.bt_stt.Name = "bt_stt";
            this.bt_stt.Size = new System.Drawing.Size(38, 23);
            this.bt_stt.TabIndex = 5;
            this.bt_stt.Text = "STT";
            this.bt_stt.UseVisualStyleBackColor = true;
            this.bt_stt.Click += new System.EventHandler(this.bt_stt_Click);
            // 
            // bt_name_thucpham
            // 
            this.bt_name_thucpham.Location = new System.Drawing.Point(157, 67);
            this.bt_name_thucpham.Name = "bt_name_thucpham";
            this.bt_name_thucpham.Size = new System.Drawing.Size(205, 23);
            this.bt_name_thucpham.TabIndex = 6;
            this.bt_name_thucpham.Text = "TÊN THỰC PHẨM";
            this.bt_name_thucpham.UseVisualStyleBackColor = true;
            // 
            // bt_luongtp
            // 
            this.bt_luongtp.Location = new System.Drawing.Point(368, 67);
            this.bt_luongtp.Name = "bt_luongtp";
            this.bt_luongtp.Size = new System.Drawing.Size(113, 23);
            this.bt_luongtp.TabIndex = 7;
            this.bt_luongtp.Text = "SỐ LƯỢNG";
            this.bt_luongtp.UseVisualStyleBackColor = true;
            // 
            // bt_dongia
            // 
            this.bt_dongia.Location = new System.Drawing.Point(487, 67);
            this.bt_dongia.Name = "bt_dongia";
            this.bt_dongia.Size = new System.Drawing.Size(113, 23);
            this.bt_dongia.TabIndex = 8;
            this.bt_dongia.Text = "ĐƠN GIÁ";
            this.bt_dongia.UseVisualStyleBackColor = true;
            // 
            // bt_unit
            // 
            this.bt_unit.Location = new System.Drawing.Point(606, 67);
            this.bt_unit.Name = "bt_unit";
            this.bt_unit.Size = new System.Drawing.Size(113, 23);
            this.bt_unit.TabIndex = 9;
            this.bt_unit.Text = "ĐƠN VỊ";
            this.bt_unit.UseVisualStyleBackColor = true;
            // 
            // tb_sum_value
            // 
            this.tb_sum_value.Location = new System.Drawing.Point(487, 464);
            this.tb_sum_value.Name = "tb_sum_value";
            this.tb_sum_value.Size = new System.Drawing.Size(113, 20);
            this.tb_sum_value.TabIndex = 13;
            // 
            // sum_value
            // 
            this.sum_value.AutoSize = true;
            this.sum_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum_value.Location = new System.Drawing.Point(365, 468);
            this.sum_value.Name = "sum_value";
            this.sum_value.Size = new System.Drawing.Size(125, 16);
            this.sum_value.TabIndex = 14;
            this.sum_value.Text = "TỔNG GIÁ TRỊ = ";
            // 
            // fr_import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(829, 565);
            this.Controls.Add(this.sum_value);
            this.Controls.Add(this.tb_sum_value);
            this.Controls.Add(this.bt_unit);
            this.Controls.Add(this.bt_dongia);
            this.Controls.Add(this.bt_luongtp);
            this.Controls.Add(this.bt_name_thucpham);
            this.Controls.Add(this.bt_stt);
            this.Controls.Add(this.bt_change);
            this.Controls.Add(this.bt_add_items);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.flp_infor);
            this.Controls.Add(this.headline_phieu_plkho);
            this.Name = "fr_import";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headline_phieu_plkho;
        private System.Windows.Forms.FlowLayoutPanel flp_infor;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Button bt_add_items;
        private System.Windows.Forms.Button bt_change;
        private System.Windows.Forms.Button bt_stt;
        private System.Windows.Forms.Button bt_name_thucpham;
        private System.Windows.Forms.Button bt_luongtp;
        private System.Windows.Forms.Button bt_dongia;
        private System.Windows.Forms.Button bt_unit;
        private System.Windows.Forms.TextBox[] tb_stt = new System.Windows.Forms.TextBox[20];
        private System.Windows.Forms.TextBox[] tb_num_thucpham = new System.Windows.Forms.TextBox[20];
        private System.Windows.Forms.TextBox[] tb_price_thucpham = new System.Windows.Forms.TextBox[20];
        private System.Windows.Forms.ComboBox[] cb_name_thucpham = new System.Windows.Forms.ComboBox[20];
        private System.Windows.Forms.TextBox tb_sum_value;
        private System.Windows.Forms.Label sum_value;
        private System.Windows.Forms.ComboBox[] cb_unit_thucpham = new System.Windows.Forms.ComboBox[20];
    }
}