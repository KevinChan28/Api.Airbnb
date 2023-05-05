using System;
using System.Collections.Generic;

namespace Api.Airbnb.Models;

public partial class LocationTag
{
    public int Id { get; set; }

    public string NameTags { get; set; } = null!;

    public string Description { get; set; } = null!;
}
