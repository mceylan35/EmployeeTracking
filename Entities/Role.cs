using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Role : BaseEntity,IEntity
    {
        public Role()
        {
            Employee = new HashSet<Employee>();
        }
         
        public string RoleName { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
