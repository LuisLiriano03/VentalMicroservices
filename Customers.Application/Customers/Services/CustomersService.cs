using AutoMapper;
using Customers.Application.Customers.Dtos;
using Customers.Application.Customers.Exceptions;
using Customers.Application.Customers.Interfaces;
using Customers.Domain.Entities;
using Customers.Domain.Interfaces;

namespace Customers.Application.Customers.Services
{
    public class CustomersService : ICustomersService
    {

        private readonly ICustomerRepository<Customer> _customerRepository;
        private readonly IMapper _mapper;

        public CustomersService(ICustomerRepository<Customer> customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<List<GetCustomers>> GetAllCustomers()
        {
            try
            {
                var query = await _customerRepository.ValidateDataExistence();
                return _mapper.Map<List<GetCustomers>>(query.ToList());
            }
            catch
            {
                throw;
            }

        }

        public async Task<GetCustomers> CreateCustomers(CreateCustomers model)
        {
            try
            {
                var customerCreated = await _customerRepository.CreateData(_mapper.Map<Customer>(model));

                if (customerCreated.Id == 0)
                    throw new FailedCreateException();

                var query = await _customerRepository.ValidateDataExistence(u => u.Id == customerCreated.Id);

                return _mapper.Map<GetCustomers>(customerCreated);

            }
            catch
            {
                throw;
            }

        }

        public async Task<bool> UpdateCustomers(UpdateCustomers model)
        {
            try
            {
                var customerModel = _mapper.Map<Customer>(model);
                var customerFound = await _customerRepository.GetDataDetails(u => u.Id == customerModel.Id);

                if (customerFound == null)
                    throw new WhenNoExistException();

                customerFound.FirstName = customerModel.FirstName;
                customerFound.LastName = customerModel.LastName;
                customerFound.LastName = customerModel.LastName;
                customerFound.Email = customerModel.Email;
                customerFound.Address = customerModel.Address;
                customerFound.PhoneNumber = customerModel.PhoneNumber;

                bool response = await _customerRepository.UpdateData(customerFound);

                if (!response)
                    throw new UpdateWhenNoEditException();

                return response;

            }
            catch
            {
                throw;
            }

        }

        public async Task<bool> EliminateCustomers(int id)
        {
            try
            {
                var customerFound = await _customerRepository.GetDataDetails(u => u.Id == id);

                if (customerFound == null)
                    throw new WhenNoExistException();

                bool response = await _customerRepository.RemoveData(customerFound);

                if (!response)
                    throw new WhenNoDeleteException();

                return response;
            }
            catch
            {
                throw;
            }

        }

    }

}
