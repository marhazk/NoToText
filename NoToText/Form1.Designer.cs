namespace NoToText
{
    partial class Form1
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
            this.txtIn = new System.Windows.Forms.TextBox();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnGen2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGen3 = new System.Windows.Forms.Button();
            this.btnGen4 = new System.Windows.Forms.Button();
            this.btnGen6 = new System.Windows.Forms.Button();
            this.btnGen5 = new System.Windows.Forms.Button();
            this.btnDHaz = new System.Windows.Forms.Button();
            this.btnHaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(12, 37);
            this.txtIn.Multiline = true;
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(318, 183);
            this.txtIn.TabIndex = 0;
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(345, 37);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(332, 183);
            this.txtOut.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(218, 226);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "&Num to Text";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnGen2
            // 
            this.btnGen2.Location = new System.Drawing.Point(218, 255);
            this.btnGen2.Name = "btnGen2";
            this.btnGen2.Size = new System.Drawing.Size(112, 23);
            this.btnGen2.TabIndex = 3;
            this.btnGen2.Text = "&Text To Num";
            this.btnGen2.UseVisualStyleBackColor = true;
            this.btnGen2.Click += new System.EventHandler(this.btnGen2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Developed by MarHazK / Marhazli Kipli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Coded Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Decoded Message";
            // 
            // btnGen3
            // 
            this.btnGen3.Location = new System.Drawing.Point(336, 226);
            this.btnGen3.Name = "btnGen3";
            this.btnGen3.Size = new System.Drawing.Size(112, 23);
            this.btnGen3.TabIndex = 7;
            this.btnGen3.Text = "&Hex to Text";
            this.btnGen3.UseVisualStyleBackColor = true;
            this.btnGen3.Click += new System.EventHandler(this.btnGen3_Click);
            // 
            // btnGen4
            // 
            this.btnGen4.Location = new System.Drawing.Point(336, 255);
            this.btnGen4.Name = "btnGen4";
            this.btnGen4.Size = new System.Drawing.Size(112, 23);
            this.btnGen4.TabIndex = 8;
            this.btnGen4.Text = "&T&ext to Hex";
            this.btnGen4.UseVisualStyleBackColor = true;
            this.btnGen4.Click += new System.EventHandler(this.btnGen4_Click);
            // 
            // btnGen6
            // 
            this.btnGen6.Location = new System.Drawing.Point(454, 255);
            this.btnGen6.Name = "btnGen6";
            this.btnGen6.Size = new System.Drawing.Size(112, 23);
            this.btnGen6.TabIndex = 9;
            this.btnGen6.Text = "&Text t&o MD5";
            this.btnGen6.UseVisualStyleBackColor = true;
            this.btnGen6.Click += new System.EventHandler(this.btnGen6_Click);
            // 
            // btnGen5
            // 
            this.btnGen5.Location = new System.Drawing.Point(454, 226);
            this.btnGen5.Name = "btnGen5";
            this.btnGen5.Size = new System.Drawing.Size(112, 23);
            this.btnGen5.TabIndex = 10;
            this.btnGen5.Text = "&MD5 to Text";
            this.btnGen5.UseVisualStyleBackColor = true;
            this.btnGen5.Click += new System.EventHandler(this.btnGen5_Click);
            // 
            // btnDHaz
            // 
            this.btnDHaz.Enabled = false;
            this.btnDHaz.Location = new System.Drawing.Point(570, 255);
            this.btnDHaz.Name = "btnDHaz";
            this.btnDHaz.Size = new System.Drawing.Size(112, 23);
            this.btnDHaz.TabIndex = 12;
            this.btnDHaz.Text = "Text to H4&Z";
            this.btnDHaz.UseVisualStyleBackColor = true;
            this.btnDHaz.Click += new System.EventHandler(this.btnDHaz_Click);
            // 
            // btnHaz
            // 
            this.btnHaz.Enabled = false;
            this.btnHaz.Location = new System.Drawing.Point(570, 226);
            this.btnHaz.Name = "btnHaz";
            this.btnHaz.Size = new System.Drawing.Size(112, 23);
            this.btnHaz.TabIndex = 11;
            this.btnHaz.Text = "&H4Z to Text";
            this.btnHaz.UseVisualStyleBackColor = true;
            this.btnHaz.Click += new System.EventHandler(this.btnHaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 284);
            this.Controls.Add(this.btnDHaz);
            this.Controls.Add(this.btnHaz);
            this.Controls.Add(this.btnGen5);
            this.Controls.Add(this.btnGen6);
            this.Controls.Add(this.btnGen4);
            this.Controls.Add(this.btnGen3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGen2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtIn);
            this.Name = "Form1";
            this.Text = "Numthography by MarHazK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnGen2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGen3;
        private System.Windows.Forms.Button btnGen4;
        private System.Windows.Forms.Button btnGen6;
        private System.Windows.Forms.Button btnGen5;
        private System.Windows.Forms.Button btnDHaz;
        private System.Windows.Forms.Button btnHaz;
    }
}

