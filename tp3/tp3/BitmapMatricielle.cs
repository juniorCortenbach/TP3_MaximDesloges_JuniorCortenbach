#region MÉTADONNÉES

// Nom du fichier : BitmapMatricielle.cs
// Auteur : Desloges et Junior
// Date de création : 2016-04-25
// Date de modification : 2016-04-25

#endregion

#region USING

using System;
using System.Drawing;

#endregion

namespace tp3
{
    /// <summary>
    /// Classe représentant une image bitmap et permettant la manipulation de ses pixels avec la
    /// notation matricielle.
    /// </summary>
    public class BitmapMatricielle
    {
        #region ATTRIBUTS

        /// <summary>
        /// Image bitmap que représente l'objet.
        /// </summary>
        private Bitmap _imageBitmap;

        #endregion

        #region PROPRIÉTÉS ET INDEXEURS

        /// <summary>
        /// Image bitmap que représente l'objet.
        /// </summary>
        public Bitmap ImageBitmap
        {
            get { return this._imageBitmap; }
            set
            { this._imageBitmap = value; }
        }

        /// <summary>
        /// Hauteur de l'image.
        /// </summary>
        public int Hauteur
        {
            get { return this._imageBitmap.Height; }
            set
            {
                if (value > 512)
                    throw new ArgumentOutOfRangeException("L'image ne doit pas avoir une dimension" +
                        "plus grande que la taille du pictureBox");
                if (value == 0)
                    throw new ArgumentNullException(null, "La hauteur ne doit pas être nulle.");
                this.Hauteur = value;
            }
        }

        /// <summary>
        /// Largeur de l'image.
        /// </summary>
        public int Largeur
        {
            get { return this._imageBitmap.Width; }
            set
            {
                if (value > 512)
                    throw new ArgumentOutOfRangeException("L'image ne doit pas avoir une dimension" +
                        "plus grande que la taille du pictureBox");
                if (value == 0)
                    throw new ArgumentNullException(null, "La hauteur ne doit pas être nulle.");
                this.Hauteur = value;
            }
        }

        #endregion

        #region CONSTRUCTEURS

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public BitmapMatricielle()
        {
            this.ImageBitmap = null;
        }

        /// <summary>
        /// Constructeur qui initialise l'objet avec l'image bitmap reçu en paramètre.
        /// </summary>
        /// <param name="imageBitmap">Bitmap que représente l'objet.</param>
        public BitmapMatricielle(Bitmap imageBitmap)
        {
            this.ImageBitmap = imageBitmap;
        }

        /// <summary>
        /// Constructeur qui initialise l'objet avec un bitmap vide de la dimension spécifiée.
        /// </summary>
        /// <param name="largeur">Largeur de l'image.</param>
        /// <param name="hauteur">Hauteur de l'image.</param>
        public BitmapMatricielle(short largeur, short hauteur)
        {
            this.ImageBitmap = new Bitmap(largeur, hauteur);
        }

        #endregion

        /// <summary>
        /// Indexeur qui permet d'accéder aux pixels de l'image en x (lignes) et en y (colonnes).
        /// </summary>
        /// <param name="lignes">Indice du sous-élément de l'élément actuel.</param>
        /// <param name="colonnes">Indice du sous-élément du sous-élément à la position indice1</param>
        /// <returns>Le sous-élément (String ou ElementHtml) désigné par les deux indices.</returns>
        public Color this[int i, int j]
        {
            get
            {
                // Validation des indices à l'aide la méthode privée.
                // Note : Si les indices sont invalides, cette méthode de validation lève une exception qui n'est pas attrapée ici
                // et qui causera ainsi l'arrêt de l'exécution de l'accesseur.
                // ValiderIndicesIndexeur(lignes, colonnes);

                // Récupération de la couleur du pixel à la position (i,j).
                //Color couleurPixelAIndice = this.ImageBitmap.GetPixel(i, j);

                // Retourne la valeur (pixel) désigné par les deux indices
                // (comme si un pixel est une position sur un plan cartésien(image)).
                return this.ImageBitmap.GetPixel(i, j);
            }

            set
            {

                // Validation des indices à l'aide la méthode privée.
                // Note : Si les indices sont invalides, cette méthode de validation lève une exception qui n'est pas attrapée ici
                // et qui causera ainsi l'arrêt de l'exécution de l'accesseur.
                //ValiderIndicesIndexeur(indice1, indice2);

                // Récupération du sous-élément (de type ElementHtml) de l'élément actuel à l'indice indice1.
                //Color couleurPixelAIndice = this.ImageBitmap.GetPixel(i, j);

                // Affecte la couleur désirée à la position demandée.
                //Color couleurIndice = this.ImageBitmap.SetPixel(i, j, ImageBitmap[i,j].color);
                // Retourne la valeur (pixel) désigné par les deux indices
                // (comme si un pixel est une position sur un plan cartésien(image)).
                //couleurPixelAIndice = (Color) value;

                this.ImageBitmap.SetPixel(i, j, value);
            }
        }

