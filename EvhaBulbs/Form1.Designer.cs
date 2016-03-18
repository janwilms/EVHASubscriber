namespace EvhaBulbs
{
    partial class EvhaBulbs
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblPrime = new System.Windows.Forms.Label();
            this.pbPrime = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrimeDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(18, 71);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(302, 52);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start listening";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(438, 71);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(302, 52);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop listening";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // listBoxLog
            // 
            this.listBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 31;
            this.listBoxLog.Location = new System.Drawing.Point(18, 147);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(722, 1027);
            this.listBoxLog.TabIndex = 4;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(18, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(89, 46);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "port";
            // 
            // lblPrime
            // 
            this.lblPrime.AutoSize = true;
            this.lblPrime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrime.Location = new System.Drawing.Point(762, 147);
            this.lblPrime.Name = "lblPrime";
            this.lblPrime.Size = new System.Drawing.Size(1100, 46);
            this.lblPrime.TabIndex = 6;
            this.lblPrime.Text = "The light will turn red when the incoming id is a prime number";
            // 
            // pbPrime
            // 
            this.pbPrime.Location = new System.Drawing.Point(1048, 249);
            this.pbPrime.Name = "pbPrime";
            this.pbPrime.Size = new System.Drawing.Size(500, 500);
            this.pbPrime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrime.TabIndex = 7;
            this.pbPrime.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(929, 814);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Last prime number";
            // 
            // lblPrimeDisplay
            // 
            this.lblPrimeDisplay.AutoSize = true;
            this.lblPrimeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeDisplay.Location = new System.Drawing.Point(1316, 802);
            this.lblPrimeDisplay.Name = "lblPrimeDisplay";
            this.lblPrimeDisplay.Size = new System.Drawing.Size(172, 61);
            this.lblPrimeDisplay.TabIndex = 9;
            this.lblPrimeDisplay.Text = "#####";
            // 
            // EvhaBulbs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1956, 1191);
            this.Controls.Add(this.lblPrimeDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPrime);
            this.Controls.Add(this.lblPrime);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "EvhaBulbs";
            this.Text = "EvhaBulbs";
            ((System.ComponentModel.ISupportInitialize)(this.pbPrime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblPrime;
        private System.Windows.Forms.PictureBox pbPrime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrimeDisplay;
    }
}

