using BusinessObject;
using MaterialSkin;
using MaterialSkin.Controls;
using SalesWinApp.services;
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
    public partial class frmLogin : MaterialForm
    {
        private MemberService _service = new MemberService();

        public frmLogin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var found = GetCurrentUser(txtEmail.Text, txtPassword.Text);
            if (found == null)
            {
                MessageBox.Show("haha");
            }
            else
            {
                frmMain.currentSession.MemberInfo = found;
                if (found.Email.Equals(_service.RetrieveDefaultAccount("Email")))
                {
                    frmMain.currentSession.Role = commons.RoleBased.Admin;
                }
                else
                {
                    frmMain.currentSession.Role = commons.RoleBased.User;
                }
            }
        }

        private MemberObject? GetCurrentUser(string email, string password) => _service.Authenticate(email, password);
    }
}
