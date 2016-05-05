using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp3
{
    public partial class FrmTransformationImage : Form
    {

        #region ATTRIBUTS
        // Création d'une matrice d'image
        private int[,] matriceImage;
        //Bitmap de l'image à transformer 
        Bitmap _imageATransformerBitmap = null;
        #endregion


        public FrmTransformationImage()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (TransformationType transformation in Enum.GetValues(typeof(TransformationType)))
            {
                this.cmbTransformation.Items.Add(transformation);
            }

        }

        private void chargerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            string cheminFichier;
            // Création de l'objet "OpenFileDialog".
            OpenFileDialog ofd = new OpenFileDialog();

            Utilitaire.DemanderSelectionnerFichierImage(out cheminFichier);
            this._imageATransformerBitmap = (Bitmap)(this.pboImageIni.Image = Image.FromFile(cheminFichier));

            int largeur = this._imageATransformerBitmap.Width;
            int hauteur = this._imageATransformerBitmap.Height;

            // Création de la matrice de l'image charger
            this.matriceImage = new int[largeur, hauteur];

        }

        private void pboImageIni_Click(object sender, EventArgs e)
        {

        }

        private void btnNiveauDeGris_Click(object sender, EventArgs e)
        {

        }



        private void btnSepia_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(this.matriceImage.GetLength(0).ToString());
            MessageBox.Show(this.matriceImage.GetLength(1).ToString());

        }
    }
}
