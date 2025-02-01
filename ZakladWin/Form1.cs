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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            frmClient frm = new frmClient();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK) {
                //Program.ListaKlientow.Add(frm.klient);
                DataBase.AddClient(frm.klient);
            }
               
        }

        private void ctnClientsList_Click(object sender, EventArgs e)
        {
            frmListaKlientow frm = new frmListaKlientow();
            frm.ShowDialog();
        }
    }
}
