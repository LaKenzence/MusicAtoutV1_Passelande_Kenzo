
namespace MusicAtoutV1_Passelande_Kenzo
{
    partial class FSalle
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
            this.bsSalle = new System.Windows.Forms.BindingSource(this.components);
            this.dgvSalle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bsSalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalle
            // 
            this.dgvSalle.AllowUserToAddRows = false;
            this.dgvSalle.AllowUserToDeleteRows = false;
            this.dgvSalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalle.Location = new System.Drawing.Point(31, 26);
            this.dgvSalle.Name = "dgvSalle";
            this.dgvSalle.ReadOnly = true;
            this.dgvSalle.Size = new System.Drawing.Size(594, 304);
            this.dgvSalle.TabIndex = 0;
            this.dgvSalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalle_CellContentClick);
            // 
            // FSalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSalle);
            this.Name = "FSalle";
            this.Text = "FSalles";
            this.Load += new System.EventHandler(this.FSalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsSalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsSalle;
        private System.Windows.Forms.DataGridView dgvSalle;
    }
}