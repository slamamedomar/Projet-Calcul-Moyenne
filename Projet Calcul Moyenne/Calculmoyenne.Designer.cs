namespace Projet_Calcul_Moyenne
{
    partial class CalculMoyenne
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
            this.txt_NomPrenom = new System.Windows.Forms.TextBox();
            this.txt_NoteDS = new System.Windows.Forms.TextBox();
            this.txt_NoteTP = new System.Windows.Forms.TextBox();
            this.txt_NoteExamen = new System.Windows.Forms.TextBox();
            this.txt_Coef = new System.Windows.Forms.TextBox();
            this.txt_Moyenne = new System.Windows.Forms.TextBox();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_Calculer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lst_Moyenne = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_NomPrenom
            // 
            this.txt_NomPrenom.AccessibleName = "";
            this.txt_NomPrenom.Location = new System.Drawing.Point(190, 78);
            this.txt_NomPrenom.Name = "txt_NomPrenom";
            this.txt_NomPrenom.Size = new System.Drawing.Size(178, 22);
            this.txt_NomPrenom.TabIndex = 0;
            this.txt_NomPrenom.TextChanged += new System.EventHandler(this.txt_NomPrenom_TextChanged);
            // 
            // txt_NoteDS
            // 
            this.txt_NoteDS.AccessibleName = "";
            this.txt_NoteDS.Location = new System.Drawing.Point(190, 137);
            this.txt_NoteDS.Name = "txt_NoteDS";
            this.txt_NoteDS.Size = new System.Drawing.Size(178, 22);
            this.txt_NoteDS.TabIndex = 1;
            this.txt_NoteDS.TextChanged += new System.EventHandler(this.txt_NoteDS_TextChanged);
            this.txt_NoteDS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NoteDS_KeyPress);
            // 
            // txt_NoteTP
            // 
            this.txt_NoteTP.AccessibleName = "";
            this.txt_NoteTP.Location = new System.Drawing.Point(190, 199);
            this.txt_NoteTP.Name = "txt_NoteTP";
            this.txt_NoteTP.Size = new System.Drawing.Size(178, 22);
            this.txt_NoteTP.TabIndex = 2;
            this.txt_NoteTP.TextChanged += new System.EventHandler(this.txt_NoteTP_TextChanged);
            this.txt_NoteTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NoteTP_KeyPress);
            // 
            // txt_NoteExamen
            // 
            this.txt_NoteExamen.AccessibleName = "";
            this.txt_NoteExamen.Location = new System.Drawing.Point(190, 262);
            this.txt_NoteExamen.Name = "txt_NoteExamen";
            this.txt_NoteExamen.Size = new System.Drawing.Size(178, 22);
            this.txt_NoteExamen.TabIndex = 3;
            this.txt_NoteExamen.TextChanged += new System.EventHandler(this.txt_NoteExamen_TextChanged);
            this.txt_NoteExamen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NoteExamen_KeyPress);
            // 
            // txt_Coef
            // 
            this.txt_Coef.AccessibleName = "";
            this.txt_Coef.Location = new System.Drawing.Point(190, 323);
            this.txt_Coef.Name = "txt_Coef";
            this.txt_Coef.Size = new System.Drawing.Size(178, 22);
            this.txt_Coef.TabIndex = 4;
            this.txt_Coef.TextChanged += new System.EventHandler(this.txt_Coef_TextChanged);
            this.txt_Coef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Coef_KeyPress);
            // 
            // txt_Moyenne
            // 
            this.txt_Moyenne.AccessibleName = "";
            this.txt_Moyenne.Enabled = false;
            this.txt_Moyenne.Location = new System.Drawing.Point(190, 383);
            this.txt_Moyenne.Name = "txt_Moyenne";
            this.txt_Moyenne.Size = new System.Drawing.Size(178, 22);
            this.txt_Moyenne.TabIndex = 5;
            this.txt_Moyenne.TextChanged += new System.EventHandler(this.txt_Moyenne_TextChanged);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.AccessibleName = "";
            this.btn_Supprimer.Enabled = false;
            this.btn_Supprimer.Location = new System.Drawing.Point(703, 455);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(142, 36);
            this.btn_Supprimer.TabIndex = 7;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.AccessibleName = "";
            this.btn_Ajouter.Enabled = false;
            this.btn_Ajouter.Location = new System.Drawing.Point(523, 455);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(142, 36);
            this.btn_Ajouter.TabIndex = 8;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Calculer
            // 
            this.btn_Calculer.AccessibleName = "";
            this.btn_Calculer.Enabled = false;
            this.btn_Calculer.Location = new System.Drawing.Point(343, 455);
            this.btn_Calculer.Name = "btn_Calculer";
            this.btn_Calculer.Size = new System.Drawing.Size(142, 36);
            this.btn_Calculer.TabIndex = 9;
            this.btn_Calculer.Text = "Calculer";
            this.btn_Calculer.UseVisualStyleBackColor = false;
            this.btn_Calculer.Click += new System.EventHandler(this.btn_Calculer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Note DS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Note TP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Note EXAM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "coef";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Moyenne";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 78);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nom et Prenom";
            // 
            // lst_Moyenne
            // 
            this.lst_Moyenne.FormattingEnabled = true;
            this.lst_Moyenne.ItemHeight = 16;
            this.lst_Moyenne.Location = new System.Drawing.Point(447, 78);
            this.lst_Moyenne.MultiColumn = true;
            this.lst_Moyenne.Name = "lst_Moyenne";
            this.lst_Moyenne.ScrollAlwaysVisible = true;
            this.lst_Moyenne.Size = new System.Drawing.Size(398, 340);
            this.lst_Moyenne.TabIndex = 16;
            this.lst_Moyenne.SelectedIndexChanged += new System.EventHandler(this.lst_Moyenne_SelectedIndexChanged);
            // 
            // CalculMoyenne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 536);
            this.Controls.Add(this.lst_Moyenne);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Calculer);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.txt_Moyenne);
            this.Controls.Add(this.txt_Coef);
            this.Controls.Add(this.txt_NoteExamen);
            this.Controls.Add(this.txt_NoteTP);
            this.Controls.Add(this.txt_NoteDS);
            this.Controls.Add(this.txt_NomPrenom);
            this.Name = "CalculMoyenne";
            this.Text = "Calcul Moyenne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NomPrenom;
        private System.Windows.Forms.TextBox txt_NoteDS;
        private System.Windows.Forms.TextBox txt_NoteTP;
        private System.Windows.Forms.TextBox txt_NoteExamen;
        private System.Windows.Forms.TextBox txt_Coef;
        private System.Windows.Forms.TextBox txt_Moyenne;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Calculer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lst_Moyenne;
    }
}

