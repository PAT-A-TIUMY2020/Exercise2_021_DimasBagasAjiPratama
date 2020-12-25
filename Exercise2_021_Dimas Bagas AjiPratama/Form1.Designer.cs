namespace Exercise2_021_Dimas_Bagas_AjiPratama
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
            this.btncreate = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnseacrh = new System.Windows.Forms.Button();
            this.btnjumlah = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtnim = new System.Windows.Forms.TextBox();
            this.txtprodi = new System.Windows.Forms.TextBox();
            this.txtangkatan = new System.Windows.Forms.TextBox();
            this.lbljumlahdata = new System.Windows.Forms.Label();
            this.btclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Mahasiswa ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(532, 98);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(149, 23);
            this.btncreate.TabIndex = 1;
            this.btncreate.Text = "Tambah Data Baru";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(532, 143);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(149, 23);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Update Data";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(532, 184);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(149, 23);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "Delete Data";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnseacrh
            // 
            this.btnseacrh.Location = new System.Drawing.Point(639, 308);
            this.btnseacrh.Name = "btnseacrh";
            this.btnseacrh.Size = new System.Drawing.Size(149, 23);
            this.btnseacrh.TabIndex = 4;
            this.btnseacrh.Text = "Search Data";
            this.btnseacrh.UseVisualStyleBackColor = true;
            this.btnseacrh.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnjumlah
            // 
            this.btnjumlah.Location = new System.Drawing.Point(639, 371);
            this.btnjumlah.Name = "btnjumlah";
            this.btnjumlah.Size = new System.Drawing.Size(149, 23);
            this.btnjumlah.TabIndex = 5;
            this.btnjumlah.Text = "Jumlah Data";
            this.btnjumlah.UseVisualStyleBackColor = true;
            this.btnjumlah.Click += new System.EventHandler(this.btnjumlah_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(581, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "NIM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Prodi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Angkatan";
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(149, 92);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(263, 22);
            this.txtnama.TabIndex = 11;
            // 
            // txtnim
            // 
            this.txtnim.Location = new System.Drawing.Point(149, 127);
            this.txtnim.Name = "txtnim";
            this.txtnim.Size = new System.Drawing.Size(263, 22);
            this.txtnim.TabIndex = 12;
            // 
            // txtprodi
            // 
            this.txtprodi.Location = new System.Drawing.Point(149, 161);
            this.txtprodi.Name = "txtprodi";
            this.txtprodi.Size = new System.Drawing.Size(263, 22);
            this.txtprodi.TabIndex = 13;
            // 
            // txtangkatan
            // 
            this.txtangkatan.Location = new System.Drawing.Point(149, 196);
            this.txtangkatan.Name = "txtangkatan";
            this.txtangkatan.Size = new System.Drawing.Size(263, 22);
            this.txtangkatan.TabIndex = 14;
            // 
            // lbljumlahdata
            // 
            this.lbljumlahdata.AutoSize = true;
            this.lbljumlahdata.Location = new System.Drawing.Point(693, 397);
            this.lbljumlahdata.Name = "lbljumlahdata";
            this.lbljumlahdata.Size = new System.Drawing.Size(0, 17);
            this.lbljumlahdata.TabIndex = 15;
            // 
            // btclear
            // 
            this.btclear.Location = new System.Drawing.Point(567, 222);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(75, 23);
            this.btclear.TabIndex = 16;
            this.btclear.Text = "Clear";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btclear);
            this.Controls.Add(this.lbljumlahdata);
            this.Controls.Add(this.txtangkatan);
            this.Controls.Add(this.txtprodi);
            this.Controls.Add(this.txtnim);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnjumlah);
            this.Controls.Add(this.btnseacrh);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mahasiswa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnseacrh;
        private System.Windows.Forms.Button btnjumlah;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtnim;
        private System.Windows.Forms.TextBox txtprodi;
        private System.Windows.Forms.TextBox txtangkatan;
        private System.Windows.Forms.Label lbljumlahdata;
        private System.Windows.Forms.Button btclear;
    }
}

