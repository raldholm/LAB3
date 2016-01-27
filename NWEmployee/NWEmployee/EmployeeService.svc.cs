using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;

namespace NWEmployee
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        public NORTHWNDEntities context = new NORTHWNDEntities();

        public MyEmployee GetEmployee(int employeeId)
        {
            try
            {
                var newemployee = context.Employees.SingleOrDefault(s => s.EmployeeID == employeeId);
                MyEmployee employee = new MyEmployee();
                if (newemployee != null)
                {
                    employee.EmployeeId = newemployee.EmployeeID;
                    employee.LastName = newemployee.LastName;
                    employee.FirstName = newemployee.FirstName;
                    employee.Title = newemployee.Title;
                    employee.TitleOfCourtesy = newemployee.TitleOfCourtesy;
                    employee.BirthDate = newemployee.BirthDate;
                    employee.HireDate = newemployee.HireDate;
                    employee.Address = newemployee.Address;
                    employee.City = newemployee.City;
                    employee.Region = newemployee.Region;
                    employee.PostalCode = newemployee.PostalCode;
                    employee.Country = newemployee.Country;
                    employee.HomePhone = newemployee.HomePhone;
                    employee.Extension = newemployee.Extension;
                    employee.Notes = newemployee.Notes;
                    employee.ReportsTo = newemployee.ReportsTo;
                }
                return employee;
            }
            catch (Exception)
            {
                return new MyEmployee();
            }
        }

        public void SaveEmployee(MyEmployee employee) { throw new NotImplementedException(); }

        public class FaultErrorHandler: IErrorHandler
        {
            public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
            {
                throw new NotImplementedException();
            }

            public bool HandleError(Exception error)
            {
                throw new NotImplementedException();
            }
        }
}
}
