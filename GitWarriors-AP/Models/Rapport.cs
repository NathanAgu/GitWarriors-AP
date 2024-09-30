using System;
using System.Collections.Generic;

namespace GitWarriors_AP.Models;

public partial class Rapport
{
    public int IdRapport { get; set; }

    public DateOnly? DateRapport { get; set; }

    public int? IdMotif { get; set; }

    public string? Bilan { get; set; }

    public string IdVisiteur { get; set; } = null!;

    public int IdMedecin { get; set; }

    public virtual Medecin IdMedecinNavigation { get; set; } = null!;

    public virtual Motif? IdMotifNavigation { get; set; }

    public virtual Visiteur IdVisiteurNavigation { get; set; } = null!;

    public virtual ICollection<Offrir> Offrirs { get; set; } = new List<Offrir>();
}
