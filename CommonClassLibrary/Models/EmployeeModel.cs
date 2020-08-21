using BusinessData.Property;
using CommonClassLibrary.Propertys;
using CommonClassLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommonClassLibrary.Models
{
    public class EmployeeModel
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        EmployeeService _service = new EmployeeService();

        public OutputOnDbProperty SearchOne(EmployeeProperty dataItem)
        {
            _resultData = _service.Search(dataItem);
            return _resultData;
        }
    }
}