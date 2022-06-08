using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class OperationClaim:BaseEntity,IEntity
    {
        public OperationClaim()
        {
            EmployeeOperationClaims = new HashSet<EmployeeOperationClaim>();
        }

        public string Name { get; set; } 

        public virtual ICollection<EmployeeOperationClaim> EmployeeOperationClaims { get; set; }
    }
}
