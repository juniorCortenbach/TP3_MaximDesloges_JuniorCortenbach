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
            set { this._imageBitmap = value; }
        }

        /// <summary>
        /// Hauteur de l'image.
        /// </summary>
        public int Hauteur
        {
            get { return this._imageBitmap.Height; }
        }

        /// <summary>
        /// Largeur de l'image.
        /// </summary>
        public int Largeur
        {
            get { return this._imageBitmap.Width; }
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
        // TODO : Ajouter un indexeur [i, j] pour accéder et modifier les pixels de l'image (i = y, j = x).

        #region MÉTHODES ET OPÉRATEURS

        // TODO : Surcharger les opérateurs == et != ainsi que de la méthode "Equals".

        // TODO : Créer toutes les méthodes pour les transformations bijectives (une étape)
        // ainsi que pour les effets niveau de gris et sépia.

        #region #EFFECTS

        #region  NiveauDeGris

        /// <summary>
        /// </summary>
        /// <param name="imageChargee"></param>
        /// <param name="iteration"></param>
        /// <returns>Retourn l'image transfomé en Niveau de gris</returns>
        public Bitmap NiveauDeGris(Bitmap imageChargee, int iteration)
        {


            //Pour chaque colonne.
            for (int i = 0; i < this.Largeur; i++)
            {
                //Pour chaque rangée.
                for (int j = 0; j < this.Hauteur; j++)
                {
                    //Prend la couleur de chaque pixel
                    Color couleur = this[i, j];
                    //Prend le rouge le vert et le bleu de chaque pixel et y applique une transformation
                    byte ng = (byte)Math.Round(couleur.R * 0.299 + couleur.G * 0.587 + couleur.B * 0.114);


                    //La couleur final est stoxcker dans la variable
                    Color nouvelleCouleur = Color.FromArgb(ng, ng, ng);
                    //Chaque pixel et afficher de nouveau avec sa nouvelle couleur
                    this[i, j] = nouvelleCouleur;
                }
            }
            //Retourne la nouvelle image transformée 
            return this.ImageBitmap;
        }
        #endregion

        #region Sepia

        /// <summary>
        /// </summary>
        /// <param name="imageChargee"></param>
        /// <param name="iteration"></param>
        /// <returns>Retourn l'image transfomé en Sepia</returns>
        public Bitmap Sepia(Bitmap imageChargee, int iteration)
        {
            //Pour chaque colonne.
            for (int i = 0; i < this.Largeur; i++)
            {
                //Pour chaque rangée.
                for (int j = 0; j < this.Hauteur; j++)
                {
                    //Prend la couleur de chaque pixel
                    Color couleur = this[i, j];
                    ////Prend le rouge le vert et le bleu de chaque pixel et y applique une transformation
                    byte r = (byte)(Math.Min(couleur.R * 0.393 + couleur.G * 0.769 + couleur.B * 0.189, 255));
                    byte v = (byte)(Math.Min(couleur.R * 0.349 + couleur.G * 0.686 + couleur.B * 0.168, 255));
                    byte b = (byte)(Math.Min(couleur.R * 0.272 + couleur.G * 0.534 + couleur.B * 0.131, 255));


                    //La couleur final est stoxcker dans la variable
                    Color nouvelleCouleur = Color.FromArgb(r, v, b);
                    //Chaque pixel et afficher de nouveau avec sa nouvelle couleur
                    this[i, j] = nouvelleCouleur;
                }
            }
            //Retourne la nouvelle image transformée 
            return this.ImageBitmap;
        }

        #endregion

        #endregion

        #region TRANSFORMATION

        #region Photomaton

        /// <summary>
        /// Méthode qui retourne l'image en Photomaton
        /// </summary>
        public void Photomaton()
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
                    tabTempo[i / 2 + this.Largeur / 2, j / 2] = this[i, j];
                }
            }
            //boucle pour le vert
            for (int j = 1; j < this.Hauteur; j = j + 2)
            {
                for (int i = 0; i < this.Largeur; i = i + 2)
                {
                    tabTempo[i / 2, j / 2 + this.Hauteur / 2] = this[i, j];
                }
            }
            //boucle pour le jaune
            for (int j = 1; j < this.Hauteur; j = j + 2)
            {
                for (int i = 1; i < this.Largeur; i = i + 2)
                {
                    tabTempo[i / 2 + this.Largeur / 2, j / 2 + this.Hauteur / 2] = this[i, j];
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

        #region DécalageHorizontal

        /// <summary>
        ///  Méthode qui retourne l'image décallée horizontalment
        /// </summary>
        public void DecalageHorizontal()
        {
            //Tablau temporaire de pixel en column
            Color[] pixelColumn = new Color[this.Hauteur];

            //Pour chaque colonne.
            for (int i = 0; i < this.Largeur; i++)
            {
                //Pour chaque rangée.
                // Décalage des pixels dans la colonne de travail

                for (int j = 0; j < this.Hauteur; j++)
                {
                    if (j == 0)
                    {
                        pixelColumn[j] = this[i, this.Hauteur - 1];
                    }
                    else
                    {
                        pixelColumn[j] = this[i, j - 1];
                    }
                }

                // recopie depuis la colonne de travail
                for (int j = 0; j < this.Hauteur; j++)
                {
                    this[i, j] = pixelColumn[j];
                }
            }

        }


        #endregion

        #region DécalageVertical
        /// <summary>
        /// Méthode qui retourne l'image décallée verticalment 
        /// </summary>
        public void DecalageVertical()
        {
            //Tablau temporaire de pixel en rangee 
            Color[] pixelRangee = new Color[this.Largeur];

            //Pour chaque rangée.
            for (int j = 0; j < this.Hauteur; j++)
            {
                //Pour chaque rangée.
                // Décalage des pixels dans la rangée de travail
                for (int i = 0; i < this.Largeur; i++)
                {
                    if (i == 0)
                    {
                        pixelRangee[i] = this[this.Largeur - 1, j];
                    }
                    else
                    {
                        pixelRangee[i] = this[i - 1, j];
                    }
                }

                // recopie depuis la rangee de travail
                for (int i = 0; i < this.Largeur; i++)
                {
                    this[i, j] = pixelRangee[i];
                }
            }

        }
        #endregion

        #region DécalageDiagonale

        /// <summary>
        /// Méthode qui retourne l'image décallée en diagonale
        /// </summary>
        public void DecalageDiagonale()
        {
            //Tableau de pixels utilisé comme tableau temporaire.
            Color[,] tabPixels = new Color[this.Largeur, this.Hauteur];

            //Pour chaque colonne.
            for (int j = 0; j < this.Hauteur; j++)
            {
                //Pour chaque rangée.
                //Décalage des pixels dans la rangée de travail.
                for (int i = 0; i < this.Largeur; i++)
                {
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

                //Affectation de la rangée de pixels modifiés à l'image.
                for (int j = 0; j < this.Hauteur; j++)
                {
                    this[i, j] = tabPixels[i, j];
                }
            }

        }


        #endregion

        #region MiroirHorizontal
        /// <summary>
        /// Méthode qui retourne limage transformé en miroir horizontal
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
        /// Méthode qui retourne limage transformé en miroir Vertical
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

        #region Fleur

        public void Fleur()
        {

        }

        #endregion

        #region Svasitka


        /// <summary>
        /// Méthode qui retourne l'image en Photomaton
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

                    tabTempo[i / 2 + this.Largeur / 2, j / 2 + this.Hauteur / 2] = this[this.Hauteur - 1 - i, this.Largeur - 1 - j];


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
    }
}