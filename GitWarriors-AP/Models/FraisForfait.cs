using System;
using System.Collections.Generic;

namespace GitWarriors_AP.Models;

public partial class FraisForfait
{
    public string Id { get; set; } = null!;

    public string? Libelle { get; set; }

    public decimal? Montant { get; set; }

    public virtual ICollection<LigneFraisForfait> LigneFraisForfaits { get; set; } = new List<LigneFraisForfait>();
}
