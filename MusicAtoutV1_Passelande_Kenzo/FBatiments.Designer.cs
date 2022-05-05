
namespace MusicAtoutV1_Passelande_Kenzo
{
    partial class FBatiments
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
            this.bsBatiment = new System.Windows.Forms.BindingSource(this.components);
            this.dgvBatiment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bsBatiment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatiment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBatiment
            // 
            this.dgvBatiment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatiment.Location = new System.Drawing.Point(61, 37);
            this.dgvBatiment.Name = "dgvBatiment";
            this.dgvBatiment.Size = new System.Drawing.Size(667, 370);
            this.dgvBatiment.TabIndex = 1;
            // 
            // FBatiments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvBatiment);
            this.Name = "FBatiments";
            this.ShowIcon = false;
            this.Text = "FBatiments";
            this.Load += new System.EventHandler(this.FBatiments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsBatiment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatiment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsBatiment;
        private System.Windows.Forms.DataGridView dgvBatiment;
    }
}