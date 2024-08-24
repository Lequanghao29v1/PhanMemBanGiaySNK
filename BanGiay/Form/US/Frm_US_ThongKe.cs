using BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanGiay.Form.US
{
    public partial class Frm_US_ThongKe : UserControl
    {
        public Frm_US_ThongKe()
        {
            InitializeComponent();
            datebatdau.Format = DateTimePickerFormat.Custom;
            datebatdau.CustomFormat = "dd/MM/yyyy";
            dateketthuc.Format = DateTimePickerFormat.Custom;
            dateketthuc.CustomFormat = "dd/MM/yyyy";
            LoadGrid();
        }

        ThhongkeService _services = new ThhongkeService();
        private bool isFiltering = false;
        Dictionary<string, Tuple<Nullable<int>, Nullable<double>, Nullable<DateTime>>> thongtinsanpham = new Dictionary<string, Tuple<Nullable<int>, Nullable<double>, Nullable<DateTime>>>();
        private Dictionary<string, Tuple<Nullable<int>, Nullable<double>, Nullable<DateTime>>> thongtinsanphamLoc;

        public void LoadGrid()
        {
            int stt = 1;
            dgvSP_BanChay.ColumnCount = 5;
            dgvSP_BanChay.Columns[0].Name = "STT";
            dgvSP_BanChay.Columns[0].Visible = false;
            dgvSP_BanChay.Columns[1].Name = "Tên sản phẩm";
            dgvSP_BanChay.Columns[2].Name = "Số lượng bán";
            dgvSP_BanChay.Columns[3].Name = "Tổng tiền";
            dgvSP_BanChay.Columns[4].Name = "Ngày tạo";
            dgvSP_BanChay.Columns[4].Visible = false;

            dgvSP_BanChay.Rows.Clear();
            double? tongtiente = 0.0;
            int? soluong = 0;
            int tonghoadon = 0;
            thongtinsanpham.Clear();

            HashSet<int> uniqueHoaDonIds = new HashSet<int>();

            foreach (var x in _services.GetHoadonchitiets())
            {
                var idgiayct = _services.GetGiaychitiets().FirstOrDefault(e => e.Magiaychitiet == x.Magiaychitiet);
                var tenGiay = _services.GetGiays().FirstOrDefault(e => e.Magiay == idgiayct.Magiay)?.Tengiay;
                var hoadon = _services.GetHoadons().FirstOrDefault(h => h.Mahoadon == x.Mahoadon);

                if (isFiltering)
                {
                    DateTime? ngayTao = hoadon.Ngaytao;
                    if (!IsWithinDateRange(ngayTao, datebatdau.Value, dateketthuc.Value))
                    {
                        continue;
                    }
                }

                if (thongtinsanpham.ContainsKey(tenGiay))
                {
                    var existingTuple = thongtinsanpham[tenGiay];
                    thongtinsanpham[tenGiay] = Tuple.Create(existingTuple.Item1 + x.Soluongmua, existingTuple.Item2 + x.Gia * x.Soluongmua, hoadon.Ngaytao);
                }
                else
                {
                    thongtinsanpham[tenGiay] = Tuple.Create(x.Soluongmua, x.Gia * x.Soluongmua, hoadon.Ngaytao);
                }
                if (uniqueHoaDonIds.Add(hoadon.Mahoadon))
                {
                    tonghoadon++;
                }

                tongtiente += x.Soluongmua * x.Gia;
                soluong += x.Soluongmua;
            }

            var sanphamData = thongtinsanphamLoc != null ? thongtinsanphamLoc : thongtinsanpham;
            var sapxepgiamdan = sanphamData.OrderByDescending(e => e.Value.Item1);

            foreach (var sanpham in sapxepgiamdan)
            {
                dgvSP_BanChay.Rows.Add(stt++, sanpham.Key, sanpham.Value.Item1, sanpham.Value.Item2, "N/A");
            }

            lbTongtien.Text = tongtiente.ToString() + " " + "đ";
            lbTongSP.Text = soluong.ToString();
            lbTonghoadon.Text = tonghoadon.ToString();
        }
        private bool IsWithinDateRange(DateTime? dateToCheck, DateTime startDate, DateTime endDate)
        {
            return dateToCheck >= startDate && dateToCheck <= endDate;
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (datebatdau.Value >= dateketthuc.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime batdau = datebatdau.Value;
            DateTime ketthuc = dateketthuc.Value;

            thongtinsanphamLoc = thongtinsanpham
                .Where(pair =>
                {
                    DateTime? ngayTao = pair.Value.Item3;
                    return ngayTao >= batdau && ngayTao <= ketthuc;
                })
                .ToDictionary(pair => pair.Key, pair => Tuple.Create(pair.Value.Item1, pair.Value.Item2, pair.Value.Item3));

            isFiltering = true;
            LoadGrid();
            isFiltering = false;
        }

        private void lbTongtien_Click(object sender, EventArgs e)
        {

        }
    }
}
