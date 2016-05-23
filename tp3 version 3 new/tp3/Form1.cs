#region MÉTADONNÉES
/* Nom du fichier         : Form1
 * Nom du programmeur     : Maxim Desloges et Junior Cortenbach
 * Date                   : 22 mai 2016
*/
#endregion

#region USING
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
#endregion


namespace tp3
{
    /// <summary>
    /// </summary>
    public partial class FrmTransformationImage : Form
    {

        #region ATTRIBUTS


        /// <summary>
        /// Bitmap de l'image à transformée pour affichage dans le premier pbo.
        /// </summary>
        private BitmapMatricielle _imageATransformerBitmap = null;

        /// <summary>
        /// Bitmap de l'image une fois transformée pour affichage dans le deuxième pbo.
        /// </summary>
        private BitmapMatricielle _imageTransformee = null;


        /// <summary>
        /// Importation du dll qui sert a faire sortir le lecteur dvd
        /// </summary>
        /// <param name="lpstrCommand"></param>
        /// <param name="lpstrReturnString"></param>
        /// <param name="uReturnLength"></param>
        /// <param name="hwndCallback"></param>
        /// <returns></returns>
        [DllImport("winmm.dll", EntryPoint = "mciSendString")]
        public static extern int mciSendStringA(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        /// <summary>
        /// Nombre iterations.
        /// </summary>
        private int _iteration;

        /// <summary>
        /// Nombre intervalle entre iteration
        /// </summary>
        private int _intervalleEntreIteration;

        /// <summary>
        /// Aller à en chiffre
        /// </summary>
        private int _lieuxChiffre;

        /// <summary>
        /// Variable
        /// </summary>
        private string _rt;

        
        #endregion

        #region PROPRIETES

        /// <summary>
        /// Image à Transofrmé 
        /// </summary>
        public BitmapMatricielle ImageATransformerBitmap
        {
            get { return this._imageATransformerBitmap; }
            set { this._imageATransformerBitmap = value; }
        }

        /// <summary>
        /// Image Transformée 
        /// </summary>
        public BitmapMatricielle ImageTransformee
        {
            get { return this._imageTransformee; }
            set { this._imageTransformee = value; }
        }

        #endregion

        /// <summary>
        /// Initialize les composant.
        /// </summary>
        public FrmTransformationImage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Liste de transformation avec leur déscription. 
            List<String> transformationAffichage = UtilEnum.GetAllDescriptions<TransformationType>();

            //Boucle qui permet d'afficher les Transformation dans un combobox
            for (int i = 0; i < transformationAffichage.Count; i++)
            {
                this.cmbTransformation.Items.Add(transformationAffichage[i]);
            }

        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chargerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Intialisation du message.
            this.lblMessage.Text = "";

            string cheminFichier;


            Utilitaire.DemanderSelectionnerFichierImage(out cheminFichier);

            this.ImageATransformerBitmap = new BitmapMatricielle();
            this.ImageATransformerBitmap.ImageBitmap = new Bitmap(Image.FromFile(cheminFichier));
            this.pboImageIni.Image = this.ImageATransformerBitmap.ImageBitmap;


            this.ImageTransformee = new BitmapMatricielle();
            this.ImageTransformee.ImageBitmap = new Bitmap(Image.FromFile(cheminFichier));
            this.pboImageTransfo.Image = this.ImageATransformerBitmap.ImageBitmap;

        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSepia_Click_1(object sender, EventArgs e)
        {

            Bitmap image = this.ImageATransformerBitmap.ImageBitmap;
            this.ImageTransformee.ImageBitmap = this.ImageATransformerBitmap.Sepia(image, this._iteration);
            this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
            this._iteration = 0;
            this.lblIteration.Text = this._iteration.ToString();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="Exception"></exception>
        private void btnAvancementUnique_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbTransformation.SelectedItem == null)
                {
                    throw new ArgumentNullException("Veuillez sélectionner une transformation.");
                }
                else
                {
                    string transformationSelectionner = this.cmbTransformation.Text;

                    switch (transformationSelectionner)
                    {
                        case "Miroir horizontal":
                            this.ImageTransformee.MiroirHorizontal();
                            this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                            this._iteration++;
                            break;
                        case "Miroir vertical":
                            this.ImageTransformee.MiroirVertical();
                            this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                            this._iteration++;
                            break;
                        case "Transposition (dimensions identiques)":
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
                        case "Décalage horizontal vers la droite":
                            this.ImageTransformee.DecalageHorizontal();
                            this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                            this._iteration++;
                            break;
                        case "Décalage en diagonale vers la droite et le bas":
                            this.ImageTransformee.DecalageDiagonale();
                            this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                            this._iteration++;
                            break;
                        case "En colonnes (dimensions paires)":
                            if ((this.ImageATransformerBitmap.Hauteur % 2 != 0) || (this.ImageATransformerBitmap.Largeur % 2 != 0))
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
                        case "Photomaton (dimensions paires)":
                            if ((this.ImageATransformerBitmap.Hauteur % 2 != 0) || (this.ImageATransformerBitmap.Largeur % 2 != 0))
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
                        case "Boulanger (dimensions paires)":
                            if ((this.ImageATransformerBitmap.Hauteur % 2 != 0) || (this.ImageATransformerBitmap.Largeur % 2 != 0))
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
                        case "Fleur (dimensions paires)":
                            if ((this.ImageATransformerBitmap.Hauteur % 2 != 0) || (this.ImageATransformerBitmap.Largeur % 2 != 0))
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
                        case "Svastika (dimensions paires et identiques)":
                            if (this.ImageATransformerBitmap.Hauteur > this.ImageATransformerBitmap.Largeur)
                            {
                                throw new Exception("Les dimensions de l'image doivent être paires et identiques.");
                            }
                            else if ((this.ImageATransformerBitmap.Hauteur % 2 != 0) || (this.ImageATransformerBitmap.Largeur % 2 != 0))
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
            }
            catch
            {
                //Affichage du message d'erreur si une exception est levée.
                MessageBox.Show(@"Une erreur s'est produite. Veuillez vous référer à l'exception.");
            }
            //Affiche le nombre d'iteration
            this.lblIteration.Text = this._iteration.ToString();

        }


        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNiveauDeGris_Click(object sender, EventArgs e)
        {
            Bitmap image = this.ImageATransformerBitmap.ImageBitmap;
            this.ImageTransformee.ImageBitmap = this.ImageATransformerBitmap.NiveauDeGris(image, this._iteration);
            this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
            this._iteration = 0;
            this.lblIteration.Text = this._iteration.ToString();
            //Affiche le nombre d'iteration
            this.lblIteration.Text = this._iteration.ToString();

            FrmTransformationImage.mciSendStringA("set CDAudio door open", this._rt, 127, 0);

        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStoper_Click(object sender, EventArgs e)
        {
            this.chronometre1.Stop();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentNullException"></exception>
        private void btnAvancementContinue_Click(object sender, EventArgs e)
        {
            //Intialisation du message.
            this.lblMessage.Text = "";

            try
            {
                if (this.txtDuree.Text == null)
                    throw new ArgumentNullException(null, @"La durée ne doit pas être nulle.");
                else
                {
                    //Temps chronomètre
                    this._intervalleEntreIteration = int.Parse(this.txtDuree.Text);
                    this.chronometre1.Interval = this._intervalleEntreIteration;

                    this.chronometre1.Start();
                }
            }
            catch
            {
                MessageBox.Show(@"Veuillez saisir une durée adéquate.");
            }

            if (this.cmbTransformation.SelectedItem == null)
            {
                throw new ArgumentNullException(null, @"Veuillez selectionez une transformation");
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chronometre1_Tick(object sender, EventArgs e)
        {

            this._iteration++;

            string transformationSelectionner = this.cmbTransformation.Text;



            switch (transformationSelectionner)
            {
                case "Miroir horizontal":
                    this.ImageTransformee.MiroirHorizontal();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                    break;
                case "Miroir vertical":
                    this.ImageTransformee.MiroirVertical();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                    break;
                case "Transposition (dimensions identiques)":
                    this.ImageTransformee.Transposition();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                    break;
                case "Décalage horizontal vers la droite":
                    this.ImageTransformee.DecalageHorizontal();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                    break;
                case "Décalage en diagonale vers la droite et le bas":
                    this.ImageTransformee.DecalageDiagonale();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                    break;
                case "En colonnes (dimensions paires)":
                    this.ImageTransformee.Colonnes();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                    break;
                case "Photomaton (dimensions paires)":
                    this.ImageTransformee.Photomaton();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                    break;
                case "Boulanger (dimensions paires)":
                    this.ImageTransformee.Boulanger();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                    break;
                case "Fleur (dimensions paires)":
                    this.ImageTransformee.Fleur();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                    break;
                case "Svastika (dimensions paires et identiques)":
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
                this.lblMessage.Text = @"Transformation complétée en " + this._iteration.ToString() + @" itérations.";
                this.lblIteration.Text = (this._iteration = 0).ToString();
            }
            this.lblIteration.Text = this._iteration.ToString();

        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.pboImageTransfo.Image = this.pboImageIni.Image;
            this._iteration = 0;
            this.lblIteration.Text = this._iteration.ToString();
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="Exception"></exception>
        private void btnAllerA_Click(object sender, EventArgs e)
        {

            this.pboImageTransfo.Image = this.pboImageIni.Image;
            this._iteration = 0;

            string transformationSelectionner = this.cmbTransformation.Text;

            try
            {
                if (this.cmbTransformation.SelectedItem == null)
                {
                    throw new ArgumentNullException("Veuillez sélectionner une transformation.");
                }
                if (this.txtAller.Text == null)
                {
                    throw new ArgumentNullException("Veuillez sélectionner une transformation.");

                    throw new ArgumentNullException("Veuillez sélectionner une transformation.");
                }
                else
                {
                    string lieux = this.txtAller.Text;
                    this._lieuxChiffre = int.Parse(lieux);

                    switch (transformationSelectionner)
                    {
                        case "Miroir horizontal":
                            for (int i = 0; i < this._lieuxChiffre; i++)
                            {
                                this.ImageTransformee.MiroirHorizontal();
                                this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                                i++;
                            }
                            break;
                        case "Miroir vertical":
                            for (int i = 0; i < this._lieuxChiffre; i++)
                            {
                                this.ImageTransformee.MiroirVertical();
                                this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                                i++;
                            }
                            break;
                        case "Transposition (dimensions identiques)":
                            if (this.ImageATransformerBitmap.Largeur / this.ImageATransformerBitmap.Hauteur != 1)
                            {
                                throw new Exception("Les deux dimensions de l'image doivent avoir la même valeur.");
                            }
                            else
                            {
                                for (int i = 0; i < this._lieuxChiffre; i++)
                                {
                                    this.ImageTransformee.Transposition();
                                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                                    i++;
                                }
                            }
                            break;
                        case "Décalage horizontal vers la droite":
                            for (int i = 0; i < this._lieuxChiffre; i++)
                            {
                                this.ImageTransformee.DecalageHorizontal();
                                this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                                i++;
                            }
                            break;
                        case "Décalage en diagonale vers la droite et le bas":
                            for (int i = 0; i < this._lieuxChiffre; i++)
                            {
                                this.ImageTransformee.DecalageDiagonale();
                                this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                                i++;
                            }
                            break;
                        case "En colonnes (dimensions paires)":
                            if ((this.ImageATransformerBitmap.Hauteur % 2 != 0) ||
                                    (this.ImageATransformerBitmap.Largeur % 2 != 0))
                            {
                                throw new Exception("Les dimensions de l'image doivent être paires.");
                            }
                            else
                            {
                                for (int i = 0; i < this._lieuxChiffre; i++)
                                {
                                    this.ImageTransformee.Colonnes();
                                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                                    i++;
                                }
                            }
                            break;
                        case "Photomaton (dimensions paires)":
                            if (this.ImageATransformerBitmap.Hauteur % 2 != 0 ||
                                this.ImageATransformerBitmap.Largeur % 2 != 0)
                            {
                                throw new Exception(
                                    "Les dimensions de l'image doivent être paires pour effectuer une transformation de Photomaton.");
                            }
                            else
                            {
                                for (int i = 0; i < this._lieuxChiffre; i++)
                                {
                                    this.ImageTransformee.Photomaton();
                                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                                    i++;
                                }
                            }
                            break;
                        case "Boulanger (dimensions paires)":
                            if (this.ImageATransformerBitmap.Hauteur % 2 != 0 ||
                                this.ImageATransformerBitmap.Largeur % 2 != 0)
                            {
                                throw new Exception(
                                    "Les dimensions de l'image doivent être paires pour effectuer une transformation de Boulanger.");
                            }
                            else
                            {
                                for (int i = 0; i < this._lieuxChiffre; i++)
                                {
                                    this.ImageTransformee.Boulanger();
                                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                                    i++;
                                }
                            }
                            break;
                        case "Fleur (dimensions paires)":
                            if ((this.ImageATransformerBitmap.Hauteur % 2 != 0) ||
                                (this.ImageATransformerBitmap.Largeur % 2 != 0))
                            {
                                throw new Exception(
                                    "Les dimensions de l'image doivent être paires pour effectuer une transformation de Fleur.");
                            }
                            else
                            {
                                for (int i = 0; i < this._lieuxChiffre; i++)
                                {
                                    this.ImageTransformee.Fleur();
                                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                                    i++;
                                }
                            }
                            break;
                        case "Svastika (dimensions paires et identiques)":
                            if (this.ImageATransformerBitmap.Hauteur > this.ImageATransformerBitmap.Largeur)
                            {
                                throw new Exception("Les dimensions de l'image doivent être paires et identiques.");
                            }
                            else if ((this.ImageATransformerBitmap.Hauteur % 2 != 0) ||
                                     (this.ImageATransformerBitmap.Largeur % 2 != 0))
                            {
                                throw new Exception(
                                    "Les dimensions de l'image doivent être paires pour effecture une transformation de Svastiaka");
                            }
                            else
                            {
                                for (int i = 0; i < this._lieuxChiffre; i++)
                                {
                                    this.ImageTransformee.Svasitka();
                                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;
                                    i++;
                                }
                            }
                            break;
                        default:
                            MessageBox.Show(@"Une erreur s'est produite");
                            break;
                    }
                    //Affiche le nombre d'iteration
                    this.lblIteration.Text = this._iteration.ToString();
                    this.pboImageTransfo.Image = this.ImageTransformee.ImageBitmap;

                }
            }
            catch
            {
                //Affichage du message d'erreur si une exception est levée.
                MessageBox.Show(@"Une erreur s'est produite. Veuillez vous référer à l'exception.");
            }

        }

    }
}
