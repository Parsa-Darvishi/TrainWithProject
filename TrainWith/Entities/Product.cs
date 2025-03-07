﻿using System.Runtime.InteropServices;

namespace TrainWith.Entity;

public class Product 
{
    public int Id { get; set; }
    public string Name { get; set; } 
    public decimal Price { get; set; }
    public int Barcode { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
}
