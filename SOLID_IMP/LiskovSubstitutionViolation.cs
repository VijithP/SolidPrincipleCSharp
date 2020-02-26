using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IMP
{
    public class LiskovSubstitutionViolation
    {
        public LiskovSubstitutionViolation()
        {
            List<Resource> resourceList = new List<Resource>();
            resourceList.Add(new ContractualResource());
            resourceList.Add(new CasualResource());
            foreach (Resource e in resourceList)
            {
                e.GetResourceDetails(1245);
            }
        }
    }

}


public abstract class Resource
    {
        public virtual string GetProjectDetails(int employeeId)
        {
            return "Base Project";
        }
        public virtual string GetResourceDetails(int employeeId)
        {
            return "Base Resource";
        }
    }
    public class CasualResource : Resource
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }
        // May be for contractual employee we do not need to store the details into database.
        public override string GetResourceDetails(int employeeId)
        {
            return "Child Resource";
        }
    }
    public class ContractualResource : Resource
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }
        // May be for contractual Resource we do not need to store the details into database.
        public override string GetResourceDetails(int employeeId)
        {
            throw new NotImplementedException();
        }
    }
