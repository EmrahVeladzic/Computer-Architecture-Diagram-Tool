using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Architecture_Diagram_Tool
{
    public partial class DDisplay : Form
    {
        Color background = Color.RosyBrown;

        int reset;


        Font font = new Font("Arial",8,FontStyle.Regular);

        char type_class;
        int list_Id;

        int node_size = 5;

        bool busy;

        Point def_origin;
        Point mouse_current;

        bool clr;

     
        int selectionId;
        

        public DDisplay()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            
        }

        Timer update;

        Pen pen;
        Pen selection;

        public enum Tool
        {
            Draw = 0,
            Select = 1,
            Connect = 2,
            Group =3,

        }

        ObjectClass TempClass;

        private void DDisplay_Load(object sender, EventArgs e)
        {
            busy = false;
            clr = false;

            def_origin = new Point();
            pen = new Pen(color: Color.Black);
            selection = new Pen(color: Color.Gray);
            
            cmbTools.DataSource = Enum.GetValues(typeof(Tool));


            reset = 0;
            

            cmbCath.DataSource = Classes.list;
            cmbObjCls.DataSource = Classes.list;

            update = new Timer();
            update.Interval = 10;
            update.Tick += new EventHandler(render);
            update.Enabled = true;


      
        }
        
      


        private void newDiagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void defineObjectClassToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Emrah Veladžić - IB210162 - 2023", "About");
        }

        private void gettingStartedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void appendToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportAsHeaderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        
        }

        private void drawBox_MouseDown(object sender, MouseEventArgs e)
        {
            def_origin.X = e.X;
            def_origin.Y = e.Y;

            clr = true;


            switch (cmbTools.SelectedIndex)
            {

                case 0: place_new(); break;
                case 1: select_new();break;

                default: break;
            }

        }

        void place_new()
        {
            if (TempClass == null)
            {
                return;
            }

            Objects.list.Add(new Object
            {
                Id = Objects.list.Count(),

                ClassId = TempClass.Id,

                TypeName = $"Instance of {TempClass.TypeName}",

                origin=new Point(def_origin.X, def_origin.Y),

                TypeId = 'o',

            }); 
        }


        
        void select_new()
        {
            if (busy) { return; }

            foreach (Object obj in Objects.list)
            {
                int width = Classes.list.Where(c => c.Id == obj.ClassId).Select(c => c.Width).FirstOrDefault();
                int height = Classes.list.Where(c => c.Id == obj.ClassId).Select(c => c.Height).FirstOrDefault();

                int left = obj.origin.X - (width / 2);
                int right = obj.origin.X + (width / 2);
                int top = obj.origin.Y - (height / 2);
                int bottom = obj.origin.Y + (height / 2);



                if (def_origin.X >= left && def_origin.X <= right && def_origin.Y >= top && def_origin.Y <= bottom)
                {
                    cmbObjCls.Enabled = true;
                    btnDetail.Enabled = true;
                    cmbObjCls.DataSource=Classes.list;

                    type_class = obj.TypeId;
                    list_Id = obj.Id;
                    
                    cmbObjCls.SelectedIndex = obj.ClassId;
                    txName.Text = obj.TypeName;

          

                    selectionId=obj.Id;


                    return;
                }


            }

            foreach(ObjGroup g in Groups.list)
            {
                if(Math.Abs(def_origin.X-g.begin_point.X)<=5&& Math.Abs(def_origin.Y - g.begin_point.Y) <= 5)
                {
                    cmbObjCls.DataSource = null;
                    cmbObjCls.DataSource = new List<string> { $"<NOT AN OBJECT>" } ;
                    cmbObjCls.Enabled=false;
                    btnDetail.Enabled=false;

                    type_class = g.TypeId;
                    list_Id = g.Id;

                   
                    txName.Text = g.TypeName;

                   

                    selectionId = g.Id;

                    return;
                }


            }

            foreach (Connector c in Connectors.list)
            {
                if (Math.Abs(def_origin.X - c.joint_point.X) <= 5 && Math.Abs(def_origin.Y - c.joint_point.Y) <= 5)
                {
                    cmbObjCls.DataSource = null;
                    cmbObjCls.DataSource = new List<string> { $"<NOT AN OBJECT>" };
                    cmbObjCls.Enabled = false;
                    btnDetail.Enabled = false;

                    type_class = c.TypeId;
                    list_Id = c.Id;


                    txName.Text = c.TypeName;

             

                    selectionId = c.Id;


                    return;
                }


            }


            cmbObjCls.DataSource = null;
            cmbObjCls.DataSource = new List<string> { $"" };
            cmbObjCls.Enabled = false;
            txName.Text = $"";
            btnDetail.Enabled = false;
    
            selectionId = 0;
            type_class = '\0';
            list_Id = -1;

        }
       
       

        private void cmbCath_SelectedIndexChanged(object sender, EventArgs e)
        {
            TempClass = cmbCath.SelectedItem as ObjectClass;
          
        }

        private void drawBox_MouseUp(object sender, MouseEventArgs e)
        {

            clr = true;

            switch (cmbTools.SelectedIndex)
            {


                case 3:calculate_group();break;
                case 2:calculate_connection();break;


                default: break;


            }


            void calculate_group()
            {
                if (e.X > def_origin.X)
                {
                    if (e.Y > def_origin.Y)
                    {
                        group_new(def_origin.X,def_origin.Y,e.X,e.Y);
                    }
                    else
                    {
                        group_new(def_origin.X,e.Y,e.X,def_origin.Y);
                    }

                }

                else
                {
                    if (e.Y > def_origin.Y)
                    {
                        group_new(e.X, def_origin.Y, def_origin.X, e.Y);
                    }
                    else
                    {
                        group_new(e.X, e.Y, def_origin.X, def_origin.Y);
                    }


                }

            }


            void calculate_connection()
            {
                int x = -1;
                int y = -1;

                int X = -1;
                int Y = -1;

                int first_ID=-1;
                int second_ID=-1;

                Color f=Color.Wheat;

                Color s=Color.Teal;


                foreach (Object obj in Objects.list)
                {
                    int width = Classes.list.Where(c => c.Id == obj.ClassId).Select(c => c.Width).FirstOrDefault();
                    int height = Classes.list.Where(c => c.Id == obj.ClassId).Select(c => c.Height).FirstOrDefault();

                    int left = obj.origin.X - (width / 2);
                    int right = obj.origin.X + (width / 2);
                    int top = obj.origin.Y - (height / 2);
                    int bottom = obj.origin.Y + (height / 2);

                    if (def_origin.X >= left && def_origin.X <= right && def_origin.Y >= top && def_origin.Y <= bottom)
                    {
                        x=obj.origin.X; y=obj.origin.Y;

                        first_ID=obj.Id;

                        f=Classes.list.Where(c=>c.Id==obj.ClassId).Select(c=>c.Color).FirstOrDefault();
                    }
                }

                foreach (Object obj in Objects.list)
                {
                    int width = Classes.list.Where(c => c.Id == obj.ClassId).Select(c => c.Width).FirstOrDefault();
                    int height = Classes.list.Where(c => c.Id == obj.ClassId).Select(c => c.Height).FirstOrDefault();

                    int left = obj.origin.X - (width / 2);
                    int right = obj.origin.X + (width / 2);
                    int top = obj.origin.Y - (height / 2);
                    int bottom = obj.origin.Y + (height / 2);

                    if (e.X >= left && e.X <= right && e.Y >= top && e.Y <= bottom )
                    {


                        X = obj.origin.X; Y = obj.origin.Y;
                        second_ID = obj.Id;

                        s = Classes.list.Where(c => c.Id == obj.ClassId).Select(c => c.Shaded).FirstOrDefault();

                    }


                }


                if (x == -1 || y == -1 || X == -1 || Y == -1 || first_ID==second_ID)
                {
                    return;
                }


 

                connect_new(x, y, X, Y, f, s);

            }

        }


        void connect_new(int x,int y, int X, int Y, Color f, Color s)
        {
            int mid_x;
            int mid_y;

            int tolerance=25;

            if (Math.Abs(x-X)> tolerance && Math.Abs(y-Y)> tolerance)
            {
                mid_x=x; mid_y=Y;

            }

            else if(Math.Abs(x - X) <= tolerance && Math.Abs(y - Y) > tolerance)
            {

                mid_x = x;
                mid_y=(Y+y)/2;

            }

            else if(Math.Abs(x - X) > tolerance && Math.Abs(y - Y) <= tolerance)
            {
                mid_x = (x + X) / 2;
                mid_y=y;
            }

            else 
            {
                return;
            }



            Connectors.list.Add(new Connector
            {
                Id=Connectors.list.Count(),

                TypeId='c',

                TypeName=$"Function ",

                begin_point=(new Point(x,y)),

                end_point =(new Point(X,Y)),
                
                joint_point=(new Point(mid_x,mid_y)),



                Con1=f, Con2=s,

            });;


        }


        void group_new(int x,int y, int X, int Y)
        {
            Groups.list.Add(new ObjGroup
            {
                Id=Groups.list.Count(),
                TypeName=$"Device ",

                TypeId='g',
                
                begin_point=new Point(x,y),

                end_point=(new Point(X,Y)),


            });

        }

        private void cmbTools_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTools.SelectedIndex == 1)
            {
                cmbCath.Enabled = false;
                cmbObjCls.Enabled = true;

                txName.Enabled = true;

                btnSave.Enabled = true;

                btnDelete.Enabled = true;
                btnDetail.Enabled = true;

                btnNewClass.Enabled = false;


              

            }

            else
            {

                btnSave.Enabled = false;

                cmbCath.Enabled = true;
                cmbObjCls.Enabled = false;

                txName.Enabled = false;

                btnDelete.Enabled = false;
                btnDetail.Enabled = false;

                btnNewClass.Enabled = true;




            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            busy = true;

           


            var rez =MessageBox.Show("Are you sure?","Delete?",MessageBoxButtons.YesNo);
            if (rez == DialogResult.Yes)
            {
                if (type_class == 'o')
                {

                    Object temp = Objects.list.Find(o => o.Id == list_Id);

                    for (int i = Connectors.list.Count-1;i>-1;i--)
                    {
                        Connector c = Connectors.list[i];

                        if (c.end_point==temp.origin||c.begin_point==temp.origin)
                        {
                            Connectors.list.Remove(c);

                           
                        }

                    }

                    if (Connectors.list.Count>0)
                    {
                        Connectors.list[0].Id = 0;

                        for (int i = 1; i < Connectors.list.Count; i++)
                        {

                            if (Connectors.list[i].Id != (Connectors.list[i - 1].Id - 1))
                            {
                                Connectors.list[i].Id = (Connectors.list[i - 1].Id - 1);
                            }


                        }
                    }

                   
                 
                    Objects.list.Remove(temp);

                  


                    foreach (Object obj in Objects.list)
                    {


                        if(obj.Id > list_Id)
                        {
                            obj.Id--;
                        }

                    }

                 




                }
                else if (type_class == 'g')
                {
                    Groups.list.Remove(Groups.list.Find(g => g.Id == list_Id));

                    

                    foreach (ObjGroup grp in Groups.list)
                    {
                        if (grp.Id > list_Id)
                        {
                            grp.Id--;
                        }

                    }

                }
                else if (type_class == 'c')
                {
                    Connectors.list.Remove(Connectors.list.Find(c => c.Id == list_Id));

                  

                    foreach (Connector con in Connectors.list)
                    {
                        if (con.Id > list_Id)
                        {
                            con.Id--;
                        }

                    }

                }

          
            }

            type_class = '\0';
            list_Id = -1;

            busy = false;
            manual_clear();
        }

        void manual_clear()
        {
            using (Graphics g = drawBox.CreateGraphics())
            {
                g.Clear(background);

                g.Dispose();

            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {



            if (type_class == 'o')
            {
                Object obj = Objects.list.Find(o => o.Id == list_Id);

                obj.TypeName = txName.Text;
                obj.ClassId = cmbObjCls.SelectedIndex;

                foreach (Connector c in Connectors.list)
                {

                    if (c.begin_point == obj.origin)
                    {
                        c.Con1 = Classes.list.Where(cl => cl.Id == obj.ClassId).Select(cl => cl.Color).FirstOrDefault();
                    }

                    if (c.end_point==obj.origin)
                    {
                        c.Con2 = Classes.list.Where(cl => cl.Id == obj.ClassId).Select(cl => cl.Shaded).FirstOrDefault();
                    

                    }

            }

            }
            else if (type_class == 'g')
            {
                ObjGroup grp = Groups.list.Find(g => g.Id == list_Id);

                grp.TypeName = txName.Text;

            }
            else if (type_class == 'c')
            {
                Connector con = Connectors.list.Find(c => c.Id == list_Id);
                con.TypeName = txName.Text;

            }


            manual_clear();
        }

        void render(object sender, EventArgs e)
        {
            reset++;
            if (reset>=50)
            {
                clr = true;
            }


            using (Graphics g = drawBox.CreateGraphics())
            {




                SolidBrush brush = new SolidBrush(Color.Black);


                if (clr)
                {
                    g.Clear(background);
                    clr = false;
                    reset = 0;

                }

                if (cmbTools.SelectedIndex == 3)
                {

                    int temp_origin_x, temp_origin_y;

                    int temp_inc_x, temp_inc_y;

                    if (mouse_current.X > def_origin.X)
                    {
                        temp_origin_x = def_origin.X;
                        temp_inc_x = mouse_current.X;
                    }
                    else
                    {
                        temp_origin_x = mouse_current.X;
                        temp_inc_x = def_origin.X;
                    }

                    if (mouse_current.Y > def_origin.Y)
                    {
                        temp_origin_y = def_origin.Y;
                        temp_inc_y = mouse_current.Y;
                    }
                    else
                    {
                        temp_origin_y = mouse_current.Y;
                        temp_inc_y = def_origin.Y;
                    }



                    Rectangle sel = new Rectangle(temp_origin_x, temp_origin_y, temp_inc_x - temp_origin_x, temp_inc_y - temp_origin_y);

                    g.DrawRectangle(selection, sel);
                }

                foreach (Connector c in Connectors.list)
                {



                    PointF begin = new PointF(c.joint_point.X - node_size, c.joint_point.Y - node_size);

                    PointF end = new PointF(c.joint_point.X + node_size, c.joint_point.Y + node_size);


                    LinearGradientBrush c_brush = new LinearGradientBrush(begin, end, c.Con1, c.Con2);


                    Rectangle grab = new Rectangle(c.joint_point.X - node_size, c.joint_point.Y - node_size, node_size * 2, node_size * 2);

                    g.DrawRectangle(pen, grab);


                    g.FillRectangle(c_brush, grab);
                    g.DrawRectangle(pen, grab);




                    g.DrawLine(pen, c.begin_point, c.joint_point);
                    g.DrawLine(pen, c.joint_point, c.end_point);

                    g.DrawString(c.TypeName, font, brush, c.joint_point.X, c.joint_point.Y);




                }


                foreach (Object o in Objects.list)
                {
                    int width = Classes.list.Where(c => c.Id == o.ClassId).Select(c => c.Width).FirstOrDefault();
                    int height = Classes.list.Where(c => c.Id == o.ClassId).Select(c => c.Height).FirstOrDefault();

                    Point begin = new Point(o.origin.X - (width / 2), o.origin.Y - (height / 2));

                    Point end = new Point(o.origin.X + (width / 2), o.origin.Y + (height / 2));

                    Color tone_one = Classes.list.Where(c => c.Id == o.ClassId).Select(c => c.Color).FirstOrDefault();
                    Color tone_two = Classes.list.Where(c => c.Id == o.ClassId).Select(c => c.Shaded).FirstOrDefault();

                    LinearGradientBrush obj_brush = new LinearGradientBrush(begin, end, tone_one, tone_two);

                    Rectangle rect = new Rectangle(o.origin.X - (width / 2), o.origin.Y - (height / 2), width, height);




                   

                        g.FillRectangle(obj_brush, rect);

                        g.DrawRectangle(pen, rect);


                        g.DrawString(o.TypeName, font, brush, o.origin.X - width / 2 - 15, o.origin.Y - height / 2 - 15);


                        


                    

                    obj_brush.Dispose();

                };

                SolidBrush grp_brush = new SolidBrush(Color.Purple);



                foreach (ObjGroup og in Groups.list)
                {
                    




                        Rectangle rect = new Rectangle(og.begin_point.X, og.begin_point.Y, (og.end_point.X - og.begin_point.X), (og.end_point.Y - og.begin_point.Y));

                        Rectangle grab = new Rectangle(og.begin_point.X - node_size, og.begin_point.Y - node_size, node_size * 2, node_size * 2);

                        g.DrawRectangle(pen, rect);


                        g.FillRectangle(grp_brush, grab);
                        g.DrawRectangle(pen, grab);

                        g.DrawString(og.TypeName, font, brush, og.begin_point.X + 5, og.begin_point.Y - 15);

                        


                    


                }


               


                brush.Dispose();

                g.Dispose();
            }

        }

        private void drawBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (cmbTools.SelectedIndex == 3)
            {

                if (e.Button == MouseButtons.Left)
                {

                    mouse_current.X = e.X;
                    mouse_current.Y = e.Y;

                    clr = true;

                }

                else
                {
                    mouse_current.X = def_origin.X;
                    mouse_current.Y = def_origin.Y;

                    clr = false;
                }

            }

            else if (cmbTools.SelectedIndex == 1){

                if (e.Button == MouseButtons.Left)
                {

                    mouse_current.X = e.X;
                    mouse_current.Y = e.Y;

                    

                    if (type_class == 'o')
                    {
                       Object temp = Objects.list.Where(o=>o.Id==selectionId).FirstOrDefault();


                        foreach (Connector c in Connectors.list)
                        {

                            if (c.begin_point == temp.origin)
                            {
                                c.begin_point.X = mouse_current.X;
                                c.begin_point.Y = mouse_current.Y;
                            }

                            if (c.end_point==temp.origin)
                            {

                                c.end_point.X = mouse_current.X;
                                c.end_point.Y = mouse_current.Y;
                            }

                        }



                        temp.origin.X = mouse_current.X;
                        temp.origin.Y=mouse_current.Y;

                    }

                    else if (type_class=='c')
                    {
                        Connector temp = Connectors.list.Where(c=>c.Id==selectionId).FirstOrDefault();


                        temp.joint_point.X = mouse_current.X;
                        temp.joint_point.Y = mouse_current.Y;
                    }

                    else if (type_class=='g')
                    {
                        ObjGroup temp = Groups.list.Where(g=>g.Id==selectionId).FirstOrDefault();


                        if (temp.end_point.X>mouse_current.X)
                        {
                            temp.begin_point.X = mouse_current.X;
                            
                        }

                        if (temp.end_point.Y>mouse_current.Y)
                        {
                            temp.begin_point.Y = mouse_current.Y;
                        }


                    }

                    clr = true;

                }


                else if (e.Button == MouseButtons.Right && type_class == 'g')
                {
                    mouse_current.X = e.X;
                    mouse_current.Y = e.Y;

                    clr = true;

                    ObjGroup temp = Groups.list.Where(g => g.Id == selectionId).FirstOrDefault();

                    int w = temp.end_point.X - temp.begin_point.X;
                    int h = temp.end_point.Y - temp.begin_point.Y;

                    temp.begin_point.X = mouse_current.X;
                    temp.begin_point.Y = mouse_current.Y;

                    temp.end_point.X = temp.begin_point.X + w;
                    temp.end_point.Y = temp.begin_point.Y + h;
                }



                else
                {
                    mouse_current.X = def_origin.X;
                    mouse_current.Y = def_origin.Y;

                    clr = false;
                }

               



            }


        }

        private void btnNewClass_Click(object sender, EventArgs e)
        {
            Form newFrm = new ClassDeclaration();
            newFrm.ShowDialog();

            cmbCath.DataSource = null;
            cmbCath.DataSource = Classes.list;

            cmbObjCls.DataSource = null;
            cmbObjCls.DataSource = Classes.list;

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (type_class != 'o')
            {
                
                return;
            }

            Object tmp = Objects.list.Where(c=>c.Id==selectionId).FirstOrDefault();



            Form newForm = new Details(tmp);
            newForm.ShowDialog();
        }
    }
}
