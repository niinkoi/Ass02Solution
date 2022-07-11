using AutoMapper;
using BusinessObject;
using MaterialSkin;
using MaterialSkin.Controls;
using SalesWinApp.commons;
using SalesWinApp.extensions;
using SalesWinApp.forms;
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
    public partial class frmMain : MaterialForm
    {
        public static CurrentSession currentSession { get; set; } = new CurrentSession();

        public IMapper _mapper;
        public frmProfile profile;

        public frmMain(IMapper mapper)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            _mapper = mapper;
            profile = new frmProfile(_mapper);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            new frmLogin().ShowDialog();
            lblName.Text = $"Welcome, { GetEmailPrefix(currentSession.MemberInfo.Email) }";
            if (currentSession.Role == RoleBased.User)
            {
                materialButton3.Enabled = false;
            }
        }

        private string GetEmailPrefix(string email)
        {
            return email.Split("@")[0].ToUpper();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            this.NavigateForm(profile);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.NavigateForm(profile);
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            this.NavigateFromOtherForm(profile, new frmMembers(_mapper));
        }
    }
}
