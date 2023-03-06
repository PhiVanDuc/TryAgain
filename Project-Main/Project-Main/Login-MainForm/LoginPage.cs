using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Sell_Clothes_Project
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FManageSellClothes f = new FManageSellClothes();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void formLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát ra khỏi ứng dụng ?","Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void switchChangeColor_CheckedChanged(object sender, EventArgs e)
        {
            if(switchChangeColor.Checked == true) 
            {
                this.BackColor = Color.FromArgb(255, 14, 17, 51);
                txtTaiKhoan.FillColor = Color.FromArgb(255, 14, 17, 51);
                txtMatKhau.FillColor = Color.FromArgb(255, 14, 17, 51);
            }
            else
            {
                this.BackColor = Color.White;
                txtTaiKhoan.FillColor = Color.White;
                txtMatKhau.FillColor = Color.White;
            }
        }
    }
}
