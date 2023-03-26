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
            this.nameL = new System.Windows.Forms.Label();
            this.epl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.RichTextBox();
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
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameL.Location = new System.Drawing.Point(418, 12);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(248, 29);
            this.nameL.TabIndex = 1;
            this.nameL.Text = "Имя: testTesttestTest";
            // 
            // epl
            // 
            this.epl.AutoSize = true;
            this.epl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.epl.Location = new System.Drawing.Point(418, 41);
            this.epl.Name = "epl";
            this.epl.Size = new System.Drawing.Size(353, 29);
            this.epl.TabIndex = 2;
            this.epl.Text = "Email\\Phone...: testTesttestTest";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(418, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Секретный код:";
            // 
            // sec
            // 
            this.sec.Location = new System.Drawing.Point(423, 102);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(546, 310);
            this.sec.TabIndex = 4;
            this.sec.Text = "";
            // 
            // qrAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 424);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.epl);
            this.Controls.Add(this.nameL);
            this.Controls.Add(this.qrcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "qrAuth";
            ((System.ComponentModel.ISupportInitialize)(this.qrcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox qrcode;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.Label epl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox sec;
    }
}