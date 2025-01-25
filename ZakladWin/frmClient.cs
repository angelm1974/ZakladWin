using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZakladWin
{
    public partial class frmClient : Form
    {
        public Zaklad.Klient klient = new Zaklad.Klient();
        public frmClient()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            klient.Imie = txtImie.Text;
            klient.Nazwisko = txtNazwisko.Text;
            klient.Telefon = txtTelefon.Text;
        }
    }
}
