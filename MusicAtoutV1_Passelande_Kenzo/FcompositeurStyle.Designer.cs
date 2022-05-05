
namespace MusicAtoutV1_Passelande_Kenzo
{
    partial class FcompositeurStyle
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCompositeur = new System.Windows.Forms.DataGridView();
            this.cboStyle = new System.Windows.Forms.ComboBox();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDebut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRemarque = new System.Windows.Forms.TextBox();
            this.txtDécès = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNaissance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStyle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNationalité = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSelectionné = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvOeuvre = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bsCompositeur = new System.Windows.Forms.BindingSource(this.components);
            this.bsStyle = new System.Windows.Forms.BindingSource(this.components);
            this.bsOeuvre = new System.Windows.Forms.BindingSource(this.components);
            this.bsNation = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompositeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOeuvre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompositeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOeuvre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sélectionner un style ou une époque";
            // 
            // dgvCompositeur
            // 
            this.dgvCompositeur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompositeur.Location = new System.Drawing.Point(12, 281);
            this.dgvCompositeur.Name = "dgvCompositeur";
            this.dgvCompositeur.Size = new System.Drawing.Size(362, 360);
            this.dgvCompositeur.TabIndex = 1;
            this.dgvCompositeur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompositeur_CellContentClick);
            // 
            // cboStyle
            // 
            this.cboStyle.FormattingEnabled = true;
            this.cboStyle.Location = new System.Drawing.Point(12, 133);
            this.cboStyle.Name = "cboStyle";
            this.cboStyle.Size = new System.Drawing.Size(273, 21);
            this.cboStyle.TabIndex = 2;
            this.cboStyle.SelectedIndexChanged += new System.EventHandler(this.cboStyle_SelectedIndexChanged);
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(132, 216);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(100, 20);
            this.txtFin.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fin du style";
            // 
            // txtDebut
            // 
            this.txtDebut.Location = new System.Drawing.Point(12, 216);
            this.txtDebut.Name = "txtDebut";
            this.txtDebut.Size = new System.Drawing.Size(94, 20);
            this.txtDebut.TabIndex = 9;
            this.txtDebut.TextChanged += new System.EventHandler(this.txtDebut_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Début du style";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Compositeurs de ce style";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(1249, 618);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 62;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(586, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Les oeuvres de ce compositeur";
            // 
            // txtRemarque
            // 
            this.txtRemarque.Location = new System.Drawing.Point(589, 193);
            this.txtRemarque.Name = "txtRemarque";
            this.txtRemarque.Size = new System.Drawing.Size(562, 20);
            this.txtRemarque.TabIndex = 60;
            // 
            // txtDécès
            // 
            this.txtDécès.Location = new System.Drawing.Point(930, 147);
            this.txtDécès.Name = "txtDécès";
            this.txtDécès.Size = new System.Drawing.Size(82, 20);
            this.txtDécès.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(863, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "Décès";
            // 
            // txtNaissance
            // 
            this.txtNaissance.Location = new System.Drawing.Point(754, 151);
            this.txtNaissance.Name = "txtNaissance";
            this.txtNaissance.Size = new System.Drawing.Size(82, 20);
            this.txtNaissance.TabIndex = 57;
            this.txtNaissance.TextChanged += new System.EventHandler(this.txtNaissance_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(586, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Naissance";
            // 
            // txtStyle
            // 
            this.txtStyle.Location = new System.Drawing.Point(1045, 94);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.Size = new System.Drawing.Size(106, 20);
            this.txtStyle.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(965, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Style";
            // 
            // txtNationalité
            // 
            this.txtNationalité.Location = new System.Drawing.Point(754, 98);
            this.txtNationalité.Name = "txtNationalité";
            this.txtNationalité.Size = new System.Drawing.Size(147, 20);
            this.txtNationalité.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Nationalité";
            // 
            // txtSelectionné
            // 
            this.txtSelectionné.Location = new System.Drawing.Point(754, 52);
            this.txtSelectionné.Name = "txtSelectionné";
            this.txtSelectionné.Size = new System.Drawing.Size(397, 20);
            this.txtSelectionné.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Vous avez sélectionné";
            // 
            // dgvOeuvre
            // 
            this.dgvOeuvre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOeuvre.Location = new System.Drawing.Point(589, 272);
            this.dgvOeuvre.Name = "dgvOeuvre";
            this.dgvOeuvre.Size = new System.Drawing.Size(562, 369);
            this.dgvOeuvre.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicAtoutV1_Passelande_Kenzo.Properties.Resources.cle_de_sol;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // bsCompositeur
            // 
            this.bsCompositeur.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // bsStyle
            // 
            this.bsStyle.CurrentChanged += new System.EventHandler(this.bsStyle_CurrentChanged);
            // 
            // bsOeuvre
            // 
            this.bsOeuvre.CurrentChanged += new System.EventHandler(this.bsOeuvre_CurrentChanged);
            // 
            // bsNation
            // 
            this.bsNation.CurrentChanged += new System.EventHandler(this.bsNation_CurrentChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(104, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 64;
            this.label11.Text = "Atout";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // FcompositeurStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 653);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRemarque);
            this.Controls.Add(this.txtDécès);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNaissance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtStyle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNationalité);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSelectionné);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvOeuvre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDebut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboStyle);
            this.Controls.Add(this.dgvCompositeur);
            this.Controls.Add(this.label1);
            this.Name = "FcompositeurStyle";
            this.Text = "FcompositeurStyle";
            this.Load += new System.EventHandler(this.FcompositeurStyle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompositeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOeuvre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompositeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOeuvre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCompositeur;
        private System.Windows.Forms.ComboBox cboStyle;
        private System.Windows.Forms.BindingSource bsCompositeur;
        private System.Windows.Forms.BindingSource bsStyle;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDebut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bsOeuvre;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRemarque;
        private System.Windows.Forms.TextBox txtDécès;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNaissance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStyle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNationalité;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSelectionné;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvOeuvre;
        private System.Windows.Forms.BindingSource bsNation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
    }
}