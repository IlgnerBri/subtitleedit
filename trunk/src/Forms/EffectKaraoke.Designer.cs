﻿namespace Nikse.SubtitleEdit.Forms
{
    sealed partial class EffectKaraoke
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
            this.components = new System.ComponentModel.Container();
            this.labelTotalMillisecs = new System.Windows.Forms.Label();
            this.labelTM = new System.Windows.Forms.Label();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelEndDelay = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonChooseColor = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.labelChooseColor = new System.Windows.Forms.Label();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richTextBoxPreview = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotalMillisecs
            // 
            this.labelTotalMillisecs.AutoSize = true;
            this.labelTotalMillisecs.Location = new System.Drawing.Point(120, 57);
            this.labelTotalMillisecs.Name = "labelTotalMillisecs";
            this.labelTotalMillisecs.Size = new System.Drawing.Size(108, 17);
            this.labelTotalMillisecs.TabIndex = 49;
            this.labelTotalMillisecs.Text = "labelTotalMillisecs";
            // 
            // labelTM
            // 
            this.labelTM.AutoSize = true;
            this.labelTM.Location = new System.Drawing.Point(44, 56);
            this.labelTM.Name = "labelTM";
            this.labelTM.Size = new System.Drawing.Size(97, 17);
            this.labelTM.TabIndex = 48;
            this.labelTM.Text = "Total millisecs.:";
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.DecimalPlaces = 3;
            this.numericUpDownDelay.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownDelay.Location = new System.Drawing.Point(156, 77);
            this.numericUpDownDelay.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownDelay.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Size = new System.Drawing.Size(54, 24);
            this.numericUpDownDelay.TabIndex = 47;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(180, 22);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(40, 17);
            this.labelColor.TabIndex = 46;
            this.labelColor.Text = "Color";
            // 
            // labelEndDelay
            // 
            this.labelEndDelay.AutoSize = true;
            this.labelEndDelay.Location = new System.Drawing.Point(10, 78);
            this.labelEndDelay.Name = "labelEndDelay";
            this.labelEndDelay.Size = new System.Drawing.Size(141, 17);
            this.labelEndDelay.TabIndex = 45;
            this.labelEndDelay.Text = "End delay in millisecs.:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(353, 181);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 21);
            this.buttonCancel.TabIndex = 44;
            this.buttonCancel.Text = "C&ancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(272, 181);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 21);
            this.buttonOK.TabIndex = 43;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOkClick);
            // 
            // buttonChooseColor
            // 
            this.buttonChooseColor.Location = new System.Drawing.Point(121, 17);
            this.buttonChooseColor.Name = "buttonChooseColor";
            this.buttonChooseColor.Size = new System.Drawing.Size(27, 23);
            this.buttonChooseColor.TabIndex = 42;
            this.buttonChooseColor.Text = "...";
            this.buttonChooseColor.UseVisualStyleBackColor = true;
            this.buttonChooseColor.Click += new System.EventHandler(this.ButtonChooseColorClick);
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(154, 19);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(20, 20);
            this.panelColor.TabIndex = 41;
            // 
            // labelChooseColor
            // 
            this.labelChooseColor.AutoSize = true;
            this.labelChooseColor.Location = new System.Drawing.Point(29, 20);
            this.labelChooseColor.Name = "labelChooseColor";
            this.labelChooseColor.Size = new System.Drawing.Size(93, 17);
            this.labelChooseColor.TabIndex = 40;
            this.labelChooseColor.Text = "Choose color:";
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(12, 154);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(75, 21);
            this.buttonPreview.TabIndex = 39;
            this.buttonPreview.Text = "Preview";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.ButtonPreviewClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // richTextBoxPreview
            // 
            this.richTextBoxPreview.BackColor = System.Drawing.Color.Black;
            this.richTextBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxPreview.DetectUrls = false;
            this.richTextBoxPreview.Location = new System.Drawing.Point(13, 99);
            this.richTextBoxPreview.Name = "richTextBoxPreview";
            this.richTextBoxPreview.ReadOnly = true;
            this.richTextBoxPreview.Size = new System.Drawing.Size(415, 49);
            this.richTextBoxPreview.TabIndex = 50;
            this.richTextBoxPreview.TabStop = false;
            this.richTextBoxPreview.Text = "";
            // 
            // EffectKaraoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 208);
            this.Controls.Add(this.richTextBoxPreview);
            this.Controls.Add(this.labelTotalMillisecs);
            this.Controls.Add(this.labelTM);
            this.Controls.Add(this.numericUpDownDelay);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelEndDelay);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonChooseColor);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.labelChooseColor);
            this.Controls.Add(this.buttonPreview);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EffectKaraoke";
            this.Text = "Karaoke effect";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEffectkaraoke_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalMillisecs;
        private System.Windows.Forms.Label labelTM;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelEndDelay;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonChooseColor;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label labelChooseColor;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox richTextBoxPreview;
    }
}