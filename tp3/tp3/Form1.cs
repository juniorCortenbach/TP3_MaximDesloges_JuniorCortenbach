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
        private BitmapMatricielle _imageATransformerBitmap = null;

        private BitmapMatricielle _imageTransformee = null;

        byte _iteration;

        #endregion


        #region PROPRIETES

        public BitmapMatricielle ImageATransformerBitmap
        {
            get { return _imageATransformerBitmap; }
            set { _imageATransformerBitmap = value; }
        }

        public BitmapMatricielle ImageTransformee
        {
            get { return _imageTransformee; }
            set { _imageTransformee = value; }
        }

        #region

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
            string cheminFichier;
            // Création de l'objet "OpenFileDialog".
            OpenFileDialog ofd = new OpenFileDialog();

            Utilitaire.DemanderSelectionnerFichierImage(out cheminFichier);

            this.ImageATransformerBitmap = new BitmapMatricielle();
            this.ImageATransformerBitmap.ImageBitmap = new Bitmap(Image.FromFile(cheminFichier));
            this.pboImageIni.Image = this.ImageATransformerBitmap.ImageBitmap;


            this.ImageTransformee = new BitmapMatricielle();
            this.ImageTransformee.ImageBitmap = new Bitmap(Image.FromFile(cheminFichier));
            this.pboImageTransfo.Image = this.ImageATransformerBitmap.ImageBitmap;

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

            this.ImageATransformerBitmap = new BitmapMatricielle();
            this.ImageATransformerBitmap.ImageBitmap = new Bitmap(Image.FromFile(cheminFichier));
            this.pboImageIni.Image = this.ImageATransformerBitmap.ImageBitmap;


            this.ImageTransformee = new BitmapMatricielle();
            this.ImageTransformee.ImageBitmap = new Bitmap(Image.FromFile(cheminFichier));
            this.pboImageTransfo.Image = this.ImageATransformerBitmap.ImageBitmap;

        }

        private void btnSepia_Click_1(object sender, EventArgs e)
        {

            //Bitmap image = this.ImageTransformee.ImageBitmap;
            //this.ImageTransformee.ImageBitmap = this.ImageATransformerBitmap.MiroirHorizontal(image, this._iteration);

            //this.pboImageTransfo.Image = this.pboImageIni.Image;

            //this.pboImageTransfo.Image = ImageTransformee.ImageBitmap;


        }

        private void cmbTransformation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BitmapMatricielle imageTransfo = new BitmapMatricielle(this._imageATransformerBitmap);

            //imageTransfo =  BitmapMatricielle.MiroirHorizontal(this._imageATransformerBitmap);

            if (cmbTransformation.SelectedIndex == 0)

                // this.ImageTransformee.ImageBitmap == this.ImageATransformerBitmap.MiroirHorizontal(ImageATransformerBitmap.ImageBitmap, this._iteration);

                this.pboImageTransfo.Image = ImageTransformee.ImageBitmap;

        }

        private void btnAvancementUnique_Click(object sender, EventArgs e)
        {
            // this.ImageATransformerBitmap.MiroirHorizontal(image, this._iteration);
            this.ImageTransformee.MiroirHorizontal();
            this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
            this.pboImageTransfo.Invalidate();
        }
        #endregion
    }
}
#endregion