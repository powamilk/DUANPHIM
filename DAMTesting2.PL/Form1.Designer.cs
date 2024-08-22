namespace DAMTesting2.PL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_phim = new DataGridView();
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            btn_clear = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_ten = new TextBox();
            txt_thoigian = new TextBox();
            txt_daodien = new TextBox();
            txt_thoiluong = new TextBox();
            txt_mota = new TextBox();
            txt_timkiem = new TextBox();
            label7 = new Label();
            cb_trangthai = new ComboBox();
            flowLayoutPanelTheLoais = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgv_phim).BeginInit();
            SuspendLayout();
            // 
            // dgv_phim
            // 
            dgv_phim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_phim.Location = new Point(8, 317);
            dgv_phim.Name = "dgv_phim";
            dgv_phim.Size = new Size(1051, 282);
            dgv_phim.TabIndex = 0;
            dgv_phim.CellClick += dgv_phim_CellClick;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(796, 25);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(159, 49);
            btn_them.TabIndex = 1;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(796, 97);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(159, 49);
            btn_sua.TabIndex = 2;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(796, 169);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(159, 49);
            btn_xoa.TabIndex = 3;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(796, 238);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(159, 49);
            btn_clear.TabIndex = 4;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 14);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 5;
            label1.Text = "Tên Phim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 48);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 6;
            label2.Text = "Thời Gian Phát Hành";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 86);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "Đạo Diễn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 121);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 8;
            label4.Text = "Thời Lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(115, 158);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 9;
            label5.Text = "Mô tả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(98, 233);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 10;
            label6.Text = "Thể Loại";
            // 
            // txt_ten
            // 
            txt_ten.Location = new Point(173, 14);
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(301, 23);
            txt_ten.TabIndex = 12;
            // 
            // txt_thoigian
            // 
            txt_thoigian.Location = new Point(173, 48);
            txt_thoigian.Name = "txt_thoigian";
            txt_thoigian.Size = new Size(301, 23);
            txt_thoigian.TabIndex = 13;
            // 
            // txt_daodien
            // 
            txt_daodien.Location = new Point(173, 83);
            txt_daodien.Name = "txt_daodien";
            txt_daodien.Size = new Size(301, 23);
            txt_daodien.TabIndex = 14;
            // 
            // txt_thoiluong
            // 
            txt_thoiluong.Location = new Point(173, 118);
            txt_thoiluong.Name = "txt_thoiluong";
            txt_thoiluong.Size = new Size(301, 23);
            txt_thoiluong.TabIndex = 15;
            // 
            // txt_mota
            // 
            txt_mota.Location = new Point(173, 155);
            txt_mota.Name = "txt_mota";
            txt_mota.Size = new Size(301, 23);
            txt_mota.TabIndex = 16;
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(8, 288);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(466, 23);
            txt_timkiem.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(92, 197);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 19;
            label7.Text = "Trạng Thái";
            // 
            // cb_trangthai
            // 
            cb_trangthai.FormattingEnabled = true;
            cb_trangthai.Location = new Point(173, 194);
            cb_trangthai.Name = "cb_trangthai";
            cb_trangthai.Size = new Size(301, 23);
            cb_trangthai.TabIndex = 20;
            // 
            // flowLayoutPanelTheLoais
            // 
            flowLayoutPanelTheLoais.Location = new Point(173, 223);
            flowLayoutPanelTheLoais.Name = "flowLayoutPanelTheLoais";
            flowLayoutPanelTheLoais.Size = new Size(301, 59);
            flowLayoutPanelTheLoais.TabIndex = 26;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 611);
            Controls.Add(label6);
            Controls.Add(flowLayoutPanelTheLoais);
            Controls.Add(cb_trangthai);
            Controls.Add(label7);
            Controls.Add(txt_timkiem);
            Controls.Add(txt_mota);
            Controls.Add(txt_thoiluong);
            Controls.Add(txt_daodien);
            Controls.Add(txt_thoigian);
            Controls.Add(txt_ten);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_clear);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_them);
            Controls.Add(dgv_phim);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv_phim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_phim;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_clear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_ten;
        private TextBox txt_thoigian;
        private TextBox txt_daodien;
        private TextBox txt_thoiluong;
        private TextBox txt_mota;
        private TextBox txt_timkiem;
        private Label label7;
        private ComboBox cb_trangthai;
        private FlowLayoutPanel flowLayoutPanelTheLoais;
    }
}
