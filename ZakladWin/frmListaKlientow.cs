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
    public partial class frmListaKlientow : Form
    {
        public frmListaKlientow()
        {
            InitializeComponent();
            frmListaKlientow_Load();
        }

        private void frmListaKlientow_Load()
        {
            foreach (Zaklad.Klient klient in Program.ListaKlientow)
            {
                dataGridView1.Rows.Add(klient.Imie, klient.Nazwisko, klient.Telefon);
            }
        }
    }
}
