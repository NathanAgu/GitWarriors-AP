using System;
using System.Collections.Generic;

namespace GitWarriors_AP.Models;

public partial class Secteur
{
    public int IdSecteur { get; set; }

    public string? LibSecteur { get; set; }

    public string IdVisiteur { get; set; } = null!;

    public virtual Visiteur IdVisiteurNavigation { get; set; } = null!;

    public virtual ICollection<Region> Regions { get; set; } = new List<Region>();
}
