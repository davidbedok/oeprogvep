using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planets
{
    public partial class PlanetsForm : Form
    {
        private const String PLANETS_FILE = "planets.txt";
        
        private SolarSystem solarSystem;

        public PlanetsForm()
        {
            InitializeComponent();
            this.solarSystem = SolarSystem.load(PlanetsForm.PLANETS_FILE);
            this.output.Text = this.solarSystem.ToString();
            this.image.Image = new Bitmap(SolarSystem.IMG_X, SolarSystem.IMG_Y);
            this.image.SizeMode = PictureBoxSizeMode.StretchImage;
            this.clear();
            this.draw(Brushes.Blue);
        }

        private void clear()
        {
            Graphics graphics = Graphics.FromImage(this.image.Image);
            graphics.Clear(Color.White);
            graphics.DrawRectangle(Pens.Black, 0, 0, SolarSystem.IMG_X - 1, SolarSystem.IMG_Y - 1);
            this.image.Refresh();
        }

        private void draw( Brush brush )
        {
            this.solarSystem.draw(Graphics.FromImage(this.image.Image), brush);
            this.image.Refresh();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            this.planetTimer.Enabled = true;
        }

        private void planetTimer_Tick(object sender, EventArgs e)
        {
            this.draw(Brushes.White);
            this.solarSystem.simulateDays(20);
            this.draw(Brushes.Blue);
        }

    }
}
