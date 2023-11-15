
using Dependencyinjection.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Dependencyinjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployee _emp1;
        IEmployee _emp2;
        public EmployeeController(IEmployee EMP1, IEmployee EMP2)
        {
            _emp1 = EMP1;
            _emp2 = EMP2;
        }
        [HttpGet]
        public ActionResult Index()
        {

            string id1=_emp1.GenarateGuId().ToString();
            String id2=_emp2.GenarateGuId().ToString();

            List<string> emplist=_emp1.GetEmployeeList();
            return Ok(emplist);
        }


    }
}
