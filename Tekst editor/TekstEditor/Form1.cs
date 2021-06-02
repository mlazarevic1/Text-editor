using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekstEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFile.Title = "Open file";
            openFile.Filter = "Text file|*.txt|Csv fajl|*.csv";
            openFile.Multiselect = false;

            if(openFile.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            txtSadrzaj.Text = OpenFile(openFile.FileName);

        }

        string OpenFile(string fileName)
        {

            string t;

            try
            {
                StreamReader sr = new StreamReader(fileName);
                t = sr.ReadToEnd();
                sr.Close();
                return t;
                //while ((t = sr.ReadLine()) != null)
                //{

                //    txtSadrzaj.Text = txtSadrzaj.Text + t + Environment.NewLine;


                //}

                //sr.Close();
                //return t;
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return "Fajl ne moze da se otvori";


            }





        
        }


        public void Replace(TextBox txt, string find, string replace)
        {
            try
            {
                txt.Text = txt.Text.Replace(find, replace);
                if (txtSadrzaj.Text == "")
                {
                    throw new Exception("Prvo morate otvoriti fajl");
                }
                else if (txtFind.Text == "")
                {

                    throw new Exception("Unesite rec koju zelite da pretrazite");
                }

                else if (txtReplace.Text == "")
                {
                    throw new Exception("Niste uneli zamensku rec");
                }

                

            } 
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
                




        }

        private void btnReplace_Click(object sender, EventArgs e)
        {

            Replace(txtSadrzaj, txtFind.Text, txtReplace.Text);

        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileName = "";

            saveFile.Title = "Save file";
            saveFile.DefaultExt = "txt";
            saveFile.Filter = "Text file|*.txt|Csv file|*.csv";
            if (txtSadrzaj.Text.Trim() == "")
            {

                MessageBox.Show("Unesite neki tekst za snimanje", "Upozorenje", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtSadrzaj.Focus();
                return;
                


            }
            if (saveFile.ShowDialog() == DialogResult.Cancel)
            {
                //korisnik odustao od save dijaloga

                return;

            }
            fileName = saveFile.FileName;
            Save(fileName, txtSadrzaj.Text);
            
            

            if(Save(fileName, txtSadrzaj.Text) == true)
            {
                MessageBox.Show("Uspesno ste sacuvali fajl", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Niste sacuvali fajl", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public bool Save(string fileName, string Sadrzaj)
        {


            try
            {

                StreamWriter sw = new StreamWriter(fileName);

                sw.Write(Sadrzaj);
                sw.Flush();
                sw.Close();
                return true;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }






        }








    }
}
