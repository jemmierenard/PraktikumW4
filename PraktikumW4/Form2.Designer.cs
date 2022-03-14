namespace PraktikumW4
{
    partial class FormShowData
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
            this.lblShowNama = new System.Windows.Forms.Label();
            this.lblShowAlamat = new System.Windows.Forms.Label();
            this.lblShowTelp = new System.Windows.Forms.Label();
            this.tboxShowNama = new System.Windows.Forms.TextBox();
            this.tboxShowAlamat = new System.Windows.Forms.TextBox();
            this.tboxShowTelp = new System.Windows.Forms.TextBox();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShowNama
            // 
            this.lblShowNama.AutoSize = true;
            this.lblShowNama.Location = new System.Drawing.Point(29, 40);
            this.lblShowNama.Name = "lblShowNama";
            this.lblShowNama.Size = new System.Drawing.Size(52, 20);
            this.lblShowNama.TabIndex = 0;
            this.lblShowNama.Text = "Nama:";
            // 
            // lblShowAlamat
            // 
            this.lblShowAlamat.AutoSize = true;
            this.lblShowAlamat.Location = new System.Drawing.Point(29, 85);
            this.lblShowAlamat.Name = "lblShowAlamat";
            this.lblShowAlamat.Size = new System.Drawing.Size(60, 20);
            this.lblShowAlamat.TabIndex = 1;
            this.lblShowAlamat.Text = "Alamat:";
            // 
            // lblShowTelp
            // 
            this.lblShowTelp.AutoSize = true;
            this.lblShowTelp.Location = new System.Drawing.Point(29, 132);
            this.lblShowTelp.Name = "lblShowTelp";
            this.lblShowTelp.Size = new System.Drawing.Size(40, 20);
            this.lblShowTelp.TabIndex = 2;
            this.lblShowTelp.Text = "Telp:";
            // 
            // tboxShowNama
            // 
            this.tboxShowNama.Enabled = false;
            this.tboxShowNama.Location = new System.Drawing.Point(110, 40);
            this.tboxShowNama.Name = "tboxShowNama";
            this.tboxShowNama.Size = new System.Drawing.Size(337, 27);
            this.tboxShowNama.TabIndex = 3;
            // 
            // tboxShowAlamat
            // 
            this.tboxShowAlamat.Enabled = false;
            this.tboxShowAlamat.Location = new System.Drawing.Point(110, 85);
            this.tboxShowAlamat.Name = "tboxShowAlamat";
            this.tboxShowAlamat.Size = new System.Drawing.Size(447, 27);
            this.tboxShowAlamat.TabIndex = 4;
            // 
            // tboxShowTelp
            // 
            this.tboxShowTelp.Enabled = false;
            this.tboxShowTelp.Location = new System.Drawing.Point(110, 132);
            this.tboxShowTelp.Name = "tboxShowTelp";
            this.tboxShowTelp.Size = new System.Drawing.Size(125, 27);
            this.tboxShowTelp.TabIndex = 5;
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(29, 197);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(94, 29);
            this.btnKembali.TabIndex = 6;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(166, 197);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(94, 29);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "Prev Data";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(304, 197);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next Data";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // FormShowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 279);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.tboxShowTelp);
            this.Controls.Add(this.tboxShowAlamat);
            this.Controls.Add(this.tboxShowNama);
            this.Controls.Add(this.lblShowTelp);
            this.Controls.Add(this.lblShowAlamat);
            this.Controls.Add(this.lblShowNama);
            this.Name = "FormShowData";
            this.Text = "Form Tampilan Data";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowNama;
        private System.Windows.Forms.Label lblShowAlamat;
        private System.Windows.Forms.Label lblShowTelp;
        private System.Windows.Forms.TextBox tboxShowNama;
        private System.Windows.Forms.TextBox tboxShowAlamat;
        private System.Windows.Forms.TextBox tboxShowTelp;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
    }
}