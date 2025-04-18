using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    internal class Dough
    {
        private const int calPerGram = 2;
        private string flourType;
        private string bakingTech;
        private double grams;
        public Dough(string flourType, string bakingTech, double grams)
        {
            FlourType = flourType;
            BakingTech = bakingTech;
            Grams = grams;
        }
        public string FlourType
        {
            get => flourType;
            set
            {
                if (value != "white" && value != "wholegrain")
                {
                    throw new Exception("Invalid type of dough.");
                }
                flourType = value;
            }
        }
        public string BakingTech
        {
            get => bakingTech;
            set
            {
                if (value != "crispy" && value != "chewy" && value != "homemade")
                {
                    throw new Exception("Invalid type of dough.");
                }
                bakingTech = value;
            }
        }
        public double Grams
        {
            get => grams;
            set
            {
                if (value <= 0 || value > 200)
                {
                    throw new Exception("Dough weight should be in the range [1..200].");
                }
                grams = value;
            }
        }
        public double GetDoughCalories()
        {
            double flourModifier = 0;
            double bakingTech = 0;
            if (FlourType == "white")
            {
                flourModifier = 1.5;
            }
            else if (FlourType == "wholegrain")
            {
                flourModifier = 1.0;
            }
            if (BakingTech == "crispy")
            {
                bakingTech = 0.9;
            }
            else if (BakingTech == "chewy")
            {
                bakingTech = 1.1;
            }
            else if (BakingTech == "homemade")
            {
                bakingTech = 1.0;
            }
            return (calPerGram * Grams) * flourModifier * bakingTech;
        }
    }
}
