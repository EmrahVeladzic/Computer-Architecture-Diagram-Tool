using Computer_Architecture_Diagram_Tool;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Computer_Architecture_Diagram_Tool
{

    public class Types
    {
        

        public string TypeName { get; set; }


        public char TypeId { get; set; }

    }


    public class Register
    {
        public int Id { get; set; }

        public int Address { get; set; }

        public string Description { get; set; }

    }

    public class RegSet 
    {
        

        public List<Register> Values { get; set; }

        public string Description { get; set; }
    }

    public class Function 
    {

        public int Id { get; set; }

        public string Declaration { get; set; }

        public string Description { get; set; }

    }


    public class Flag 
    {
        public int Id { get; set; }

        public int BaseValue { get; set; }

        public char BitMask { get; set; }

        public string Description { get; set; }

    }


    public class FlagSet 
    {
       

        public List<Flag> Values { get; set;}

        public string Description { get; set; }
    }

    public class ObjectClass : Types
    {

        public int Id { get; set; }

        public Color Color { get; set; }
        public Color Shaded { get; set; }

        public string Description { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public virtual RegSet Registers { get; set; }
        public virtual FlagSet Flags { get; set; }

        public List<Function> Functions { get; set; }


        public override string ToString()
        {
            return TypeName;
        }

    }

    public class Object : Types
    {
        public int Id { get; set; }

        public int ClassId { get; set; }

        public Point origin;

    }

    public class ObjGroup : Types
    {
        public int Id { get; set; }

        public Point begin_point;
        public Point end_point;


    }

    public class Connector : Types
    {

        public int Id { get; set; }

        public int first_end;
        public int second_end;


        public  Point begin_point;

        public  Point end_point;

        public Point joint_point;


        public Color Con1 { get; set; }

        public Color Con2 { get; set; }

        public List<string> Functions { get; set; }

    }

    public static class Classes
    {

        public static List<ObjectClass> list = new List<ObjectClass>();

    }

    public static class Objects 
    {

        public static List<Object> list = new List<Object>();


    }

    public static class Connectors
    {

        public static List<Connector> list = new List<Connector>();
    }

    public static class Groups
    {

        public static List <ObjGroup> list = new List<ObjGroup>();
    }

}

