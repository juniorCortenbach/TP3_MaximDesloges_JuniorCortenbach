namespace tp3
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNiveauDeGris = new System.Windows.Forms.Button();
            this.btnSepia = new System.Windows.Forms.Button();
            this.Transformation = new System.Windows.Forms.Label();
            this.btnDuree = new System.Windows.Forms.Label();
            this.txtDurée = new System.Windows.Forms.TextBox();
            this.cmbTransformation = new System.Windows.Forms.ComboBox();
            this.txtAller = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1021, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chargerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // chargerToolStripMenuItem
            // 
            this.chargerToolStripMenuItem.Name = "chargerToolStripMenuItem";
            this.chargerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chargerToolStripMenuItem.Text = "Charger image";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(0, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 408);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnNiveauDeGris
            // 
            this.btnNiveauDeGris.Location = new System.Drawing.Point(54, 39);
            this.btnNiveauDeGris.Name = "btnNiveauDeGris";
            this.btnNiveauDeGris.Size = new System.Drawing.Size(109, 37);
            this.btnNiveauDeGris.TabIndex = 3;
            this.btnNiveauDeGris.Text = "Niveau de gris";
            this.btnNiveauDeGris.UseVisualStyleBackColor = true;
            // 
            // btnSepia
            // 
            this.btnSepia.Location = new System.Drawing.Point(169, 39);
            this.btnSepia.Name = "btnSepia";
            this.btnSepia.Size = new System.Drawing.Size(109, 37);
            this.btnSepia.TabIndex = 4;
            this.btnSepia.Text = "Sepia";
            this.btnSepia.UseVisualStyleBackColor = true;
            // 
            // Transformation
            // 
            this.Transformation.AutoSize = true;
            this.Transformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transformation.Location = new System.Drawing.Point(318, 39);
            this.Transformation.Name = "Transformation";
            this.Transformation.Size = new System.Drawing.Size(104, 15);
            this.Transformation.TabIndex = 5;
            this.Transformation.Text = "Transformation";
            // 
            // btnDuree
            // 
            this.btnDuree.AutoSize = true;
            this.btnDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuree.Location = new System.Drawing.Point(438, 39);
            this.btnDuree.Name = "btnDuree";
            this.btnDuree.Size = new System.Drawing.Size(87, 15);
            this.btnDuree.TabIndex = 6;
            this.btnDuree.Text = "Durée (ms) :";
            // 
            // txtDurée
            // 
            this.txtDurée.Location = new System.Drawing.Point(531, 39);
            this.txtDurée.Name = "txtDurée";
            this.txtDurée.Size = new System.Drawing.Size(61, 20);
            this.txtDurée.TabIndex = 7;
            // 
            // cmbTransformation
            // 
            this.cmbTransformation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransformation.FormattingEnabled = true;
            this.cmbTransformation.Location = new System.Drawing.Point(321, 65);
            this.cmbTransformation.Name = "cmbTransformation";
            this.cmbTransformation.Size = new System.Drawing.Size(271, 21);
            this.cmbTransformation.TabIndex = 8;
            // 
            // txtAller
            // 
            this.txtAller.Location = new System.Drawing.Point(733, 40);
            this.txtAller.Name = "txtAller";
            this.txtAller.Size = new System.Drawing.Size(61, 20);
            this.txtAller.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(671, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Aller à :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(860, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Itération:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(930, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Location = new System.Drawing.Point(520, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(501, 408);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 530);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAller);
            this.Controls.Add(this.cmbTransformation);
            this.Controls.Add(this.txtDurée);
            this.Controls.Add(this.btnDuree);
            this.Controls.Add(this.Transformation);
            this.Controls.Add(this.btnSepia);
            this.Controls.Add(this.btnNiveauDeGris);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Transformations bijectives sur des images (TP-3, 420-216-FX)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNiveauDeGris;
        private System.Windows.Forms.Button btnSepia;
        private System.Windows.Forms.Label Transformation;
        private System.Windows.Forms.Label btnDuree;
        private System.Windows.Forms.TextBox txtDurée;
        private System.Windows.Forms.ComboBox cmbTransformation;
        private System.Windows.Forms.TextBox txtAller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

