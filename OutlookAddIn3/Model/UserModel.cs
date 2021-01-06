using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookAddIn3
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int? LoginPermissionId { get; set; }

        public bool IsPassive { get; set; }

        public string Email { get; set; }

        public string Gsm { get; set; }

        public string ProfilePicturePath { get; set; }

        public int DefaultOrganizationId { get; set; }

        public int? UserGroupId { get; set; }

        public string ActiveColor { get; set; }

        public string PassiveColor { get; set; }

        public bool? IsLocationTracking { get; set; }

        public bool? IsShowOnMap { get; set; }

        public int? TransactionTypeId { get; set; }

        public int? ContractTypeId { get; set; }

        public int? OrderTypeId { get; set; }

        public string JobTitle { get; set; }

        public string ProfilePicture { get; set; }

        public bool? IsActivityRestriction { get; set; }

        public bool? IsTaskRestriction { get; set; }

        public bool? IsOpportunityRestriction { get; set; }

        public bool? IsOfferRestriction { get; set; }

        public bool? IsSurveyRestriction { get; set; }

        public bool? IsOrderRestriction { get; set; }

        public bool? IsUnitPriceNotChange { get; set; }
        public int? PageDesignGroupId { get; set; }

    }
}
