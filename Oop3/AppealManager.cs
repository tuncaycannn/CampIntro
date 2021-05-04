using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    class AppealManager
    {

        public void Appeal(ICreditManager creditManager,List <ILoggerService> loggerService)
        {
            creditManager.Calculate();
            foreach (var logger in loggerService)
            {
                logger.Log();
            }

        }

        public void CreditInformation(List<ICreditManager> creditManagers)
        {
            foreach (var credit in creditManagers)
            {
                credit.Calculate();

            }
        }
    }
}
