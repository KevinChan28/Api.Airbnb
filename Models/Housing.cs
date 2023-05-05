using System;
using System.Collections.Generic;

namespace Api.Airbnb.Models;

public partial class Housing
{
    public int Id { get; set; }

    public int IdHousingCharacteristics { get; set; }

    public int IdLocationCharacteristics { get; set; }

    public int IdOwner { get; set; }

    public string NameHousing { get; set; }

    public string Country { get; set; }

    public string State { get; set; }

    public string Description { get; set; }
}
