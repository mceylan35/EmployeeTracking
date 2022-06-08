using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EmployeeOperationClaim : BaseEntity, IEntity
    {
        public int? EmployeeId { get; set; }
        public int? OperationClaimId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual OperationClaim OperationClaim { get; set; }
    }
}