        #region MÉTHODES ET OPÉRATEURS

        #region COMPARAISON

        /// <summary>
        /// </summary>
        /// <param name="imageInital"></param>
        /// <param name="imageAComparer"></param>
        /// <returns>Retourne vrai si les images sont identiques</returns>
        public static bool operator ==(BitmapMatricielle imageInital, BitmapMatricielle imageAComparer)
        {
            //Compare les deux images.
            if (Object.ReferenceEquals(imageInital, imageAComparer))
            {
                return true;
            }

            //Compare les deux images pixel par pixel.
            for (int i = 0; i < imageInital.Largeur; i++)
            {
                for (int j = 0; j < imageInital.Hauteur; j++)
                {
                    if (imageInital[i, j] != imageAComparer[i, j])
                        return false;

                }
            }
            return true;
        }


        /// <summary>
        /// Permet de vérifier si deux objets de type Fraction sont égaux.
        /// </summary>
        /// <param name="obj">Objet de type Fraction à comparer avec l'object courant</param>
        /// <returns>true si les deux objets sont égaux; false, autrement.</returns>
        /// <remarks>
        /// Redéfinition de la méthode de la classe Object qui compare les références des objets uniquement.
        /// Note: Lorsqu'on définit l'opérateur d'égalité (==), on doit redéfinir la méthode "Equals". 
        /// </remarks>
        public override bool Equals(Object obj)
        {
            // Est-ce que "obj" est du type BitmapMatricielle.
            if (obj.GetType() == typeof (BitmapMatricielle))
                return this == (BitmapMatricielle) obj;
            else
                return false;
        }

        /// <summary>
        /// Surcharge de l'opérateur d'inégalité (!=).
        /// </summary>
        /// <param name="fractionGauche">Fraction à gauche de l'opérateur.</param>
        /// <param name="fractionDroite">Fraction à droite de l'opérateur.</param>
        /// <returns>true si les deux images sont différentes; false, autrement.</returns>
        public static bool operator !=(BitmapMatricielle imageInital, BitmapMatricielle imageAComparer)
        {
            // Retourne l'inverse de l'opérateur d'égalité.
            return !(imageInital == imageAComparer);
        }

        #endregion
        

        #region EFFECTS

        #region  NiveauDeGris

        /// <summary>
        /// </summary>
        /// <param name="imageChargee"></param>
        /// <param name="iteration"></param>
        /// <returns>Retourne l'image transfomée sur un niveau de gris supérieur.</returns>
        public Bitmap NiveauDeGris(Bitmap imageChargee, int iteration)
        {

            //Pour chaque rangée.
            for (int i = 0; i < this.Largeur; i++)
            {
                //Pour chaque colonne.
                for (int j = 0; j < this.Hauteur; j++)
                {
                    //Affecte la couleur de chaque pixel.
                    Color couleur = this[i, j];

                    //Prend le rouge, le vert et le bleu de chaque pixel et y applique
                    //la transformation désirée.
                    byte ng = (byte) Math.Round(couleur.R*0.299 + couleur.G*0.587 + couleur.B*0.114);

                    //Affectation de la couleur finale.
                    Color nouvelleCouleur = Color.FromArgb(ng, ng, ng);

                    //La couleur finale est affectée à chaque pixel.
                    this[i, j] = nouvelleCouleur;
                }
            }
            //Retourne la nouvelle image transformée.
            return this.ImageBitmap;
        }

        #endregion

        #region Sepia

        /// <summary>
        /// </summary>
        /// <param name="imageChargee"></param>
        /// <param name="iteration"></param>
        /// <returns>Retourne l'image transfomée en Sepia</returns>
        public Bitmap Sepia(Bitmap imageChargee, int iteration)
        {
            //Pour chaque colonne.
            for (int i = 0; i < this.Largeur; i++)
            {
                //Pour chaque rangée.
                for (int j = 0; j < this.Hauteur; j++)
                {
                    //Affecte la couleur de chaque pixel.
                    Color couleur = this[i, j];
                    //Prend le rouge, le vert et le bleu de chaque pixel et y applique une transformation.
                    byte r = (byte) (Math.Min(couleur.R*0.393 + couleur.G*0.769 + couleur.B*0.189, 255));
                    byte v = (byte) (Math.Min(couleur.R*0.349 + couleur.G*0.686 + couleur.B*0.168, 255));
                    byte b = (byte) (Math.Min(couleur.R*0.272 + couleur.G*0.534 + couleur.B*0.131, 255));

                    //La couleur finale est stockée dans la variable.
                    Color nouvelleCouleur = Color.FromArgb(r, v, b);

                    //Chaque pixel est affiché de nouveau avec sa nouvelle couleur.
                    this[i, j] = nouvelleCouleur;
                }
            }
            //Retourne la nouvelle image transformée 
            return this.ImageBitmap;
        }

