using System;
using System.Collections.Generic;

namespace Api.Airbnb.Models;

public partial class Client
{
    public int IdClient { get; set; }

    public int Name { get; set; }

    public string Address { get; set; } = null!;

    public string Contact { get; set; } = null!;
}
