   using Dependencyinjection.Interface;
namespace Dependencyinjection.Interface
{
    public class Employee : IEmployee
    {
        Guid id;
        public Employee()
        {
           id= Guid.NewGuid();
        }

        public Guid GenarateGuId()
        {
           return id;
        }

        public List<string> GetEmployeeList()
        {
            List<string> listObj = new List<string>();
            listObj.Add("Ram");
            listObj.Add("Sriram");
            listObj.Add("Sri");
            return listObj;
        }
    }
}
