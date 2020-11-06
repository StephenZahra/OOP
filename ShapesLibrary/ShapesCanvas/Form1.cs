using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapesLibrary;

namespace ShapesCanvas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            Shape drawingShape;

            switch (cmbShapes.Text)
            {
                case "Circle":
                    drawingShape = new Circle(e.X, e.Y, Convert.ToDouble(txtRadius.Text));
                    break;

                case "Square":
                    break;

                case "Rectangle":
                    break;

                default:
                    break;
            }
        }
    }
}
