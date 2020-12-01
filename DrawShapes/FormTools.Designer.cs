namespace DrawShapes
{
    partial class FormTools
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
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(13, 12);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(150, 79);
            this.btnLine.TabIndex = 0;
            this.btnLine.Tag = "Line";
            this.btnLine.Text = "Линия";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.buttonsMain_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(166, 12);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(150, 79);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.Tag = "Rec";
            this.btnRectangle.Text = "Прямоугольник";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.buttonsMain_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(322, 12);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(150, 79);
            this.btnEllipse.TabIndex = 2;
            this.btnEllipse.Tag = "Ell";
            this.btnEllipse.Text = "Элипс";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.buttonsMain_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(478, 12);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(150, 79);
            this.btnTriangle.TabIndex = 3;
            this.btnTriangle.Tag = "Tri";
            this.btnTriangle.Text = "Треугольник";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.buttonsMain_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 98);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(303, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Tag = "Save";
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.buttonsMain_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(322, 98);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(303, 31);
            this.btnNew.TabIndex = 5;
            this.btnNew.Tag = "New";
            this.btnNew.Text = "Новый";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.buttonsMain_Click);
            // 
            // FormTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 141);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.btnEllipse);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormTools";
            this.Text = "Инструменты";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTools_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}