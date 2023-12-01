using FishShop.Controller;
using FishShop.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishShop.View
{
    public partial class FormResetPass : Form
    {
        AdminController adminController;
        admin admin;
        public FormResetPass()
        {
            InitializeComponent();
        }
        private void FormResetPass_Load(object sender, EventArgs e)
        {
            adminController = new AdminController();
            admin = new admin();
        }

        private void btnLuuMK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTK.Text)
                && !string.IsNullOrEmpty(txtPassOld.Text)
                && !string.IsNullOrEmpty(txtPassNew.Text)
                && !string.IsNullOrEmpty(txtPassCheck.Text))
            {
                if (txtPassNew.Text == txtPassCheck.Text)
                {
                    admin = new admin(txtTK.Text, txtPassOld.Text, null);
                    if (adminController.CheckLogin(admin))
                    {
                        if (adminController.ChangePassword(admin, txtPassNew.Text))
                        {
                            MessageBox.Show("Đổi mật khẩu thành công !");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi đổi mật khẩu !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !");
                    }
                }
                else
                {
                    txtPassNew.Clear();
                    txtPassCheck.Clear();
                    MessageBox.Show("Mật khẩu nhập lại không đúng !");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
