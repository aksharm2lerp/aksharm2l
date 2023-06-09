﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business.Entities.Contractor
{
    public class ContractorMaster
    {
        public int ContractorID { get; set; }
        [NotMapped]
        public string EncryptedId { get; set; }
        public string UnitNoName { get; set; }
        public string ContractorCode { get; set; }
        public string ContractorName { get; set; }
        public string GroupName { get; set; }
        public string OwnerName { get; set; }
        public string ContactPhone1 { get; set; }
        public string Mobile1 { get; set; }
        public string FaxNo { get; set; }
        public int? IndustryTypeID { get; set; }
        public int? BusinessTypeID { get; set; }
        public string LogoImagePath { get; set; }        
        public IFormFile LogoImage { get; set; }
        public string LogoImageName { get; set; }
        public bool IsActive { get; set; } = true;
        public int? CreatedOrModifiedBy { get; set; }
        public int SrNo { get; set; }
    }
}
