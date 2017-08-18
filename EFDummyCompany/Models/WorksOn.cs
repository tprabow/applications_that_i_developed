using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace EFDummyCompany.Models
{
    [Table("WorksOn")]
    public partial class WorksOn
    {

        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int DepartmentId { get; set; }

        public int RoleId { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Department Department { get; set; }

       
    }
}