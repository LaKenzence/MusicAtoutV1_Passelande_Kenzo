
namespace MusicAtoutV1_Passelande_Kenzo
{
    partial class FVille
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
            this.dgvVille = new System.Windows.Forms.DataGridView();
            this.bsVille = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVille)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVille
            // 
            this.dgvVille.AllowUserToAddRows = false;
            this.dgvVille.AllowUserToDeleteRows = false;
            this.dgvVille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVille.Location = new System.Drawing.Point(1, 0);
            this.dgvVille.Name = "dgvVille";
            this.dgvVille.ReadOnly = true;
            this.dgvVille.Size = new System.Drawing.Size(477, 327);
            this.dgvVille.TabIndex = 0;
            this.dgvVille.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVille);
            this.Name = "FVille";
            this.Text = "FVille";
            this.Load += new System.EventHandler(this.FVille_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVille)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVille;
        private System.Windows.Forms.BindingSource bsVille;
    }
}