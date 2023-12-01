using FishShop.Controller;
using FishShop.model;
using FishShop.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishShop.view
{
    public partial class FormLogin : Form
    {
        AdminController adminController;
        admin admin;
        public FormLogin()
        {
            InitializeComponent();
        }
        private void login_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.ResumeLayout(false);
            adminController = new AdminController();
            admin = new admin();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_userName.Text) || !string.IsNullOrWhiteSpace(tb_password.Text))
            {
                string user = tb_userName.Text;
                string password = tb_password.Text;

                admin = new admin(user, password, "");
                if (adminController.CheckLogin(admin))
                {
                    MessageBox.Show("Đăng Nhập thành công ^-^");
                    this.Hide();
                    FormFishShop form = new FormFishShop();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu !!!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ tài khoản và mật khẩu !");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tb_userName.Clear();
            tb_password.Clear();
        }

        private void tb_userName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true;
            }
        }

        private void tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(tb_userName.Text) || !string.IsNullOrWhiteSpace(tb_password.Text))
                {
                    string user = tb_userName.Text;
                    string password = tb_password.Text;

                    admin = new admin(user, password, "");
                    if (adminController.CheckLogin(admin))
                    {
                        MessageBox.Show("Đăng Nhập thành công ^-^");
                        this.Hide();
                        FormFishShop form = new FormFishShop();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu !!!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ tài khoản và mật khẩu !");
                }
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
