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
            foreach (Zaklad.Klient klient in DataBase.GetClients())
            {
                dataGridView1.Rows.Add(klient.Imie, klient.Nazwisko, klient.Telefon);
            }
        }

        private void btdDelete_Click(object sender, EventArgs e)
        {
            var wybranyKlient=DataBase.GetClients().ElementAt(dataGridView1.CurrentRow.Index);

           if (MessageBox.Show("Czy na pewno chcesz usunąć klienta?", "Usuwanie klienta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataBase.DeleteClient(wybranyKlient);
                dataGridView1.Rows.Clear();
                frmListaKlientow_Load();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wybranyKlient = DataBase.GetClients().ElementAt(dataGridView1.CurrentRow.Index);

            if (MessageBox.Show("Czy na pewno chcesz usunąć klienta?", "Usuwanie klienta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataBase.deleteForeverClient(wybranyKlient);
                dataGridView1.Rows.Clear();
                frmListaKlientow_Load();
            }
        }
    }
}
