namespace WindowsFormsApplication1
{
    partial class bt_fixtd
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.flp1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_id = new System.Windows.Forms.Button();
            this.bt_name = new System.Windows.Forms.Button();
            this.bt_unit = new System.Windows.Forms.Button();
            this.bt_price = new System.Windows.Forms.Button();
            this.bt_nhaphanphoi = new System.Windows.Forms.Button();
            this.bt_date = new System.Windows.Forms.Button();
            this.flp2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button11 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_dg_new = new System.Windows.Forms.TextBox();
            this.tb_dv = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_submit = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.flp1.SuspendLayout();
            this.flp2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(876, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ HỢP ĐỒNG THỰC PHẨM HÀNG NGÀY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(17, 502);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Xem tất cả";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(17, 525);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(139, 19);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Xem từng thực phẩm";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // flp1
            // 
            this.flp1.AutoScroll = true;
            this.flp1.Controls.Add(this.bt_id);
            this.flp1.Controls.Add(this.bt_name);
            this.flp1.Controls.Add(this.bt_unit);
            this.flp1.Controls.Add(this.bt_price);
            this.flp1.Controls.Add(this.bt_nhaphanphoi);
            this.flp1.Controls.Add(this.bt_date);
            this.flp1.Location = new System.Drawing.Point(20, 51);
            this.flp1.Name = "flp1";
            this.flp1.Size = new System.Drawing.Size(860, 445);
            this.flp1.TabIndex = 3;
            this.flp1.Visible = false;
            // 
            // bt_id
            // 
            this.bt_id.Location = new System.Drawing.Point(3, 3);
            this.bt_id.Name = "bt_id";
            this.bt_id.Size = new System.Drawing.Size(45, 23);
            this.bt_id.TabIndex = 0;
            this.bt_id.Text = "ID";
            this.bt_id.UseVisualStyleBackColor = true;
            // 
            // bt_name
            // 
            this.bt_name.Location = new System.Drawing.Point(54, 3);
            this.bt_name.Name = "bt_name";
            this.bt_name.Size = new System.Drawing.Size(205, 23);
            this.bt_name.TabIndex = 1;
            this.bt_name.Text = "Tên thực phẩm";
            this.bt_name.UseVisualStyleBackColor = true;
            // 
            // bt_unit
            // 
            this.bt_unit.Location = new System.Drawing.Point(265, 3);
            this.bt_unit.Name = "bt_unit";
            this.bt_unit.Size = new System.Drawing.Size(100, 23);
            this.bt_unit.TabIndex = 3;
            this.bt_unit.Text = "Đơn vị tính";
            this.bt_unit.UseVisualStyleBackColor = true;
            // 
            // bt_price
            // 
            this.bt_price.Location = new System.Drawing.Point(371, 3);
            this.bt_price.Name = "bt_price";
            this.bt_price.Size = new System.Drawing.Size(110, 23);
            this.bt_price.TabIndex = 4;
            this.bt_price.Text = "Đơn giá";
            this.bt_price.UseVisualStyleBackColor = true;
            // 
            // bt_nhaphanphoi
            // 
            this.bt_nhaphanphoi.Location = new System.Drawing.Point(487, 3);
            this.bt_nhaphanphoi.Name = "bt_nhaphanphoi";
            this.bt_nhaphanphoi.Size = new System.Drawing.Size(176, 23);
            this.bt_nhaphanphoi.TabIndex = 11;
            this.bt_nhaphanphoi.Text = "Nhà phân phối";
            this.bt_nhaphanphoi.UseVisualStyleBackColor = true;
            // 
            // bt_date
            // 
            this.bt_date.Location = new System.Drawing.Point(669, 3);
            this.bt_date.Name = "bt_date";
            this.bt_date.Size = new System.Drawing.Size(146, 23);
            this.bt_date.TabIndex = 10;
            this.bt_date.Text = "Ngày cập nhật";
            this.bt_date.UseVisualStyleBackColor = true;
            // 
            // flp2
            // 
            this.flp2.Controls.Add(this.button11);
            this.flp2.Controls.Add(this.listBox1);
            this.flp2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp2.Location = new System.Drawing.Point(17, 51);
            this.flp2.Name = "flp2";
            this.flp2.Size = new System.Drawing.Size(272, 445);
            this.flp2.TabIndex = 4;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(3, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(259, 23);
            this.button11.TabIndex = 0;
            this.button11.Text = "Danh sách thực phẩm";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(3, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 395);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.lb_changeText);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.tb_date);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tb_dg_new);
            this.panel1.Controls.Add(this.tb_dv);
            this.panel1.Controls.Add(this.tb_ID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(295, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 445);
            this.panel1.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(302, 120);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 18;
            // 
            // tb_date
            // 
            this.tb_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_date.Location = new System.Drawing.Point(119, 228);
            this.tb_date.Name = "tb_date";
            this.tb_date.ReadOnly = true;
            this.tb_date.Size = new System.Drawing.Size(132, 20);
            this.tb_date.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Ngày nhập";
            // 
            // tb_dg_new
            // 
            this.tb_dg_new.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_dg_new.Location = new System.Drawing.Point(119, 200);
            this.tb_dg_new.Name = "tb_dg_new";
            this.tb_dg_new.Size = new System.Drawing.Size(132, 20);
            this.tb_dg_new.TabIndex = 13;
            this.tb_dg_new.TextChanged += new System.EventHandler(this.tb_dg_new_TextChanged);
            // 
            // tb_dv
            // 
            this.tb_dv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_dv.Location = new System.Drawing.Point(119, 173);
            this.tb_dv.Name = "tb_dv";
            this.tb_dv.ReadOnly = true;
            this.tb_dv.Size = new System.Drawing.Size(59, 20);
            this.tb_dv.TabIndex = 9;
            // 
            // tb_ID
            // 
            this.tb_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ID.Location = new System.Drawing.Point(119, 145);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.ReadOnly = true;
            this.tb_ID.Size = new System.Drawing.Size(59, 20);
            this.tb_ID.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Đơn giá mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đơn vị tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // bt_submit
            // 
            this.bt_submit.Enabled = false;
            this.bt_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_submit.Location = new System.Drawing.Point(569, 507);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(82, 40);
            this.bt_submit.TabIndex = 6;
            this.bt_submit.Text = "Nhập";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // button12
            // 
            this.button12.Enabled = false;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(473, 507);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(73, 40);
            this.button12.TabIndex = 7;
            this.button12.Text = "Fix TD";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 40);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(61, 290);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(478, 136);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // bt_fixtd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(900, 559);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.flp2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flp1);
            this.Name = "bt_fixtd";
            this.Text = "Quản lý hợp đồng";
            this.Load += new System.EventHandler(this.fr_quanli_HDTP_Load);
            this.flp1.ResumeLayout(false);
            this.flp2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.FlowLayoutPanel flp1;
        private System.Windows.Forms.Button bt_id;
        private System.Windows.Forms.Button bt_name;
        private System.Windows.Forms.Button bt_unit;
        private System.Windows.Forms.Button bt_price;
        private System.Windows.Forms.Button bt_date;
        private System.Windows.Forms.FlowLayoutPanel flp2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_dg_new;
        private System.Windows.Forms.TextBox tb_dv;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bt_submit;

        //15/08
        

        /*
        int[] ID_TP = new int[200]; // mảng chưa ID thực phẩm
        System.Int64[] gia_old = new System.Int64[200];
        System.Int64[] gia_new = new System.Int64[200];

        System.Int64[] gia_TP = new System.Int64[200]; // mảng chưa giá thực phẩm
        int[] dv_TP = new int[200]; // mảng chứa đơn vị tính của thực phẩm (1000 or 1)
        int[,] tp_vc = new int[200, 10]; // mảng chứa lượng vi chất trong mỗi thực phẩm
        int countTP = 0;  // đếm số loại thực phẩm có

        int count_MA_TD = 0;  // đếm số món ăn được dùng trong thực đơn hiện tại
        int[] td_ma = new int[20];  // mảng chưa ID món ăn được dùng trong thực đơn hiện tại
        int[,] ma_tp = new int[20, 200];  // chứa lượng thực phẩm cho các món ăn trong thực đơn hiện tại
        //int count_MA = 0;
        //int[] id_TD = new int[10];
         */


        private System.Windows.Forms.TextBox[] tb_ID_TP = new System.Windows.Forms.TextBox[1000];
        private System.Windows.Forms.TextBox[] tb_Name_TP = new System.Windows.Forms.TextBox[1000];
        private System.Windows.Forms.TextBox[] tb_DonGia_TP_new = new System.Windows.Forms.TextBox[1000];
        
        private System.Windows.Forms.TextBox[] tb_DonVi_TP = new System.Windows.Forms.TextBox[1000];
        
        private System.Windows.Forms.TextBox[] tb_Date_TP = new System.Windows.Forms.TextBox[1000];
        private System.Windows.Forms.TextBox[] tb_nhaphanphoi = new System.Windows.Forms.TextBox[1000];
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button bt_nhaphanphoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;

    }
}