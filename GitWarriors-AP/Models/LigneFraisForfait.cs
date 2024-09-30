using System;
using System.Collections.Generic;

namespace GitWarriors_AP.Models;

public partial class LigneFraisForfait
{
    public string IdVisiteur { get; set; } = null!;

    public string Mois { get; set; } = null!;

    public string IdFraisForfait { get; set; } = null!;

    public int? Quantite { get; set; }

    public virtual Fichefrai Fichefrai { get; set; } = null!;

    public virtual FraisForfait IdFraisForfaitNavigation { get; set; } = null!;
}
