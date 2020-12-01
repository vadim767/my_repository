namespace DrawShapes
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlWithStartButtons = new System.Windows.Forms.Panel();
            this.btnOpenImg = new System.Windows.Forms.Button();
            this.btnNewImg = new System.Windows.Forms.Button();
            this.colorDialogBackColor = new System.Windows.Forms.ColorDialog();
            this.pictureBoxDrawing = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnlWithStartButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawing)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlWithStartButtons
            // 
            this.pnlWithStartButtons.Controls.Add(this.btnOpenImg);
            this.pnlWithStartButtons.Controls.Add(this.btnNewImg);
            this.pnlWithStartButtons.Location = new System.Drawing.Point(257, 135);
            this.pnlWithStartButtons.Name = "pnlWithStartButtons";
            this.pnlWithStartButtons.Size = new System.Drawing.Size(231, 79);
            this.pnlWithStartButtons.TabIndex = 0;
            // 
            // btnOpenImg
            // 
            this.btnOpenImg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOpenImg.Location = new System.Drawing.Point(118, 15);
            this.btnOpenImg.Name = "btnOpenImg";
            this.btnOpenImg.Size = new System.Drawing.Size(110, 50);
            this.btnOpenImg.TabIndex = 1;
            this.btnOpenImg.Tag = "Open";
            this.btnOpenImg.Text = "Открыть";
            this.btnOpenImg.UseVisualStyleBackColor = true;
            this.btnOpenImg.Click += new System.EventHandler(this.startButtons_Click);
            // 
            // btnNewImg
            // 
            this.btnNewImg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNewImg.Location = new System.Drawing.Point(3, 15);
            this.btnNewImg.Name = "btnNewImg";
            this.btnNewImg.Size = new System.Drawing.Size(110, 50);
            this.btnNewImg.TabIndex = 0;
            this.btnNewImg.Tag = "Create";
            this.btnNewImg.Text = "Создать";
            this.btnNewImg.UseVisualStyleBackColor = true;
            this.btnNewImg.Click += new System.EventHandler(this.startButtons_Click);
            // 
            // colorDialogBackColor
            // 
            this.colorDialogBackColor.FullOpen = true;
            // 
            // pictureBoxDrawing
            // 
            this.pictureBoxDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDrawing.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDrawing.Name = "pictureBoxDrawing";
            this.pictureBoxDrawing.Size = new System.Drawing.Size(732, 404);
            this.pictureBoxDrawing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDrawing.TabIndex = 1;
            this.pictureBoxDrawing.TabStop = false;
            this.pictureBoxDrawing.Visible = false;
            this.pictureBoxDrawing.VisibleChanged += new System.EventHandler(this.pictureBoxDrawing_VisibleChanged);
            this.pictureBoxDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDrawing_MouseMove);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 403);
            this.Controls.Add(this.pnlWithStartButtons);
            this.Controls.Add(this.pictureBoxDrawing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Draw shapes";
            this.pnlWithStartButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWithStartButtons;
        private System.Windows.Forms.Button btnOpenImg;
        private System.Windows.Forms.Button btnNewImg;
        private System.Windows.Forms.ColorDialog colorDialogBackColor;
        private System.Windows.Forms.PictureBox pictureBoxDrawing;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

