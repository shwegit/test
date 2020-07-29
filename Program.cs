using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classD
{
    //#region static example
    //class Shape
    //{
    //    private float area;
    //    public Shape(string Message) : this()
    //    {
    //        Console.WriteLine(Message);
    //    }
    //    public Shape()
    //    {
    //        Console.WriteLine("parameterless");
    //    }

    //}
    //class Circle : Shape
    //{
    //    static float pi;
    //    int radius;

    //    static Circle()
    //    {
    //        pi = 3.14f;
    //    }
    //    public Circle(int Radius)
    //    {
    //        radius = Radius;
    //    }


    //    public static float GetPi()
    //    {
    //        return pi;
    //    }
    //    public float Area()
    //    {
    //        return (pi * radius * radius);
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        float val = Circle.GetPi();
    //        Circle c1 = new Circle(4);

    //        Console.WriteLine(c1.Area());
    //        Circle c2 = new Circle(5);
    //        Console.WriteLine(c2.Area());
    //        Console.ReadLine();
    //    }
    //}

    //#endregion

    class Empoyee
    {
         protected string LName = "K";

         protected string FName;


        public Empoyee(string fname, string lname)
        {
            FName = fname;
            LName = lname;
        }

        public virtual void PrintName()
        {
            Console.WriteLine(FName+" "+LName);
        }
    }

    class FullEmp : Empoyee
    {
        public FullEmp(string fname, string lname) : base(fname, lname)
        {

        }

        public new void PrintName()
        {
            Console.WriteLine(FName + " " + LName+" FullEmp");

        }

    }
    class PartEmp : Empoyee
    {
        public PartEmp(string fname, string lname) : base(fname, lname)
        {
        }
        public override void PrintName()
        {
            Console.WriteLine(FName + " " + LName + " PartEmp");

        }
    }

     class TempEmp : Empoyee
    {
        public TempEmp(string fname, string lname) : base(fname, lname)
        {
        }
      

}


    class Program
    {
        public static void Main()
        {
            Empoyee[] emp = new Empoyee[4];
            emp[0] =
             new Empoyee("dd", "ff");
            emp[1] = new FullEmp("gg", "hh");
            emp[2] = new PartEmp("qq", "ww");
            emp[3] = new TempEmp("tt", "yy");

            foreach (Empoyee item in emp)
            {
                item.PrintName();

            }
            Console.ReadLine();
        }
    }

}
