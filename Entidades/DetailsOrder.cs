using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetailsOrder
    {
        private Drink SelectDrink
        {
            get => default;
            set
            {
            }
        }

        private Order SelectOrder
        {
            get => default;
            set
            {
            }
        }

        private float Amount
        {
            get => default;
            set
            {
            }
        }

        public float TotalPrice()
        {
            throw new System.NotImplementedException();
        }
    }
}