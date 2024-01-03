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
                    Id = Classes.list.Count,
                    TypeId = 'o',
                    TypeName = txtName.Text,
                    Color = Color.FromName(cmbPrim.Text),
                    Shaded = Color.FromName(cmbSec.Text),
                    Width = (int)nWidth.Value,
                    Height = (int)nHeight.Value,
                    Description = txtDesc.Text,


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
        }

        private void dgvClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex<0||cbEdit.Checked==false) return;


        }
    }
}
