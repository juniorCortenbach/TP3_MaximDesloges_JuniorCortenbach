namespace tp3
{
    partial class FrmTransformationImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransformationImage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNiveauDeGris = new System.Windows.Forms.Button();
            this.btnSepia = new System.Windows.Forms.Button();
            this.Transformation = new System.Windows.Forms.Label();
            this.btnDuree = new System.Windows.Forms.Label();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.cmbTransformation = new System.Windows.Forms.ComboBox();
            this.txtAller = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIteration = new System.Windows.Forms.Label();
            this.pboImageTransfo = new System.Windows.Forms.PictureBox();
            this.btnStoper = new System.Windows.Forms.PictureBox();
            this.btnAvancementContinue = new System.Windows.Forms.PictureBox();
            this.btnAvancementUnique = new System.Windows.Forms.PictureBox();
            this.btnAvencer = new System.Windows.Forms.PictureBox();
            this.btnRetour = new System.Windows.Forms.PictureBox();
            this.pboImageIni = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.chronometre1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboImageTransfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStoper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAvancementContinue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAvancementUnique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAvencer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboImageIni)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1133, 24);
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
            this.chargerToolStripMenuItem.Click += new System.EventHandler(this.chargerToolStripMenuItem_Click_1);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // btnNiveauDeGris
            // 
            this.btnNiveauDeGris.Location = new System.Drawing.Point(54, 39);
            this.btnNiveauDeGris.Name = "btnNiveauDeGris";
            this.btnNiveauDeGris.Size = new System.Drawing.Size(109, 37);
            this.btnNiveauDeGris.TabIndex = 3;
            this.btnNiveauDeGris.Text = "Niveau de gris";
            this.btnNiveauDeGris.UseVisualStyleBackColor = true;
            this.btnNiveauDeGris.Click += new System.EventHandler(this.btnNiveauDeGris_Click);
            // 
            // btnSepia
            // 
            this.btnSepia.Location = new System.Drawing.Point(169, 39);
            this.btnSepia.Name = "btnSepia";
            this.btnSepia.Size = new System.Drawing.Size(109, 37);
            this.btnSepia.TabIndex = 4;
            this.btnSepia.Text = "Sepia";
            this.btnSepia.UseVisualStyleBackColor = true;
            this.btnSepia.Click += new System.EventHandler(this.btnSepia_Click_1);
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
            // txtDuree
            // 
            this.txtDuree.Location = new System.Drawing.Point(531, 39);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(61, 20);
            this.txtDuree.TabIndex = 7;
            // 
            // cmbTransformation
            // 
            this.cmbTransformation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransformation.FormattingEnabled = true;
            this.cmbTransformation.Location = new System.Drawing.Point(321, 71);
            this.cmbTransformation.Name = "cmbTransformation";
            this.cmbTransformation.Size = new System.Drawing.Size(271, 21);
            this.cmbTransformation.TabIndex = 8;
            // 
            // txtAller
            // 
            this.txtAller.Location = new System.Drawing.Point(814, 49);
            this.txtAller.Name = "txtAller";
            this.txtAller.Size = new System.Drawing.Size(61, 20);
            this.txtAller.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(752, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Aller à :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1017, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Itération:";
            // 
            // lblIteration
            // 
            this.lblIteration.AutoSize = true;
            this.lblIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIteration.ForeColor = System.Drawing.Color.DarkRed;
            this.lblIteration.Location = new System.Drawing.Point(1087, 40);
            this.lblIteration.Name = "lblIteration";
            this.lblIteration.Size = new System.Drawing.Size(15, 15);
            this.lblIteration.TabIndex = 12;
            this.lblIteration.Text = "0";
            // 
            // pboImageTransfo
            // 
            this.pboImageTransfo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pboImageTransfo.Location = new System.Drawing.Point(590, 107);
            this.pboImageTransfo.Name = "pboImageTransfo";
            this.pboImageTransfo.Size = new System.Drawing.Size(512, 512);
            this.pboImageTransfo.TabIndex = 13;
            this.pboImageTransfo.TabStop = false;
            // 
            // btnStoper
            // 
            this.btnStoper.Image = ((System.Drawing.Image)(resources.GetObject("btnStoper.Image")));
            this.btnStoper.Location = new System.Drawing.Point(708, 40);
            this.btnStoper.Name = "btnStoper";
            this.btnStoper.Size = new System.Drawing.Size(38, 46);
            this.btnStoper.TabIndex = 14;
            this.btnStoper.TabStop = false;
            this.btnStoper.Click += new System.EventHandler(this.btnStoper_Click);
            // 
            // btnAvancementContinue
            // 
            this.btnAvancementContinue.Image = ((System.Drawing.Image)(resources.GetObject("btnAvancementContinue.Image")));
            this.btnAvancementContinue.Location = new System.Drawing.Point(653, 40);
            this.btnAvancementContinue.Name = "btnAvancementContinue";
            this.btnAvancementContinue.Size = new System.Drawing.Size(38, 46);
            this.btnAvancementContinue.TabIndex = 15;
            this.btnAvancementContinue.TabStop = false;
            this.btnAvancementContinue.Click += new System.EventHandler(this.btnAvancementContinue_Click);
            // 
            // btnAvancementUnique
            // 
            this.btnAvancementUnique.Image = ((System.Drawing.Image)(resources.GetObject("btnAvancementUnique.Image")));
            this.btnAvancementUnique.Location = new System.Drawing.Point(600, 40);
            this.btnAvancementUnique.Name = "btnAvancementUnique";
            this.btnAvancementUnique.Size = new System.Drawing.Size(38, 46);
            this.btnAvancementUnique.TabIndex = 16;
            this.btnAvancementUnique.TabStop = false;
            this.btnAvancementUnique.Click += new System.EventHandler(this.btnAvancementUnique_Click);
            // 
            // btnAvencer
            // 
            this.btnAvencer.Image = ((System.Drawing.Image)(resources.GetObject("btnAvencer.Image")));
            this.btnAvencer.Location = new System.Drawing.Point(891, 39);
            this.btnAvencer.Name = "btnAvencer";
            this.btnAvencer.Size = new System.Drawing.Size(38, 46);
            this.btnAvencer.TabIndex = 17;
            this.btnAvencer.TabStop = false;
            // 
            // btnRetour
            // 
            this.btnRetour.Image = ((System.Drawing.Image)(resources.GetObject("btnRetour.Image")));
            this.btnRetour.Location = new System.Drawing.Point(952, 40);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(38, 46);
            this.btnRetour.TabIndex = 18;
            this.btnRetour.TabStop = false;
            // 
            // pboImageIni
            // 
            this.pboImageIni.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pboImageIni.Location = new System.Drawing.Point(37, 107);
            this.pboImageIni.Name = "pboImageIni";
            this.pboImageIni.Size = new System.Drawing.Size(512, 512);
            this.pboImageIni.TabIndex = 19;
            this.pboImageIni.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(598, 77);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(255, 15);
            this.lblMessage.TabIndex = 21;
            this.lblMessage.Text = "llllllllllllllllllllllllllllllllllllllllllllllllllllllllllllll";
            // 
            // chronometre1
            // 
            this.chronometre1.Tick += new System.EventHandler(this.chronometre1_Tick);
            // 
            // FrmTransformationImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 631);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pboImageIni);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAvencer);
            this.Controls.Add(this.btnAvancementUnique);
            this.Controls.Add(this.btnAvancementContinue);
            this.Controls.Add(this.btnStoper);
            this.Controls.Add(this.pboImageTransfo);
            this.Controls.Add(this.lblIteration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAller);
            this.Controls.Add(this.cmbTransformation);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.btnDuree);
            this.Controls.Add(this.Transformation);
            this.Controls.Add(this.btnSepia);
            this.Controls.Add(this.btnNiveauDeGris);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmTransformationImage";
            this.Text = "Transformations bijectives sur des images (TP-3, 420-216-FX)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboImageTransfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStoper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAvancementContinue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAvancementUnique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAvencer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboImageIni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Button btnNiveauDeGris;
        private System.Windows.Forms.Button btnSepia;
        private System.Windows.Forms.Label Transformation;
        private System.Windows.Forms.Label btnDuree;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.ComboBox cmbTransformation;
        private System.Windows.Forms.TextBox txtAller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIteration;
        private System.Windows.Forms.PictureBox pboImageTransfo;
        private System.Windows.Forms.PictureBox btnStoper;
        private System.Windows.Forms.PictureBox btnAvancementContinue;
        private System.Windows.Forms.PictureBox btnAvancementUnique;
        private System.Windows.Forms.PictureBox btnAvencer;
        private System.Windows.Forms.PictureBox btnRetour;
        private System.Windows.Forms.PictureBox pboImageIni;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer chronometre1;
    }
}

