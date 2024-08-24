using System;
using BUS.Services;
using DAL.Models.DomainClass;
using PRL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class HinhThucThanhToan : System.Windows.Forms.Form
    {
        HinhThucTTService _service = new HinhThucTTService();
        int _idWhenClick;
        public HinhThucThanhToan()
        {
            InitializeComponent();
            LoadGrid(null);
        }
        public void LoadGrid(string search)
        {
            int stt = 1;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Mã";
            dataGridView1.Columns[2].Name = "Tên";
            dataGridView1.Columns[3].Name = "Mô tả";

            dataGridView1.Rows.Clear();
            foreach (var i in _service.GetHinhthucTT(search))
            {
                dataGridView1.Rows.Add(stt++, i.Mahinhthucthanhtoan, i.Tenhinhthuc, i.Mota);
            }
        }
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            LoadGrid(txtTimkiem.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            _idWhenClick = int.Parse(dataGridView1.Rows[rowindex].Cells[1].Value.ToString());
            var obj = _service.GetHinhthucTT(null).FirstOrDefault(x => x.Mahinhthucthanhtoan == _idWhenClick);
            txtTen.Text = obj.Tenhinhthuc;
            txtMota.Text = obj.Mota;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Hinhthucthanhtoan ht = new Hinhthucthanhtoan();
            ht.Tenhinhthuc = txtTen.Text;
            ht.Mota = txtMota.Text;
            MessageBox.Show(_service.AddHTTT(ht));
            LoadGrid(null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Hinhthucthanhtoan ht = new Hinhthucthanhtoan();
            ht.Mahinhthucthanhtoan = _idWhenClick;
            ht.Tenhinhthuc = txtTen.Text;
            ht.Mota = txtMota.Text;
            MessageBox.Show(_service.UpdateHTTT(ht));
            LoadGrid(null);
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            txtMota.Text = "";
        }
    }
}
