namespace CRUD_operation_Employee.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee_Detail
    {
        public int id { get; set; }

        [StringLength(100)]
        public string Employee_Name { get; set; }

        [StringLength(20)]
        public string Employee_ID { get; set; }

        [StringLength(100)]
        public string Designation { get; set; }

        [StringLength(100)]
        public string Salary { get; set; }
    }
}
