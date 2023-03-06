using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Main
{
    public partial class formBtnNhapVaSuaHangHoa : Form
    {
        public formBtnNhapVaSuaHangHoa()
        {
            InitializeComponent();
        }

        private void btnSelecet_Click(object sender, EventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "Tệp tin ảnh | *.bmp*; *.jpg*; *.png*; *.gif*; *.svg | File tùy ý (*.*) | *.*";

            if(image.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image saveImage = Image.FromFile(image.FileName);
                    ProductImage.Image = saveImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Không thể nạp file ảnh [{0}]", image.FileName));
                }
            }
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {

        }
    }
}
