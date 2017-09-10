using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsGui
{
   

    public partial class mainform: Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public mainform()
        {
            InitializeComponent();
        }

        

      
    

        
        private void main_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void main_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void main_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point((Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
                Update();
            }
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                if (ActiveForm != null){
                    ActiveForm.Location = new Point((ActiveForm.Location.X - lastLocation.X) + e.X, (ActiveForm.Location.Y - lastLocation.Y) + e.Y);
                    ActiveForm.Update();
                }
            }
        }
        private void panel_header_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void panel_header_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
    }
}
