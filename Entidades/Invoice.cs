using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Invoice
    {
        private String CodInvoice
        {
            get => default;
            set
            {
            }
        }

        private DetailsInvoice DetailsInvoice
        {
            get => default;
            set
            {
            }
        }

        private Admin Admin
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

        public void Print()
        {
            throw new System.NotImplementedException();
        }
    }
}