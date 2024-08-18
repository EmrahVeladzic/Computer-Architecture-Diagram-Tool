using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Architecture_Diagram_Tool
{
    public partial class ClassDeclaration : Form
    {
        List<Color> Primary=new List<Color>();
        List<Color> Secondary= new List<Color>();

        Timer t;
        Pen pen;

        string PrimTemp;
        string SecTemp;

        int selection;

        public ClassDeclaration()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            dgvClasses.AutoGenerateColumns = false;

        }

        bool clear;

        private void ClassDeclaration_Load(object sender, EventArgs e)
        {
            clear = false;

            pen = new Pen(Color.Black);


            
            foreach(KnownColor kc in Enum.GetValues(typeof(KnownColor))){

                Color c = Color.FromKnownColor(kc);


                if (!c.IsSystemColor)
                {

                    Primary.Add(c);

                    Secondary.Add(c);

                }

                
            }
            

            cmbPrim.DataSource= Primary;
            cmbSec.DataSource = Secondary;
           
            
            t = new Timer();

            t.Interval = 10;

            t.Tick += new EventHandler(render);

            t.Enabled = true;

            dgvClasses.DataSource = null;
            if (Classes.list.Count>0)
            {
                dgvClasses.DataSource = Classes.list;
            }
            

            btnSave.Enabled = false;
        }

        void render(object sender ,EventArgs e)
        {
            using (Graphics g = DrawBox.CreateGraphics())
            {

                if (clear)
                {
                    g.Clear(Color.RosyBrown);
                    clear = false;
                }


                Point Origin = new Point(DrawBox.Left+(DrawBox.Width/2),DrawBox.Top+(DrawBox.Height/2));

                float w = (float)nWidth.Value;
                float h = (float)nHeight.Value;


                int wo = Origin.X;
                int ho =Origin.Y;


                Rectangle rect = new Rectangle(wo- ((int)w / 2), ho- (((int)h*2 )/3), (int)w, (int)h);
              


                Color p  =Color.FromName(cmbPrim.Text);
                Color s =Color.FromName(cmbSec.Text);


                KnownColor kp = p.ToKnownColor();
                KnownColor ks = s.ToKnownColor();

                if (kp!=0&&ks!=0  &&Enum.IsDefined(typeof(KnownColor),kp) && Enum.IsDefined(typeof(KnownColor),ks ) && w > 0 && h>0)
                {

                    LinearGradientBrush obj_brush = new LinearGradientBrush(rect,p,s,45);

                    g.FillRectangle(obj_brush, rect);


                    obj_brush.Dispose();
                    
                }




                g.DrawRectangle(pen,rect);

                

                g.Dispose();
            }


        }

        bool complete_entry()
        {

            return (nWidth.Value>0&&nHeight.Value>0&&txtName.Text!=string.Empty&&txtDesc.Text!=string.Empty);
        }



        private void cmbPrim_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrimTemp = cmbPrim.Text;

            clear = true;
        }

        private void cmbSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecTemp = cmbSec.Text;

            clear = true;
        }

        private void nWidth_ValueChanged(object sender, EventArgs e)
        {
            clear = true;

            if (complete_entry())
            {
                btnSave.Enabled = true;
            }

            else
            {
                btnSave.Enabled=false;
            }


        }

        private void nHeight_ValueChanged(object sender, EventArgs e)
        {
            clear= true;

            if (complete_entry())
            {
                btnSave.Enabled = true;
            }

            else
            {
                btnSave.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (complete_entry())
            {
                btnSave.Enabled = true;
            }

            else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            if (complete_entry())
            {
                btnSave.Enabled = true;
            }

            else
            {
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbEdit.Checked == false)
            {

                ObjectClass newClass = new ObjectClass
                {
                    Id = selection,
                    TypeId = 'o',
                    TypeName = txtName.Text,
                    Color = Color.FromName(cmbPrim.Text),
                    Shaded = Color.FromName(cmbSec.Text),
                    Width = (int)nWidth.Value,
                    Height = (int)nHeight.Value,
                    Description = txtDesc.Text,
                    Addresses = new List<Address>(),
                    Flags = new List<Flag>()

                };


                Classes.list.Add(newClass);

                dgvClasses.DataSource = null;
                dgvClasses.DataSource = Classes.list;

                txtName.Text = string.Empty;
                txtDesc.Text = string.Empty;

                nWidth.Value = 0;
                nHeight.Value = 0;

                cmbPrim.SelectedIndex = 0;
                cmbSec.SelectedIndex = 0;


            }

            else
            {
                ObjectClass newClass = Classes.list.Where(c => c.Id == this.selection).FirstOrDefault();

                

                
                    newClass.TypeName = txtName.Text;
                     newClass.Color = Color.FromName(cmbPrim.Text);
                    newClass.Shaded = Color.FromName(cmbSec.Text);
                    newClass.Width = (int)nWidth.Value;
                    newClass.Height = (int)nHeight.Value;
                    newClass.Description = txtDesc.Text;

                


                dgvClasses.DataSource = null;
                dgvClasses.DataSource = Classes.list;

                txtName.Text = string.Empty;
                txtDesc.Text = string.Empty;

                nWidth.Value = 0;
                nHeight.Value = 0;

                cmbPrim.SelectedIndex = 0;
                cmbSec.SelectedIndex = 0;



            }

            cbEdit.Checked = false;
            selection = Classes.list.Count();
        }

        private void dgvClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex<0) return;

            ObjectClass tmp = dgvClasses.Rows[e.RowIndex].DataBoundItem as ObjectClass;

            

            if (e.ColumnIndex == 0)
            {

                

                this.selection = tmp.Id;

                this.cbEdit.Checked = true;

                this.txtDesc.Text = tmp.Description;

                this.txtName.Text = tmp.TypeName;

                this.nHeight.Value = tmp.Height;

                this.nWidth.Value = tmp.Width;

                this.cmbPrim.SelectedItem = tmp.Color;

                this.cmbSec.SelectedItem = tmp.Shaded;

            }

            else if (e.ColumnIndex == 1)
            {
                var dRes = MessageBox.Show("Are you sure?", "Delete?",MessageBoxButtons.YesNo);
                if (dRes == DialogResult.Yes)
                {


                    

                    



                    foreach (Object o in Objects.list.ToList())
                    {
                        foreach (Connector c in Connectors.list.ToList())
                        {
                            if (c.begin_point == o.origin || c.end_point == o.origin)
                            {

                                Connectors.list.Remove(c);
                            }



                        }


                        if (o.ClassId == tmp.Id)
                        {
                            Objects.list.Remove(o);
                            
                        }

                    }


                  
                        foreach (ObjectClass cls in Classes.list)
                        {
                            if (cls.Id == tmp.Id)
                            {

                                Classes.list.Remove(cls);
                                
                               

                                break;
                            }

                           
                        }

                        foreach (ObjectClass cls in Classes.list)
                        {

                            if (cls.Id > tmp.Id)
                            {

                                 cls.Id--;



                                 break;
                            }

                        }


                    dgvClasses.DataSource = null;
                    dgvClasses.DataSource = Classes.list;


                    this.txtName.Text = string.Empty;
                    this.txtDesc.Text = string.Empty;
                    this.nHeight.Value = 0;
                    this.nWidth.Value = 0;

                    this.cmbPrim.SelectedIndex = 0;
                    this.cmbSec.SelectedIndex = 0;
                }

                

            }

            else
            {
                return;
            }

            
        }

        private void cbEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEdit.Checked == false)
            {
                this.selection = Classes.list.Count();
            }

           
        }
    }
}
