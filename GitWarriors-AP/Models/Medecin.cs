using System;
using System.Collections.Generic;

namespace GitWarriors_AP.Models;

public partial class Medecin
{
    public int IdMedecin { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public string Adresse { get; set; } = null!;

    public string? Tel { get; set; }

    public string? IdSpecialite { get; set; }

    public int Departement { get; set; }

    public virtual Specialite? IdSpecialiteNavigation { get; set; }

    public virtual ICollection<Rapport> Rapports { get; set; } = new List<Rapport>();
}
