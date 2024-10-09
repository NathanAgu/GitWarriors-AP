using System;
using System.Collections.Generic;

namespace GitWarriors_AP.Models;

public partial class Visiteur
{
    public string IdVisiteur { get; set; } = null!;

    public int IdLabo { get; set; }

    public string? Nom { get; set; }

    public string? Prenom { get; set; }

    public string? Rue { get; set; }

    public string? Cp { get; set; }

    public string? Ville { get; set; }

    public string? DateEmbauche { get; set; }

    public string Identifiant { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Fichefrai> Fichefrais { get; set; } = new List<Fichefrai>();

    public virtual Laboratoire IdLaboNavigation { get; set; } = null!;

    public virtual ICollection<Rapport> Rapports { get; set; } = new List<Rapport>();

    public virtual ICollection<Region> Regions { get; set; } = new List<Region>();

    public virtual ICollection<Secteur> Secteurs { get; set; } = new List<Secteur>();

    public virtual ICollection<Region> IdRegions { get; set; } = new List<Region>();
}
