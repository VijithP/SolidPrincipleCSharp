using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IMP
{
    class LiskovSubstitutionImplemetation
    {
        public LiskovSubstitutionImplemetation()
        {
            List<IProject> resourceList = new List<IProject>();
            resourceList.Add(new ContractualResourceImp());
            resourceList.Add(new CasualResourceImp());
            foreach (IProject e in resourceList)
            {
               Console.WriteLine(e.GetProjectDetails(1245));
            }
        }

    }

    public interface IProject
    {
        string GetProjectDetails(int employeeId);

    }

    public interface IResource
    {
       string GetResourceDetails(int employeeId);
    }

    public class CasualResourceImp : IResource,IProject
    {
        public  string GetProjectDetails(int employeeId)
        {
            return "Sub Project (Casual)";
        }
        public  string GetResourceDetails(int employeeId)
        {
            return "Child Resource";
        }
    }
    public class ContractualResourceImp : IProject
    {
        public  string GetProjectDetails(int employeeId)
        {
            return "Sub Project (contractual)";
        }
        
    }

}
