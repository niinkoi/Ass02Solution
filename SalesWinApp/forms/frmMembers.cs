using AutoMapper;
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
    public partial class frmMembers : MaterialForm
    {

        private IMapper _mapper;
        private MemberService _service = new MemberService();
        private MaterialTextBox2[] boxes;
        private bool isUpdated = true;
        BindingSource source;

        public frmMembers(IMapper mapper)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            _mapper = mapper;
            boxes = new MaterialTextBox2[]
            {
                txtID,
                txtEmail,
                txtPassword,
                txtCompanyName,
                txtCity,
                txtCountry
            };
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (isUpdated)
                {
                    _service.UpdateProfile(_mapper, Int32.Parse(txtID.Text), new()
                    {
                        Email = txtEmail.Text,
                        CompanyName = txtCompanyName.Text,
                        Password = txtPassword.Text,
                        City = txtCity.Text,
                        Country = txtCountry.Text
                    });
                }
                else
                {
                    _service.CreateMember(_mapper, new()
                    {
                        Email = txtEmail.Text,
                        CompanyName = txtCompanyName.Text,
                        Password = txtPassword.Text,
                        City = txtCity.Text,
                        Country = txtCountry.Text
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ClearText(boxes);
                DisableControls(false, btnDelete, btnSave, txtCity, txtEmail, txtCompanyName, txtPassword, txtCountry);
                LoadMemberList();
            }
        }

        private void LoadMemberList()
        {
            var members = _service.GetAll(_mapper);
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                ClearBindingsForTextBoxes(boxes);
                AddBindingsForTextBoxes(source, "Text", boxes);
                dgvMemberList.DataSource = source;

                if (members.Count() == 0)
                {
                    ClearText(boxes);
                    DisableControls(false, btnDelete, btnSave, txtCity, txtEmail, txtCompanyName, txtPassword, txtCountry);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _service.DeleteMember(_mapper, Int32.Parse(txtID.Text));
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearText(boxes);
            ClearBindingsForTextBoxes(boxes);
            isUpdated = false;
            DisableControls(true, btnDelete, btnSave, txtCity, txtEmail, txtCompanyName, txtPassword, txtCountry);
        }

        private void ClearText(params MaterialTextBox2[] boxes)
        {
            foreach (var box in boxes)
            {
                box.Text = string.Empty;
            }
        }

        private void ClearBindingsForTextBoxes(params MaterialTextBox2[] boxes)
        {
            foreach (var box in boxes)
            {
                box.DataBindings.Clear();
            }
        }

        private void AddBindingsForTextBoxes(BindingSource source, string sourceType, params MaterialTextBox2[] boxes)
        {
            foreach (var box in boxes)
            {
                box.DataBindings.Add(sourceType, source, GetControlNameWithoutPrefix(box, "txt"));
            }
        }

        private string GetControlNameWithoutPrefix(Control control, string toSplit)
        {
            return control.Name.Split(toSplit)[1];
        }

        private void DisableControls(bool state, params Control[] controls)
        {
            foreach (var control in controls)
            {
                control.Enabled = state;
            }
        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            isUpdated = true;
            DisableControls(true, btnDelete, btnSave, txtCity, txtEmail, txtCompanyName, txtPassword, txtCountry);
        }
    }
}
