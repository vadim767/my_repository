using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawShapes
{
    public partial class MainForm : Form
    {
        private Bitmap bmp;
        private string _filter;
        
        public MainForm()
        {
            InitializeComponent();

            _filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|ICO (*.ico)|*.ico|BMP (*.bmp)|*.bmp|All file (*.*)|*.*";
            openFileDialog.Filter = _filter;
        }

        private void startButtons_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
           

            switch (button.Tag.ToString())
            {
                case "Create":

                    if (!SetWindow())
                        return;

                    SetPictureBox();

                    break;
                case "Open":

                    if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                        return;

                    SetWindow(false);

                    try
                    {
                        pictureBoxDrawing.Image = Image.FromFile(openFileDialog.FileName);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }

                    bmp = new Bitmap(pictureBoxDrawing.Image);

                    break;       
            }

            FormTools formTools = new FormTools(this, pictureBoxDrawing, bmp);
            formTools.Show();
        }
        private void SetPictureBox()
        {
            bmp = new Bitmap(pictureBoxDrawing.Width, pictureBoxDrawing.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.Clear(colorDialogBackColor.Color);
            pictureBoxDrawing.Image = bmp;
            graphics.Dispose();
        }

        private bool SetWindow(bool showColor = true)
        {
            string resolution = "";

            FormSize formSize = new FormSize();
            formSize.ShowDialog();
            resolution = formSize.ReturnSetting();

            if (showColor && (resolution == string.Empty ||
                colorDialogBackColor.ShowDialog() == DialogResult.Cancel))
                return false;

            try
            {
                this.Size = StringManager.ParseSize(resolution);
            }
            catch
            {
                this.Close();
            }

            pnlWithStartButtons.Visible = false;
            pictureBoxDrawing.Visible = true;

            return true;
        }

        private void pictureBoxDrawing_VisibleChanged(object sender, EventArgs e)
        {
            pnlWithStartButtons.Visible = !pictureBoxDrawing.Visible;
        }

        private void pictureBoxDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Image: {pictureBoxDrawing.Image.Width} x {pictureBoxDrawing.Image.Height} - " +
                $"Mouse: {e.X} x {e.Y}";
        }
    }
}
