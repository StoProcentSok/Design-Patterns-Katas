using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Facade
{
    internal class BigClassFacade
    {
        private readonly BigClass bigClass;

        public BigClassFacade()
        {
            bigClass = new BigClass();
            this.bigClass.SetValueI(0);
        }

        public string DoOperations()
        {
            bigClass.SetValueI(3);
            bigClass.IncrementI();
            bigClass.IncrementI();
            bigClass.IncrementI();
            bigClass.DecrememntI();

            return bigClass.GetValueA().ToString();
        }
    }
}
