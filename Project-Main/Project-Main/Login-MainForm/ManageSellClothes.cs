using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sell_Clothes_Project
{
    public partial class FManageSellClothes : Form
    {
        public FManageSellClothes()
        {
            InitializeComponent();
        }

        private void btnSlideOut_Click(object sender, EventArgs e)
        {
            LogoBrand.Visible = true;
            btnSlideOut.Visible = false;
            btnSlideIn.Visible = true;
            Line1.Visible = true;
            Line2.Visible = false;
            SlideBar.Visible = false;
            SlideBar.Width = 215;
            TransitionSlideBar.ShowSync(SlideBar);
        }

        private void btnSlideIn_Click(object sender, EventArgs e)
        {
            LogoBrand.Visible = true;
            SlideBar.Visible = false;
            btnSlideIn.Visible = false;
            btnSlideOut.Visible = true;
            Line1.Visible = false;
            Line2.Visible = true;
            SlideBar.Width = 99;
            TransitionSlideBar.ShowSync(SlideBar);
        }

        // Dùng là đối tượng chung cho các form con
        private Form currentFormChild;
        private void OpenChildForm(Form ChildForm)
        {
            // Nếu currentFormChild đã khởi tạo thì đóng vào.
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = ChildForm;

            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(ChildForm);
            panel_Body.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formQuanLy());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formThuNgan());
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formKho());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
