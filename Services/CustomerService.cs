using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomerAPI.Data;
using CustomerAPI.Models;

namespace CustomerAPI.Services
{
    public class CustomerService: ICustomerService
    {
        private readonly Context context;

        public CustomerService(Context context)
        {
            this.context = context;
        }

        public async Task<Customer> GetCustomersAsync(int customerId)
        {
            return await context.Customers
                .Where(c => c.CustomerId == customerId)
                .Select(c => new Customer
                {
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Phone = c.Phone,
                    Email = c.Email,
                    Street = c.Street,
                    City = c.City,
                    State = c.State,
                    ZipCode = c.ZipCode
                }).FirstOrDefaultAsync();
        }

    }
}
