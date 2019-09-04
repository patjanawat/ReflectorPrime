using System;
using System.Collections.Generic;
using PCMI.DeveloperTest.Model;

namespace PCMI.DeveloperTest.BLL
{
    public class Contracts : IContracts
    {
        private IEnumerable<Contract> GenerateData()
        {
            return new List<Contract>
            {
                new Contract(1, "CL10008", "Cole", "Baltz", Status.Inactive, 100.23m,118.27m),
                new Contract(2, "CL10001", "John", "Doe", Status.Active, 200.4m,236.47m),
                new Contract(3, "CL10005", "Cleo", "Rowse", Status.Active, 150.5m, 177.59m),
                new Contract(4, "CL10003", "John", "Engell", Status.Active, 235.0m,277.30m),
                new Contract(5, "CL10004", "Kelly", "Dickson", Status.Active, 78.9m,93.10m),
                new Contract(6, "CL10009", "Angeline", "Carper", Status.Active, 101.01m,119.19m),
                new Contract(7, "CL10006", "Adel", "Marschall", Status.Inactive, 827.12m,976.00m),
                new Contract(8, "CL10002", "Tom", "Smith", Status.Inactive, 543.56m,641.40m),
                new Contract(9, "CL10007", "Klara", "Larkin", Status.Active, 10.99m,12.97m)
            };
        }

        public IEnumerable<Contract> GetAllContracts()
        {
            return GenerateData();
        }

        public void ActivateContract(Contract contract)
        {
            throw new NotImplementedException();
        }
    }
}
