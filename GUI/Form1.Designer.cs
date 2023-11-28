﻿namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.LabelUser = new System.Windows.Forms.Label();
            this.labelcon = new System.Windows.Forms.Label();
            this.iconmenusmall = new FontAwesome.Sharp.IconPictureBox();
            this.paneltrangcon = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btn_nhanvien = new FontAwesome.Sharp.IconButton();
            this.btnsetting = new FontAwesome.Sharp.IconButton();
            this.btn_thongke = new FontAwesome.Sharp.IconButton();
            this.btnlogout = new FontAwesome.Sharp.IconButton();
            this.btn_khachhang = new FontAwesome.Sharp.IconButton();
            this.btn_sanpham = new FontAwesome.Sharp.IconButton();
            this.btn_trangchu = new FontAwesome.Sharp.IconButton();
            this.btn_nhasanxuat = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelTitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconmenusmall)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelTitlebar.Controls.Add(this.lbDateTime);
            this.panelTitlebar.Controls.Add(this.LabelUser);
            this.panelTitlebar.Controls.Add(this.labelcon);
            this.panelTitlebar.Controls.Add(this.iconmenusmall);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(227, 0);
            this.panelTitlebar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(881, 86);
            this.panelTitlebar.TabIndex = 5;
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbDateTime.Location = new System.Drawing.Point(488, 38);
            this.lbDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(90, 25);
            this.lbDateTime.TabIndex = 6;
            this.lbDateTime.Text = "12:30:33";
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelUser.Location = new System.Drawing.Point(245, 38);
            this.LabelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(123, 20);
            this.LabelUser.TabIndex = 5;
            this.LabelUser.Text = "Tên người dùng";
            // 
            // labelcon
            // 
            this.labelcon.AutoSize = true;
            this.labelcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelcon.Location = new System.Drawing.Point(85, 38);
            this.labelcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcon.Name = "labelcon";
            this.labelcon.Size = new System.Drawing.Size(54, 20);
            this.labelcon.TabIndex = 1;
            this.labelcon.Text = "Home";
            // 
            // iconmenusmall
            // 
            this.iconmenusmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.iconmenusmall.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconmenusmall.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconmenusmall.IconColor = System.Drawing.Color.Gainsboro;
            this.iconmenusmall.IconSize = 39;
            this.iconmenusmall.Location = new System.Drawing.Point(25, 28);
            this.iconmenusmall.Margin = new System.Windows.Forms.Padding(4);
            this.iconmenusmall.Name = "iconmenusmall";
            this.iconmenusmall.Size = new System.Drawing.Size(43, 39);
            this.iconmenusmall.TabIndex = 0;
            this.iconmenusmall.TabStop = false;
            // 
            // paneltrangcon
            // 
            this.paneltrangcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.paneltrangcon.Location = new System.Drawing.Point(227, 83);
            this.paneltrangcon.Margin = new System.Windows.Forms.Padding(4);
            this.paneltrangcon.Name = "paneltrangcon";
            this.paneltrangcon.Size = new System.Drawing.Size(881, 656);
            this.paneltrangcon.TabIndex = 6;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.PanelMenu.Controls.Add(this.btn_nhanvien);
            this.PanelMenu.Controls.Add(this.btnsetting);
            this.PanelMenu.Controls.Add(this.btn_thongke);
            this.PanelMenu.Controls.Add(this.btnlogout);
            this.PanelMenu.Controls.Add(this.btn_khachhang);
            this.PanelMenu.Controls.Add(this.btn_sanpham);
            this.PanelMenu.Controls.Add(this.btn_trangchu);
            this.PanelMenu.Controls.Add(this.btn_nhasanxuat);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(227, 735);
            this.PanelMenu.TabIndex = 4;
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.FlatAppearance.BorderSize = 0;
            this.btn_nhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhanvien.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhanvien.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_nhanvien.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btn_nhanvien.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_nhanvien.IconSize = 35;
            this.btn_nhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhanvien.Location = new System.Drawing.Point(0, 389);
            this.btn_nhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btn_nhanvien.Rotation = 0D;
            this.btn_nhanvien.Size = new System.Drawing.Size(227, 62);
            this.btn_nhanvien.TabIndex = 9;
            this.btn_nhanvien.Text = "Nhân viên";
            this.btn_nhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nhanvien.UseVisualStyleBackColor = true;
            // 
            // btnsetting
            // 
            this.btnsetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnsetting.FlatAppearance.BorderSize = 0;
            this.btnsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsetting.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnsetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnsetting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnsetting.IconColor = System.Drawing.Color.Gainsboro;
            this.btnsetting.IconSize = 35;
            this.btnsetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsetting.Location = new System.Drawing.Point(0, 611);
            this.btnsetting.Margin = new System.Windows.Forms.Padding(4);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnsetting.Rotation = 0D;
            this.btnsetting.Size = new System.Drawing.Size(227, 62);
            this.btnsetting.TabIndex = 8;
            this.btnsetting.Text = "Thiết lập";
            this.btnsetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsetting.UseVisualStyleBackColor = true;
            // 
            // btn_thongke
            // 
            this.btn_thongke.FlatAppearance.BorderSize = 0;
            this.btn_thongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongke.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongke.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_thongke.IconChar = FontAwesome.Sharp.IconChar.TachometerAlt;
            this.btn_thongke.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_thongke.IconSize = 35;
            this.btn_thongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongke.Location = new System.Drawing.Point(0, 459);
            this.btn_thongke.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btn_thongke.Rotation = 0D;
            this.btn_thongke.Size = new System.Drawing.Size(227, 62);
            this.btn_thongke.TabIndex = 4;
            this.btn_thongke.Text = "Thống kê";
            this.btn_thongke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thongke.UseVisualStyleBackColor = true;
            // 
            // btnlogout
            // 
            this.btnlogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnlogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnlogout.IconColor = System.Drawing.Color.Gainsboro;
            this.btnlogout.IconSize = 35;
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(0, 673);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnlogout.Rotation = 0D;
            this.btnlogout.Size = new System.Drawing.Size(227, 62);
            this.btnlogout.TabIndex = 7;
            this.btnlogout.Text = "Đăng xuất";
            this.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btn_khachhang
            // 
            this.btn_khachhang.FlatAppearance.BorderSize = 0;
            this.btn_khachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_khachhang.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_khachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khachhang.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_khachhang.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.btn_khachhang.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_khachhang.IconSize = 35;
            this.btn_khachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_khachhang.Location = new System.Drawing.Point(0, 255);
            this.btn_khachhang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_khachhang.Name = "btn_khachhang";
            this.btn_khachhang.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btn_khachhang.Rotation = 0D;
            this.btn_khachhang.Size = new System.Drawing.Size(227, 62);
            this.btn_khachhang.TabIndex = 6;
            this.btn_khachhang.Text = "Khách hàng";
            this.btn_khachhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_khachhang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_khachhang.UseVisualStyleBackColor = true;
            // 
            // btn_sanpham
            // 
            this.btn_sanpham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sanpham.FlatAppearance.BorderSize = 0;
            this.btn_sanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sanpham.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_sanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sanpham.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_sanpham.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.btn_sanpham.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_sanpham.IconSize = 35;
            this.btn_sanpham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sanpham.Location = new System.Drawing.Point(0, 185);
            this.btn_sanpham.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sanpham.Name = "btn_sanpham";
            this.btn_sanpham.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btn_sanpham.Rotation = 0D;
            this.btn_sanpham.Size = new System.Drawing.Size(227, 62);
            this.btn_sanpham.TabIndex = 2;
            this.btn_sanpham.Text = "Sản phẩm";
            this.btn_sanpham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sanpham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sanpham.UseVisualStyleBackColor = true;
            // 
            // btn_trangchu
            // 
            this.btn_trangchu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_trangchu.FlatAppearance.BorderSize = 0;
            this.btn_trangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trangchu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_trangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trangchu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_trangchu.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_trangchu.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_trangchu.IconSize = 35;
            this.btn_trangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trangchu.Location = new System.Drawing.Point(0, 123);
            this.btn_trangchu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_trangchu.Name = "btn_trangchu";
            this.btn_trangchu.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btn_trangchu.Rotation = 0D;
            this.btn_trangchu.Size = new System.Drawing.Size(227, 62);
            this.btn_trangchu.TabIndex = 1;
            this.btn_trangchu.Text = "Trang chủ";
            this.btn_trangchu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trangchu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_trangchu.UseVisualStyleBackColor = true;
            // 
            // btn_nhasanxuat
            // 
            this.btn_nhasanxuat.FlatAppearance.BorderSize = 0;
            this.btn_nhasanxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhasanxuat.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_nhasanxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhasanxuat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_nhasanxuat.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btn_nhasanxuat.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_nhasanxuat.IconSize = 35;
            this.btn_nhasanxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhasanxuat.Location = new System.Drawing.Point(0, 321);
            this.btn_nhasanxuat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nhasanxuat.Name = "btn_nhasanxuat";
            this.btn_nhasanxuat.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btn_nhasanxuat.Rotation = 0D;
            this.btn_nhasanxuat.Size = new System.Drawing.Size(227, 62);
            this.btn_nhasanxuat.TabIndex = 5;
            this.btn_nhasanxuat.Text = "Nhà xản xuất";
            this.btn_nhasanxuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhasanxuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nhasanxuat.UseVisualStyleBackColor = true;
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.picLogo);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(227, 123);
            this.PanelLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::GUI.Properties.Resources._11zon_cropped;
            this.picLogo.Location = new System.Drawing.Point(51, 11);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(124, 112);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 735);
            this.Controls.Add(this.panelTitlebar);
            this.Controls.Add(this.paneltrangcon);
            this.Controls.Add(this.PanelMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelTitlebar.ResumeLayout(false);
            this.panelTitlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconmenusmall)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Label labelcon;
        private FontAwesome.Sharp.IconPictureBox iconmenusmall;
        private System.Windows.Forms.Panel paneltrangcon;
        private System.Windows.Forms.Panel PanelMenu;
        private FontAwesome.Sharp.IconButton btnsetting;
        private FontAwesome.Sharp.IconButton btn_thongke;
        private FontAwesome.Sharp.IconButton btnlogout;
        private FontAwesome.Sharp.IconButton btn_khachhang;
        private FontAwesome.Sharp.IconButton btn_sanpham;
        private FontAwesome.Sharp.IconButton btn_trangchu;
        private FontAwesome.Sharp.IconButton btn_nhasanxuat;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private FontAwesome.Sharp.IconButton btn_nhanvien;


    }
}