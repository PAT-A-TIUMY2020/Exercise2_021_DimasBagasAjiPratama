namespace Server_021_DimasBagasAjiPratama
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblonoff = new System.Windows.Forms.Label();
            this.lblmessage = new System.Windows.Forms.Label();
            this.btnon = new System.Windows.Forms.Button();
            this.btnoff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server ";
            // 
            // lblonoff
            // 
            this.lblonoff.AutoSize = true;
            this.lblonoff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblonoff.Location = new System.Drawing.Point(363, 109);
            this.lblonoff.Name = "lblonoff";
            this.lblonoff.Size = new System.Drawing.Size(0, 17);
            this.lblonoff.TabIndex = 1;
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmessage.Location = new System.Drawing.Point(363, 166);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 17);
            this.lblmessage.TabIndex = 2;
            // 
            // btnon
            // 
            this.btnon.Location = new System.Drawing.Point(220, 257);
            this.btnon.Name = "btnon";
            this.btnon.Size = new System.Drawing.Size(75, 23);
            this.btnon.TabIndex = 3;
            this.btnon.Text = "ON";
            this.btnon.UseVisualStyleBackColor = true;
            this.btnon.Click += new System.EventHandler(this.btnon_Click);
            // 
            // btnoff
            // 
            this.btnoff.Location = new System.Drawing.Point(451, 257);
            this.btnoff.Name = "btnoff";
            this.btnoff.Size = new System.Drawing.Size(75, 23);
            this.btnoff.TabIndex = 4;
            this.btnoff.Text = "OFF";
            this.btnoff.UseVisualStyleBackColor = true;
            this.btnoff.Click += new System.EventHandler(this.btnoff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnoff);
            this.Controls.Add(this.btnon);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.lblonoff);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblonoff;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Button btnon;
        private System.Windows.Forms.Button btnoff;
    }
}

