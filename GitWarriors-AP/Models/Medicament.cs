using System;
using System.Collections.Generic;

namespace GitWarriors_AP.Models;

public partial class Medicament
{
    public string IdMedicament { get; set; } = null!;

    public string NomCommercial { get; set; } = null!;

    public string IdFamille { get; set; } = null!;

    public string Composition { get; set; } = null!;

    public string Effets { get; set; } = null!;

    public string ContreIndications { get; set; } = null!;

    public virtual Famille IdFamilleNavigation { get; set; } = null!;

    public virtual ICollection<Offrir> Offrirs { get; set; } = new List<Offrir>();
}
