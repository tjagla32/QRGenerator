namespace ReloadPage
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            this.comboBoxECC = new System.Windows.Forms.ComboBox();
            this.textBoxQRCode = new System.Windows.Forms.TextBox();
            this.iconSize = new System.Windows.Forms.NumericUpDown();
            this.labelIconsize = new System.Windows.Forms.Label();
            this.iconPath = new System.Windows.Forms.TextBox();
            this.labelIcon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSize)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "zdjęcie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(530, 319);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.Location = new System.Drawing.Point(57, 129);
            this.pictureBoxQRCode.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(110, 97);
            this.pictureBoxQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQRCode.TabIndex = 4;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // comboBoxECC
            // 
            this.comboBoxECC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxECC.FormattingEnabled = true;
            this.comboBoxECC.Items.AddRange(new object[] {
            "L",
            "M",
            "Q",
            "H"});
            this.comboBoxECC.Location = new System.Drawing.Point(40, 66);
            this.comboBoxECC.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxECC.Name = "comboBoxECC";
            this.comboBoxECC.Size = new System.Drawing.Size(165, 24);
            this.comboBoxECC.TabIndex = 5;
            // 
            // textBoxQRCode
            // 
            this.textBoxQRCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQRCode.Location = new System.Drawing.Point(273, 66);
            this.textBoxQRCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQRCode.Name = "textBoxQRCode";
            this.textBoxQRCode.Size = new System.Drawing.Size(524, 22);
            this.textBoxQRCode.TabIndex = 6;
            this.textBoxQRCode.Text = "1234567890";
            this.textBoxQRCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // iconSize
            // 
            this.iconSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconSize.Location = new System.Drawing.Point(114, 516);
            this.iconSize.Margin = new System.Windows.Forms.Padding(4);
            this.iconSize.Name = "iconSize";
            this.iconSize.Size = new System.Drawing.Size(167, 22);
            this.iconSize.TabIndex = 13;
            this.iconSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelIconsize
            // 
            this.labelIconsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIconsize.AutoSize = true;
            this.labelIconsize.Location = new System.Drawing.Point(34, 521);
            this.labelIconsize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIconsize.Name = "labelIconsize";
            this.labelIconsize.Size = new System.Drawing.Size(67, 17);
            this.labelIconsize.TabIndex = 12;
            this.labelIconsize.Text = "Icon size:";
            // 
            // iconPath
            // 
            this.iconPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconPath.Location = new System.Drawing.Point(360, 517);
            this.iconPath.Margin = new System.Windows.Forms.Padding(4);
            this.iconPath.Name = "iconPath";
            this.iconPath.Size = new System.Drawing.Size(196, 22);
            this.iconPath.TabIndex = 11;
            // 
            // labelIcon
            // 
            this.labelIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIcon.AutoSize = true;
            this.labelIcon.Location = new System.Drawing.Point(311, 521);
            this.labelIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIcon.Name = "labelIcon";
            this.labelIcon.Size = new System.Drawing.Size(38, 17);
            this.labelIcon.TabIndex = 10;
            this.labelIcon.Text = "Icon:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 612);
            this.Controls.Add(this.iconSize);
            this.Controls.Add(this.labelIconsize);
            this.Controls.Add(this.iconPath);
            this.Controls.Add(this.labelIcon);
            this.Controls.Add(this.textBoxQRCode);
            this.Controls.Add(this.comboBoxECC);
            this.Controls.Add(this.pictureBoxQRCode);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
        private System.Windows.Forms.ComboBox comboBoxECC;
        private System.Windows.Forms.TextBox textBoxQRCode;
        private System.Windows.Forms.NumericUpDown iconSize;
        private System.Windows.Forms.Label labelIconsize;
        private System.Windows.Forms.TextBox iconPath;
        private System.Windows.Forms.Label labelIcon;
    }
}

