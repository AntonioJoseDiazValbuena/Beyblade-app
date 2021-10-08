using System;
using System.Collections.Generic;
using System.Text;

namespace Beyblade.Entities
{
    public class Frame
    {
        public string Name { get; private set; }
        public int Weight { get; private set; }
        public Frame(string name, int wegiht)
        {
            if (wegiht > 15)
            {
                throw new Exception("There aren't any frames that weight over 15 grams.");
            }

            Name = name;
            Weight = wegiht;
        }
    }
}
