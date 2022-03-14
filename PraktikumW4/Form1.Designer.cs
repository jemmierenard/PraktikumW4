namespace PraktikumW4
{
    partial class FormAddData
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAddNama = new System.Windows.Forms.Label();
            this.lblAddAlamat = new System.Windows.Forms.Label();
            this.lblAddTelp = new System.Windows.Forms.Label();
            this.tboxAddNama = new System.Windows.Forms.TextBox();
            this.tboxAddAlamat = new System.Windows.Forms.TextBox();
            this.tboxAddTelp = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnLihatData = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.SuspendLayout();
            // 
            // lblAddNama
            // 
            this.lblAddNama.AutoSize = true;
            this.lblAddNama.Location = new System.Drawing.Point(37, 48);
            this.lblAddNama.Name = "lblAddNama";
            this.lblAddNama.Size = new System.Drawing.Size(52, 20);
            this.lblAddNama.TabIndex = 0;
            this.lblAddNama.Text = "Nama:";
            // 
            // lblAddAlamat
            // 
            this.lblAddAlamat.AutoSize = true;
            this.lblAddAlamat.Location = new System.Drawing.Point(37, 99);
            this.lblAddAlamat.Name = "lblAddAlamat";
            this.lblAddAlamat.Size = new System.Drawing.Size(60, 20);
            this.lblAddAlamat.TabIndex = 1;
            this.lblAddAlamat.Text = "Alamat:";
            // 
            // lblAddTelp
            // 
            this.lblAddTelp.AutoSize = true;
            this.lblAddTelp.Location = new System.Drawing.Point(37, 141);
            this.lblAddTelp.Name = "lblAddTelp";
            this.lblAddTelp.Size = new System.Drawing.Size(40, 20);
            this.lblAddTelp.TabIndex = 2;
            this.lblAddTelp.Text = "Telp:";
            // 
            // tboxAddNama
            // 
            this.tboxAddNama.Location = new System.Drawing.Point(131, 48);
            this.tboxAddNama.Name = "tboxAddNama";
            this.tboxAddNama.Size = new System.Drawing.Size(292, 27);
            this.tboxAddNama.TabIndex = 3;
            this.tboxAddNama.TextChanged += new System.EventHandler(this.tboxAddNama_TextChanged);
            // 
            // tboxAddAlamat
            // 
            this.tboxAddAlamat.Location = new System.Drawing.Point(132, 96);
            this.tboxAddAlamat.Name = "tboxAddAlamat";
            this.tboxAddAlamat.Size = new System.Drawing.Size(428, 27);
            this.tboxAddAlamat.TabIndex = 4;
            // 
            // tboxAddTelp
            // 
            this.tboxAddTelp.Location = new System.Drawing.Point(131, 138);
            this.tboxAddTelp.Name = "tboxAddTelp";
            this.tboxAddTelp.Size = new System.Drawing.Size(138, 27);
            this.tboxAddTelp.TabIndex = 5;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(37, 201);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(94, 29);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnLihatData
            // 
            this.btnLihatData.Location = new System.Drawing.Point(175, 201);
            this.btnLihatData.Name = "btnLihatData";
            this.btnLihatData.Size = new System.Drawing.Size(94, 29);
            this.btnLihatData.TabIndex = 7;
            this.btnLihatData.Text = "Lihat Data";
            this.btnLihatData.UseVisualStyleBackColor = true;
            this.btnLihatData.Click += new System.EventHandler(this.btnLihatData_Click);
            // 
            // FormAddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 296);
            this.Controls.Add(this.btnLihatData);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.tboxAddTelp);
            this.Controls.Add(this.tboxAddAlamat);
            this.Controls.Add(this.tboxAddNama);
            this.Controls.Add(this.lblAddTelp);
            this.Controls.Add(this.lblAddAlamat);
            this.Controls.Add(this.lblAddNama);
            this.Name = "FormAddData";
            this.Text = "Form Penambahan Data";
            this.Load += new System.EventHandler(this.FormAddData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddNama;
        private System.Windows.Forms.Label lblAddAlamat;
        private System.Windows.Forms.Label lblAddTelp;
        private System.Windows.Forms.TextBox tboxAddNama;
        private System.Windows.Forms.TextBox tboxAddAlamat;
        private System.Windows.Forms.TextBox tboxAddTelp;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnLihatData;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}
