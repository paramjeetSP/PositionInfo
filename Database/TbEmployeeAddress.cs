using System;
using System.Collections.Generic;

#nullable disable

namespace PositionInfo.Database
{
    public partial class TbEmployeeAddress
    {
        public int Id { get; set; }
        public int Fkemployee { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string PinCode { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Ext { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DateUpdated { get; set; }
        public string AddressType { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Employee FkemployeeNavigation { get; set; }
    }
}
