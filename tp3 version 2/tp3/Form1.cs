using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

        //Bitmap de l'image à transformée pour affichage dans le premier pbo.
        private BitmapMatricielle _imageATransformerBitmap = null;

        //Bitmap de l'image une fois transformée pour affichage dans le deuxième pbo.
        private BitmapMatricielle _imageTransformee = null;

        //Variables intermédiaires.
        int _iteration;
        int _intervalleEntreIteration;

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

        #region EVENEMENTS

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
            //string cheminFichier;

            // Création de l'objet "OpenFileDialog".
            //OpenFileDialog ofd = new OpenFileDialog();

            //Utilitaire.DemanderSelectionnerFichierImage(out cheminFichier);

            //this.ImageATransformerBitmap = new BitmapMatricielle();
            //this.ImageATransformerBitmap.ImageBitmap = new Bitmap(Image.FromFile(cheminFichier));
            //this.pboImageIni.Image = this.ImageATransformerBitmap.ImageBitmap;

            //this.ImageTransformee = new BitmapMatricielle();
            //this.ImageTransformee.ImageBitmap = new Bitmap(Image.FromFile(cheminFichier));
            //this.pboImageTransfo.Image = this.ImageATransformerBitmap.ImageBitmap;

            //Boucle qui permet d'afficher les transformations dans un combobox.
            foreach (TransformationType transformation in Enum.GetValues(typeof(TransformationType)))
            {
                this.cmbTransformation.Items.Add(transformation);
            }
            List<String> transformationAffichage = UtilEnum.GetAllDescriptions<TransformationType>();

        }

        private void chargerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Intialisation du message.
            lblMessage.Text = "";

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
            this._iteration = 0;
            lblIteration.Text = this._iteration.ToString();
        }

        private void btnAvancementUnique_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (this.cmbTransformation.SelectedItem == null)
            {
                throw new ArgumentNullException(null, "Veuillez sélectionner une transformation.");
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
                        this._iteration++;
                        break;
                    case TransformationType.MiroirVertical:
                        this.ImageTransformee.MiroirVertical();
                        this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                        this._iteration++;
                        break;
                    case TransformationType.Transposition:
                        if (this.ImageATransformerBitmap.Largeur / this.ImageATransformerBitmap.Hauteur != 1)
                        {
                            throw new Exception("Les deux dimensions de l'image doivent avoir la même valeur.");
                        }
                        else
                        {
                            this.ImageTransformee.Transposition();
                            this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                            this._iteration++;
                        }
                        break;
                    case TransformationType.DecalageHorizontal:
                        this.ImageTransformee.DecalageHorizontal();
                        this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                        this._iteration++;
                        break;
                    case TransformationType.DecalageEnDiagonale:
                        this.ImageTransformee.DecalageDiagonale();
                        this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                        this._iteration++;
                        break;
                    case TransformationType.Colonnes:
                        if (this.ImageATransformerBitmap.Hauteur % 2 != 0 || this.ImageATransformerBitmap.Largeur % 2 != 0)
                        {
                            throw new Exception("Les dimensions de l'image doivent être paires.");
                        }
                        else
                        {
                            this.ImageTransformee.Colonnes();
                            this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                            this._iteration++;
                        }
                        break;
                    case TransformationType.Photomaton:
                        if (this.ImageATransformerBitmap.Hauteur % 2 != 0 || this.ImageATransformerBitmap.Largeur % 2 != 0)
                        {
                            throw new Exception("Les dimensions de l'image doivent être paires pour effectuer une transformation de Photomaton.");
                        }
                        else
                        {
                            this.ImageTransformee.Photomaton();
                            this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                            this._iteration++;
                        }
                        break;
                    case TransformationType.Boulanger:
                        if (this.ImageATransformerBitmap.Hauteur % 2 != 0 || this.ImageATransformerBitmap.Largeur % 2 != 0)
                        {
                            throw new Exception("Les dimensions de l'image doivent être paires pour effectuer une transformation de Boulanger.");
                        }
                        else
                        {
                            this.ImageTransformee.Boulanger();
                            this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                            this._iteration++;
                        }
                        break;
                    case TransformationType.Fleur:
                        if (this.ImageATransformerBitmap.Hauteur % 2 != 0 || this.ImageATransformerBitmap.Largeur % 2 != 0)
                        {
                            throw new Exception("Les dimensions de l'image doivent être paires pour effectuer une transformation de Fleur.");
                        }
                        else
                        {
                            this.ImageTransformee.Fleur();
                            this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                            this._iteration++;
                        }
                        break;
                    case TransformationType.Svastika:
                        if (this.ImageATransformerBitmap.Hauteur > this.ImageATransformerBitmap.Largeur)
                        {
                            throw new Exception("Les dimensions de l'image doivent être paires et identiques.");
                        }
                        else if (this.ImageATransformerBitmap.Hauteur % 2 != 0 || this.ImageATransformerBitmap.Largeur % 2 != 0)
                        {
                            throw new Exception("Les dimensions de l'image doivent être paires pour effecture une transformation de Svastiaka");
                        }
                        else
                        {
                            this.ImageTransformee.Svasitka();
                            this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                            this._iteration++;
                        }
                        break;
                    default:
                        MessageBox.Show(@"Une erreur s'est produite");
                        break;
                }
                //Affiche le nombre d'iteration
                this.lblIteration.Text = this._iteration.ToString();

            }
            //}
            // catch
            //{
            //Affichage du message d'erreur si une exception est levée.
            //    MessageBox.Show("Une erreur s'est produite. Veuillez vous référer à l'exception.");
            // }

        }

        private void btnNiveauDeGris_Click(object sender, EventArgs e)
        {
            Bitmap image = this.ImageATransformerBitmap.ImageBitmap;
            this.ImageTransformee.ImageBitmap = this.ImageATransformerBitmap.NiveauDeGris(image, this._iteration);
            this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
            this._iteration = 0;
            lblIteration.Text = this._iteration.ToString();
            //Affiche le nombre d'iteration
            this.lblIteration.Text = this._iteration.ToString();
        }

        private void btnStoper_Click(object sender, EventArgs e)
        {
            this.chronometre1.Stop();
        }

        private void btnAvancementContinue_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDuree.Text == null)
                    throw new ArgumentNullException(null, "La durée ne doit pas être nulle.");
                else
                {
                    //Temps chronomètre
                    _intervalleEntreIteration = int.Parse(txtDuree.Text);
                    this.chronometre1.Interval = _intervalleEntreIteration;

                    this.chronometre1.Start();
                }
            }
            catch
            {
                MessageBox.Show("Veuillez saisir une durée adéquate.");
            }

            if (this.cmbTransformation.SelectedItem == null)
            {
                throw new ArgumentNullException(null, @"Veuillez selectionez une transformation");
            }
        }

        private void chronometre1_Tick(object sender, EventArgs e)
        {
            //Variable TransformationType qui contient la transformation selectionée
            TransformationType transformation = (TransformationType)Enum.Parse(typeof(TransformationType), this.cmbTransformation.SelectedItem.ToString());

            this._iteration++;

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
                    this.ImageTransformee.Transposition();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                    break;
                case TransformationType.DecalageHorizontal:
                    this.ImageTransformee.DecalageHorizontal();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                    break;
                case TransformationType.DecalageEnDiagonale:
                    this.ImageTransformee.DecalageDiagonale();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                    break;
                case TransformationType.Colonnes:
                    this.ImageTransformee.Colonnes();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                    break;
                case TransformationType.Photomaton:
                    this.ImageTransformee.Photomaton();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                    break;
                case TransformationType.Boulanger:
                    this.ImageTransformee.Boulanger();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                    break;
                case TransformationType.Fleur:
                    this.ImageTransformee.Fleur();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                    break;
                case TransformationType.Svastika:
                    this.ImageTransformee.Svasitka();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                    break;
                default:
                    MessageBox.Show(@"Une erreur s'est produite");
                    break;
            }
            if (this.ImageATransformerBitmap == this.ImageTransformee)
            {
                this.chronometre1.Stop();
                lblMessage.Text = "Transformation complétée en " + this._iteration.ToString() + " itérations.";
                lblIteration.Text = (this._iteration = 0).ToString();
            }
            lblIteration.Text = this._iteration.ToString();

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.pboImageTransfo.Image = this.pboImageIni.Image;
            this._iteration = 0;
            lblIteration.Text = this._iteration.ToString();
        }

        private void btnAllerA_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
#endregion