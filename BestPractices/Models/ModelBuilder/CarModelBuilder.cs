﻿using System;

namespace DesignPatterns.Models.ModelBuilder
{
    public class CarModelBuilder
    {
        private string color = "red";
        private string brand = "Ford";
        private string model = "Mustang";
        private int year = DateTime.Now.Year;

        public CarModelBuilder setColor(string color)
        {
            this.color = color;
            return this;
        }
        public CarModelBuilder setBrand(string brand)
        {
            this.brand = brand;
            return this;
        }

        public CarModelBuilder setModel(string model)
        {
            this.model = model;
            return this;
        }
        public CarModelBuilder setYear(int year)
        {
            this.year = year;
            return this;
        }

        public Vehicle Build() { 
            return new Car(color, brand, model, year);
                
        }
    }


}