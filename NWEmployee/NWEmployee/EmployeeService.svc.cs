﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NWEmployee
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        public NORTHWNDEntities contex = new NORTHWNDEntities();

        public MyEmployee GetEmployee(int employeeId) { throw new NotImplementedException(); }

        public void SaveEmployee(MyEmployee employee) { throw new NotImplementedException(); }
    }
}
