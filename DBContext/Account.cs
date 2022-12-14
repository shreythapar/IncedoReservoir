using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IncedoReservoir.DBContext
{
    public class Account
    {
        [Key]
        public int iAccountID { get; set; }
        public string sAccountName { get; set; }
        public string sDisplayName { get; set; }
        public string sOrganizationName { get; set; }
        public string sAccountType { get; set; }
        public Nullable<System.DateTime> dAOpeningDate { get; set; }
        public string sAddress { get; set; }
        public Nullable<int> iCountry { get; set; }
        public string sCountry { get; set; }
        public Nullable<int> iState { get; set; }
        public string sState { get; set; }
        public Nullable<int> iCity { get; set; }
        public string sCity { get; set; }
        public string sPIN { get; set; }
        public string sMobile { get; set; }
        public string sTelOffOne { get; set; }
        public string sTelOffTwo { get; set; }
        public string sFax { get; set; }
        public string sEmailID { get; set; }
        public Nullable<int> iStatus { get; set; }
        public string sCompanyLogoPath { get; set; }
        public Nullable<int> iUserID { get; set; }
        public Nullable<System.DateTime> dCreatedOn { get; set; }
        public Nullable<int> iAccountIdCreatedBy { get; set; }
        public Nullable<int> iCreatedBy { get; set; }
        public Nullable<System.DateTime> dModifiedOn { get; set; }
        public Nullable<int> iAccountIdModifiedBy { get; set; }
        public Nullable<int> iModifiedBy { get; set; }
        public Nullable<System.DateTime> dDeletedOn { get; set; }
        public Nullable<int> iAccountIdDeletedBy { get; set; }
        public Nullable<int> iDeletedBy { get; set; }
        public string sEmployeeCode { get; set; }
        public Nullable<int> iEmployeeID { get; set; }
    }
}