using API_ZapBank.DataContext;
using API_ZapBank.Models;

namespace API_ZapBank.Service.EmployeeService
{
    public class EmployeeService : IEmployeeInterface
    {
        //temos que colocar a ligação entre esses contratos com o banco de dados
        private readonly ApplicationDbContext _context; //a gente 

        public EmployeeService(ApplicationDbContext context) 
        { 
            _context = context;
            //toda vez que eu utilizo o _context eu estou conversando com as minhas tabelas do banco de dados
        }

        public async Task<ServiceResponse<List<EmployeeModel>>> GetEmployees()
        {
            ServiceResponse<List<EmployeeModel>> serviceResponse = new ServiceResponse<List<EmployeeModel>>();
            try
            {
               serviceResponse.Data = _context.Employee.ToList();
                if(serviceResponse.Data.Count == 0)
                {
                    serviceResponse.Message = "Nenhum dado encontrado!";
                }
            }catch (Exception ex)
            {
                serviceResponse.Message = ex.Message;
                serviceResponse.Sucess = false;
            }

            return serviceResponse;
        }
        public async Task<ServiceResponse<EmployeeModel>> GetEmployeeById(int id)
        {
            ServiceResponse<EmployeeModel> serviceResponse = new ServiceResponse<EmployeeModel>();
            try
            {
                EmployeeModel employee = _context.Employee.FirstOrDefault(x => x.Id == id); //o primeiro x é um funcionario model
                if (employee == null)
                {
                    serviceResponse.Data = null;
                    serviceResponse.Message = "Nenhum dado encontrado!";
                    serviceResponse.Sucess = false;
                }
                serviceResponse.Data = employee;
              
            }
            catch (Exception ex)
            {
                serviceResponse.Message = ex.Message;
                serviceResponse.Sucess = false;
            }

            return serviceResponse;

        }
        public async Task<ServiceResponse<List<EmployeeModel>>> CreateEmployee(EmployeeModel newEmployee)
        {
            ServiceResponse<List<EmployeeModel>> serviceResponse = new ServiceResponse<List<EmployeeModel>>();
            try
            {
                if(newEmployee == null)
                {
                    serviceResponse.Data = null;
                    serviceResponse.Message = "Informar dados!";
                    serviceResponse.Sucess = false; 

                    return serviceResponse;
                }
                _context.Add(newEmployee);
                await _context.SaveChangesAsync();
                serviceResponse.Data = _context.Employee.ToList();

            }catch (Exception ex)
            {
                serviceResponse.Message = ex.Message;
                serviceResponse.Sucess = false;
            }
            return serviceResponse;
        }
        public Task<ServiceResponse<List<EmployeeModel>>> DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }
        public Task<ServiceResponse<List<EmployeeModel>>> InactiveEmployee(int id)
        {
            throw new NotImplementedException();
        }
        public Task<ServiceResponse<List<EmployeeModel>>> UpdateEmployee(EmployeeModel updateEmployee)
        {
            throw new NotImplementedException();
        }
    }
}
