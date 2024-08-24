using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Frm_Main
{
    public partial class SoLuongMua_Frm : System.Windows.Forms.Form
    {
        public int soLuongMua;
        public SoLuongMua_Frm()
        {
            InitializeComponent();
        }

        private void SoLuongMua_Frm_Load(object sender, EventArgs e)
        {
            soLuongMua = new();
        }

        private void btnSoLuong_Click(object sender, EventArgs e)
        {
            try
            {
                soLuongMua = int.Parse(txtSoLuong.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show(" Chỉ chấp nhận số không chứa khoảng trắng!");
            }
        }

        private void txtSoLuong_Enter(object sender, EventArgs e)
        {
        }
    }
}
