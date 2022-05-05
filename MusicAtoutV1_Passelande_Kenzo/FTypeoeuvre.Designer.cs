
namespace MusicAtoutV1_Passelande_Kenzo
{
    partial class FTypesd_oeuvre
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
            this.bsTypedoeuvre = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTypedoeuvre = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypedoeuvre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypedoeuvre)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTypedoeuvre
            // 
            this.dgvTypedoeuvre.AllowUserToAddRows = false;
            this.dgvTypedoeuvre.AllowUserToDeleteRows = false;
            this.dgvTypedoeuvre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypedoeuvre.Location = new System.Drawing.Point(54, 48);
            this.dgvTypedoeuvre.Name = "dgvTypedoeuvre";
            this.dgvTypedoeuvre.ReadOnly = true;
            this.dgvTypedoeuvre.Size = new System.Drawing.Size(520, 344);
            this.dgvTypedoeuvre.TabIndex = 0;
            // 
            // FTypesd_oeuvre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTypedoeuvre);
            this.Name = "FTypesd_oeuvre";
            this.Text = "FTypesd_oeuvre";
            this.Load += new System.EventHandler(this.FTypesdoeuvre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTypedoeuvre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypedoeuvre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsTypedoeuvre;
        private System.Windows.Forms.DataGridView dgvTypedoeuvre;
    }
}