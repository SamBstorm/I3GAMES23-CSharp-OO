namespace ExoBonus_Monopoly.Models
{
    internal class CasePropriete : Case
    {
        public EnumCouleur Couleur { get; private set; }
        public int PrixAchat { get; private set; }
        public int PrixHypotequere { get { return PrixAchat / 2; } }
        public Joueur Proprietaire { get; private set; }
        public CasePropriete(string nomCase, EnumCouleur couleur, int prixAchat) : base(nomCase)
        {
            Couleur = couleur;
            PrixAchat = prixAchat;
            //Proprietaire = null;
        }

        public void AchatPar(Joueur nouveauProprio)
        {
            if (nouveauProprio.Solde < PrixAchat) return;
            nouveauProprio.Payer(PrixAchat);
            Proprietaire = nouveauProprio;
            Proprietaire.DevenirProprio(this);
        }
    }
}