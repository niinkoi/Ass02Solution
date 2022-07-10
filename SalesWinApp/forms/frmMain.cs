using BusinessObject;
using SalesWinApp.commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public static CurrentSession? currentSession { get; set; }

        public frmMain()
        {
            InitializeComponent();
        }
    }
}
