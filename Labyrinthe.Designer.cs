
namespace TP1_INF1008
{
    partial class Labyrinthe
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
            this.lbl_infoDimension = new System.Windows.Forms.Label();
            this.btn_generer = new System.Windows.Forms.Button();
            this.lbl_operation_init = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDraggable = new System.Windows.Forms.Panel();
            this.lbl_operation_prim = new System.Windows.Forms.Label();
            this.lbl_operation_total = new System.Windows.Forms.Label();
            this.lbl_coup_pinceau = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBox_max = new System.Windows.Forms.TextBox();
            this.lbl_max = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lbl_largeur = new System.Windows.Forms.Label();
            this.lbl_longueur = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_infoDimension
            // 
            this.lbl_infoDimension.AutoSize = true;
            this.lbl_infoDimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_infoDimension.Location = new System.Drawing.Point(26, 200);
            this.lbl_infoDimension.Name = "lbl_infoDimension";
            this.lbl_infoDimension.Size = new System.Drawing.Size(172, 20);
            this.lbl_infoDimension.TabIndex = 0;
            this.lbl_infoDimension.Text = "information dimension :";
            // 
            // btn_generer
            // 
            this.btn_generer.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_generer.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_generer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generer.ForeColor = System.Drawing.Color.White;
            this.btn_generer.Location = new System.Drawing.Point(386, 44);
            this.btn_generer.Name = "btn_generer";
            this.btn_generer.Size = new System.Drawing.Size(102, 36);
            this.btn_generer.TabIndex = 5;
            this.btn_generer.Text = "Generate";
            this.btn_generer.UseVisualStyleBackColor = false;
            this.btn_generer.Click += new System.EventHandler(this.btn_generer_Click);
            // 
            // lbl_operation_init
            // 
            this.lbl_operation_init.AutoSize = true;
            this.lbl_operation_init.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_operation_init.Location = new System.Drawing.Point(26, 231);
            this.lbl_operation_init.Name = "lbl_operation_init";
            this.lbl_operation_init.Size = new System.Drawing.Size(253, 20);
            this.lbl_operation_init.TabIndex = 6;
            this.lbl_operation_init.Text = "Number of Initialization operations:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(712, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelDraggable
            // 
            this.panelDraggable.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelDraggable.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDraggable.Location = new System.Drawing.Point(0, 0);
            this.panelDraggable.Name = "panelDraggable";
            this.panelDraggable.Size = new System.Drawing.Size(752, 15);
            this.panelDraggable.TabIndex = 12;
            this.panelDraggable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PannelDraggable_MouseDown);
            // 
            // lbl_operation_prim
            // 
            this.lbl_operation_prim.AutoSize = true;
            this.lbl_operation_prim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_operation_prim.Location = new System.Drawing.Point(26, 263);
            this.lbl_operation_prim.Name = "lbl_operation_prim";
            this.lbl_operation_prim.Size = new System.Drawing.Size(201, 20);
            this.lbl_operation_prim.TabIndex = 13;
            this.lbl_operation_prim.Text = "Number of Prim operations:";
            // 
            // lbl_operation_total
            // 
            this.lbl_operation_total.AutoSize = true;
            this.lbl_operation_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_operation_total.Location = new System.Drawing.Point(26, 330);
            this.lbl_operation_total.Name = "lbl_operation_total";
            this.lbl_operation_total.Size = new System.Drawing.Size(203, 20);
            this.lbl_operation_total.TabIndex = 14;
            this.lbl_operation_total.Text = "Total number of operations:";
            // 
            // lbl_coup_pinceau
            // 
            this.lbl_coup_pinceau.AutoSize = true;
            this.lbl_coup_pinceau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coup_pinceau.Location = new System.Drawing.Point(26, 296);
            this.lbl_coup_pinceau.Name = "lbl_coup_pinceau";
            this.lbl_coup_pinceau.Size = new System.Drawing.Size(103, 20);
            this.lbl_coup_pinceau.TabIndex = 15;
            this.lbl_coup_pinceau.Text = "Brushstroke :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txtBox_max);
            this.panel1.Controls.Add(this.lbl_max);
            this.panel1.Controls.Add(this.txtWidth);
            this.panel1.Controls.Add(this.txtLength);
            this.panel1.Controls.Add(this.lbl_largeur);
            this.panel1.Controls.Add(this.lbl_longueur);
            this.panel1.Controls.Add(this.lbl_operation_total);
            this.panel1.Controls.Add(this.lbl_coup_pinceau);
            this.panel1.Controls.Add(this.lbl_infoDimension);
            this.panel1.Controls.Add(this.lbl_operation_init);
            this.panel1.Controls.Add(this.lbl_operation_prim);
            this.panel1.Controls.Add(this.btn_generer);
            this.panel1.Location = new System.Drawing.Point(102, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 377);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtBox_max
            // 
            this.txtBox_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_max.Location = new System.Drawing.Point(187, 145);
            this.txtBox_max.Name = "txtBox_max";
            this.txtBox_max.Size = new System.Drawing.Size(100, 26);
            this.txtBox_max.TabIndex = 21;
            // 
            // lbl_max
            // 
            this.lbl_max.AutoSize = true;
            this.lbl_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_max.Location = new System.Drawing.Point(67, 151);
            this.lbl_max.Name = "lbl_max";
            this.lbl_max.Size = new System.Drawing.Size(96, 20);
            this.lbl_max.TabIndex = 20;
            this.lbl_max.Text = "Max Weight:";
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(187, 92);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 26);
            this.txtWidth.TabIndex = 19;
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(187, 44);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 26);
            this.txtLength.TabIndex = 18;
            // 
            // lbl_largeur
            // 
            this.lbl_largeur.AutoSize = true;
            this.lbl_largeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_largeur.Location = new System.Drawing.Point(26, 98);
            this.lbl_largeur.Name = "lbl_largeur";
            this.lbl_largeur.Size = new System.Drawing.Size(120, 20);
            this.lbl_largeur.TabIndex = 17;
            this.lbl_largeur.Text = "Enter the Width";
            // 
            // lbl_longueur
            // 
            this.lbl_longueur.AutoSize = true;
            this.lbl_longueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_longueur.Location = new System.Drawing.Point(26, 47);
            this.lbl_longueur.Name = "lbl_longueur";
            this.lbl_longueur.Size = new System.Drawing.Size(129, 20);
            this.lbl_longueur.TabIndex = 16;
            this.lbl_longueur.Text = "Enter the Length";
            // 
            // Labyrinthe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(752, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDraggable);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Labyrinthe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_infoDimension;
        private System.Windows.Forms.Button btn_generer;
        private System.Windows.Forms.Label lbl_operation_init;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDraggable;
        private System.Windows.Forms.Label lbl_operation_prim;
        private System.Windows.Forms.Label lbl_operation_total;
        private System.Windows.Forms.Label lbl_coup_pinceau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBox_max;
        private System.Windows.Forms.Label lbl_max;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lbl_largeur;
        private System.Windows.Forms.Label lbl_longueur;
    }
}

