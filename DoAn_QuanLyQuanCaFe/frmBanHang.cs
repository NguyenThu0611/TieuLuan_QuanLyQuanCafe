﻿using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyQuanCaFe
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Office 2010 Blue";
        }

        #region Method

        #endregion

        #region Event
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        #endregion


    }
}