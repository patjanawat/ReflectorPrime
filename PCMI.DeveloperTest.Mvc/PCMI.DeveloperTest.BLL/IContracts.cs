using System.Collections.Generic;
using PCMI.DeveloperTest.Model;

namespace PCMI.DeveloperTest.BLL
{
    public interface IContracts
    {
        IEnumerable<Contract> GetAllContracts();
        void ActivateContract(Contract contract);
    }
}