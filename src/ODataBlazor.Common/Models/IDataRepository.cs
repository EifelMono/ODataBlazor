using System.Collections.Generic;

namespace ODataBlazor.Common.Models
{
    public interface IDataRepository
    {
        IEnumerable<Customer> GetCustomers();
    }
}
