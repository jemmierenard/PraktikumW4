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
    
    public partial class FormAddData : Form
    {
        public static string[,] DataIsi = new string[10, 3];
        public static int dataKe = 0;
        public FormAddData()
        {
            InitializeComponent();
        }
       
        private void tboxAddNama_TextChanged(object sender, EventArgs e)
        {
            
        }
        public DataTable dataInput = new DataTable();
        
        private void FormAddData_Load(object sender, EventArgs e)
        {
           
            
        }

        private void btnLihatData_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormShowData formShow = new FormShowData();
            formShow.Show();  
        }
       
        private void btnSimpan_Click(object sender, EventArgs e)
        { 
            if(dataKe > 9)
            {
                MessageBox.Show("Data sudah penuh!");
            }
            else
            {
                
                if (Int32.TryParse(tboxAddTelp.Text, out int value))
                {
                    DataIsi[dataKe, 0] = tboxAddNama.Text;
                    DataIsi[dataKe, 1] = tboxAddAlamat.Text;
                    DataIsi[dataKe, 2] = tboxAddTelp.Text;
                    dataKe++;
                }
                else
                {
                    MessageBox.Show("Masukkan angka pada nomor telepon!");
                }
                
            }
            
        }
    }
}
