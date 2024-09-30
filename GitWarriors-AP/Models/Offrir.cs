using System;
using System.Collections.Generic;

namespace GitWarriors_AP.Models;

public partial class Offrir
{
    public int IdRapport { get; set; }

    public string IdMedicament { get; set; } = null!;

    public int? Quantite { get; set; }

    public virtual Medicament IdMedicamentNavigation { get; set; } = null!;

    public virtual Rapport IdRapportNavigation { get; set; } = null!;
}
