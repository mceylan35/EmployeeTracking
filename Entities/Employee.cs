using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Employee: BaseEntity,IEntity
    {
        public Employee()
        {
            EmployeeOperationClaims = new HashSet<EmployeeOperationClaim>();
        }
         
        public string Name { get; set; }
        public string SurName { get; set; }
        public bool? Status { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<EmployeeOperationClaim> EmployeeOperationClaims { get; set; }
    }
}
