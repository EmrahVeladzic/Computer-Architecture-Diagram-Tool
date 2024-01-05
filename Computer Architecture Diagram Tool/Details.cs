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
            this.dgvRegisters.AutoGenerateColumns = false;
            
        }

        public Details(Object input) : this()
        {
            ClassID = input.ClassId;

           
        }

        void Reload_DGV()
        {
            this.dgvRegisters.DataSource = null;
            this.dgvFlags.DataSource = null;

            this.dgvFlags.DataSource = Classes.list.Where(c => c.Id == ClassID).FirstOrDefault().Flags;
            this.dgvRegisters.DataSource = Classes.list.Where(c => c.Id == ClassID).FirstOrDefault().Registers;

        }


        private void Details_Load(object sender, EventArgs e)
        {
            Reload_DGV();
        }

   

        private void btnRegSave_Click(object sender, EventArgs e)
        {
            int.TryParse(txtRegAdd.Text,out int rv);

            
            int newID = Classes.list.Where(c => c.Id == ClassID).FirstOrDefault().Registers.Count();



            Register newReg = new Register {
                Id = newID,
                Address = rv,
                Description = txtRegDesc.Text


            };

            Classes.list.Where(c => c.Id == ClassID).FirstOrDefault().Registers.Add(newReg);

            txtRegAdd.Text = string.Empty;
            txtRegDesc.Text = string.Empty;

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

        private void dgvRegisters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0 || e.ColumnIndex<0)
            {
                return;
            }


            if (e.ColumnIndex==1)
            {
                var res = MessageBox.Show("Are you sure?","Delete?",MessageBoxButtons.YesNo);

                if (res==DialogResult.Yes)
                {

                    Register tmp = dgvRegisters.Rows[e.RowIndex].DataBoundItem as Register;


                    Classes.list.Where(c => c.Id == ClassID).FirstOrDefault().Registers.Remove(tmp);

                    Reload_DGV();
                }
            }



        }

        private void dgvFlags_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 1)
            {
                var res = MessageBox.Show("Are you sure?", "Delete?", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {

                    Flag tmp = dgvFlags.Rows[e.RowIndex].DataBoundItem as Flag;


                    Classes.list.Where(c => c.Id == ClassID).FirstOrDefault().Flags.Remove(tmp);

                    Reload_DGV();
                }
            }

        }
    }
}
