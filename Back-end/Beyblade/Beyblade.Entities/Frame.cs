using System;
using System.Collections.Generic;
using System.Text;

namespace Beyblade.Entities
{
    public class Frame
    {
        private const int MAXIMUM_WEIGHT = 15;
        public static readonly string MAXIMUM_WEIGHT_MESSAGE = "There aren't any frames that weight over 15 grams.";

        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Weight { get; private set; }
        public Frame(string name, int weight)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("The Frame should have a name.");

            if (weight > MAXIMUM_WEIGHT)
                throw new Exception(MAXIMUM_WEIGHT_MESSAGE);

            Name = name;
            Weight = weight;
        }
    }
}
