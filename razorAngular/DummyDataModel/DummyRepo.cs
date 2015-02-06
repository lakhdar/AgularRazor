using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace razorAngular.DummyDataModel
{
    public class DummyRepo
    {
        IEnumerable<Employee> employees;

        public IEnumerable<Employee> Employees
        {
            get {
                if (employees == null)
                {
                    employees = JsonConvert.DeserializeObject<List<Employee>>(System.IO.File.ReadAllText(HostingEnvironment.MapPath(@"~/App_Data\data.json")));
                }
                return employees; 
            }
           
        }

        public IEnumerable<Employee> GetAll()
        {
            return Employees;
        }

        public Employee GetElementById(int id)
        {
            return Employees.FirstOrDefault(x => x.EmployeeID == id);
        }

    }
}