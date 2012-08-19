using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace CSGraph
{
    public class Point
    {

        private int id;
        private string name;
        private float posX;
        private float posY;
        private float radius;
        private Color color;        

        public int Id
        {
            get { return id; }           
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public float PosX
        {
            get { return posX; }
            set { posX = value; }
        }

        public float PosY
        {
            get { return posY; }
            set { posY = value; }
        }

        public Color PointColor
        {
            get { return color; }
        }

        public Point(int id, string name, float posX, float posY, float radius, byte red, byte green, byte blue)
        {
            this.id = id;
            this.name = name;
            this.posX = posX;
            this.posY = posY;
            this.radius = radius;
            this.color = Color.FromArgb(red,green,blue);
        }
        
        ~Point(){
            // 
        }
       
        public override string ToString()
        {
            return this.name + " (" + this.id +")";
        }

    }
}