        #endregion

        #endregion

        #region TRANSFORMATIONS

        #region MiroirHorizontal

        /// <summary>
        /// Méthode qui retourne l'image transformé en miroir horizontal (inversion haut-bas).
        /// </summary>
        public void MiroirHorizontal()
        {
            //Pour chaque colonne.
            for (int i = 0; i < this.Largeur / 2; i++)
            {
                //Pour chaque rangée.
                for (int j = 0; j < this.Hauteur; j++)
                {
                    //Affecte la couleur du premier pixel de la largeur à une variable temporaire.
                    Color pixel = this[i, j];

                    //Affecte la couleur du dernier pixel au premier pixel de la largeur.
                    this[i, j] = this[this.Largeur - 1 - i, j];

                    //Affecte la couleur du premier pixel au dernier pixel de la largeur.
                    this[this.Largeur - 1 - i, j] = pixel;
                }

            }

        }

        #endregion

        #region MiroirVertical

        /// <summary>
        /// Méthode qui retourne l'image transformée en miroir vertical (inversion haut-bas).
        /// </summary>
        public void MiroirVertical()
        {
            //Pour chaque colonne.
            for (int j = 0; j < this.Hauteur; j++)
            {
                //Pour chaque rangée.
                for (int i = 0; i < this.Largeur / 2; i++)
                {
                    //Affecte la couleur du premier pixel de la largeur à une variable temporaire.
                    Color pixel = this[j, i];

                    //Affecte la couleur du dernier pixel au premier pixel de la largeur.
                    this[j, i] = this[j, this.Largeur - 1 - i];

                    //Affecte la couleur du premier pixel au dernier pixel de la largeur.
                    this[j, this.Largeur - 1 - i] = pixel;
                }

            }

        }

        #endregion

        #region Transposition

        //Transposition selon la diagonale qui part du coin supérieur gauche au
        //coin inférieur droit (selon la diagonale).
        public void Transposition()
        {
            //Pour chaque rangée.
            for (int x = 0; x < this.Largeur; x++)
            {
                //Pour chaque colonne.
                for (int y = x; y < this.Hauteur; y++)
                {
                    //Affecte la couleur du premier pixel de la largeur à une variable temporaire.
                    Color pixel = this[x, y];

                    //Inverse les pixels sur les deux axes.
                    this[x, y] = this[y, x];

                    //Affecte la couleur du pixel lu aux coordonées inversées.
                    this[y, x] = pixel;

                }

            }
        }
        #endregion

        #region DécalageHorizontal

        /// <summary>
        ///  Méthode qui retourne l'image décalée horizontalment.
        /// </summary>
        public void DecalageHorizontal()
        {

            //Tableau temporaire de pixels en rangée. 
            Color[] pixelRangee = new Color[this.Largeur];

            //Pour chaque rangée.
            for (int j = 0; j < this.Hauteur; j++)
            {
                //Pour chaque colonne.
                for (int i = 0; i < this.Largeur; i++)
                {
                    //Décalage des pixels dans la rangée de travail.
                    if (i == 0)
                    {
                        pixelRangee[i] = this[this.Largeur - 1, j];
                    }
                    else
                    {
                        pixelRangee[i] = this[i - 1, j];
                    }
                }

                //Affecte les pixels de la rangée de travail à l'image originel.
                for (int i = 0; i < this.Largeur; i++)
                {
                    this[i, j] = pixelRangee[i];
                }

            }

            }


            #endregion

        #region DécalageVertical

