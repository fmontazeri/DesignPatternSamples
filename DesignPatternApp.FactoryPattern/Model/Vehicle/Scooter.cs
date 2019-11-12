﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp.FactoryPattern.Model
{
    public class Scooter : IVehicle
    {
        public string Name { get; set; }
        public void Drive()
        {
            this.Name = "Scooter";
        }
    }
}