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

        public void MiroirHorizontal()
        {
            //Pour chaque colonne.
            for (int x = 0; x < this.Largeur / 2; x++)
            {
                //Pour chaque rangée.
                for (int y = 0; y < this.Hauteur; y++)
                {
                    //Affecte la couleur du premier pixel de la largeur à une variable temporaire.
                    Color pixel = this[x, y];

                    //Affecte la couleur du dernier pixel au premier pixel de la largeur.
                    this[x, y] = this[this.Largeur - 1 - x, y];

                    //Affecte la couleur du premier pixel au dernier pixel de la largeur.
                    this[this.Largeur - 1 - x, y] = pixel;
                }

            }

        }

        public void MiroirVertical()
        {
            //Pour chaque colonne.
            for (int y = 0; y < this.Hauteur; y++)
            {
                //Pour chaque rangée.
                for (int x = 0; x < this.Largeur / 2; x++)
                {
                    //Affecte la couleur du premier pixel de la largeur à une variable temporaire.
                    Color pixel = this[y, x];

                    //Affecte la couleur du dernier pixel au premier pixel de la largeur.
                    this[y, x] = this[y, this.Largeur - 1 - x];

                    //Affecte la couleur du premier pixel au dernier pixel de la largeur.
                    this[y, this.Largeur - 1 - x] = pixel;
                }

            }

        }

        #endregion
    }
}