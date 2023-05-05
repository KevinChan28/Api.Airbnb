using System;
using System.Collections.Generic;

namespace Api.Airbnb.Models;

public partial class HousingCharacteristic
{
    public int Id { get; set; }

    public int IdServices { get; set; }

    public decimal Price { get; set; }

    public int CuantityBedroom { get; set; }

    public int CuantityBed { get; set; }

    public int CuantityBathrooms { get; set; }

    public string? TypeProperty { get; set; }
}
