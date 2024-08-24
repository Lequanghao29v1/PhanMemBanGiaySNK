using BUS.Services;
using DAL.Models.ModelRefer;
using OfficeOpenXml;
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
    public partial class Frm_US_HoaDon : UserControl
    {
        public Frm_US_HoaDon()
        {
            InitializeComponent(); LoadGridHD(null, null);
            Loadcombobox();
        }
        HoaDonService _service = new HoaDonService();

        int _idWhenclick;


        public void Loadcombobox()
        {
            List<string> hinhThucThanhToans = _service.GetHinhthucthanhtoans().Select(p => p.Tenhinhthuc).ToList();
            cmbloaitt.Items.Add("Tất cả");
            cmbloaitt.Items.AddRange(hinhThucThanhToans.ToArray());
            cmbloaitt.SelectedIndex = 0;
            cmbloaitt.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbTimkiem.Items.Add(SearchType.tatca);
            cmbTimkiem.Items.Add(SearchType.tenkhach);
            cmbTimkiem.Items.Add(SearchType.SDTkhach);
            cmbTimkiem.Items.Add(SearchType.TenTaikhoan);
            cmbTimkiem.SelectedIndex = 0;
            cmbTimkiem.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        public void LoadGridHD(string search, string searchType)
        {
            int stt = 1;
            dgvHD.ColumnCount = 11;
            dgvHD.Columns[0].Name = "STT";
            dgvHD.Columns[1].Name = "Mã hoá đơn";
            dgvHD.Columns[2].Name = "Tên khách";
            dgvHD.Columns[3].Name = "SĐT khách";
            dgvHD.Columns[4].Name = "Mã NV";
            dgvHD.Columns[5].Name = "Tên NV";
            dgvHD.Columns[6].Name = "Ngày tạo";
            dgvHD.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvHD.Columns[7].Name = "Loại thanh toán";
            dgvHD.Columns[8].Name = "Tổng tiền";
            dgvHD.Columns[9].Name = "Ghi chú";
            dgvHD.Columns[10].Name = "Trạng thái";

            dgvHD.Rows.Clear();

            foreach (var x in _service.hoaDonNhes(search, searchType))
            {
                dgvHD.Rows.Add(stt++, x.Hoadone.Mahoadon, x.tenkhachhang, x.sdtkhach, x.Hoadone.Mataikhoan, x.hovatentaikhoan, x.Hoadone.Ngaytao, x.tenhinhthuc, x.Hoadone.Tongtien, x.Hoadone.Ghichu, x.Hoadone.Trangthai == false ? "Chưa thanh toán" : "Đã thanh toán");
            }
        }

        public void loadgridHoadonchitiet(int selectedID)
        {
            int stt = 1;
            dgvHDCT.ColumnCount = 5;
            dgvHDCT.Columns[0].Name = "STT";
            dgvHDCT.Columns[1].Name = "Mã hoá đơn";
            dgvHDCT.Columns[2].Name = "Tên sản phẩm";
            dgvHDCT.Columns[3].Name = "Số lượng";
            dgvHDCT.Columns[4].Name = "Giá bán";

            dgvHDCT.Rows.Clear();
            foreach (var e in _service.GetHoadonchitiets().Where(x => x.Mahoadon == selectedID))
            {
                var idspct = _service.GetGiaychitiets().FirstOrDefault(i => i.Magiaychitiet == e.Magiaychitiet);
                var idsp = _service.GetGiays().FirstOrDefault(s => s.Magiay == idspct.Magiay);
                dgvHDCT.Rows.Add(stt++, e.Mahoadon, idsp.Tengiay, e.Soluongmua, e.Gia);
            }
        }
        private void dtgHoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _service.hoaDonNhes(null, null).Count)
            {
                return;
            }
            _idWhenclick = int.Parse(dgvHD.Rows[index].Cells[1].Value.ToString());
            loadgridHoadonchitiet(_idWhenclick);



        }


        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            LoadGridHD(txtTimkiem.Text, cmbTimkiem.Text);
        }

        private void cmbloaitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hinhThucThanhToanDuocChon = cmbloaitt.SelectedItem.ToString();
            string loaiThanhToan = (hinhThucThanhToanDuocChon == "Tất cả") ? null : hinhThucThanhToanDuocChon;
            LoadGridHD(null, loaiThanhToan);
        }

        private void cmbTimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGridHD(txtTimkiem.Text, cmbTimkiem.Text);
        }

        private void datetao_ValueChanged(object sender, EventArgs e)
        {
            LoadGridHD(txtTimkiem.Text, cmbTimkiem.Text);
        }
        private void dateden_ValueChanged(object sender, EventArgs e)
        {
            LoadGridHD(txtTimkiem.Text, cmbTimkiem.Text);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                for (int i = 0; i < dgvHD.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dgvHD.Columns[i].HeaderText;
                }

                for (int i = 0; i < dgvHD.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvHD.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dgvHD.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                var result = saveFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                    excelPackage.SaveAs(fileInfo);
                    MessageBox.Show("Dữ liệu đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xuất file thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


    }
}
