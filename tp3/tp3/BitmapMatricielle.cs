#region MÉTADONNÉES

// Nom du fichier : BitmapMatricielle.cs
// Auteur : [VOTRE NOM]
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

        // TODO : Ajouter un indexeur [i, j] pour accéder et modifier les pixels de l'image (i = y, j = x).

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

        #region MÉTHODES ET OPÉRATEURS

        // TODO : Surcharger les opérateurs == et != ainsi que de la méthode "Equals".

        // TODO : Créer toutes les méthodes pour les transformations bijectives (une étape)
        // ainsi que pour les effets niveau de gris et sépia.

        #endregion
    }
}