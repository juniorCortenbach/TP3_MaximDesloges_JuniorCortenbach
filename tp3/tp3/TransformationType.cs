#region MÉTADONNÉES

// Nom du fichier : TransformationType.cs
// Auteur : Stéphane Lapointe (slapointe)
// Date de création : 2015-12-21
// Date de modification : 2016-04-22

#endregion

#region USING

using System.ComponentModel;

#endregion

namespace tp3
{
    /// <summary>
    /// Types de transformation.
    /// </summary>
    public enum TransformationType
    {
        [Description("Miroir horizontal")]
        MiroirHorizontal,
        [Description("Miroir vertical")]
        MiroirVertical,
        [Description("Transposition (dimensions identiques)")]
        Transposition,
        [Description("Décalage horizontal vers la droite")]
        DecalageHorizontal,
        [Description("Décalage vertical vers la droite")]
        DecalageVertical,
        [Description("Décalage en diagonale vers la droite et le bas")]
        DecalageEnDiagonale,
        [Description("En colonnes (dimensions paires)")]
        Colonnes,
        [Description("Photomaton (dimensions paires)")]
        Photomaton,
        [Description("Boulanger (dimensions paires)")]
        Boulanger,
        [Description("Fleur (dimensions paires)")]
        Fleur,
        [Description("Svastika (dimensions paires et identiques)")]
        Svastika
    }
}