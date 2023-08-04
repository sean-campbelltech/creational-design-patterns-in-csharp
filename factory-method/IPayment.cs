using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface IPayment
    {
        void Pay(Double amount);
    }
}