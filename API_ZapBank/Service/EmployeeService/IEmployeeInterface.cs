using API_ZapBank.Models;

namespace API_ZapBank.Service.EmployeeService
{
    public interface IEmployeeInterface //nesse fluxo eu começo por aqui depois vou para o service e depois para controller
    {
        //contratos //task serve para metodos assincronos (async) isso significa boas práticas
        Task<ServiceResponse<List<EmployeeModel>>> GetEmployees();
        Task<ServiceResponse<List<EmployeeModel>>> CreateEmployee(EmployeeModel newEmployee);
        Task<ServiceResponse<EmployeeModel>> GetEmployeeById(int id);
        Task<ServiceResponse<List<EmployeeModel>>> UpdateEmployee(EmployeeModel updateEmployee);
        Task<ServiceResponse<List<EmployeeModel>>> DeleteEmployee(int id);
        Task<ServiceResponse<List<EmployeeModel>>> InactiveEmployee(int id);

    }
}
