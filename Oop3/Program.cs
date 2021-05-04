using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager requirementCrediManager = new RequirementCrediManager();
            ICreditManager vehicleCrediManager = new VehicleCrediManager();
            ICreditManager houseCrediManager = new HouseCrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            AppealManager appealManager = new AppealManager();
            appealManager.Appeal(requirementCrediManager, new List<ILoggerService> { databaseLoggerService, fileLoggerService });


            List<ICreditManager> creditManager = new List<ICreditManager>() { houseCrediManager,requirementCrediManager};
            //appealManager.CreditInformation(creditManager);
            

        }
    }
}
