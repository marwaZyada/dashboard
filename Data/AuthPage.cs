using System;
using System.Collections.Generic;

namespace Dashboard.Data
{
    public partial class AuthPage
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }
        public int? ModuleId { get; set; }
        public string? Url { get; set; }
        public string? Icon { get; set; }
        public int? OrderId { get; set; }
        public bool? IsActive { get; set; }
        public int? DepId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public bool IsSystem { get; set; }
    }
}
