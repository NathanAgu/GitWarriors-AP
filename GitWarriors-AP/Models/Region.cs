using System;
using System.Collections.Generic;

namespace GitWarriors_AP.Models;

public partial class Region
{
    public int IdRegion { get; set; }

    public string? LibRegion { get; set; }

    public string IdVisiteur { get; set; } = null!;

    public int IdSecteur { get; set; }

    public virtual Secteur IdSecteurNavigation { get; set; } = null!;

    public virtual Visiteur IdVisiteurNavigation { get; set; } = null!;

    public virtual ICollection<Visiteur> IdVisiteurs { get; set; } = new List<Visiteur>();
}
