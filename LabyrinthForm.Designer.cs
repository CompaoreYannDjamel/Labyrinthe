
namespace TP1_INF1008
{
    partial class LabyrinthForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_generer = new System.Windows.Forms.Button();
            this.txtBox_max = new System.Windows.Forms.TextBox();
            this.lbl_max = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lbl_largeur = new System.Windows.Forms.Label();
            this.lbl_longueur = new System.Windows.Forms.Label();
            this.lbl_operation_total = new System.Windows.Forms.Label();
            this.lbl_coup_pinceau = new System.Windows.Forms.Label();
            this.lbl_infoDimension = new System.Windows.Forms.Label();
            this.lbl_operation_init = new System.Windows.Forms.Label();
            this.lbl_operation_prim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_generer
            // 
            this.btn_generer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_generer.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_generer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generer.ForeColor = System.Drawing.Color.Black;
            this.btn_generer.Location = new System.Drawing.Point(355, 29);
            this.btn_generer.Name = "btn_generer";
            this.btn_generer.Size = new System.Drawing.Size(120, 31);
            this.btn_generer.TabIndex = 5;
            this.btn_generer.Text = "Generate";
            this.btn_generer.UseVisualStyleBackColor = false;
            this.btn_generer.Click += new System.EventHandler(this.btn_generer_Click);
            // 
            // txtBox_max
            // 
            this.txtBox_max.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_max.Location = new System.Drawing.Point(121, 91);
            this.txtBox_max.Name = "txtBox_max";
            this.txtBox_max.Size = new System.Drawing.Size(184, 25);
            this.txtBox_max.TabIndex = 32;
            // 
            // lbl_max
            // 
            this.lbl_max.AutoSize = true;
            this.lbl_max.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_max.Location = new System.Drawing.Point(35, 94);
            this.lbl_max.Name = "lbl_max";
            this.lbl_max.Size = new System.Drawing.Size(80, 17);
            this.lbl_max.TabIndex = 31;
            this.lbl_max.Text = "Max Weight:";
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(122, 60);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(184, 25);
            this.txtWidth.TabIndex = 30;
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(121, 26);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(184, 25);
            this.txtLength.TabIndex = 29;
            // 
            // lbl_largeur
            // 
            this.lbl_largeur.AutoSize = true;
            this.lbl_largeur.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_largeur.Location = new System.Drawing.Point(18, 63);
            this.lbl_largeur.Name = "lbl_largeur";
            this.lbl_largeur.Size = new System.Drawing.Size(98, 17);
            this.lbl_largeur.TabIndex = 28;
            this.lbl_largeur.Text = "Enter the Width";
            // 
            // lbl_longueur
            // 
            this.lbl_longueur.AutoSize = true;
            this.lbl_longueur.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_longueur.Location = new System.Drawing.Point(12, 29);
            this.lbl_longueur.Name = "lbl_longueur";
            this.lbl_longueur.Size = new System.Drawing.Size(103, 17);
            this.lbl_longueur.TabIndex = 27;
            this.lbl_longueur.Text = "Enter the Length";
            // 
            // lbl_operation_total
            // 
            this.lbl_operation_total.AutoSize = true;
            this.lbl_operation_total.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_operation_total.Location = new System.Drawing.Point(155, 341);
            this.lbl_operation_total.Name = "lbl_operation_total";
            this.lbl_operation_total.Size = new System.Drawing.Size(182, 17);
            this.lbl_operation_total.TabIndex = 25;
            this.lbl_operation_total.Text = "Total number of operations:";
            // 
            // lbl_coup_pinceau
            // 
            this.lbl_coup_pinceau.AutoSize = true;
            this.lbl_coup_pinceau.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coup_pinceau.Location = new System.Drawing.Point(154, 310);
            this.lbl_coup_pinceau.Name = "lbl_coup_pinceau";
            this.lbl_coup_pinceau.Size = new System.Drawing.Size(89, 17);
            this.lbl_coup_pinceau.TabIndex = 26;
            this.lbl_coup_pinceau.Text = "Brushstroke :";
            // 
            // lbl_infoDimension
            // 
            this.lbl_infoDimension.AutoSize = true;
            this.lbl_infoDimension.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_infoDimension.Location = new System.Drawing.Point(154, 205);
            this.lbl_infoDimension.Name = "lbl_infoDimension";
            this.lbl_infoDimension.Size = new System.Drawing.Size(155, 17);
            this.lbl_infoDimension.TabIndex = 22;
            this.lbl_infoDimension.Text = "Information dimension:";
            // 
            // lbl_operation_init
            // 
            this.lbl_operation_init.AutoSize = true;
            this.lbl_operation_init.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_operation_init.Location = new System.Drawing.Point(154, 239);
            this.lbl_operation_init.Name = "lbl_operation_init";
            this.lbl_operation_init.Size = new System.Drawing.Size(231, 17);
            this.lbl_operation_init.TabIndex = 23;
            this.lbl_operation_init.Text = "Number of Initialization operations:";
            // 
            // lbl_operation_prim
            // 
            this.lbl_operation_prim.AutoSize = true;
            this.lbl_operation_prim.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_operation_prim.Location = new System.Drawing.Point(154, 275);
            this.lbl_operation_prim.Name = "lbl_operation_prim";
            this.lbl_operation_prim.Size = new System.Drawing.Size(182, 17);
            this.lbl_operation_prim.TabIndex = 24;
            this.lbl_operation_prim.Text = "Number of Prim operations:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(553, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "_________________________________________________________________________________" +
    "__________";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(355, 63);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 31);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "_________________________________________________________________________________" +
    "__________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "#####Results#####";
            // 
            // LabyrinthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(561, 379);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_max);
            this.Controls.Add(this.lbl_max);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lbl_largeur);
            this.Controls.Add(this.lbl_longueur);
            this.Controls.Add(this.lbl_operation_total);
            this.Controls.Add(this.lbl_coup_pinceau);
            this.Controls.Add(this.lbl_infoDimension);
            this.Controls.Add(this.lbl_operation_init);
            this.Controls.Add(this.lbl_operation_prim);
            this.Controls.Add(this.btn_generer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LabyrinthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labyrinth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_generer;
        private System.Windows.Forms.TextBox txtBox_max;
        private System.Windows.Forms.Label lbl_max;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lbl_largeur;
        private System.Windows.Forms.Label lbl_longueur;
        private System.Windows.Forms.Label lbl_operation_total;
        private System.Windows.Forms.Label lbl_coup_pinceau;
        private System.Windows.Forms.Label lbl_infoDimension;
        private System.Windows.Forms.Label lbl_operation_init;
        private System.Windows.Forms.Label lbl_operation_prim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

