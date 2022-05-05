
namespace MusicAtoutV1_Passelande_Kenzo
{
    partial class FConnex
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
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnModifMdp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAncienMDP = new System.Windows.Forms.TextBox();
            this.lblNewMDP = new System.Windows.Forms.Label();
            this.txtnewmdp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(118, 69);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(305, 20);
            this.txtIdentifiant.TabIndex = 0;
            this.txtIdentifiant.TextChanged += new System.EventHandler(this.textLogin_TextChanged);
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(118, 121);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(305, 20);
            this.txtPasswd.TabIndex = 1;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(110, 349);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Identifiant";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mot de passe";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(320, 349);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnModifMdp
            // 
            this.btnModifMdp.Location = new System.Drawing.Point(159, 172);
            this.btnModifMdp.Name = "btnModifMdp";
            this.btnModifMdp.Size = new System.Drawing.Size(158, 24);
            this.btnModifMdp.TabIndex = 6;
            this.btnModifMdp.Text = "Modifier le MDP";
            this.btnModifMdp.UseVisualStyleBackColor = true;
            this.btnModifMdp.Click += new System.EventHandler(this.btnModifMdp_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ancien mot de passe :";
            this.label3.Visible = false;
            // 
            // txtAncienMDP
            // 
            this.txtAncienMDP.Location = new System.Drawing.Point(142, 223);
            this.txtAncienMDP.Name = "txtAncienMDP";
            this.txtAncienMDP.Size = new System.Drawing.Size(388, 20);
            this.txtAncienMDP.TabIndex = 8;
            this.txtAncienMDP.Visible = false;
            this.txtAncienMDP.TextChanged += new System.EventHandler(this.txtAncienMDP_TextChanged);
            // 
            // lblNewMDP
            // 
            this.lblNewMDP.AutoSize = true;
            this.lblNewMDP.Location = new System.Drawing.Point(12, 275);
            this.lblNewMDP.Name = "lblNewMDP";
            this.lblNewMDP.Size = new System.Drawing.Size(123, 13);
            this.lblNewMDP.TabIndex = 11;
            this.lblNewMDP.Text = "Nouveau mot de passe :";
            this.lblNewMDP.Visible = false;
            // 
            // txtnewmdp
            // 
            this.txtnewmdp.Location = new System.Drawing.Point(141, 272);
            this.txtnewmdp.Name = "txtnewmdp";
            this.txtnewmdp.Size = new System.Drawing.Size(388, 20);
            this.txtnewmdp.TabIndex = 10;
            this.txtnewmdp.Visible = false;
            // 
            // FConnex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNewMDP);
            this.Controls.Add(this.txtnewmdp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAncienMDP);
            this.Controls.Add(this.btnModifMdp);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtIdentifiant);
            this.Name = "FConnex";
            this.Text = "FConnex";
            this.Load += new System.EventHandler(this.FConnex_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnModifMdp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAncienMDP;
        private System.Windows.Forms.Label lblNewMDP;
        private System.Windows.Forms.TextBox txtnewmdp;
    }

   /* public static void ThreadProc()
    {
        Application.Run(new FMenu());
    }
   */
}