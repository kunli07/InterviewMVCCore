﻿using System;
using System.Collections.Generic;

namespace InterviewMVCCore.DB
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
