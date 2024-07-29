using CHUATHITHUNET103.DomainClass;
using CHUATHITHUNET103.Services;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace CHUATHITHUNET103
{
    public partial class Form1 : Form
    {
        SinhVienService _service = new SinhVienService();
        int _IdWhenClick;
        public Form1()
        {
            InitializeComponent();
            LoadDataView();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            //Thêm dữ liệu
            cmbCoSo.Items.Add("Kiều Mai");
            cmbCoSo.Items.Add("Cầu Diễn");
            cmbCoSo.Items.Add("Trịnh Văn Bô");
            //Đặt hiển thị ban đầu
            cmbCoSo.SelectedIndex = 0;
            //Khóa chỉnh sửa
            cmbCoSo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadDataView()
        {
            // tạo ra 1 stt
            int stt = 1;
            // Xác định số cột cần tạo ra
            // = số lượng thuộc tính đối tượng + stt 
            dtgView.ColumnCount = 5;
            //đặt tên cột
            dtgView.Columns[0].Name = "STT";
            dtgView.Columns[1].Name = "ID";
            dtgView.Columns[2].Name = "Tên";
            dtgView.Columns[3].Name = "Tuổi";
            dtgView.Columns[4].Name = "Cơ Sở";
            //Quang trọng : clear tất cả các dòng
            dtgView.Rows.Clear();
            //Add dữ liệu vào từng cột
            foreach (var sv in _service.GetDanhSach())
            {
                dtgView.Rows.Add(stt++, sv.Id, sv.Ten, sv.Tuoi, sv.CoSo);
            }
        }

        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy dòng đang được chọn
            int selectedRow = e.RowIndex;
            //Kiểm tra dòng ko có dữ liệu
            if (selectedRow < 0 || selectedRow >= _service.GetDanhSach().Count)
            {
                return; //ko tương tác gì
            }
            //trích xuất dữ liệu của ID đối tượng => lưu vào biến toàn cục
            _IdWhenClick = int.Parse(dtgView.Rows[selectedRow].Cells[1].Value.ToString());
            FillTextBox();
        }

        private void FillTextBox()
        {
            var data = _service.GetDanhSach().FirstOrDefault(x => x.Id == _IdWhenClick);
            //Bind dữ liệu vào các trường cần thiết
            txtTen.Text = data.Ten;
            txtTuoi.Text = data.Tuoi.ToString();
            cmbCoSo.Text = data.CoSo;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Tạo đối tượng mới
            Sinhvien sv = new Sinhvien();
            //Gán các giá trị từ box vào thuộc tính 
            sv.Ten = txtTen.Text;
            sv.Tuoi = int.Parse(txtTuoi.Text);
            sv.CoSo = cmbCoSo.Text;
            //Gọi thông báo và load lại data
            MessageBox.Show(_service.ThemSV(sv));
            LoadDataView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Tìm đối tượng với ID đã chọn
            var sv = _service.GetDanhSach().FirstOrDefault(x => x.Id == _IdWhenClick);
            //Gán từ box vào
            sv.Ten = txtTen.Text;
            sv.Tuoi = int.Parse(txtTuoi.Text);
            sv.CoSo = cmbCoSo.Text;
            //Gọi thông báo và load lại data
            MessageBox.Show(_service.SuaSV(sv));
            LoadDataView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Xóa chỉ cần ID => y hệt bước 1 của sửa
            var sv = _service.GetDanhSach().FirstOrDefault(x => x.Id == _IdWhenClick);
            //Gọi thông báo và load lại data
            MessageBox.Show(_service.XoaSV(sv));
            LoadDataView();
        }
    }
}
