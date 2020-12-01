using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawShapes
{
    public partial class FormBasicSettings : Form
    {
        private PictureBox _mainPictureBox;
        private Bitmap _bmp;
        private Graphics _g;
        public FormBasicSettings()
        {
            InitializeComponent();
        }
        public FormBasicSettings(in PictureBox mainPictureBox, in Bitmap bmp)
        {
            InitializeComponent();

            _mainPictureBox = mainPictureBox;
            _bmp = bmp;
        }

        private void txtBoxesPoints_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = sender as TextBox;

            if (Char.IsNumber(e.KeyChar) ||
            (!string.IsNullOrEmpty(txtBox.Text) && (e.KeyChar == '\b' || e.KeyChar == ',')))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtBoxesSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = sender as TextBox;

            if (Char.IsNumber(e.KeyChar) ||
            (!string.IsNullOrEmpty(txtBox.Text) && e.KeyChar == '\b'))
            {
                return;
            }
            e.Handled = true;
        }

       

        public void ShowDialog(WhatFigure figure)
        {
            Point location = new Point(panelMainSettings.Location.X, panelMainSettings.Height + 20);

            switch (figure)
            {
                case WhatFigure.Line:
                    panelLine.Visible = true;
                    panelLine.Location = location;
                    break;
                case WhatFigure.RectangleOrEllipse:
                    panelRactangleAndEllipse.Visible = true;
                    panelRactangleAndEllipse.Location = location;
                    break;
                case WhatFigure.Triangle:
                    panelTriangle.Visible = true;
                    panelTriangle.Location = location;
                    break;
            }

            
            this.ShowDialog();
        }

        private void panelColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;

            panelColor.BackColor = colorDialog.Color;
        }

        private void FormBasicSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            panelLine.Visible = panelRactangleAndEllipse.Visible = panelTriangle.Visible = false;
            SetDefaultValues();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            _g = Graphics.FromImage(_bmp);
            _g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Pen pen = null;
            SolidBrush solidBrush = null;


            try
            {
                if (!checkBoxFill.Checked)
                    pen = new Pen(panelColor.BackColor, int.Parse(textBoxThickness.Text));
                else
                    solidBrush = new SolidBrush(panelColor.BackColor);

                switch (Options.Figure)
                {
                    case WhatFigure.Line:
                        CreateLine(_g, pen, StringManager.ParseCoordinates(new string[] { textBoxPoint1.Text, textBoxLinePoint2.Text }));
                        break;
                    case WhatFigure.Rectangle:
                        CreateRectangle(_g, pen, solidBrush, StringManager.ParseCoordinates(new string[] { textBoxPoint1.Text }),
                            int.Parse(textBoxRecEllWidth.Text), int.Parse(textBoxRecElliHeight.Text));
                        break;
                    case WhatFigure.Ellipse:
                        CreateEllipse(_g, pen, solidBrush, StringManager.ParseCoordinates(new string[] { textBoxPoint1.Text }),
                            int.Parse(textBoxRecEllWidth.Text), int.Parse(textBoxRecElliHeight.Text));
                        break;
                    case WhatFigure.Triangle:
                        CreateTriangle(_g, pen, solidBrush, StringManager.ParseCoordinates(new string[]
                            {textBoxPoint1.Text, textBoxTrianglePoint2.Text, textBoxTrianglePoint3.Text }));
                        break;
                }
            
                SetDefaultValues();
                _mainPictureBox.Image = _bmp;

                _g.Dispose();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Не заполнены все поля", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateLine(in Graphics g, in Pen pen, Point[] points)
        {
            _g.DrawLine(pen, points[0], points[1]);
        }
        private void CreateRectangle(in Graphics g, in Pen pen, in SolidBrush brush, Point[] points, int width, int height)
        {
            if (checkBoxFill.Checked)
                g.FillRectangle(brush, points[0].X, points[0].Y, width, height);
            else
                g.DrawRectangle(pen, points[0].X, points[0].Y, width, height);          
        }

        private void CreateEllipse(in Graphics g, in Pen pen, in SolidBrush brush, Point[] points, int width, int height)
        {
            if (checkBoxFill.Checked)
                g.FillEllipse(brush, points[0].X, points[0].Y, width, height);
            else
                g.DrawEllipse(pen, points[0].X, points[0].Y, width, height);
        }

        private void CreateTriangle(in Graphics g, in Pen pen, in SolidBrush brush, Point[] points)
        {
            if (checkBoxFill.Checked)
                g.FillPolygon(brush, points);
            else
                g.DrawPolygon(pen, points);
        }

        private void SetDefaultValues()
        {
            panelColor.BackColor = Color.Black;
            checkBoxFill.Checked = false;
            textBoxThickness.Text = textBoxPoint1.Text = string.Empty;

            switch(Options.Figure)
            {
                case WhatFigure.Line:
                    textBoxLinePoint2.Text = string.Empty;
                    break;
                case WhatFigure.Rectangle:
                case WhatFigure.Ellipse:
                    textBoxRecEllWidth.Text = textBoxRecElliHeight.Text = string.Empty;
                    break;
                case WhatFigure.Triangle:
                    textBoxTrianglePoint2.Text = textBoxTrianglePoint3.Text = string.Empty;
                    break;
            }
        }

        private void FormBasicSettings_Load(object sender, EventArgs e)
        {
            if (Options.Figure == WhatFigure.Line)
                checkBoxFill.Visible = false;
            else
                checkBoxFill.Visible = true;
        }

        private void checkBoxFill_CheckedChanged(object sender, EventArgs e)
        {
            textBoxThickness.Enabled = !checkBoxFill.Checked;                          
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            SetDefaultValues();
            this.Close();
        }
    }

}
