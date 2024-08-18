using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Architecture_Diagram_Tool
{
    public partial class Details : Form
    {
        private int ClassID;

        public Details()
        {
            InitializeComponent();

            this.dgvFlags.AutoGenerateColumns = false;
            this.dgvAdresses.AutoGenerateColumns = false;
            
        }

        public Details(Object input) : this()
        {
            ClassID = input.ClassId;

           
        }

        void Reload_DGV()
        {
            this.dgvAdresses.DataSource = null;
            this.dgvFlags.DataSource = null;

            BindingList<Address> addrList = new BindingList<Address>();
            foreach (Address addr in Classes.list.Where(c => c.Id == ClassID).FirstOrDefault().Addresses)
            {
                addrList.Add(addr);
            }

            BindingList<Flag> fList = new BindingList<Flag>();

            foreach (Flag fl in Classes.list.Where(c => c.Id == ClassID).FirstOrDefault().Flags)
            {
                fList.Add(fl);
            }


            this.dgvAdresses.DataSource = addrList;
            this.dgvFlags.DataSource= fList;

            

        }


        private void Details_Load(object sender, EventArgs e)
        {
            Reload_DGV();
        }

   

        private void btnAddrSave_Click(object sender, EventArgs e)
        {
            int.TryParse(txtAddrAdd.Text,out int rv);

            
            int newID = Classes.list.Where(c => c.Id == ClassID).FirstOrDefault().Addresses.Count();



            Address newReg = new Address {
                Id = newID,
                Value = rv,
                Description = txtAddrDesc.Text


            };

            Classes.list.Where(c => c.Id == ClassID).FirstOrDefault().Addresses.Add(newReg);

            txtAddrAdd.Text = string.Empty;
            txtAddrDesc.Text = string.Empty;

            Reload_DGV();


        }

      

        private void btnFlagSave_Click(object sender, EventArgs e)
        {

            int.TryParse(txtFlagVal.Text, out int fv);

            int newID = Classes.list.Where(c => c.Id == ClassID).FirstOrDefault().Flags.Count();



            Flag newFlag = new Flag
            {
                Id = newID,
                EnumValue = fv,
                Name = txtFlagName.Text


            };

            Classes.list.Where(c => c.Id == ClassID).FirstOrDefault().Flags.Add(newFlag);

            txtFlagVal.Text = string.Empty;
            txtFlagName.Text = string.Empty;

            Reload_DGV();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAddresses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


            if (e.RowIndex>=0 && e.ColumnIndex==1)
            {
                var res = MessageBox.Show("Are you sure?","Delete?",MessageBoxButtons.YesNo);

                if (res==DialogResult.Yes)
                {

                    Address tmp = dgvAdresses.Rows[e.RowIndex].DataBoundItem as Address;

                    int ti = tmp.Id;


                  


                   ObjectClass tempClass = Classes.list.Where(c => c.Id == ClassID).FirstOrDefault();



                    foreach (Address addr in tempClass.Addresses)
                    {

                        if (addr.Id == ti)
                        {
                            tempClass.Addresses.Remove(addr);

                            break;
                        }

                    }


                    foreach (Address addr in tempClass.Addresses)
                    {

                        if (addr.Id > ti)
                        {
                            addr.Id--;
                        }

                    }




                    Reload_DGV();
                }
            }



        }

        private void dgvFlags_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

            if (e.RowIndex >=0 && e.ColumnIndex == 1)
            {
                var res = MessageBox.Show("Are you sure?", "Delete?", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {

                    Flag tmp = dgvFlags.Rows[e.RowIndex].DataBoundItem as Flag;

                    int ti = tmp.Id;

                   

                    ObjectClass tempClass = Classes.list.Where(c => c.Id == ClassID).FirstOrDefault();


                    foreach (Flag fl in tempClass.Flags)
                    {

                        if (fl.Id == ti)
                        {
                            tempClass.Flags.Remove(fl);

                            break;
                        }

                    }

                    foreach  (Flag fl in tempClass.Flags)
                    {

                        if (fl.Id>ti)
                        {
                            fl.Id--;
                        }

                    }





                    Reload_DGV();
                }
            }

        }

       
    }
}
