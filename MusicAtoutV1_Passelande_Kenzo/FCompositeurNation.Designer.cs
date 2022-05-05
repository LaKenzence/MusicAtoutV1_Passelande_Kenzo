
namespace MusicAtoutV1_Passelande_Kenzo
{
    partial class FCompositeurNation
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
            this.dgvCompositeur = new System.Windows.Forms.DataGridView();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNation = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnSuppression = new System.Windows.Forms.Button();
            this.bsCompositeur = new System.Windows.Forms.BindingSource(this.components);
            this.bsNation = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompositeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompositeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompositeur
            // 
            this.dgvCompositeur.AllowUserToAddRows = false;
            this.dgvCompositeur.AllowUserToDeleteRows = false;
            this.dgvCompositeur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompositeur.Location = new System.Drawing.Point(47, 56);
            this.dgvCompositeur.Name = "dgvCompositeur";
            this.dgvCompositeur.ReadOnly = true;
            this.dgvCompositeur.Size = new System.Drawing.Size(690, 210);
            this.dgvCompositeur.TabIndex = 0;
            this.dgvCompositeur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompositeur_CellContentClick);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nationalité :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboNation
            // 
            this.cboNation.FormattingEnabled = true;
            this.cboNation.Location = new System.Drawing.Point(82, 9);
            this.cboNation.Name = "cboNation";
            this.cboNation.Size = new System.Drawing.Size(121, 21);
            this.cboNation.TabIndex = 2;
            this.cboNation.Text = "Française";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Toutes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(47, 297);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(75, 23);
            this.btnAjout.TabIndex = 4;
            this.btnAjout.Text = "AJOUT";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(153, 297);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(96, 23);
            this.btnModif.TabIndex = 5;
            this.btnModif.Text = "MODIFICATION";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSuppression
            // 
            this.btnSuppression.Location = new System.Drawing.Point(283, 297);
            this.btnSuppression.Name = "btnSuppression";
            this.btnSuppression.Size = new System.Drawing.Size(93, 23);
            this.btnSuppression.TabIndex = 6;
            this.btnSuppression.Text = "SUPPRESSION";
            this.btnSuppression.UseVisualStyleBackColor = true;
            this.btnSuppression.Click += new System.EventHandler(this.btnSuppression_Click);
            // 
            // bsCompositeur
            // 
            this.bsCompositeur.CurrentChanged += new System.EventHandler(this.bsCompositeur_CurrentChanged);
            // 
            // bsNation
            // 
            this.bsNation.CurrentChanged += new System.EventHandler(this.bsNation_CurrentChanged);
            // 
            // FCompositeurNation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSuppression);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboNation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCompositeur);
            this.Name = "FCompositeurNation";
            this.Text = "FCompositeurNation";
            this.Load += new System.EventHandler(this.FCompositeurNation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompositeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompositeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompositeur;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.BindingSource bsCompositeur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNation;
        private System.Windows.Forms.BindingSource bsNation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnSuppression;
    }
}