namespace DrawShapes
{
    partial class FormBasicSettings
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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.panelMainSettings = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPoint1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxThickness = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxFill = new System.Windows.Forms.CheckBox();
            this.panelLine = new System.Windows.Forms.Panel();
            this.textBoxLinePoint2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelRactangleAndEllipse = new System.Windows.Forms.Panel();
            this.textBoxRecElliHeight = new System.Windows.Forms.TextBox();
            this.textBoxRecEllWidth = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.panelTriangle = new System.Windows.Forms.Panel();
            this.textBoxTrianglePoint3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTrianglePoint2 = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panelMainSettings.SuspendLayout();
            this.panelLine.SuspendLayout();
            this.panelRactangleAndEllipse.SuspendLayout();
            this.panelTriangle.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorDialog
            // 
            this.colorDialog.FullOpen = true;
            // 
            // panelMainSettings
            // 
            this.panelMainSettings.Controls.Add(this.panelColor);
            this.panelMainSettings.Controls.Add(this.label3);
            this.panelMainSettings.Controls.Add(this.textBoxPoint1);
            this.panelMainSettings.Controls.Add(this.label2);
            this.panelMainSettings.Controls.Add(this.textBoxThickness);
            this.panelMainSettings.Controls.Add(this.label1);
            this.panelMainSettings.Location = new System.Drawing.Point(12, 12);
            this.panelMainSettings.Name = "panelMainSettings";
            this.panelMainSettings.Size = new System.Drawing.Size(244, 100);
            this.panelMainSettings.TabIndex = 0;
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.Black;
            this.panelColor.Location = new System.Drawing.Point(122, 25);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(22, 22);
            this.panelColor.TabIndex = 5;
            this.panelColor.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цвет";
            // 
            // textBoxPoint1
            // 
            this.textBoxPoint1.Location = new System.Drawing.Point(7, 74);
            this.textBoxPoint1.Name = "textBoxPoint1";
            this.textBoxPoint1.Size = new System.Drawing.Size(65, 22);
            this.textBoxPoint1.TabIndex = 3;
            this.textBoxPoint1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxesPoints_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Точка (вводить через запятую)";
            // 
            // textBoxThickness
            // 
            this.textBoxThickness.Location = new System.Drawing.Point(7, 25);
            this.textBoxThickness.Name = "textBoxThickness";
            this.textBoxThickness.Size = new System.Drawing.Size(65, 22);
            this.textBoxThickness.TabIndex = 1;
            this.textBoxThickness.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxesSize_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Толщина";
            // 
            // checkBoxFill
            // 
            this.checkBoxFill.AutoSize = true;
            this.checkBoxFill.Location = new System.Drawing.Point(263, 16);
            this.checkBoxFill.Name = "checkBoxFill";
            this.checkBoxFill.Size = new System.Drawing.Size(151, 21);
            this.checkBoxFill.TabIndex = 1;
            this.checkBoxFill.Text = "Заполнить фигуру";
            this.checkBoxFill.UseVisualStyleBackColor = true;
            this.checkBoxFill.CheckedChanged += new System.EventHandler(this.checkBoxFill_CheckedChanged);
            // 
            // panelLine
            // 
            this.panelLine.Controls.Add(this.textBoxLinePoint2);
            this.panelLine.Controls.Add(this.label4);
            this.panelLine.Location = new System.Drawing.Point(13, 130);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(243, 58);
            this.panelLine.TabIndex = 2;
            this.panelLine.Visible = false;
            // 
            // textBoxLinePoint2
            // 
            this.textBoxLinePoint2.Location = new System.Drawing.Point(6, 24);
            this.textBoxLinePoint2.Name = "textBoxLinePoint2";
            this.textBoxLinePoint2.Size = new System.Drawing.Size(65, 22);
            this.textBoxLinePoint2.TabIndex = 2;
            this.textBoxLinePoint2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxesPoints_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Точка - 2";
            // 
            // panelRactangleAndEllipse
            // 
            this.panelRactangleAndEllipse.Controls.Add(this.textBoxRecElliHeight);
            this.panelRactangleAndEllipse.Controls.Add(this.textBoxRecEllWidth);
            this.panelRactangleAndEllipse.Controls.Add(this.labelHeight);
            this.panelRactangleAndEllipse.Controls.Add(this.labelWidth);
            this.panelRactangleAndEllipse.Location = new System.Drawing.Point(12, 194);
            this.panelRactangleAndEllipse.Name = "panelRactangleAndEllipse";
            this.panelRactangleAndEllipse.Size = new System.Drawing.Size(244, 58);
            this.panelRactangleAndEllipse.TabIndex = 3;
            this.panelRactangleAndEllipse.Visible = false;
            // 
            // textBoxRecElliHeight
            // 
            this.textBoxRecElliHeight.Location = new System.Drawing.Point(90, 24);
            this.textBoxRecElliHeight.Name = "textBoxRecElliHeight";
            this.textBoxRecElliHeight.Size = new System.Drawing.Size(65, 22);
            this.textBoxRecElliHeight.TabIndex = 4;
            this.textBoxRecElliHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxesSize_KeyPress);
            // 
            // textBoxRecEllWidth
            // 
            this.textBoxRecEllWidth.Location = new System.Drawing.Point(7, 24);
            this.textBoxRecEllWidth.Name = "textBoxRecEllWidth";
            this.textBoxRecEllWidth.Size = new System.Drawing.Size(65, 22);
            this.textBoxRecEllWidth.TabIndex = 3;
            this.textBoxRecEllWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxesSize_KeyPress);
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(87, 4);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(57, 17);
            this.labelHeight.TabIndex = 1;
            this.labelHeight.Text = "Высота";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(7, 4);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(59, 17);
            this.labelWidth.TabIndex = 0;
            this.labelWidth.Text = "Ширина";
            // 
            // panelTriangle
            // 
            this.panelTriangle.Controls.Add(this.textBoxTrianglePoint3);
            this.panelTriangle.Controls.Add(this.label6);
            this.panelTriangle.Controls.Add(this.label5);
            this.panelTriangle.Controls.Add(this.textBoxTrianglePoint2);
            this.panelTriangle.Location = new System.Drawing.Point(12, 259);
            this.panelTriangle.Name = "panelTriangle";
            this.panelTriangle.Size = new System.Drawing.Size(244, 63);
            this.panelTriangle.TabIndex = 4;
            this.panelTriangle.Visible = false;
            // 
            // textBoxTrianglePoint3
            // 
            this.textBoxTrianglePoint3.Location = new System.Drawing.Point(90, 26);
            this.textBoxTrianglePoint3.Name = "textBoxTrianglePoint3";
            this.textBoxTrianglePoint3.Size = new System.Drawing.Size(65, 22);
            this.textBoxTrianglePoint3.TabIndex = 6;
            this.textBoxTrianglePoint3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxesPoints_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Точка - 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Точка - 2";
            // 
            // textBoxTrianglePoint2
            // 
            this.textBoxTrianglePoint2.Location = new System.Drawing.Point(7, 26);
            this.textBoxTrianglePoint2.Name = "textBoxTrianglePoint2";
            this.textBoxTrianglePoint2.Size = new System.Drawing.Size(65, 22);
            this.textBoxTrianglePoint2.TabIndex = 3;
            this.textBoxTrianglePoint2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxesPoints_KeyPress);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(414, 324);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 34);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(314, 324);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(94, 34);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormBasicSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 370);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.panelTriangle);
            this.Controls.Add(this.panelRactangleAndEllipse);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.checkBoxFill);
            this.Controls.Add(this.panelMainSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormBasicSettings";
            this.Text = "Основные настройки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBasicSettings_FormClosed);
            this.Load += new System.EventHandler(this.FormBasicSettings_Load);
            this.panelMainSettings.ResumeLayout(false);
            this.panelMainSettings.PerformLayout();
            this.panelLine.ResumeLayout(false);
            this.panelLine.PerformLayout();
            this.panelRactangleAndEllipse.ResumeLayout(false);
            this.panelRactangleAndEllipse.PerformLayout();
            this.panelTriangle.ResumeLayout(false);
            this.panelTriangle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel panelMainSettings;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPoint1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxThickness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxFill;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.TextBox textBoxLinePoint2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelRactangleAndEllipse;
        private System.Windows.Forms.TextBox textBoxRecElliHeight;
        private System.Windows.Forms.TextBox textBoxRecEllWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Panel panelTriangle;
        private System.Windows.Forms.TextBox textBoxTrianglePoint3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTrianglePoint2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}