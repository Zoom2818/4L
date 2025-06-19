﻿using System.ComponentModel.DataAnnotations;

namespace _4Lv2.Models;

public class Service
{
    [Key] public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
}