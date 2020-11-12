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
            Shape drawingShape = null;

            switch (cmbShapes.Text.Trim())
            {
                case "Circle":
                    if(txtRadius.Text == string.Empty)
                    {
                        MessageBox.Show("Please input radius");
                    }
                    else
                    {
                        drawingShape = new Circle(e.X, e.Y, Convert.ToDouble(txtRadius.Text), ShapesBorderColour);
                        //drawingShape.BorderColor = "Black"; <--- can also pass colour like this
                    }
                    
                    break;

                case "Square":
                    if (txtLength.Text == string.Empty)
                    {
                        MessageBox.Show("Please input length");
                    }
                    else
                    {
                        drawingShape = new Square(e.X, e.Y, Convert.ToDouble(txtLength.Text));
                    }
                    break;

                case "Rectangle":
                    if (txtLength.Text == string.Empty || txtWidth.Text == string.Empty)
                    {
                        MessageBox.Show("Please input length");
                    }
                    else
                    {
                        drawingShape = new ShapesLibrary.Rectangle(e.X, e.Y, Convert.ToDouble(txtLength.Text), Convert.ToDouble(txtWidth.Text));
                    }
                    break;

                default:
                    break;
            }

            if(drawingShape != null)
            {
                drawingShape.Draw(pnlCanvas.CreateGraphics());
            }
        }

        public Color ShapesBorderColour { get; set; }
        private void btnChangeColour_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ShapesBorderColour = colorDialog1.Color;
            }
        }
    }
}
