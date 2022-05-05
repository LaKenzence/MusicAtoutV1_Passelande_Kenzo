
namespace MusicAtoutV1_Passelande_Kenzo
{
    partial class FOeuvre
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
            this.bsOeuvre = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOeuvre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOeuvre)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(633, 561);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 48;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Les oeuvres de ce compositeur";
            // 
            // txtRemarque
            // 
            this.txtRemarque.Location = new System.Drawing.Point(40, 156);
            this.txtRemarque.Name = "txtRemarque";
            this.txtRemarque.Size = new System.Drawing.Size(562, 20);
            this.txtRemarque.TabIndex = 46;
            // 
            // txtDécès
            // 
            this.txtDécès.Location = new System.Drawing.Point(381, 120);
            this.txtDécès.Name = "txtDécès";
            this.txtDécès.Size = new System.Drawing.Size(82, 20);
            this.txtDécès.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Décès";
            // 
            // txtNaissance
            // 
            this.txtNaissance.Location = new System.Drawing.Point(205, 120);
            this.txtNaissance.Name = "txtNaissance";
            this.txtNaissance.Size = new System.Drawing.Size(82, 20);
            this.txtNaissance.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Naissance";
            // 
            // txtStyle
            // 
            this.txtStyle.Location = new System.Drawing.Point(496, 72);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.Size = new System.Drawing.Size(106, 20);
            this.txtStyle.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Style";
            // 
            // txtNationalité
            // 
            this.txtNationalité.Location = new System.Drawing.Point(205, 68);
            this.txtNationalité.Name = "txtNationalité";
            this.txtNationalité.Size = new System.Drawing.Size(147, 20);
            this.txtNationalité.TabIndex = 39;
            this.txtNationalité.TextChanged += new System.EventHandler(this.txtNationalité_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Nationalité";
            // 
            // txtSelectionné
            // 
            this.txtSelectionné.Location = new System.Drawing.Point(205, 32);
            this.txtSelectionné.Name = "txtSelectionné";
            this.txtSelectionné.Size = new System.Drawing.Size(397, 20);
            this.txtSelectionné.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Vous avez sélectionné";
            // 
            // dgvOeuvre
            // 
            this.dgvOeuvre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOeuvre.Location = new System.Drawing.Point(40, 216);
            this.dgvOeuvre.Name = "dgvOeuvre";
            this.dgvOeuvre.Size = new System.Drawing.Size(562, 369);
            this.dgvOeuvre.TabIndex = 34;
            // 
            // bsOeuvre
            // 
            this.bsOeuvre.CurrentChanged += new System.EventHandler(this.bsOeuvre_CurrentChanged);
            // 
            // FOeuvre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 595);
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
            this.Name = "FOeuvre";
            this.Text = "FOeuvre";
            this.Load += new System.EventHandler(this.FOeuvre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOeuvre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOeuvre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.BindingSource bsOeuvre;
    }
}