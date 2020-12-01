using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawShapes
{
    public partial class FormTools : Form
    {
        private FormBasicSettings _formBasicSettings;
        private MainForm _mainForm;
        private PictureBox _pictureBox;
        private string _filter;

        public FormTools()
        {
            InitializeComponent();
        }
        public FormTools(in MainForm mainForm, in PictureBox pictureBox, in Bitmap bmp)
        {
            InitializeComponent();
            _formBasicSettings = new FormBasicSettings(pictureBox, bmp);
            _pictureBox = pictureBox;
            this.StartPosition = FormStartPosition.CenterScreen;
            _mainForm = mainForm;

            _filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|ICO (*.ico)|*.ico|BMP (*.bmp)|*.bmp|All file (*.*)|*.*";
            saveFileDialog.Filter = _filter;
        }

        private void buttonsMain_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            switch(button.Tag.ToString())
            {
                case "Line":
                    Options.Figure = WhatFigure.Line;
                    _formBasicSettings.ShowDialog(WhatFigure.Line);                  
                    break;
                case "Rec":
                    Options.Figure = WhatFigure.Rectangle;
                    _formBasicSettings.ShowDialog(WhatFigure.RectangleOrEllipse);
                    break;
                case "Ell":
                    Options.Figure = WhatFigure.Ellipse;
                    _formBasicSettings.ShowDialog(WhatFigure.RectangleOrEllipse);
                    break;
                case "Tri":
                    Options.Figure = WhatFigure.Triangle;
                    _formBasicSettings.ShowDialog(WhatFigure.Triangle);
                    break;
                case "Save":
                    Save();
                    break;
                case "New":
                    _mainForm.Text = "Draw shapes";
                    _pictureBox.Visible = false;
                    _mainForm.Size = new Size(600, 350);
                    this.Close();
                    break;
            }
        }

        private void FormTools_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_pictureBox.Visible)
                _mainForm.Close();
        }

        private void Save()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            _pictureBox.Image.Save(saveFileDialog.FileName);
        }
    }
}
