using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P4_4_1204053
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNIK_Leave(object sender, EventArgs e)
        {
            if (txtNIK.Text == "")
            {
                epWarning.SetError(txtNIK, "NIK harus diisi! tidak boleh kosong !");
                epWrong.SetError(txtNIK, "");
                epCorrect.SetError(txtNIK, "");
            }
            else
            {
                //a. Numeric Textbox

                if ((txtNIK.Text).All(Char.IsNumber)) 
                {
                    epWarning.SetError(txtNIK, "");
                    epWrong.SetError(txtNIK, "");
                    epCorrect.SetError(txtNIK, "Betul !");

                }
                else
                {
                    epWrong.SetError(txtNIK, "Inputan hanya boleh angka!");
                    epWarning.SetError(txtNIK, "");
                    epCorrect.SetError(txtNIK, "");
                }
            }
        }

        private void txtNama_Leave(object sender, EventArgs e)
        {

            if (txtNama.Text == "")
            {
                epWarning.SetError(txtNama, "Harap Masukkan Nama Anda");
                epWrong.SetError(txtNama, "");
                epCorrect.SetError(txtNama, "");
            }
            else if (txtNama.Text != txtNama.Text.ToUpper())
            {
                epWarning.SetError(txtNama, "");
                //Upper Case Textbox
                epWrong.SetError(txtNama, "Masukkan Nama dengan menggunakan huruf kapital!");
                epCorrect.SetError(txtNama, "");
            
            }
            else if (txtNama.Text.Length == 2)
            {
                epWarning.SetError(txtNama, "Harap masukkan nama lengkap dengan benar!");
                epWrong.SetError(txtNama, "");
                epCorrect.SetError(txtNama, "");
            }

            else
            {
                //Char Textbox
                if ((txtNama.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtNama, "");
                    epWrong.SetError(txtNama, "");
                    epCorrect.SetError(txtNama, " betul !");

                }
                else
                {
                    epWarning.SetError(txtNama, "");
                    epWrong.SetError(txtNama, "Harap masukkan nama lengkap dengan huruf!");
                    epCorrect.SetError(txtNama, "");
                }
            }

        }

        private void cbJk_Leave(object sender, EventArgs e)
        {
            if (cbJk.Text == "")
            {
                epWarning.SetError(cbJk, "tidak boleh kosong !");
                epWrong.SetError(cbJk, "");
                epCorrect.SetError(cbJk, "");
            }
            else
            {
                if ((cbJk.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(cbJk, "");
                    epWrong.SetError(cbJk, "");
                    epCorrect.SetError(cbJk, "Betul !");
                }
                else
                {
                    
                }
            }
        }

        private void txtUsia_Leave(object sender, EventArgs e)
        {
            if (txtUsia.Text == "")
            {
                epWarning.SetError(txtUsia, "Harus Diisi!");
                epWrong.SetError(txtUsia, "");
                epCorrect.SetError(txtUsia, "");
            }

            else if ((int.Parse(txtUsia.Text) <= 10))
            {
                //Comparison

                epWarning.SetError(txtUsia, "");
                epWrong.SetError(txtUsia, "Usia harus lebih dari 10 tahun!!");
                epCorrect.SetError(txtUsia, "");

            }
            if (txtUsia.Text.Length > 2)
            {
                epWarning.SetError(txtUsia, "Kolom umur hanya boleh 2 digit angka!");
                epWrong.SetError(txtUsia, "");
                epCorrect.SetError(txtUsia, "");
            }
            else if ((txtUsia.Text).All(Char.IsNumber)) //Numeric TextBox
            {
                epWarning.SetError(txtUsia, "");
                epWrong.SetError(txtUsia, "");
                epCorrect.SetError(txtUsia, "Betul!");
            }

            
        }

        private void txtNo_Leave(object sender, EventArgs e)
        {
            if (txtNo.Text == "")
            {
                epWarning.SetError(txtNo, "Harap masukkan nomor hp!");
                epWrong.SetError(txtNo, "");
                epCorrect.SetError(txtNo, "");
            }
            else if (txtNo.Text.Length > 13 )
            {
                epWarning.SetError(txtNo, " No hp terlalu panjang");
                epWrong.SetError(txtNo, "");
                epCorrect.SetError(txtNo, "");
            }
            else
            {
                if (Regex.IsMatch(txtNo.Text, @"^(\+62|62|0)8[1-9][0-9]{6,9}$"))
                {
                    epWarning.SetError(txtNo, "");
                    epWrong.SetError(txtNo, "");
                    epCorrect.SetError(txtNo, " BETUL ");
                }
                else
                {
                    epWarning.SetError(txtNo, " ");
                    epWrong.SetError(txtNo, "masukkan no telepon sesuai dengan format! Contoh : 6289*******");
                    epCorrect.SetError(txtNo, "");
                  
                }
            }
        }

        private void txtAlamat_Leave(object sender, EventArgs e)
        {
            if (txtAlamat.Text == "")
            {
                epWarning.SetError(txtAlamat, "Alamat tidak boleh kosong!");
                epWrong.SetError(txtAlamat, "");
                epCorrect.SetError(txtAlamat, "");
            }
            else
            {
                //Lower Case
                if ((txtAlamat.Text != txtAlamat.Text.ToLower())) 
                {
                    epWarning.SetError(txtAlamat, "");
                    epWrong.SetError(txtAlamat, "tulis dengan huruf kecil saja!");
                    epCorrect.SetError(txtAlamat, "");
                }
                else if ((txtAlamat.Text).Any(Char.IsLetter))
                {
                    epWarning.SetError(txtAlamat, "");
                    epWrong.SetError(txtAlamat, "");
                    epCorrect.SetError(txtAlamat, "Betul!");
                }
               
            }
        }

        private void btDaftar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
           "NIK   : " + txtNIK.Text +
           "\nNama : " + txtNama.Text +
           "\nJenis Kelamin : " + cbJk.Text +
           "\nUsia : " + txtUsia.Text +
           "\nNo Telepon  : " + txtNo.Text +
           "\nAlamat : " + txtAlamat.Text,
           " INFORMASI PENDAFTARAN VAKSINASI USIA 10 TAHUN KEATAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

