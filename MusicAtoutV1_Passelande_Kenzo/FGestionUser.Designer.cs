
namespace MusicAtoutV1_Passelande_Kenzo
{
    partial class FGestionUser
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
            this.cboDroits = new System.Windows.Forms.ComboBox();
            this.lblDroit = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnDesac = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReactiver = new System.Windows.Forms.Button();
            this.bsUser = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUser)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDroits
            // 
            this.cboDroits.FormattingEnabled = true;
            this.cboDroits.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboDroits.Location = new System.Drawing.Point(306, 19);
            this.cboDroits.Name = "cboDroits";
            this.cboDroits.Size = new System.Drawing.Size(121, 21);
            this.cboDroits.TabIndex = 16;
            this.cboDroits.Visible = false;
            // 
            // lblDroit
            // 
            this.lblDroit.AutoSize = true;
            this.lblDroit.Location = new System.Drawing.Point(251, 22);
            this.lblDroit.Name = "lblDroit";
            this.lblDroit.Size = new System.Drawing.Size(40, 13);
            this.lblDroit.TabIndex = 15;
            this.lblDroit.Text = "Droits :";
            this.lblDroit.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(23, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(59, 13);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "Identifiant :";
            this.lblID.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(93, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 13;
            this.txtId.Visible = false;
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(142, 116);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(510, 240);
            this.dgvUser.TabIndex = 12;
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(254, 390);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(75, 23);
            this.btnSuppr.TabIndex = 20;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Visible = false;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // btnDesac
            // 
            this.btnDesac.Location = new System.Drawing.Point(577, 390);
            this.btnDesac.Name = "btnDesac";
            this.btnDesac.Size = new System.Drawing.Size(75, 23);
            this.btnDesac.TabIndex = 19;
            this.btnDesac.Text = "Désactiver";
            this.btnDesac.UseVisualStyleBackColor = true;
            this.btnDesac.Visible = false;
            this.btnDesac.Click += new System.EventHandler(this.btnDesac_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(142, 390);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReactiver
            // 
            this.btnReactiver.Location = new System.Drawing.Point(472, 390);
            this.btnReactiver.Name = "btnReactiver";
            this.btnReactiver.Size = new System.Drawing.Size(75, 23);
            this.btnReactiver.TabIndex = 17;
            this.btnReactiver.Text = "Réactiver";
            this.btnReactiver.UseVisualStyleBackColor = true;
            this.btnReactiver.Click += new System.EventHandler(this.btnReactiver_Click);
            // 
            // FGestionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSuppr);
            this.Controls.Add(this.btnDesac);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReactiver);
            this.Controls.Add(this.cboDroits);
            this.Controls.Add(this.lblDroit);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvUser);
            this.Name = "FGestionUser";
            this.Text = "FGestionUser";
            this.Load += new System.EventHandler(this.FGestionUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDroits;
        private System.Windows.Forms.Label lblDroit;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnDesac;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReactiver;
        private System.Windows.Forms.BindingSource bsUser;
    }
}