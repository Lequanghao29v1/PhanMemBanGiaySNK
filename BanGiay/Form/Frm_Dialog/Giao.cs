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
    public partial class Giao : System.Windows.Forms.Form
    {
        CaService _service = new CaService();
        int _idWhenClick;
        public Giao()
        {
            InitializeComponent();
            datebatdau.Format = DateTimePickerFormat.Time;
            datebatdau.CustomFormat = "HH:mm";
            dateketthuc.Format = DateTimePickerFormat.Time;
            dateketthuc.CustomFormat = "HH:mm";
            loagit(null);
        }
        public void loagit(string serach)
        {
            int stt = 1;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Mã";
            dataGridView1.Columns[2].Name = "Tên";
            dataGridView1.Columns[3].Name = "Thời gian bắt đầu";
            dataGridView1.Columns[4].Name = "Thời gian kết thúc";
            dataGridView1.Columns[5].Name = "Tổng thời gian";

            dataGridView1.Rows.Clear();
            foreach (var x in _service.Giaocas(serach))
            {
                TimeSpan totalWorkingTime;
                TimeSpan batDau = x.Thoigianbatdau.Value;
                TimeSpan ketThuc = x.Thoigianketthuc.Value;
                if (x.Thoigianketthuc < x.Thoigianbatdau)
                {
                    totalWorkingTime = TimeSpan.FromHours(24) - batDau + ketThuc;
                }
                else
                {
                    totalWorkingTime = ketThuc - batDau;
                }
                dataGridView1.Rows.Add(stt++, x.Magiaoca, x.Tenca, x.Thoigianbatdau, x.Thoigianketthuc, totalWorkingTime);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            _idWhenClick = int.Parse(dataGridView1.Rows[rowindex].Cells[1].Value.ToString());
            var obj = _service.Giaocas(null).FirstOrDefault(x => x.Magiaoca == _idWhenClick);
            txtTenca.Text = obj.Tenca;
            datebatdau.Text = obj.Thoigianbatdau.ToString();
            dateketthuc.Text = obj.Thoigianketthuc.ToString();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            loagit(txtTimkiem.Text);
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            datebatdau.Format = DateTimePickerFormat.Time;
            datebatdau.CustomFormat = "HH:mm";
            dateketthuc.Format = DateTimePickerFormat.Time;
            dateketthuc.CustomFormat = "HH:mm";
            Giaoca ca = new Giaoca();
            ca.Tenca = txtTenca.Text;
            TimeSpan thoiGianBatDau = datebatdau.Value.TimeOfDay;
            TimeSpan thoiGianKetThuc = dateketthuc.Value.TimeOfDay;
            ca.Thoigianbatdau = thoiGianBatDau;
            ca.Thoigianketthuc = thoiGianKetThuc;
            MessageBox.Show(_service.AddCa(ca));

            loagit(null);
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtTenca.Text = "";
            datebatdau.Value = DateTime.Today;
            dateketthuc.Value = DateTime.Today;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            datebatdau.Format = DateTimePickerFormat.Time;
            datebatdau.CustomFormat = "HH:mm";
            dateketthuc.Format = DateTimePickerFormat.Time;
            dateketthuc.CustomFormat = "HH:mm";
            Giaoca ca = new Giaoca();
            ca.Magiaoca = _idWhenClick;
            ca.Tenca = txtTenca.Text;
            TimeSpan thoiGianBatDau = datebatdau.Value.TimeOfDay;
            TimeSpan thoiGianKetThuc = dateketthuc.Value.TimeOfDay;
            ca.Thoigianbatdau = thoiGianBatDau;
            ca.Thoigianketthuc = thoiGianKetThuc;
            MessageBox.Show(_service.UpdateCa(ca));

            loagit(null);
        }
    }
}
