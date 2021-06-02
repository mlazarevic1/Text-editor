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
    public partial class Form2 : Form
    {
       
        TSQLDataContext dataContext = new TSQLDataContext();
        
        public Form2()
        {
            InitializeComponent();
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCity.Text.Trim() != "")
                {
                    var city = from s in dataContext.Suppliers
                               where s.city == txtCity.Text
                               orderby s.supplierid ascending
                               select new
                               {
                                   s.supplierid,
                                   s.companyname,
                                   s.contactname,
                                   s.contacttitle,
                                   s.address,
                                   s.city,
                                   s.region,
                                   s.postalcode,
                                   s.country,
                                   s.phone,
                                   s.fax
                               };
                    gridCity.DataSource = city;
                }
                else
                {
                    var city = from s in dataContext.Suppliers
                               where s.city == null
                               orderby s.supplierid ascending
                               select new
                               {
                                   s.supplierid,
                                   s.companyname,
                                   s.contactname,
                                   s.contacttitle,
                                   s.address,
                                   s.city,
                                   s.region,
                                   s.postalcode,
                                   s.country,
                                   s.phone,
                                   s.fax
                               };
                    gridCity.DataSource = city;
                }
                


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var suppliers = from s in dataContext.Suppliers
                            select s;
            gridCity.DataSource = suppliers;
        }
    }
}
