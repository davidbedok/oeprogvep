using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace CSGraph
{
    public class Points
    {

        private int id;
        private string name;
        private double posX;
        private double posY;
        private double radius;
        private Color color;        

        public static uint numberOfPoints = 0;
        public static string errorText = "";
        public const uint MAXPOINTS = 20;        

        public int Pid
        {
            get { return id; }           
        }

        public string Pname
        {
            get { return name; }
            set { name = value; }
        }

        public double Pradius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double PposX
        {
            get { return posX; }
            set { posX = value; }
        }

        public double PposY
        {
            get { return posY; }
            set { posY = value; }
        }

        public Color Pcolor
        {
            get { return color; }
        }

        public void Init(int id, string name, double posX, double posY, double radius, Color color)
        {
            this.id = id;
            this.name = name;
            this.posX = posX;
            this.posY = posY;
            this.radius = radius;
            this.color = color;
        }

        public Points(int id, string name, double posX, double posY, double radius, Color color)
        {
            Init(id,name,posX,posY,radius,color);
            ++numberOfPoints;
        }

        public Points(int id, string name, double posX, double posY, double radius, byte R, byte G, byte B)
        {
            Init(id, name, posX, posY, radius, Color.FromArgb(255, R, G, B));
            ++numberOfPoints;
        }
        
        ~Points(){
            --numberOfPoints;
        }
       
        public override string ToString()
        {
            return this.name + "(" + this.id +")";
        }

        public static Points[] LoadFromFile ( string filename ){            
            errorText = "";
            Points[] ret = new Points[Points.MAXPOINTS];
            string line;
            string[] lineItem;
            try {
                StreamReader sr = new StreamReader(File.Open(filename,FileMode.Open));
                line = "";                                
                while ((line = sr.ReadLine()) != null)
                {
                    lineItem = line.Split(';');
                    ret[numberOfPoints] = new Points(
                            Convert.ToInt32(lineItem[0]), 
                            lineItem[1],
                            Convert.ToDouble(lineItem[2]),
                            Convert.ToDouble(lineItem[3]), 
                            Convert.ToDouble(lineItem[4]), 
                            Convert.ToByte(lineItem[5]), 
                            Convert.ToByte(lineItem[6]), 
                            Convert.ToByte(lineItem[7]));                    
                }
                
                sr.Close();
            } catch (Exception e){
                errorText = e.ToString();
            }

            return ret;
        }

    }
}
