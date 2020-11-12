namespace ShapesCanvas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlToolbox = new System.Windows.Forms.Panel();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblShapes = new System.Windows.Forms.Label();
            this.cmbShapes = new System.Windows.Forms.ComboBox();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnChangeColour = new System.Windows.Forms.Button();
            this.pnlToolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolbox
            // 
            this.pnlToolbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToolbox.Controls.Add(this.btnChangeColour);
            this.pnlToolbox.Controls.Add(this.txtWidth);
            this.pnlToolbox.Controls.Add(this.lblWidth);
            this.pnlToolbox.Controls.Add(this.txtLength);
            this.pnlToolbox.Controls.Add(this.lblLength);
            this.pnlToolbox.Controls.Add(this.txtRadius);
            this.pnlToolbox.Controls.Add(this.lblRadius);
            this.pnlToolbox.Controls.Add(this.lblShapes);
            this.pnlToolbox.Controls.Add(this.cmbShapes);
            this.pnlToolbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbox.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbox.Name = "pnlToolbox";
            this.pnlToolbox.Size = new System.Drawing.Size(1005, 100);
            this.pnlToolbox.TabIndex = 0;
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(526, 8);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 22);
            this.txtRadius.TabIndex = 3;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(453, 11);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(52, 17);
            this.lblRadius.TabIndex = 2;
            this.lblRadius.Text = "Radius";
            // 
            // lblShapes
            // 
            this.lblShapes.AutoSize = true;
            this.lblShapes.Location = new System.Drawing.Point(34, 11);
            this.lblShapes.Name = "lblShapes";
            this.lblShapes.Size = new System.Drawing.Size(101, 17);
            this.lblShapes.TabIndex = 1;
            this.lblShapes.Text = "Choose Shape";
            // 
            // cmbShapes
            // 
            this.cmbShapes.FormattingEnabled = true;
            this.cmbShapes.Items.AddRange(new object[] {
            "Square",
            "Circle",
            "Rectangle"});
            this.cmbShapes.Location = new System.Drawing.Point(178, 8);
            this.cmbShapes.Name = "cmbShapes";
            this.cmbShapes.Size = new System.Drawing.Size(182, 24);
            this.cmbShapes.TabIndex = 0;
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.Color.White;
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(0, 100);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(1005, 356);
            this.pnlCanvas.TabIndex = 1;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            this.pnlCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseClick);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(453, 44);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(52, 17);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Length";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(526, 39);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 22);
            this.txtLength.TabIndex = 5;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(453, 74);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(44, 17);
            this.lblWidth.TabIndex = 6;
            this.lblWidth.Text = "Width";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(526, 71);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 22);
            this.txtWidth.TabIndex = 7;
            // 
            // btnChangeColour
            // 
            this.btnChangeColour.Location = new System.Drawing.Point(178, 44);
            this.btnChangeColour.Name = "btnChangeColour";
            this.btnChangeColour.Size = new System.Drawing.Size(182, 37);
            this.btnChangeColour.TabIndex = 8;
            this.btnChangeColour.Text = "Change Colour";
            this.btnChangeColour.UseVisualStyleBackColor = true;
            this.btnChangeColour.Click += new System.EventHandler(this.btnChangeColour_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 456);
            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.pnlToolbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlToolbox.ResumeLayout(false);
            this.pnlToolbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbox;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.ComboBox cmbShapes;
        private System.Windows.Forms.Label lblShapes;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnChangeColour;
    }
}

