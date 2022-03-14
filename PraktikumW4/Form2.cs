using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumW4
{
    public partial class FormShowData : Form
    {
        public int dataKe = 0;
        public void munculData()
        {
            tboxShowNama.Text = FormAddData.DataIsi[dataKe, 0];
            tboxShowAlamat.Text = FormAddData.DataIsi[dataKe, 1];
            tboxShowTelp.Text = FormAddData.DataIsi[dataKe, 2];
        }
        public FormShowData()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            munculData();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddData formAdd = new FormAddData();
            formAdd.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            if(dataKe == 9)
            {
                MessageBox.Show("Data sudah yang terakhir!");
                dataKe--;
            }
            else
            {
                dataKe++;
                munculData();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            dataKe--;
            if (dataKe < 0)
            {
                MessageBox.Show("Sudah data yang pertama!");
                dataKe++;
            }
            else
            {
                munculData();
            }
        }
    }
}
