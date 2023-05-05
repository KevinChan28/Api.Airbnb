using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Api.Airbnb.Models;
[Table("Owner")]
public partial class Owner
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public string? Image { get; set; }

    public string Language { get; set; }
}
