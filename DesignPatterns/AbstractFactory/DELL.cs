﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.AbstractFactory
    {
        public class DELL : IBrand
        {
            public string GetBrand()
            {
                return Enumerations.Brands.DELL.ToString();
            }
        }
    }



