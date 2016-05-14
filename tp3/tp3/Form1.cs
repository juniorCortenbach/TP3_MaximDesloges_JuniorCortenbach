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
            get { return this._imageATransformerBitmap; }
            set { this._imageATransformerBitmap = value; }
        }

        public BitmapMatricielle ImageTransformee
        {
            get { return this._imageTransformee; }
            set { this._imageTransformee = value; }
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
            //Temps chronomètre
            this.chronometre1.Interval = 1000;


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


            //Boucle qui permet d'afficher les Transformation dans un combobox
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

            Bitmap image = this.ImageATransformerBitmap.ImageBitmap;
            this.ImageTransformee.ImageBitmap = this.ImageATransformerBitmap.Sepia(image, this._iteration);
            this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
            this._iteration++;


        }


        private void btnAvancementUnique_Click(object sender, EventArgs e)
        {
            if (this.cmbTransformation.SelectedItem == null)
            {
                MessageBox.Show(@"Veuillez selectionez une transformation");
            }
            else
            {
                //Variable TransformationType qui contient la transformation selectionée
                TransformationType transformation = (TransformationType)Enum.Parse(typeof(TransformationType), this.cmbTransformation.SelectedItem.ToString());

            switch (transformation)
            {
                case TransformationType.MiroirHorizontal:
                    this.ImageTransformee.MiroirHorizontal();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                    break;
                case TransformationType.MiroirVertical:
                    this.ImageTransformee.MiroirVertical();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                    break;
                case TransformationType.Transposition:
                    MessageBox.Show(@"En constructions");
                    break;
                case TransformationType.DecalageHorizontal:
                    this.ImageTransformee.DecalageHorizontal();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                    break;
                case TransformationType.DecalageVertical:
                    MessageBox.Show(@"En constructions");
                    break;
                case TransformationType.DecalageEnDiagonale:
                    MessageBox.Show(@"En constructions");
                    break;
                case TransformationType.Colonnes:
                    MessageBox.Show(@"En constructions");
                    break;
                case TransformationType.Photomaton:
                    this.ImageTransformee.Photomaton();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                    break;
                case TransformationType.Boulanger:
                    MessageBox.Show(@"En constructions");
                    break;
                case TransformationType.Fleur:
                    MessageBox.Show(@"En constructions");
                    break;
                case TransformationType.Svastika:
                    MessageBox.Show(@"En constructions");
                    break;
                default:
                    MessageBox.Show(@"Une erreur s'est produite");
                    break;
             }

            }

        }
        #endregion

        private void btnNiveauDeGris_Click(object sender, EventArgs e)
        {
            Bitmap image = this.ImageATransformerBitmap.ImageBitmap;
            this.ImageTransformee.ImageBitmap = this.ImageATransformerBitmap.NiveauDeGris(image, this._iteration);
            this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
            this._iteration++;

        }

        private void btnStoper_Click(object sender, EventArgs e)
        {
            this.chronometre1.Stop();
        }

        private void btnAvancementContinue_Click(object sender, EventArgs e)
        {
            switch (this.txtDuree.Text)
            {
                case "":
                    MessageBox.Show(@"Veillez entrez une durée");
                    break;
                case null:
                    MessageBox.Show(@"Veillez entrez une durée");
                    break;
                default:
                    if (this.cmbTransformation.SelectedItem == null)
                    {
                        MessageBox.Show(@"Veuillez selectionez une transformation");
                    }
                    else
                    this.chronometre1.Start();
                    break;
            }

     
        }

        private void chronometre1_Tick(object sender, EventArgs e)
        {
           
                        //Variable TransformationType qui contient la transformation selectionée
                        TransformationType transformation = (TransformationType)Enum.Parse(typeof(TransformationType), this.cmbTransformation.SelectedItem.ToString());

                        switch (transformation)
                        {
                            case TransformationType.MiroirHorizontal:
                                this.ImageTransformee.MiroirHorizontal();
                                this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                                break;
                            case TransformationType.MiroirVertical:
                                this.ImageTransformee.MiroirVertical();
                                this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                                break;
                            case TransformationType.Transposition:
                                 //En construction        
                                 break;
                            case TransformationType.DecalageHorizontal:
                                this.ImageTransformee.DecalageHorizontal();
                                this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                                break;
                            case TransformationType.DecalageVertical:
                             //En construction
                                break;
                            case TransformationType.DecalageEnDiagonale:
                             //En construction
                                break;
                            case TransformationType.Colonnes:
                               //En construction
                                break;
                            case TransformationType.Photomaton:
                                this.ImageTransformee.Photomaton();
                                this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                                break;
                            case TransformationType.Boulanger:
                               //En construction
                                break;
                            case TransformationType.Fleur:
                              //En construction
                                break;
                            case TransformationType.Svastika:
                             //En construction
                                 break;
                            default:
                                MessageBox.Show(@"Une erreur s'est produite");
                                break;
                        }

        }
    }
}
#endregion