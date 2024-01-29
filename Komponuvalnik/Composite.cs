using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komponuvalnik
{
    abstract class Component
    {
        public Point p;
        public Size size;
        public Point p1;
        public static  Graphics g;
        public abstract void draw();
       
       
    }
    class PizzaBase : Component
    {
        public PizzaBase() { }
        public  PizzaBase(int Height, int Width, int x, int y) {
            this.size = new Size(Width, Height);
            this.p = new Point(x, y);
        }
        public PizzaBase(int Height, int Width)
        {
            this.size = new Size(Width, Height);
           
        }
        public override void draw() {
         
           
            g.DrawImage((Image)Properties.Resources.ResourceManager.GetObject("Base"), p1.X, p1.Y, size.Height, size.Width);
        }
       
    }
  
    class Hunting_sausages : PizzaBase
    {
        public Hunting_sausages() { }
        public Hunting_sausages(int Height, int Width, int x, int y)
        {
            this.size = new Size(Width, Height);
            this.p = new Point(x, y);
        }
        public override void draw() {
            g.DrawImage((Image)Properties.Resources.ResourceManager.GetObject("hunting_sausages"), p1.X , p1.Y , size.Height, size.Width);
        }
         
    }
    class Mushrooms : PizzaBase
    {
        public Mushrooms() { }
        public Mushrooms(int Height, int Width, int x, int y)
        {
            this.size = new Size(Width, Height);
            this.p = new Point(x, y);
        }
        public override void draw() {
            g.DrawImage((Image)Properties.Resources.ResourceManager.GetObject("Mushrooms"), p1.X , p1.Y , size.Height, size.Width);
        }
         
    }
    class Tomato : PizzaBase
    {
        public Tomato() { }
        public Tomato(int Height, int Width, int x, int y)
        {
            this.size = new Size(Width, Height);
            this.p = new Point(x, y);
        }
        public override void draw() {
            g.DrawImage((Image)Properties.Resources.ResourceManager.GetObject("Tomatoes"), p1.X , p1.Y , size.Height, size.Width);
        }
         
    }
    class Provencal_herbs : PizzaBase
    {
        public Provencal_herbs() { }
        public Provencal_herbs(int Height, int Width, int x, int y)
        {
            this.size = new Size(Width, Height);
            this.p = new Point(x, y);
        }
        public override void draw() {
            g.DrawImage((Image)Properties.Resources.ResourceManager.GetObject("Provencal_herbs"), p1.X , p1.Y , size.Height, size.Width);
        }
         
    }
    class Onion : PizzaBase
    {
        public Onion() { }
        public Onion(int Height, int Width, int x, int y)
        {
            this.size = new Size(Width, Height);
            this.p = new Point(x, y);
        }
        public override void draw() {
            g.DrawImage((Image)Properties.Resources.ResourceManager.GetObject("Onion"), p1.X , p1.Y , size.Height, size.Width);
        }
         
    }
    class Souse_chise : PizzaBase
    {
       public Souse_chise() { }
        public Souse_chise(int Height, int Width, int x, int y)
        {
            this.size = new Size(Width, Height);
            this.p = new Point(x, y);
        }
        public override void draw() {
            g.DrawImage((Image)Properties.Resources.ResourceManager.GetObject("Souse_chice"), p1.X , p1.Y , size.Height, size.Width);
        }
         
    }
    class Souse_green : PizzaBase
    {
        public Souse_green() { }
        public Souse_green(int Height, int Width, int x, int y)
        {
            this.size = new Size(Width, Height);
            this.p = new Point(x, y);
        }
        public override void draw() {
            g.DrawImage((Image)Properties.Resources.ResourceManager.GetObject("Souse_green"), p1.X , p1.Y , size.Height, size.Width);
        }
        
    }
    class Souse_tomato : PizzaBase
    {
        public Souse_tomato() { }
        public Souse_tomato(int Height, int Width, int x, int y)
        {
            this.size = new Size(Width, Height);
            this.p = new Point(x, y);
        }
        public override void draw() {
            g.DrawImage((Image)Properties.Resources.ResourceManager.GetObject("Souse_tomato"), p1.X, p1.Y, size.Height, size.Width);
        }
       
    }
    class Container : Component
    {
        public Container() { }
        public Container(Container container)
        {
            this.p = container.p;
            this.size = container.size;
            for (int i = 0; i < container.components.Count; i++)
            {
                this.components.Add(container.components[i]);
            }
        }
        public Container Clone()
        {
            return new Container(this);
        }
        public List<Component> components = new List<Component>();
        public override void draw() {
            foreach (Component c in components) {


                if (this.GetType().Name == "Container")
                {
                    c.p1.X = c.p.X + this.p.X + this.p1.X;
                    c.p1.Y = c.p.Y + this.p.Y + this.p1.Y;
                }
                else {
                    c.p1.X = c.p.X + this.p.X ;
                    c.p1.Y = c.p.Y + this.p.Y ;
                }
                if (c.size.Width == 0 && c.size.Width == 0)
                {
                    c.size = this.size;
                }
                c.draw();
            }
        }
      
    }
}
