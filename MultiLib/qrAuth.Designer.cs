namespace MultiLib
{
    partial class qrAuth
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
            this.qrcode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.qrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // qrcode
            // 
            this.qrcode.Location = new System.Drawing.Point(12, 12);
            this.qrcode.Name = "qrcode";
            this.qrcode.Size = new System.Drawing.Size(400, 400);
            this.qrcode.TabIndex = 0;
            this.qrcode.TabStop = false;
            this.qrcode.Click += new System.EventHandler(this.qrcode_Click);
            // 
            // qrAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 424);
            this.Controls.Add(this.qrcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "qrAuth";
            ((System.ComponentModel.ISupportInitialize)(this.qrcode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox qrcode;
    }
}