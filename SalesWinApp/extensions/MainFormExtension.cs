using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesWinApp.extensions
{
    public enum CurrentDest
    {
        Profile,
        Product,
        Members,
        Orders
    }

    public static class MainFormExtension
    {
        public static void NavigateForm(this frmMain main, MaterialForm formToChange)
        {
            formToChange.TopLevel = false;
            formToChange.AutoScroll = true;
            main.mainPanel.Controls.Add(formToChange);
            formToChange.Show();
        }

        public static void NavigateFromOtherForm(this frmMain main, params MaterialForm[] forms)
        {
            forms[0].Close();
            main.NavigateForm(forms[1]);
        }
    }
}
