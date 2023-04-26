using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes
{
    internal class Ingredients
    {
        // Fields
        private string recipeName;
        private int ingredientAmount;
        private string[] ingredientNames;
        private double[] ingredientQuantity;
        private string[] ingredientUnits;
        private double scaleFactor;

        // Properties
        public int IngredientAmount { get => ingredientAmount; set => ingredientAmount = value; }
        public string[] IngredientNames { get => ingredientNames; set => ingredientNames = new string[ingredientAmount]; }
        public double[] IngredientQuantity { get => ingredientQuantity; set => ingredientQuantity = new double[ingredientAmount]; }
        public string[] IngredientUnits { get => ingredientUnits; set => ingredientUnits = new string[ingredientAmount]; }
        public string RecipeName { get => recipeName; set => recipeName = value; }
        public double ScaleFactor { get => scaleFactor; set => scaleFactor = value; }

        public void getIngredients()
        {

        }
    }
}
