using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Credit : PayForm
    {
        private String NumberCard
        {
            get => default;
            set
            {
            }
        }

        private DateTime DateExpedition
        {
            get => default;
            set
            {
            }
        }

        private String NamePropietary
        {
            get => default;
            set
            {
            }
        }

        private double AmountPaid
        {
            get => default;
            set
            {
            }
        }

        public Boolean StatePaid()
        {
            throw new System.NotImplementedException();
        }
    }
}