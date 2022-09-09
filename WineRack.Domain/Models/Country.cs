﻿namespace WineRack.Domain.Models;

public class Country
{
    public int Id { get; set; }
    public string CountryName { get; set; } = string.Empty;
    public List<Winery> Wineries { get; set; } = new();
}
