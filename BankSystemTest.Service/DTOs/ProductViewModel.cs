﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemTest.Service.DTOs
{
  public class ProductViewModel
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Photo { get; set; }
    public int CategoryId { get; set; }
  }
}
