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

        private readonly int id;
        private readonly string name;
        private readonly float posX;
        private readonly float posY;
        private readonly float radius;
        private readonly Color color;

        public int Id
        {
            get { return this.id; }
        }

        public float PosX
        {
            get { return this.posX; }
        }

        public float PosY
        {
            get { return this.posY; }
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

        public void draw(Graphics graphics)
        {
            Brush brush = new SolidBrush(this.color);
            graphics.FillEllipse(brush,
                (this.posX - this.radius),
                (this.posY - this.radius),
                (this.radius * 2),
                (this.radius * 2));
            graphics.DrawString(this.name, SystemFonts.DefaultFont, brush,
                (this.posX - this.radius) - 20,
                (this.posY - this.radius) + 10);
        }
       
        public override string ToString()
        {
            return this.name + " (" + this.id +")";
        }

        public static void load(string fileName, Graph holder)
        {
            string line;
            string[] lineItem;
            try
            {
                StreamReader sr = new StreamReader(File.Open(fileName, FileMode.Open));
                line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    lineItem = line.Split(';');
                    holder.addPoint(new Point(
                            Convert.ToInt32(lineItem[0]),
                            lineItem[1],
                            Convert.ToSingle(lineItem[2]),
                            Convert.ToSingle(lineItem[3]),
                            Convert.ToSingle(lineItem[4]),
                            Convert.ToByte(lineItem[5]),
                            Convert.ToByte(lineItem[6]),
                            Convert.ToByte(lineItem[7])));
                }
                sr.Close();
            }
            catch (Exception e)
            {
                //
            }
        }

    }
}
