using BUS.Services;
using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using Microsoft.VisualBasic.ApplicationServices;
using PRL.Frm_Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Form
{
    public partial class Giay_Frm : System.Windows.Forms.Form
    {
        GiayService _Ser = new GiayService();
        List<Giay> _lstObj = new List<Giay>();
        DangNhap_Frm frm_DangNhap = new DangNhap_Frm();
        int idClicked;
        public Giay_Frm()
        {
            InitializeComponent();
        }
        private void Giay_Frm_Load(object sender, EventArgs e)
        {
            LoadCBB();
            LoadDataGridView(null, null);
        }
        public void ClearTextBox()
        {
            txtTen.Text = "";
            txtTimKiem.Text = "";
        }
        public void LoadCBB()
        {
            cbbTimKiem.Items.Clear();
            cbbTimKiem.Items.Add(SearchType.All);
            cbbTimKiem.Items.Add(SearchType.tenGiay);
            cbbTimKiem.SelectedIndex = 0;
        }
        public void LoadDataGridView(string? txtTimKiem, string? SearchType)
        {
            dgv_Objects.Rows.Clear();

            dgv_Objects.ColumnCount = 2;
            dgv_Objects.Columns[0].Name = "STT";
            dgv_Objects.Columns[1].Name = "tên";

            _lstObj = _Ser.GetAll(txtTimKiem, SearchType);

            foreach (var item in _lstObj)
            {
                int stt = _lstObj.IndexOf(item) + 1;

                dgv_Objects.Rows.Add(stt,
                    item.Tengiay
                    );
            }

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDataGridView(txtTimKiem.Text, cbbTimKiem.Text);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            bool result;
            if (CheckTextbox())
            {
                var confirmResult = MessageBox.Show("Xác nhận 'thêm' giày không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var existingProduct = _Ser.GetAll(null, null)
                            .FirstOrDefault(p =>
                                p.Tengiay == txtTen.Text);
                    if (existingProduct != null)
                    {
                        MessageBox.Show("Tên giày đã tồn tại!");
                        result = false;
                    }
                    else
                    {
                        result = _Ser.Them(new Giay()
                        {
                            Tengiay = txtTen.Text
                        });

                    }


                    if (result)
                    {
                        MessageBox.Show("Đã 'thêm' thành công 1 giày mới");

                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Thêm' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'thêm' sản phẩm này");
                }
                ClearTextBox();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu hợp lý!");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckTextbox())
            {
                var confirmResult = MessageBox.Show("Xác nhận 'sửa' giày này không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var result = _Ser.Sua(idClicked, new Giay()
                    {
                        Tengiay = txtTen.Text,
                    });

                    if (result)
                    {
                        MessageBox.Show("Đã 'sửa' giày này thành công");

                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Sửa' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'sửa' giày này");
                }
                ClearTextBox();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu hợp lý!");
            }

        }
        private void dgv_Objects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index < 0 || index >= _lstObj.Count)
            {
                ClearTextBox();
                return;
            }

            var objCellClick = _lstObj[index];

            idClicked = objCellClick.Magiay;

            txtTen.Text = objCellClick.Tengiay;
        }
        private bool CheckTextbox()
        {
            if (txtTen.Text == "" || LoginManager.Instance.IdTaiKhoan == 0)
            {
                return false;
            }
            return true;
        }

    }
}
