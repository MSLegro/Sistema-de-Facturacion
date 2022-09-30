using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public interface IServiceInvoice<T>
    {
        string Add(T Person);
        string Delete(T Person);
        List<T> GetAll();
    }
}