            /// <summary>
            /// Méthode qui retourne l'image décalée verticalement.
            /// </summary>
            public void DecalageVertical()
            {
            //Tableau temporaire de pixels en colonne.
            Color[] pixelColumn = new Color[this.Hauteur];

            //Pour chaque colonne.
            for (int i = 0; i < this.Largeur; i++)
            {
                //Pour chaque rangée.
                for (int j = 0; j < this.Hauteur; j++)
                {
                    //Décalage des pixels dans la colonne de travail.
                    if (j == 0)
                    {
                        pixelColumn[j] = this[i, this.Hauteur - 1];
                    }
                    else
                    {
                        pixelColumn[j] = this[i, j - 1];
                    }
                }

                //Affecte les pixels de la colonne à l'image d'origine.
                for (int j = 0; j < this.Hauteur; j++)
                {
                    this[i, j] = pixelColumn[j];
                }

            }

        }

        #endregion

        #region Décalage diagonale

        /// <summary>
        /// Méthode qui retourne l'image décalée en diagonale.
        /// </summary>
        public void DecalageDiagonale()
        {
            //Tableau de pixels utilisé comme tableau temporaire.
            Color[,] tabPixels = new Color[this.Largeur, this.Hauteur];

            //Pour chaque rangée.
            for (int j = 0; j < this.Hauteur; j++)
            {
                //Pour chaque colonne.
                for (int i = 0; i < this.Largeur; i++)
                {
                    //Décalage des pixels dans la rangée de travail.
                    if (i == 0)
                    {
                        //Le premier pixel en largeur prend la couleur
                        //du dernier pixel en largeur sur la même hauteur.
                        tabPixels[i, j] = this[this.Largeur - 1, j];
                    }
                    else
                    {
                        //Le pixel lu prend la couleur du
                        //pixel précédent en largeur sur la même hauteur.
                        tabPixels[i, j] = this[i - 1, j];
                    }
                }

                //Pour toute la largeur de l'image.
                for (int i = 0; i < this.Largeur; i++)
                {
                    //Affectation de la colonne de pixels modifiés
                    //à l'image.
                    this[i, j] = tabPixels[i, j];
                }
            }

            //Pour chaque colonne.
            for (int i = 0; i < this.Largeur; i++)
            {
                //Pour chaque rangée.
                //Décalage des pixels dans la colonne de travail.
                for (int j = 0; j < this.Hauteur; j++)
                {
                    if (j == 0)
                    {
                        //Si le pixel lu est le premier pixel en hauteur,
                        //Sa couleur sera celle du dernier pixel en hauteur. 
                        tabPixels[i, j] = this[i, this.Hauteur - 1];
                    }
                    else
                    {
                        //La couleur du pixel est celle du pixel précédent
                        //en hauteur.
                        tabPixels[i, j] = this[i, j - 1];
                    }
                }

                //Affectation de la matrice de pixels modifiés à l'image.
                for (int j = 0; j < this.Hauteur; j++)
                {
                    this[i, j] = tabPixels[i, j];
                }
            }

        }


        #endregion

        #region Colonnes

        /// <summary>
        /// Méthode qui retourne l'image en colonnes (dimensions paires).
        /// </summary>
        public void Colonnes()
        {
            //Clone de l'image initiale.
            BitmapMatricielle imgTempo = new BitmapMatricielle(new Bitmap(this.ImageBitmap));

            //Boucles qui ne reprennent que la moitié des pixels sur la largeur.
            for (int j = 0; j < this.Hauteur; j++)
            {
                for (int i = 0; i < this.Largeur; i = i + 2)
                {
                    if (i != 0)
                        this[i, j] = imgTempo[i / 2, j];
                }
            }

            //Boucles qui affectent les derniers pixels sur la largeur aux premiers pixels.
            for (int j = 0; j < this.Hauteur; j++)
            {
                for (int i = 1; i < this.Largeur; i = i + 2)
                {
                    this[i, j] = imgTempo[((this.Largeur) + (i - 1)) / 2, j];
                }
            }
        }
        #endregion

        #region Photomaton

        /// <summary>
        /// Méthode qui retourne l'image en Photomaton.
        /// </summary>
        public void Photomaton()
        {
            //Tableau temporaire avec les mêmes dimensions.
            Color[,] tabTempo = new Color[this.Largeur, this.Hauteur];

            //Boucles pour le premier quadrant (rouge).
            for (int j = 0; j < this.Hauteur; j = j + 2)
            {
                for (int i = 0; i < this.Largeur; i = i + 2)
                {
                    tabTempo[i/2, j/2] = this[i, j];
                }
            }
            //Boucles pour le deuxième quadrant (bleu).
            for (int i = 1; i < this.Largeur; i = i + 2)
            {
                for (int j = 0; j < this.Hauteur; j = j + 2)
                {
                    tabTempo[i/2 + this.Largeur/2, j/2] = this[i, j];
                }
            }
            //Boucles pour le troisième quadrant (vert).
            for (int j = 1; j < this.Hauteur; j = j + 2)
            {
                for (int i = 0; i < this.Largeur; i = i + 2)
                {
                    tabTempo[i/2, j/2 + this.Hauteur/2] = this[i, j];
                }
            }
            //Boucles pour le quatirème quadrant (jaune).
            for (int j = 1; j < this.Hauteur; j = j + 2)
            {
                for (int i = 1; i < this.Largeur; i = i + 2)
                {
                    tabTempo[i/2 + this.Largeur/2, j/2 + this.Hauteur/2] = this[i, j];
                }
            }
            //Affecte les pixels modifiés à l'image intial pour l'affichage.
            for (int i = 0; i < this.Largeur; i++)
            {
                for (int j = 0; j < this.Hauteur; j++)
                {
                    this[i, j] = tabTempo[i, j];
                }
            }
        }

