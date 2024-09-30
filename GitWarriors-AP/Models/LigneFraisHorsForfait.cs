using System;
using System.Collections.Generic;

namespace GitWarriors_AP.Models;

public partial class LigneFraisHorsForfait
{
    public int Id { get; set; }

    public string IdVisiteur { get; set; } = null!;

    public string Mois { get; set; } = null!;

    public string? Libelle { get; set; }

    public DateOnly? Date { get; set; }

    public decimal? Montant { get; set; }

    public virtual Fichefrai Fichefrai { get; set; } = null!;
}
