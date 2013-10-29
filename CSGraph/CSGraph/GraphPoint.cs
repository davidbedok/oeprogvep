using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace CSGraph
{
    public class GraphPoint
    {
        private const char DELIMITER = ';';

        private readonly int id;
        private readonly string name;
        private PointF position;
        private readonly float radius;
        private readonly Color color;

        public int Id
        {
            get { return this.id; }
        }

        public PointF Position
        {
            get { return this.position; }
        }
       
        public GraphPoint(int id, string name, float posX, float posY, float radius, byte red, byte green, byte blue)
        {
            this.id = id;
            this.name = name;
            this.position = new PointF(posX, posY);
            this.radius = radius;
            this.color = Color.FromArgb(red,green,blue);
        }
        
        ~GraphPoint(){
            // 
        }

        public void draw(Graphics graphics)
        {
            Brush brush = new SolidBrush(this.color);
            graphics.FillEllipse(brush,
                (this.position.X - this.radius),
                (this.position.Y - this.radius),
                (this.radius * 2),
                (this.radius * 2));
            graphics.DrawString(this.name, SystemFonts.DefaultFont, brush,
                (this.position.X - this.radius) - 20,
                (this.position.Y - this.radius) + 10);
        }
       
        public override string ToString()
        {
            return this.name + " (" + this.id +")";
        }

        public static void load(string fileName, Graph graph)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(File.Open(fileName, FileMode.Open));
                String line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    graph.add(GraphPoint.parse(line));
                }                
            }
            catch (Exception e)
            {
                throw new BadFileFormatException("Unexpected error while parsing '" + fileName + "'.", e);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        private static GraphPoint parse( String line )
        {
            try
            {
                string[] lineItem = line.Split(GraphPoint.DELIMITER);
                return new GraphPoint(
                                Convert.ToInt32(lineItem[0]),
                                lineItem[1],
                                Convert.ToSingle(lineItem[2]),
                                Convert.ToSingle(lineItem[3]),
                                Convert.ToSingle(lineItem[4]),
                                Convert.ToByte(lineItem[5]),
                                Convert.ToByte(lineItem[6]),
                                Convert.ToByte(lineItem[7]));
            } 
            catch (Exception e)
            {
                throw new GraphParseException("GraphPoint parse error.", line, e);
            }
        }

    }
}
