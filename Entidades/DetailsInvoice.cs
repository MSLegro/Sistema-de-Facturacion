using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DetailsInvoice
    {
        double Tax = 0.19;
        private DetailsOrder DetailsOrder
        {
            get => default;
            set
            {
            }
        }

        private PayForm PayForm
        {
            get => default;
            set
            {
            }
        }

        private float Perquisite
        {
            get => default;
            set
            {
            }
        }

        public float CalculateTotal()
        {
            throw new System.NotImplementedException();
        }
    }
}