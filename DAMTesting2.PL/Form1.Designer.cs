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
            tabControl = new TabControl();
            tabPhim = new TabPage();
            label6 = new Label();
            flowLayoutPanelTheLoais = new FlowLayoutPanel();
            cb_trangthai = new ComboBox();
            label7 = new Label();
            txt_timkiem = new TextBox();
            txt_mota = new TextBox();
            txt_thoiluong = new TextBox();
            txt_daodien = new TextBox();
            txt_thoigian = new TextBox();
            txt_ten = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_clear = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            dgv_phim = new DataGridView();
            tabTheLoai = new TabPage();
            flowLayoutPanelPhimByTheLoai = new FlowLayoutPanel();
            txt_theloai = new TextBox();
            btn_suatheloai = new Button();
            btn_xoatheloai = new Button();
            btn_themtheloai = new Button();
            label8 = new Label();
            dgv_theloai = new DataGridView();
            tabControl.SuspendLayout();
            tabPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_phim).BeginInit();
            tabTheLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_theloai).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPhim);
            tabControl.Controls.Add(tabTheLoai);
            tabControl.Location = new Point(2, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1171, 604);
            tabControl.TabIndex = 0;
            // 
            // tabPhim
            // 
            tabPhim.Controls.Add(label6);
            tabPhim.Controls.Add(flowLayoutPanelTheLoais);
            tabPhim.Controls.Add(cb_trangthai);
            tabPhim.Controls.Add(label7);
            tabPhim.Controls.Add(txt_timkiem);
            tabPhim.Controls.Add(txt_mota);
            tabPhim.Controls.Add(txt_thoiluong);
            tabPhim.Controls.Add(txt_daodien);
            tabPhim.Controls.Add(txt_thoigian);
            tabPhim.Controls.Add(txt_ten);
            tabPhim.Controls.Add(label5);
            tabPhim.Controls.Add(label4);
            tabPhim.Controls.Add(label3);
            tabPhim.Controls.Add(label2);
            tabPhim.Controls.Add(label1);
            tabPhim.Controls.Add(btn_clear);
            tabPhim.Controls.Add(btn_xoa);
            tabPhim.Controls.Add(btn_sua);
            tabPhim.Controls.Add(btn_them);
            tabPhim.Controls.Add(dgv_phim);
            tabPhim.Location = new Point(4, 24);
            tabPhim.Name = "tabPhim";
            tabPhim.Padding = new Padding(3);
            tabPhim.Size = new Size(1163, 576);
            tabPhim.TabIndex = 0;
            tabPhim.Text = "Phim";
            tabPhim.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(479, 64);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 37;
            label6.Text = "Thể Loại";
            // 
            // flowLayoutPanelTheLoais
            // 
            flowLayoutPanelTheLoais.Location = new Point(554, 54);
            flowLayoutPanelTheLoais.Name = "flowLayoutPanelTheLoais";
            flowLayoutPanelTheLoais.Size = new Size(301, 150);
            flowLayoutPanelTheLoais.TabIndex = 46;
            // 
            // cb_trangthai
            // 
            cb_trangthai.FormattingEnabled = true;
            cb_trangthai.Location = new Point(151, 206);
            cb_trangthai.Name = "cb_trangthai";
            cb_trangthai.Size = new Size(301, 23);
            cb_trangthai.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 209);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 44;
            label7.Text = "Trạng Thái";
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(55, 298);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(466, 23);
            txt_timkiem.TabIndex = 43;
            // 
            // txt_mota
            // 
            txt_mota.Location = new Point(151, 167);
            txt_mota.Name = "txt_mota";
            txt_mota.Size = new Size(301, 23);
            txt_mota.TabIndex = 42;
            // 
            // txt_thoiluong
            // 
            txt_thoiluong.Location = new Point(151, 130);
            txt_thoiluong.Name = "txt_thoiluong";
            txt_thoiluong.Size = new Size(301, 23);
            txt_thoiluong.TabIndex = 41;
            // 
            // txt_daodien
            // 
            txt_daodien.Location = new Point(151, 95);
            txt_daodien.Name = "txt_daodien";
            txt_daodien.Size = new Size(301, 23);
            txt_daodien.TabIndex = 40;
            // 
            // txt_thoigian
            // 
            txt_thoigian.Location = new Point(151, 60);
            txt_thoigian.Name = "txt_thoigian";
            txt_thoigian.Size = new Size(301, 23);
            txt_thoigian.TabIndex = 39;
            // 
            // txt_ten
            // 
            txt_ten.Location = new Point(151, 26);
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(301, 23);
            txt_ten.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 170);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 36;
            label5.Text = "Mô tả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 133);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 35;
            label4.Text = "Thời Lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 98);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 34;
            label3.Text = "Đạo Diễn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 60);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 33;
            label2.Text = "Thời Gian Phát Hành";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 26);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 32;
            label1.Text = "Tên Phim";
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(982, 236);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(159, 49);
            btn_clear.TabIndex = 31;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(982, 167);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(159, 49);
            btn_xoa.TabIndex = 30;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(982, 95);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(159, 49);
            btn_sua.TabIndex = 29;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(982, 23);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(159, 49);
            btn_them.TabIndex = 28;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            // 
            // dgv_phim
            // 
            dgv_phim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_phim.Location = new Point(6, 327);
            dgv_phim.Name = "dgv_phim";
            dgv_phim.Size = new Size(1151, 246);
            dgv_phim.TabIndex = 27;
        
            // 
            // tabTheLoai
            // 
            tabTheLoai.Controls.Add(flowLayoutPanelPhimByTheLoai);
            tabTheLoai.Controls.Add(txt_theloai);
            tabTheLoai.Controls.Add(btn_suatheloai);
            tabTheLoai.Controls.Add(btn_xoatheloai);
            tabTheLoai.Controls.Add(btn_themtheloai);
            tabTheLoai.Controls.Add(label8);
            tabTheLoai.Controls.Add(dgv_theloai);
            tabTheLoai.Location = new Point(4, 24);
            tabTheLoai.Name = "tabTheLoai";
            tabTheLoai.Padding = new Padding(3);
            tabTheLoai.Size = new Size(1163, 576);
            tabTheLoai.TabIndex = 1;
            tabTheLoai.Text = "Thể Loại";
            tabTheLoai.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelPhimByTheLoai
            // 
            flowLayoutPanelPhimByTheLoai.Location = new Point(259, 66);
            flowLayoutPanelPhimByTheLoai.Name = "flowLayoutPanelPhimByTheLoai";
            flowLayoutPanelPhimByTheLoai.Size = new Size(301, 150);
            flowLayoutPanelPhimByTheLoai.TabIndex = 47;
            // 
            // txt_theloai
            // 
            txt_theloai.Location = new Point(259, 16);
            txt_theloai.Name = "txt_theloai";
            txt_theloai.Size = new Size(333, 23);
            txt_theloai.TabIndex = 5;
            // 
            // btn_suatheloai
            // 
            btn_suatheloai.Location = new Point(756, 87);
            btn_suatheloai.Name = "btn_suatheloai";
            btn_suatheloai.Size = new Size(174, 43);
            btn_suatheloai.TabIndex = 4;
            btn_suatheloai.Text = "Sửa";
            btn_suatheloai.UseVisualStyleBackColor = true;
            btn_suatheloai.Click += btn_suatheloai_Click;
            // 
            // btn_xoatheloai
            // 
            btn_xoatheloai.Location = new Point(756, 150);
            btn_xoatheloai.Name = "btn_xoatheloai";
            btn_xoatheloai.Size = new Size(174, 43);
            btn_xoatheloai.TabIndex = 3;
            btn_xoatheloai.Text = "Xóa";
            btn_xoatheloai.UseVisualStyleBackColor = true;
            btn_xoatheloai.Click += btn_xoatheloai_Click;
            // 
            // btn_themtheloai
            // 
            btn_themtheloai.Location = new Point(756, 25);
            btn_themtheloai.Name = "btn_themtheloai";
            btn_themtheloai.Size = new Size(174, 43);
            btn_themtheloai.TabIndex = 2;
            btn_themtheloai.Text = "Thêm";
            btn_themtheloai.UseVisualStyleBackColor = true;
            btn_themtheloai.Click += btn_themtheloai_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(181, 19);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 1;
            label8.Text = "Tên Thể Loại";
            // 
            // dgv_theloai
            // 
            dgv_theloai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_theloai.Location = new Point(6, 250);
            dgv_theloai.Name = "dgv_theloai";
            dgv_theloai.Size = new Size(1151, 320);
            dgv_theloai.TabIndex = 0;
            dgv_theloai.CellClick += dgv_theloai_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 611);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            tabPhim.ResumeLayout(false);
            tabPhim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_phim).EndInit();
            tabTheLoai.ResumeLayout(false);
            tabTheLoai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_theloai).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPhim;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanelTheLoais;
        private ComboBox cb_trangthai;
        private Label label7;
        private TextBox txt_timkiem;
        private TextBox txt_mota;
        private TextBox txt_thoiluong;
        private TextBox txt_daodien;
        private TextBox txt_thoigian;
        private TextBox txt_ten;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_clear;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
        private DataGridView dgv_phim;
        private TabPage tabTheLoai;
        private Button btn_suatheloai;
        private Button btn_xoatheloai;
        private Button btn_themtheloai;
        private Label label8;
        private DataGridView dgv_theloai;
        private TextBox txt_theloai;
        private FlowLayoutPanel flowLayoutPanelPhimByTheLoai;
    }
}
