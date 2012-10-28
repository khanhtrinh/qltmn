namespace WindowsFormsApplication1
{
    partial class fr_show_tp_kho
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
            this.headline_show_kho = new System.Windows.Forms.Label();
            this.flp_show_hang = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_stt = new System.Windows.Forms.Button();
            this.bt_name = new System.Windows.Forms.Button();
            this.bt_type = new System.Windows.Forms.Button();
            this.bt_unit = new System.Windows.Forms.Button();
            this.bt_luong_con = new System.Windows.Forms.Button();
            this.bt_dongia_new = new System.Windows.Forms.Button();
            this.bt_luong_ton = new System.Windows.Forms.Button();
            this.bt_dongia_old = new System.Windows.Forms.Button();
            this.bt_import = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_export = new System.Windows.Forms.Button();
            this.bt_mainboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headline_show_kho
            // 
            this.headline_show_kho.AutoSize = true;
            this.headline_show_kho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headline_show_kho.ForeColor = System.Drawing.Color.Black;
            this.headline_show_kho.Location = new System.Drawing.Point(277, 16);
            this.headline_show_kho.Name = "headline_show_kho";
            this.headline_show_kho.Size = new System.Drawing.Size(345, 20);
            this.headline_show_kho.TabIndex = 0;
            this.headline_show_kho.Text = "THÔNG TIN VỀ HIỆN TRẠNG KHO HÀNG";
            // 
            // flp_show_hang
            // 
            this.flp_show_hang.AutoScroll = true;
            this.flp_show_hang.Location = new System.Drawing.Point(81, 97);
            this.flp_show_hang.Name = "flp_show_hang";
            this.flp_show_hang.Size = new System.Drawing.Size(729, 335);
            this.flp_show_hang.TabIndex = 1;
            // 
            // bt_stt
            // 
            this.bt_stt.Location = new System.Drawing.Point(84, 71);
            this.bt_stt.Name = "bt_stt";
            this.bt_stt.Size = new System.Drawing.Size(31, 23);
            this.bt_stt.TabIndex = 2;
            this.bt_stt.Text = "ID";
            this.bt_stt.UseVisualStyleBackColor = true;
            // 
            // bt_name
            // 
            this.bt_name.Location = new System.Drawing.Point(121, 71);
            this.bt_name.Name = "bt_name";
            this.bt_name.Size = new System.Drawing.Size(129, 23);
            this.bt_name.TabIndex = 3;
            this.bt_name.Text = "Tên thực phẩm";
            this.bt_name.UseVisualStyleBackColor = true;
            // 
            // bt_type
            // 
            this.bt_type.Location = new System.Drawing.Point(256, 71);
            this.bt_type.Name = "bt_type";
            this.bt_type.Size = new System.Drawing.Size(83, 23);
            this.bt_type.TabIndex = 4;
            this.bt_type.Text = "Loại TP";
            this.bt_type.UseVisualStyleBackColor = true;
            // 
            // bt_unit
            // 
            this.bt_unit.Location = new System.Drawing.Point(345, 71);
            this.bt_unit.Name = "bt_unit";
            this.bt_unit.Size = new System.Drawing.Size(83, 23);
            this.bt_unit.TabIndex = 5;
            this.bt_unit.Text = "Đơn vị ";
            this.bt_unit.UseVisualStyleBackColor = true;
            // 
            // bt_luong_con
            // 
            this.bt_luong_con.Location = new System.Drawing.Point(434, 71);
            this.bt_luong_con.Name = "bt_luong_con";
            this.bt_luong_con.Size = new System.Drawing.Size(83, 23);
            this.bt_luong_con.TabIndex = 6;
            this.bt_luong_con.Text = "Trong kho";
            this.bt_luong_con.UseVisualStyleBackColor = true;
            // 
            // bt_dongia_new
            // 
            this.bt_dongia_new.Location = new System.Drawing.Point(523, 71);
            this.bt_dongia_new.Name = "bt_dongia_new";
            this.bt_dongia_new.Size = new System.Drawing.Size(83, 23);
            this.bt_dongia_new.TabIndex = 7;
            this.bt_dongia_new.Text = "Giá";
            this.bt_dongia_new.UseVisualStyleBackColor = true;
            // 
            // bt_luong_ton
            // 
            this.bt_luong_ton.Location = new System.Drawing.Point(612, 71);
            this.bt_luong_ton.Name = "bt_luong_ton";
            this.bt_luong_ton.Size = new System.Drawing.Size(83, 23);
            this.bt_luong_ton.TabIndex = 8;
            this.bt_luong_ton.Text = "Ngày nhập";
            this.bt_luong_ton.UseVisualStyleBackColor = true;
            // 
            // bt_dongia_old
            // 
            this.bt_dongia_old.Location = new System.Drawing.Point(701, 71);
            this.bt_dongia_old.Name = "bt_dongia_old";
            this.bt_dongia_old.Size = new System.Drawing.Size(83, 23);
            this.bt_dongia_old.TabIndex = 9;
            this.bt_dongia_old.Text = "Ghi chú";
            this.bt_dongia_old.UseVisualStyleBackColor = true;
            // 
            // bt_import
            // 
            this.bt_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_import.Location = new System.Drawing.Point(501, 452);
            this.bt_import.Name = "bt_import";
            this.bt_import.Size = new System.Drawing.Size(92, 29);
            this.bt_import.TabIndex = 10;
            this.bt_import.Text = "Nhập Kho";
            this.bt_import.UseVisualStyleBackColor = true;
            this.bt_import.Click += new System.EventHandler(this.bt_import_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit.Location = new System.Drawing.Point(403, 452);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(92, 29);
            this.bt_edit.TabIndex = 11;
            this.bt_edit.Text = "Chỉnh Sửa";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_export
            // 
            this.bt_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_export.Location = new System.Drawing.Point(305, 452);
            this.bt_export.Name = "bt_export";
            this.bt_export.Size = new System.Drawing.Size(92, 29);
            this.bt_export.TabIndex = 12;
            this.bt_export.Text = "Xuất Kho";
            this.bt_export.UseVisualStyleBackColor = true;
            this.bt_export.Click += new System.EventHandler(this.bt_export_Click);
            // 
            // bt_mainboard
            // 
            this.bt_mainboard.Location = new System.Drawing.Point(599, 452);
            this.bt_mainboard.Name = "bt_mainboard";
            this.bt_mainboard.Size = new System.Drawing.Size(23, 29);
            this.bt_mainboard.TabIndex = 13;
            this.bt_mainboard.UseVisualStyleBackColor = true;
            this.bt_mainboard.Click += new System.EventHandler(this.bt_mainboard_Click);
            // 
            // fr_show_tp_kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 502);
            this.Controls.Add(this.bt_mainboard);
            this.Controls.Add(this.bt_export);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_import);
            this.Controls.Add(this.bt_dongia_old);
            this.Controls.Add(this.bt_luong_ton);
            this.Controls.Add(this.bt_dongia_new);
            this.Controls.Add(this.bt_luong_con);
            this.Controls.Add(this.bt_unit);
            this.Controls.Add(this.bt_type);
            this.Controls.Add(this.bt_name);
            this.Controls.Add(this.bt_stt);
            this.Controls.Add(this.flp_show_hang);
            this.Controls.Add(this.headline_show_kho);
            this.MaximizeBox = false;
            this.Name = "fr_show_tp_kho";
            this.Text = "THÔNG TIN VỀ KHO HÀNG CỦA NHÀ TRƯỜNG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headline_show_kho;
        private System.Windows.Forms.FlowLayoutPanel flp_show_hang;
        private System.Windows.Forms.TextBox[] tb_stt = new System.Windows.Forms.TextBox[1000];
        private System.Windows.Forms.TextBox[] tb_name = new System.Windows.Forms.TextBox[1000];
        private System.Windows.Forms.TextBox[] tb_type = new System.Windows.Forms.TextBox[1000];
        private System.Windows.Forms.TextBox[] tb_unit = new System.Windows.Forms.TextBox[1000];
        private System.Windows.Forms.TextBox[] tb_luongcon = new System.Windows.Forms.TextBox[1000];
        private System.Windows.Forms.TextBox[] tb_dongia_new = new System.Windows.Forms.TextBox[1000];
        private System.Windows.Forms.Button bt_stt;
        private System.Windows.Forms.Button bt_name;
        private System.Windows.Forms.Button bt_type;
        private System.Windows.Forms.Button bt_unit;
        private System.Windows.Forms.Button bt_luong_con;
        private System.Windows.Forms.Button bt_dongia_new;
        private System.Windows.Forms.TextBox[] tb_luongton = new System.Windows.Forms.TextBox[1000];
        private System.Windows.Forms.TextBox[] tb_dongia_old = new System.Windows.Forms.TextBox[1000];
        private System.Windows.Forms.Button bt_luong_ton;
        private System.Windows.Forms.Button bt_dongia_old;
        private System.Windows.Forms.Button bt_import;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_export;
        private System.Windows.Forms.Button bt_mainboard;
    }
}