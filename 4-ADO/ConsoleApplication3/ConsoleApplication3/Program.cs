using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    abstract public class Shape
    {
        // A few example members
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        // Virtual es perquè el fill pugui utilitzar el mètode pare i una mica més
        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
        //aquest mètode es fa servir tal qual pels fills
        public void toPrint()
        {
            Console.WriteLine("Imprimeixo en la classe pare");
        }
       // public abstract void toView();
        

    }
    class Rectangle : Shape
    {

        //override estén virtual, és adir, agafa el del pare i una mica més
        public override void Draw()
        {
            // Code to draw a rectangle...
            Console.WriteLine("Drawing a rectangle");
            base.Draw();//crido al mètode pare
        }
        public void toView()
        {
            Console.WriteLine("Estic a to View");
        }
       
    }
    class Triangle : Shape
    {
        //override es pot ficar davant l'àmbit o després
        override public void Draw()
        {
            // Code to draw a triangle...
            Console.WriteLine("Drawing a triangle");
            base.Draw();
        }
        public void toView()
        {
            Console.WriteLine("Estic a to View");
        }
    }

    //sealed class Circle : Shape
    //sealed en aquest cas no em deixa tenir DoubleCircle

     class Circle : Shape //extends
    {
        //no deixa fer canvis en el fill, a no ser que fiquem new
        //sealed es como final
        public sealed override void Draw()
        {
            // Code to draw a circle...
            Console.WriteLine("Drawing a circle");
            base.Draw();
        }
        //new es pot posar davant de l'àmbit
        new public void toPrint()
        {
            Console.WriteLine("Imprimeixo en la classe Circle");
        }
        public void toView()
        {
            Console.WriteLine("Estic a to View");
        }
    }

    class DoubleCircle : Circle
    {
        //hem sobreescrit Draw
        public new void Draw()
        {
            // Code to draw a circle...
            Console.WriteLine("Drawing a Super DoubleCircle");
            
        }
        public void toView()
        {
            Console.WriteLine("Estic a to View");
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            
           // Shape s = new Shape();
           //no es pot crear una instància de Shape ja que és abstracte



            Rectangle r=new Rectangle();
            Triangle t= new Triangle();
            Circle c= new Circle();
            DoubleCircle doubleC = new DoubleCircle();
            //Polimorfisme:fent servir virtual / override
           
            r.Draw();
            t.Draw();
            c.Draw();
            doubleC.Draw();

            //Polimorfisme: fent servir new
            r.toPrint();
            t.toPrint();
            c.toPrint();
            doubleC.toPrint();

           // Keep the console open in debug mode.
           Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

    }

    /* Output:
        Drawing a rectangle
        Performing base class drawing tasks
        Drawing a triangle
        Performing base class drawing tasks
        Drawing a circle
        Performing base class drawing tasks
     */
}
