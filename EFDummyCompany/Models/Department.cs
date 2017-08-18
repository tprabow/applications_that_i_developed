using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace EFDummyCompany.Models
{
    [Table("Department")]
    public class Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Department()
        {
            WorksOn = new HashSet<WorksOn>();
        }

        public int Id { get; set; }
        [StringLength(200)]
        public string DeptName { get; set; }
        [StringLength(200)]
        public string DeptOffice { get; set; }
        //public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public virtual ICollection<WorksOn> WorksOn { get; set; }

    }
}