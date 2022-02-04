using System.Threading.Tasks;
using CustomerAPI.Models;

namespace CustomerAPI.Services
{
    public interface ICustomerService
    {
        public Task<Customer> GetCustomersAsync(int customerId);
    }
}
