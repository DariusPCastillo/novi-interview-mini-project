using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoviProject.Models
{


    public class SingleMember
    {
        public string? UniqueID { get; set; }
        public string? TenantID { get; set; }
        public object? ParentCustomerUniqueID { get; set; }
        public string? Name { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public object? Suffix { get; set; }
        public bool? Active { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public string? Fax { get; set; }
        public string? Website { get; set; }
        public string? County { get; set; }
        public Billingaddress? BillingAddress { get; set; }
        public Shippingaddress? ShippingAddress { get; set; }
        public string? PersonalEmail { get; set; }
        public string? PersonalPhone { get; set; }
        public string? PersonalMobile { get; set; }
        public object? PersonalAddress { get; set; }
        public string? Notes { get; set; }
        public string? FacebookUrl { get; set; }
        public string? LinkedInUrl { get; set; }
        public string? TwitterHandle { get; set; }
        public string? MemberProfile { get; set; }
        public string? JobTitle { get; set; }
        public string? Image { get; set; }
        public string? OriginalJoinDate { get; set; }

       [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime? MemberSince { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime? MembershipExpires { get; set; }
        public string? MemberStatus { get; set; }
        public string? MemberSubStatus { get; set; }
        public bool HideOnWebsite { get; set; }
        public bool HideContactInformation { get; set; }
        public bool UnsubscribeFromEmails { get; set; }
        public bool Approved { get; set; }
        public bool AutoRenew { get; set; }
        public bool AutoPay { get; set; }
        public Membertype? MemberType { get; set; }
        public string? CustomerType { get; set; }
        public Customfields? CustomFields { get; set; }
        public string[]? SpecifiedSystemFields { get; set; }
        public string? QuickBooksID { get; set; }
        public Group[]? Groups { get; set; }
    }

    public class Billingaddress
    {
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public string? StateProvince { get; set; }
        public string? Country { get; set; }
    }

    public class Shippingaddress
    {
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public string? StateProvince { get; set; }
        public string? Country { get; set; }
    }

    public class Membertype
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool? ForCompanies { get; set; }
    }

    public class Customfields
    {
        public ThisIsTheTestingSite? Thisisthetestingsite { get; set; }
    }

    public class ThisIsTheTestingSite
    {
        public string Value { get; set; }
        public bool IsSumOfChildren { get; set; }
    }

    public class Group
    {
        public string? GroupUniqueID { get; set; }
        public string? GroupName { get; set; }
        public bool InheritingMember { get; set; }
    }


}
