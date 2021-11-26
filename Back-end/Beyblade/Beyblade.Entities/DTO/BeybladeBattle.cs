using System;
using System.Collections.Generic;
using System.Text;

namespace Beyblade.Entities.DTO
{
    public class BeybladeBattle
    {
        public BeybladeE FirstBeyblade { get; set; }
        public BeybladeE SecondBeyblade { get; set; }
        public BeybladeBattle()
        {

        }

        public BeybladeBattle(BeybladeE firstBeyblade, BeybladeE secondBeyblade)
        {
            FirstBeyblade = firstBeyblade;
            SecondBeyblade = secondBeyblade;
        }
    }
}
