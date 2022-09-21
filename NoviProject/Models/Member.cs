using System.ComponentModel.DataAnnotations;

namespace NoviProject.Models
{
    public class Member
    {
        public string? UniqueID { get; set; }
        public string? ParentCustomerUniqueID { get; set; }
        public string? ParentMemberName { get; set; }    
        public string? Name { get; set; }
        public string? DisplayName { get; set; }
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Suffix { get; set; }
        public bool? Active { get; set; }
        public string? CustomerType { get; set; }
        public MemberType? MemberType { get; set; }
        public string? OriginalJoinDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime? MemberSince { get; set; }
        public string? MembershipExpires { get; set; }
        public string? MemberStatus { get; set; }
        public string? MemberSubStatus { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public string? Fax { get; set; }
        public string? Website { get; set; }
        public bool AutoPay { get; set; }
        public bool Approved { get; set; }
        public bool AutoRenew { get; set; }
        public string? Image { get; set; }
        public Address? BillingAddress { get; set; }
        public Address? ShippingAddress { get; set; }
        public string? County { get; set; }
        public string? PersonalEmail { get; set; }
        public string? PersonalPhone { get; set; }
        public string? PersonalMobile { get; set; }
        public Address? PersonalAddress { get; set; }
        public string? Notes { get; set; }
        public string? FacebookUrl { get; set; }
        public string? LinkedInUrl { get; set; }
        public string? TwitterHandle { get; set; }
        public string? MemberProfile { get; set; }
        public string? JobTitle { get; set; }
        public bool HideOnWebsite { get; set; }
        public bool HideContactInformation { get; set; }
        public bool UnsubscribeFromEmails { get; set; }
        public string? QuickBooksID { get; set; }
        public string? PrimaryContactUniqueId { get; set; }
        public string? BillingContactUniqueId { get; set; }
        public CustomField? CustomFields { get; set; }
        public string? Credentials { get; set; }
        public List<string>? DirectoryGallery { get; set; }
        public List<string>? Awards { get; set; }
        public List<string>? VolunteerWorks { get; set; }
        public List<string>? Education { get; set; }
        public List<string>? Groups { get; set; }
        public List<string>? SpecifiedSystemFields { get; set; }
        public string? CreatedDate { get; set; }
        public string? LastUpdatedDate { get; set; }
    }
}
