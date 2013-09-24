using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Event
{    

    public partial class EventForm : Form
    {
        private Process iProcess;

        public EventForm()
        {
            InitializeComponent();
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            this.iProcess = new Process(Convert.ToInt32(tbMINVALUE.Text), Convert.ToInt32(tbMAXVALUE.Text));

        
            this.iProcess.customHandler += new CustomEventHandler(iProcess_CustomEventHandler);
            this.iProcess.customHandler += new CustomEventHandler(iProcess_anotherCustomEventHandler);

            this.iProcess.handler += new EventHandler(iProcess_handler);

            this.iProcess.handler += delegate
            {
                MessageBox.Show("From Anonymous method!");
            };

            this.ProcessRefresh();
            this.bStep.Enabled = true;
        }

        void iProcess_CustomEventHandler(string param)
        {
            MessageBox.Show("Fire Event! CustomHandler (" + param + ")");
        }

        void iProcess_anotherCustomEventHandler(string param)
        {
            // TODO
        }

        public void iProcess_handler(object sender, EventArgs e)
        {
            double eventStatus = 0;
            if (sender is Process){
                eventStatus = (sender as Process).getPercent();
            }
            MessageBox.Show("Fire Event! Handler (" + eventStatus.ToString() + ")");
        }

        private void ProcessRefresh()
        {
            this.tbValue.Text = this.iProcess.Status.ToString();
            this.tbPercent.Text = this.iProcess.getPercent().ToString();
        }

        private void bStep_Click(object sender, EventArgs e)
        {
            this.iProcess.step( Convert.ToInt32(this.tbStep.Text) );
            this.ProcessRefresh();
        }
    }
}