        #region Fleur

        //Méthode qui renvoie l'image sous formes de pétales (voir site
        //de sébastien).
        public void Fleur()
        {
            //Taille du tableaux temporaire
            Color[,] tabTempo = new Color[this.Largeur, this.Hauteur];
            //Boucles pour le premier quadrant (rouge).
            for (int j = 0; j < this.Hauteur; j = j + 2)
            {
                for (int i = 0; i < this.Largeur; i = i + 2)
                {
                    tabTempo[i / 2, j / 2] = this[i, j];
                }
            }
            //Boucles pour le deuxième quadrant (bleu).
            for (int i = 1; i < this.Largeur; i = i + 2)
            {
                for (int j = 0; j < this.Hauteur; j = j + 2)
                {
                    tabTempo[i / 2 + this.Largeur / 2, j / 2] = this[this.Largeur - 1 - i, j];
                }
            }
            //Boucles pour le troisième quadrant (vert).
            for (int j = 1; j < this.Hauteur; j = j + 2)
            {
                for (int i = 0; i < this.Largeur; i = i + 2)
                {
                    tabTempo[i / 2, j / 2 + this.Hauteur / 2] = this[i, this.Largeur - 1 - j];

                }
            }
            //Boucles pour le quatrième quadrant (jaune).
            for (int j = 1; j < this.Hauteur; j = j + 2)
            {
                for (int i = 1; i < this.Largeur; i = i + 2)
                {
                    tabTempo[i / 2 + this.Largeur / 2, j / 2 + this.Hauteur / 2] =
                        this[this.Hauteur - 1 - i, this.Largeur - 1 - j];

                }
            }
            //Affecte tous les quadrants modifiés à l'image originel.
            for (int i = 0; i < this.Largeur; i++)
            {
                for (int j = 0; j < this.Hauteur; j++)
                {
                    this[i, j] = tabTempo[i, j];
                }
            }
        }

        #endregion

        #region Svasitka


        /// <summary>
        /// Méthode qui retourne l'image en Svastika (dimensions paires et identiques).
        /// </summary>
        public void Svasitka()
        {
            //Taille du tableaux temporaire
            Color[,] tabTempo = new Color[this.Largeur, this.Hauteur];
            //boucle pour le rouge
            for (int j = 0; j < this.Hauteur; j = j + 2)
            {
                for (int i = 0; i < this.Largeur; i = i + 2)
                {
                    tabTempo[i / 2, j / 2] = this[i, j];
                }
            }
            //boucle pour le bleu
            for (int i = 1; i < this.Largeur; i = i + 2)
            {
                for (int j = 0; j < this.Hauteur; j = j + 2)
                {
                    tabTempo[i / 2 + this.Largeur / 2, j / 2] = this[j, this.Largeur - 1 - i];
                }
            }
            //boucle pour le vert
            for (int j = 1; j < this.Hauteur; j = j + 2)
            {
                for (int i = 0; i < this.Largeur; i = i + 2)
                {
                    tabTempo[i / 2, j / 2 + this.Hauteur / 2] = this[this.Hauteur - 1 - j, i];
                }
            }
            //boucle pour le jaune
            for (int j = 1; j < this.Hauteur; j = j + 2)
            {
                for (int i = 1; i < this.Largeur; i = i + 2)
                {

                    tabTempo[i / 2 + this.Largeur / 2, j / 2 + this.Hauteur / 2] =
                        this[this.Hauteur - 1 - i, this.Largeur - 1 - j];


                }
            }
            // recopie depuis la colonne de travail
            for (int i = 0; i < this.Largeur; i++)
            {
                for (int j = 0; j < this.Hauteur; j++)
                {
                    this[i, j] = tabTempo[i, j];
                }
            }
        }

        #endregion

        #endregion

        #endregion

        #endregion
    }

}