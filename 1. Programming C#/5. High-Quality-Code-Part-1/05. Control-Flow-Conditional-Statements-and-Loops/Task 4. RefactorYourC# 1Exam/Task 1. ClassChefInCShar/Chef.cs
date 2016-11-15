﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassChefInCShar
{
    public class Chef
    {
        private Bowl GetBowl()
        {
            //... 
        }
        private Carrot GetCarrot()
        {
            //...
        }
        private void Cut(Vegetable potato)
        {
            //...
        }
        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl;
            Peel(potato);

            Peel(carrot);
            bowl = GetBowl();
            Cut(potato);
            Cut(carrot);
            bowl.Add(carrot);

            bowl.Add(potato);
        }
        private Potato GetPotato()
        {
            //...
        }
    }
}
