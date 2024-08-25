using DAMTesting2.BUS.Implement;
using DAMTesting2.BUS.Utils;
using DAMTesting2.BUS.Utils.Status;
using DAMTesting2.BUS.ViewModel;
using DAMTesting2.BUS.Interface;
using DAMTesting2.DAL.Repositories.Implement;
using DAMTesting2.DAL;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DAMTesting2.PL
{
    public partial class Form1 : Form
    {
        // Khai báo các danh sách ViewModel
        List<PhimVM> _phims;
        List<TheLoaiVM> _theLoai;

        // Khai báo các service
        ITheLoaiService _theLoaiService;
        IPhimService _phimService;
        int _maPhimChon;
        int _maTheLoaiChon;

        public Form1()
        {
            var phimRepo = new PhimRepo();
            var theLoaiRepo = new TheLoaiRepo(new AppDBContext());

            // Khởi tạo các service
            _phimService = new PhimServices(phimRepo, new AppDBContext());
            _theLoaiService = new TheLoaiService(theLoaiRepo);

            InitializeComponent();
            LoadTheLoaiCheckBoxes();
            LoadDataForm();
            LoadGridData();
            LoadDataFormTheLoai();
            LoadGridDataTheLoai();



        }

        private void LoadDataForm()
        {
            dgv_phim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_phim.Columns.Clear();
            dgv_phim.Columns.Add("clm1", "STT");
            dgv_phim.Columns.Add("clm2", "Tên Phim");
            dgv_phim.Columns.Add("clm3", "Thời Gian Phát Hành");
            dgv_phim.Columns.Add("clm4", "Đạo Diễn");
            dgv_phim.Columns.Add("clm5", "Thời Lượng");
            dgv_phim.Columns.Add("clm8", "Mô Tả");
            dgv_phim.Columns.Add("clm6", "Trạng Thái");
            dgv_phim.Columns.Add("clm7", "Thể Loại");


            cb_trangthai.Items.Clear();
            cb_trangthai.Items.Add(StatusEnum.DangPhatHanh.GetStatusName());
            cb_trangthai.Items.Add(StatusEnum.TamDung.GetStatusName());
            cb_trangthai.Items.Add(StatusEnum.DaNgungPhatHanh.GetStatusName());

            cb_trangthai.SelectedIndex = 0;


        }

        private void LoadDataFormTheLoai()
        {
            dgv_theloai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_theloai.Columns.Clear();
            dgv_theloai.Columns.Add("clm1", "STT");
            dgv_theloai.Columns.Add("clm2", "Tên Thể Loại");
            dgv_theloai.Columns.Add("clm3", "Các Phim của Thể Loại");
        }

        private void LoadGridDataTheLoai()
        {
            _theLoai = _theLoaiService.GetAll();
            dgv_theloai.Rows.Clear();

            foreach (var theLoai in _theLoai)
            {
                var phimList = _theLoaiService.GetPhimByTheLoaiId(theLoai.TheLoaiId);
                string phimNames = string.Join(", ", phimList.Select(p => p.TenPhim).ToArray());

                dgv_theloai.Rows.Add(
                    (_theLoai.IndexOf(theLoai) + 1),
                    theLoai.TenTheLoai,
                    phimNames
                );
            }
        }

        private void LoadGridData()
        {
            _phims = _phimService.GetList();
            dgv_phim.Rows.Clear();

            foreach (var phim in _phims)
            {
                string trangThai = GetStatusName(phim.TrangThai ?? 0);
                var theLoaiNames = phim.TheLoaiIds
                    .Select(id => _phimService.GetTheLoaiName(id))
                    .ToArray();
                string theLoais = string.Join(", ", theLoaiNames);

                dgv_phim.Rows.Add(
                    (_phims.IndexOf(phim) + 1),
                    phim.TenPhim,
                    phim.ThoiGianPhatHanh?.ToShortDateString(),
                    phim.DaoDien,
                    phim.ThoiLuong,
                    phim.MoTa,
                    trangThai,
                    theLoais
                );
            }
        }


        private void LoadTheLoaiCheckBoxes()
        {
            var theLoaiList = _phimService.GetAllTheLoais();

            foreach (var theLoai in theLoaiList)
            {
                CheckBox checkBox = new CheckBox
                {
                    Text = theLoai.TenTheLoai,
                    Tag = theLoai.TheLoaiId,
                    AutoSize = true
                };
                flowLayoutPanelTheLoais.Controls.Add(checkBox);
            }
        }

        private string GetStatusName(int trangThai)
        {
            switch (trangThai)
            {
                case 1:
                    return "Đang Phát Hành";
                case 2:
                    return "Tạm Dừng";
                case 3:
                    return "Đã Ngừng Phát Hành";
                default:
                    return "Không xác định";
            }

        }

        private List<int> GetSelectedTheLoaiIds()
        {
            List<int> selectedIds = new List<int>();

            foreach (CheckBox checkBox in flowLayoutPanelTheLoais.Controls)
            {
                if (checkBox.Checked)
                {
                    selectedIds.Add((int)checkBox.Tag);
                }
            }

            return selectedIds;
        }


        private void btn_them_Click(object sender, EventArgs e)
        {
            bool isThoiLuongValid = int.TryParse(txt_thoiluong.Text.Trim(), out int thoiLuong);
            var trangThaiString = cb_trangthai.SelectedItem?.ToString();
            int trangThai = -1;

            if (!string.IsNullOrEmpty(trangThaiString))
            {
                if (trangThaiString.Contains("Đang Phát Hành")) trangThai = (int)StatusEnum.DangPhatHanh;
                else if (trangThaiString.Contains("Tạm Dừng")) trangThai = (int)StatusEnum.TamDung;
                else if (trangThaiString.Contains("Đã Ngừng Phát Hành")) trangThai = (int)StatusEnum.DaNgungPhatHanh;
            }
            if (!isThoiLuongValid || thoiLuong <= 0 || trangThai <= 0)
            {
                MessageBox.Show("Các trường số phải là số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isThoiGianValid = DateTime.TryParseExact(txt_thoigian.Text.Trim(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime thoiGianPhatHanh);
            if (!isThoiGianValid)
            {
                MessageBox.Show("Thời gian phát hành không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn thêm phim này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var selectedTheLoaiIds = GetSelectedTheLoaiIds();

                var phimCreate = new PhimCreateVM
                {
                    TenPhim = txt_ten.Text.Trim(),
                    ThoiGianPhatHanh = DateOnly.FromDateTime(thoiGianPhatHanh),
                    DaoDien = txt_daodien.Text.Trim(),
                    ThoiLuong = thoiLuong,
                    TrangThai = trangThai,
                    MoTa = txt_mota.Text.Trim(),
                    TheLoaiIds = selectedTheLoaiIds
                };

                var result = _phimService.Create(phimCreate);
                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridData();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (_maPhimChon == 0)
            {
                MessageBox.Show("Vui lòng chọn phim cần chỉnh sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isThoiLuongValid = int.TryParse(txt_thoiluong.Text, out int thoiLuong);
            var trangThaiString = cb_trangthai.SelectedItem?.ToString();
            int trangThai = -1;

            if (!string.IsNullOrEmpty(trangThaiString))
            {
                if (trangThaiString.Contains("Đang Phát Hành")) trangThai = (int)StatusEnum.DangPhatHanh;
                else if (trangThaiString.Contains("Tạm Dừng")) trangThai = (int)StatusEnum.TamDung;
                else if (trangThaiString.Contains("Đã Ngừng Phát Hành")) trangThai = (int)StatusEnum.DaNgungPhatHanh;
            }
            if (!isThoiLuongValid || thoiLuong <= 0 || trangThai <= 0)
            {
                MessageBox.Show("Các trường số phải là số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isThoiGianValid = DateTime.TryParseExact(txt_thoigian.Text.Trim(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime thoiGianPhatHanh);
            if (!isThoiGianValid)
            {
                MessageBox.Show("Thời gian phát hành không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedTheLoaiIds = GetSelectedTheLoaiIds();

            var phimUpdate = new PhimUpdateVM
            {
                PhimId = _maPhimChon,
                TenPhim = txt_ten.Text.Trim(),
                ThoiGianPhatHanh = DateOnly.FromDateTime(thoiGianPhatHanh),
                DaoDien = txt_daodien.Text.Trim(),
                ThoiLuong = thoiLuong,
                TrangThai = trangThai,
                MoTa = txt_mota.Text.Trim(),
                TheLoaiIds = selectedTheLoaiIds
            };

            var result = _phimService.Update(phimUpdate);
            string msg = result ? "Chỉnh sửa thành công" : "Chỉnh sửa thất bại";
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGridData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (_maPhimChon == 0)
            {
                MessageBox.Show("Vui lòng chọn phim cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phim này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = _phimService.Delete(_maPhimChon);
                string msg = result ? "Xóa thành công" : "Xóa thất bại";
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridData();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ten.Clear();
            txt_thoigian.Clear();
            txt_daodien.Clear();
            txt_thoiluong.Clear();
            txt_mota.Clear();
            cb_trangthai.SelectedIndex = -1;

            foreach (CheckBox checkBox in flowLayoutPanelTheLoais.Controls)
            {
                checkBox.Checked = false;
            }
        }

        private void dgv_phim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            if (index < 0 || index >= _phims.Count)
            {
                _maPhimChon = 0;
                return;
            }

            var phimChon = _phims.ElementAt(index);

            _maPhimChon = phimChon.PhimId;
            txt_ten.Text = phimChon.TenPhim;
            txt_thoigian.Text = phimChon.ThoiGianPhatHanh?.ToShortDateString();
            txt_daodien.Text = phimChon.DaoDien;
            txt_thoiluong.Text = phimChon.ThoiLuong.ToString();
            txt_mota.Text = phimChon.MoTa;
            cb_trangthai.SelectedItem = GetStatusName(phimChon.TrangThai ?? 0);
            foreach (CheckBox checkBox in flowLayoutPanelTheLoais.Controls)
            {
                checkBox.Checked = phimChon.TheLoaiIds.Contains((int)checkBox.Tag);
            }
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            _phims = _phimService.Search(txt_timkiem.Text);
            LoadGridData();
        }

        private void btn_themtheloai_Click(object sender, EventArgs e)
        {
            var tenTheLoai = txt_theloai.Text.Trim();

            if (string.IsNullOrEmpty(tenTheLoai))
            {
                MessageBox.Show("Tên thể loại không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var theLoaiVM = new TheLoaiVM
            {
                TenTheLoai = tenTheLoai
            };
            var result = _theLoaiService.Create(theLoaiVM);
            MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGridDataTheLoai();
        }

        private void btn_suatheloai_Click(object sender, EventArgs e)
        {
            if (_maPhimChon == 0)
            {
                MessageBox.Show("Vui lòng chọn thể loại cần sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var tenTheLoai = txt_theloai.Text.Trim();

            if (string.IsNullOrEmpty(tenTheLoai))
            {
                MessageBox.Show("Tên thể loại không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var theLoaiVM = new TheLoaiVM
            {
                TheLoaiId = _maPhimChon,
                TenTheLoai = tenTheLoai
            };

            var result = _theLoaiService.Update(theLoaiVM);
            string msg = result ? "Cập nhật thành công" : "Cập nhật thất bại";
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadGridData();
        }

        private void btn_xoatheloai_Click(object sender, EventArgs e)
        {
            if (_maPhimChon == 0)
            {
                MessageBox.Show("Vui lòng chọn thể loại cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa thể loại này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = _theLoaiService.Delete(_maPhimChon);
                string msg = result ? "Xóa thành công" : "Xóa thất bại";
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadGridData();
            }
        }

        private void dgv_theloai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            if (index < 0 || index >= _theLoai.Count)
            {
                _maTheLoaiChon = 0;
                return;
            }

            var theLoaiChon = _theLoai.ElementAt(index);
            _maTheLoaiChon = theLoaiChon.TheLoaiId;

            txt_theloai.Text = theLoaiChon.TenTheLoai;

            LoadAndUpdatePhimCheckBoxes(_maTheLoaiChon);
        }

        private void LoadAndUpdatePhimCheckBoxes(int theLoaiId)
        {
            var allPhims = _phimService.GetList();

            var phimsByTheLoai = _theLoaiService.GetPhimByTheLoaiId(theLoaiId);
            flowLayoutPanelPhimByTheLoai.Controls.Clear();

            foreach (var phim in allPhims)
            {
                CheckBox checkBox = new CheckBox
                {
                    Text = phim.TenPhim,
                    Tag = phim.PhimId,
                    AutoSize = true,
                    Checked = phimsByTheLoai.Any(p => p.PhimId == phim.PhimId)
                };

                flowLayoutPanelPhimByTheLoai.Controls.Add(checkBox);
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPhim)
            {
                LoadGridData();
            }
            else if (tabControl.SelectedTab == tabTheLoai)
            {
            }
        }

        private void dgv_phim_Click(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;

            if (index < 0 || index >= _phims.Count)
            {
                _maPhimChon = 0;
                return;
            }

            var phimChon = _phims.ElementAt(index);

            _maPhimChon = phimChon.PhimId;
            txt_ten.Text = phimChon.TenPhim;
            txt_thoigian.Text = phimChon.ThoiGianPhatHanh?.ToShortDateString();
            txt_daodien.Text = phimChon.DaoDien;
            txt_thoiluong.Text = phimChon.ThoiLuong.ToString();
            txt_mota.Text = phimChon.MoTa;
            cb_trangthai.SelectedItem = GetStatusName(phimChon.TrangThai ?? 0);
            foreach (CheckBox checkBox in flowLayoutPanelTheLoais.Controls)
            {
                checkBox.Checked = phimChon.TheLoaiIds.Contains((int)checkBox.Tag);
            }
        }
    }
}
