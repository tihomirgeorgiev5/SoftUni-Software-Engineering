using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SoftUni
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var context = new SoftUniContext();
            using (context)
            {
                //Console.WriteLine(GetEmployeesFullInformation(context));
                // Console.WriteLine(GetEmployeesWithSalaryOver50000(context));
                //Console.WriteLine(GetEmployeesFromResearchAndDevelopment(context));
                //Console.WriteLine(AddNewAddressToEmployee(context));
                //Console.WriteLine(GetEmployeesInPeriod(context));
                //Console.WriteLine(GetAddressesByTown(context));
                //Console.WriteLine(GetEmployee147(context));
                //Console.WriteLine(GetDepartmentsWithMoreThan5Employees(context));
                //Console.WriteLine(GetLatestProjects(context));
                //Console.WriteLine(IncreaseSalaries(context));
                //Console.WriteLine(GetEmployeesByFirstNameStartingWithSa(context));
                //Console.WriteLine(DeleteProjectById(context));
                Console.WriteLine(RemoveTown(context));       
            }


        }

        //03. Employees Full Information

        public static string
            GetEmployeesFullInformation(SoftUniContext context)
        {
            var employees = context.Employees
                .Select(e => new
                {
                    e.EmployeeId,
                    e.FirstName,
                    e.LastName,
                    e.MiddleName,
                    e.JobTitle,
                    e.Salary
           
                }
                )
                .OrderBy(e => e.EmployeeId)
                .ToList();
           
            StringBuilder result = new StringBuilder();
           
            foreach (var employee in employees)
            {
                result.AppendLine(
                    $"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:f2}");
            }
           
            return result.ToString().Trim();  
        }

        //04. Employees with Salary Over 50 000
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            var employees = context.Employees
           .Select(e => new
           {
               e.FirstName,
               e.Salary
           })
           .Where(e => e.Salary > 50000)
           .OrderBy(e => e.FirstName);

            StringBuilder sb = new StringBuilder();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} - {employee.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        // 05.Employees from Research and Development
        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                .Where(e => e.Department.Name == "Research and Development")
                .OrderBy(e => e.Salary)
                .ThenByDescending(e => e.FirstName)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    DepartmentName = e.Department.Name,
                    e.Salary
                })
                .ToArray();

            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} from {e.DepartmentName} - ${e.Salary:f2}");
            }
            return sb.ToString().TrimEnd();
        }

        //06. Adding a New Address and Updating Employee

        public static string 
            AddNewAddressToEmployee(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var newAddress = new Address()
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            var employeeNakov = context
                .Employees
                .Where(e => e.LastName == "Nakov")
                .First();

            employeeNakov.Address = newAddress;

            context.SaveChanges();

            string[] allEmployeesAddresses = context
                .Employees
                .OrderByDescending(e => e.AddressId)
                .Select(e => e.Address.AddressText)
                .Take(10)
                .ToArray();

            return String.Join(Environment.NewLine, allEmployeesAddresses);
        }

        //07. Employees and Projects

        public static string GetEmployeesInPeriod(SoftUniContext context)

        {
            var employees = context.Employees
                .Where(e => e.EmployeesProjects.Any(p => p.Project.StartDate.Year >= 2001 &&
                p.Project.StartDate.Year <= 2003))
                .Take(10)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    ManagerFirstName = e.Manager.FirstName,
                    ManagerLastName = e.Manager.LastName,
                    Projects = e.EmployeesProjects
                    .Select(ep => new
                    {
                        ProjectName = ep.Project.Name,
                        StartDate = ep.Project.StartDate
                        .ToString("M/d/yyyy h:mm:ss tt",
                        CultureInfo.InvariantCulture),
                        EndDate = ep.Project.EndDate
                        .HasValue
                        ? ep.Project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt",
                        CultureInfo.InvariantCulture)
                        : "not finished"


                    })
                    .ToList()

                }).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} - Manager: {e.ManagerFirstName} {e.ManagerLastName}");
                foreach (var ep in e.Projects)
                {
                    sb.AppendLine($"--{ep.ProjectName} - {ep.StartDate} - {ep.EndDate}");
                }
            }

            return sb.ToString().TrimEnd();
        }

        //08. Addresses by Town
        public static string GetAddressesByTown(SoftUniContext context)
        {
            var addresses = context.Addresses
                .OrderByDescending(e => e.Employees.Count)
                .ThenBy(e => e.Town.Name)
                .ThenBy(e => e.AddressText)
                .Take(10)
                .Select(e => new
                {
                    AddressText = e.AddressText,
                    TownName = e.Town.Name,
                    EmployeeCount = e.Employees.Count
                }).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var a in addresses)
            {
                sb.AppendLine($"{a.AddressText}, {a.TownName} - {a.EmployeeCount} employees");

            }
            return sb.ToString().Trim();
        }

        //09. Employee 147
        public static string GetEmployee147(SoftUniContext context)
        {
            var employeeId147 = context
                .Employees
                .Select(e => new
                {
                    EmployeeId = e.EmployeeId,
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    JobTitle = e.JobTitle,
                    Projects = e.EmployeesProjects
                    .Select(ep => new
                    {
                        projects = ep.Project.Name
                    })
                    .OrderBy(ep => ep.projects)
                    .ToList()

                })
                .Where(e => e.EmployeeId == 147)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var e in employeeId147)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle}");
                foreach (var ep in e.Projects)
                {
                    sb.AppendLine(ep.projects);
                }
            }

            return sb.ToString().Trim();
        }
        //10. Departments with More Than 5 Employees

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var departmentsWithMore5E = context
                .Departments
                .Where(d => d.Employees.Count > 5)
                .OrderBy(d => d.Employees.Count)
                .ThenBy(d => d.Name)
                .Select(d => new
                {
                    departmentName = d.Name,
                    ManagersFirstName = d.Manager.FirstName,
                    ManagersLastName = d.Manager.LastName,
                    allEmployees = d.Employees
                    .Select(e => new
                    {
                        FirstName = e.FirstName,
                        Lastname = e.LastName,
                        JobTitle = e.JobTitle

                    })
                    .OrderBy(e => e.FirstName)
                    .ThenBy(e => e.Lastname)
                    .ToList()
                }).ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var d in departmentsWithMore5E)
            {
                sb.AppendLine($"{d.departmentName} – {d.ManagersFirstName} {d.ManagersLastName}");
                foreach (var e in d.allEmployees)
                {
                    sb.AppendLine($"{e.FirstName} {e.Lastname} - {e.JobTitle}");
                }
            }
            return sb.ToString().TrimEnd();
        }

        //11. Find Latest 10 Projects
        public static string GetLatestProjects(SoftUniContext context)
        {
            var lastTenProjects = context.Projects
                .OrderByDescending(p => p.StartDate)
                .Take(10)
                .OrderBy(p => p.Name)
                .Select(p => new
                {
                    name = p.Name,
                    description = p.Description,
                    startDate = p.StartDate
                })
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var pr in lastTenProjects)
            {
                sb.AppendLine($"{pr.name}");
                sb.AppendLine($"{pr.description}");
                sb.AppendLine($"{pr.startDate}");
            }

            return sb.ToString().Trim();
        }

        //12. Increase Salaries
        public static string IncreaseSalaries(SoftUniContext context)
        {
            var employeesWithNewSalary = context.Employees
                .Where(e => e.Department.Name == "Engineering" ||
                e.Department.Name == "Tool Design" ||
                e.Department.Name == "Marketing" ||
                e.Department.Name == "Information Services");

            foreach (var e in employeesWithNewSalary)
            {
                e.Salary *=  1.12m;
            }
            context.SaveChanges();

            var empoyeesWithIncreasedSalary = employeesWithNewSalary
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.Salary

                })
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var ep in empoyeesWithIncreasedSalary)
            {
                sb.AppendLine($"{ep.FirstName} {ep.LastName} (${ep.Salary:f2})");

            }

            return sb.ToString().TrimEnd();
        }

        //13. Find Employees by First Name Starting With Sa

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            var employeesWithSa = context.Employees
                .Where(e => e.FirstName.StartsWith("Sa"))
                .Select(e => new
                {
                    firstName = e.FirstName,
                    lastName = e.LastName,
                    jobTitle = e.JobTitle,
                    salary = e.Salary 
                })
                    .OrderBy(e => e.firstName)
                    .ThenBy(e => e.lastName)
                    .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var e in employeesWithSa)
            {
                sb.AppendLine($"{e.firstName} {e.lastName} - {e.jobTitle} - (${e.salary:f2})");
            }
            return
            sb.ToString().TrimEnd();
        }

        //14. Delete Project by Id

        public static string DeleteProjectById(SoftUniContext context)
        {
            var projectWithId2 = context.Projects
                .FirstOrDefault(p => p.ProjectId == 2);

            var employeeProject = context.EmployeesProjects
                
                .Where(ep => ep.ProjectId == 2)
                .ToList();

           
            foreach (var p in employeeProject)
            {
                context.EmployeesProjects.Remove(p);
            }
            context.Projects.Remove(projectWithId2);
            context.SaveChanges();

            StringBuilder sb = new StringBuilder();

            var projects = context.Projects
                .Select(p => p.Name)
                .Take(10)
                .ToList();


            foreach (var pr in projects)
            {
                sb.AppendLine($"{pr}");
            }

            return sb.ToString().Trim();
        }

        //15. Remove Town
        public static string RemoveTown(SoftUniContext context)

        {
            var townsLikeSeattle = context.Addresses
                .Where(t => t.Town.Name == "Seattle")
                .ToArray();

            var employeesInSeattle = context.Employees
                .ToArray()
                .Where(e => townsLikeSeattle.Any(a => a.AddressId == e.AddressId))
                .ToArray();

            foreach (var e in employeesInSeattle)
            {
                e.AddressId = null;
            }

            context.Addresses.RemoveRange(townsLikeSeattle);

            var seattleTown = context.Towns
                .First(t => t.Name == "Seattle");
            context.Towns.Remove(seattleTown);

            context.SaveChanges();

            return $"{townsLikeSeattle.Length} addresses in Seattle were deleted";
            
        }









    }
}
