using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQCrud
{
    public partial class Form1 : Form
    {
        TSQLDataContext dataContext = new TSQLDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                gridRez.DataSource = dataContext.LinqRead();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int Ret = 0;
                dataContext = new TSQLDataContext();
                Ret = dataContext.LinqInsert(txtCompanyName.Text, txtContactName.Text, txtContactTitle.Text,
                    txtAddress.Text, txtCity.Text, txtRegion.Text, txtPostalCode.Text, txtCountry.Text, txtPhone.Text, txtFax.Text);
                MessageBox.Show(Ret.ToString());
                btnRead_Click(null, null);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboSupplierID.DataSource = dataContext.LinqRead();
            cboSupplierID.DisplayMember = "companyname";
            cboSupplierID.ValueMember = "supplierid";

            cboDelete.DataSource = dataContext.LinqRead();
            cboDelete.DisplayMember = "companyname";
            cboDelete.ValueMember = "supplierid";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int Ret = 0;
                int supplierid = Convert.ToInt32(cboSupplierID.SelectedValue);
                Ret = dataContext.LinqUpdate(supplierid, txtUpContactName.Text, txtUpContactTitle.Text,
                    txtUpAddress.Text, txtUpCity.Text, txtUpRegion.Text, txtUpPostalCode.Text, txtUpCountry.Text, txtUpPhone.Text, txtUpFax.Text);
                MessageBox.Show(Ret.ToString());
                btnRead_Click(null, null);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int Ret = 0;
                int supplierid = Convert.ToInt32(cboDelete.SelectedValue);
                Ret = dataContext.LinqDelete(supplierid);
                if(Ret > 0)
                {
                    throw new Exception("Ne mozete izbrisati red iz tabele");

                }
                
                btnRead_Click(null, null);
                MessageBox.Show(Ret.ToString());


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
