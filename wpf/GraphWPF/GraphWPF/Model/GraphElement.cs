using GraphWPF.Exception;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GraphWPF.Model
{
    public abstract class GraphElement
    {
        protected const char DELIMITER = ';';

        protected abstract double PenThickness
        {
            get;
        }

        public Drawing buildDrawing()
        {
            return new GeometryDrawing(this.getBrush(), this.getPen(), this.buildGeometry());
        }
        protected abstract Brush getBrush();

        private Pen getPen()
        {
            return new Pen(Brushes.Black, this.PenThickness);
        }

        protected abstract Geometry buildGeometry();

        public static String buildPath(String directory, String baseFileName, String extension)
        {
            return directory + Path.DirectorySeparatorChar + baseFileName + extension;
        }

        public static void load(string fileName, Graph graph, GraphParser parser)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(File.Open(fileName, FileMode.Open));
                String line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    graph.add(parser(graph, line));
                }
            }
            catch (System.Exception e)
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

    }
}
