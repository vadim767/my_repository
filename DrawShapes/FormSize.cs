using System;
using System.Windows.Forms;

namespace DrawShapes
{
    public partial class FormSize : Form
    {
        private string _sizeWindow = string.Empty;
        public FormSize()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public string ReturnSetting()
        {
            return _sizeWindow;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            foreach (RadioButton item in groupBox1.Controls)
                if (item.Checked)
                    _sizeWindow = item.Text;

            this.Close();
        }


    }
}
