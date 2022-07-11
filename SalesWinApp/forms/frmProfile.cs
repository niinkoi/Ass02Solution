using AutoMapper;
using MaterialSkin;
using MaterialSkin.Controls;
using SalesWinApp.raws;
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

namespace SalesWinApp.forms
{
    public partial class frmProfile : MaterialForm
    {
        private MemberService _service = new MemberService();
        private static MaterialTextBox2[] boxes;
        private IMapper _mapper;

        public frmProfile(IMapper mapper)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            _mapper = mapper;
            boxes = new MaterialTextBox2[]
            {
                txtEmail,
                txtPassword,
                txtCompany,
                txtCity,
                txtCountry
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var theId = frmMain.currentSession.MemberInfo.ID;
                var toUpdate = new MemberRaw()
                {
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    CompanyName = txtCompany.Text,
                    Country = txtCountry.Text,
                    City = txtCity.Text
                };

                _service.UpdateProfile(_mapper, theId, toUpdate);
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message);
            }
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            try
            {
                var sessionId = frmMain.currentSession.MemberInfo.ID;
                var raw = _service.LoadProfile(_mapper, sessionId);
                if (sessionId == -1)
                {
                    DisableTextBoxes(boxes);
                    txtEmail.Text = raw.Email;
                    txtPassword.Text = raw.Password;
                    txtCity.Text = raw.City;
                    txtCountry.Text = raw.Country;
                    txtCompany.Text = raw.CompanyName;
                    DisableButtons(btnSave, btnCancel);
                }
                else
                {
                    txtEmail.Text = raw.Email;
                    txtPassword.Text = raw.Password;
                    txtCity.Text = raw.City;
                    txtCountry.Text = raw.Country;
                    txtCompany.Text = raw.CompanyName;
                }
            }
            catch(Exception ex)
            {
                MaterialMessageBox.Show(ex.Message);
            }
        }

        private void DisableTextBoxes(params MaterialTextBox2[] boxes)
        {
            foreach (var box in boxes)
            {
                box.Enabled = false;
            }
        }

        private void DisableButtons(params MaterialButton[] buttons)
        {
            foreach (var btn in buttons)
            {
                btn.Enabled = false;
            }
        }
    }
}
