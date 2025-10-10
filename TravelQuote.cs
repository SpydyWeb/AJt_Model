using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TravelQuote
    {
        public class ClientDetailModel
        {
            public int ID { get; set; }

            public string NationalId { get; set; }

            public string ProductId { get; set; }

            public string MemberName { get; set; }

            public DateTime? DateofBirth { get; set; }

            public string Gender { get; set; }

            public string MobileNo { get; set; }

            public string EmailId { get; set; }

            public string Nationality { get; set; }

            public string PassportNo { get; set; }

            public string FullNameofPassport { get; set; }

            public string CountryofResidence { get; set; }

            public bool? IsActive { get; set; }

            public string CreatedBy { get; set; }

            public DateTime? CreatedDate { get; set; }

            public string UpdatedBy { get; set; }

            public DateTime? UpdatedDate { get; set; }
            public string year { get; set; }
            public string month { get; set; }
            public long CreatedById { get; set; }

        }
    

        public class AddressDetails
        {
            public int Id { get; set; }

            public int? ClientId { get; set; }

            public string addressType { get; set; }

            public string BuildingNo { get; set; }

            public string AdditionalCode { get; set; }

            public string Region { get; set; }

            public string City { get; set; }

            public string PostalCode { get; set; }

            public string UnitNo { get; set; }

            public string POBoxAddress { get; set; }

            public string POBoxNo { get; set; }

            public string Street { get; set; }

            public string Distict { get; set; }

            public string CreatedBy { get; set; }

            public DateTime? CreatedDate { get; set; }

            public string UpdatedBy { get; set; }

            public DateTime? UpdatedDate { get; set; }

            public string HomeBuildingNo { get; set; }

            public string HomeAdditionalCode { get; set; }

            public string HomeRegion { get; set; }

            public string HomeCity { get; set; }

        }
        public class TravalDetails
        {
            public int Id { get; set; }

            public int? ClientId { get; set; }

            public string PolicyType { get; set; }

            public string CoverageType { get; set; }

            public string PackageType { get; set; }

            public string PeriodofTraval { get; set; }

            public DateTime? TravalStartDate { get; set; }

            public bool? MedicalCover { get; set; }

            public bool? InconvienceCover { get; set; }

            public string CreatedBy { get; set; }

            public DateTime? CreatedDate { get; set; }

            public string UpdatedBy { get; set; }

            public DateTime? UpdatedDate { get; set; }
            public int? Adult1869 { get; set; }
            public int? Child017 { get; set; }
        }
        public class FamilyDetails
        {
            public int Id { get; set; }

            public int? ClientId { get; set; }

            public DateTime? DateofBirth { get; set; }

            public string Gender { get; set; }

            public string Relation { get; set; }

            public string Nationality { get; set; }

            public string FullNameofPassport { get; set; }

            public string PassportNo { get; set; }

            public string CreatedBy { get; set; }
            public string NationalID { get; set; }

            public DateTime? CreatedDate { get; set; }

            public string UpdatedBy { get; set; }

            public DateTime? UpdatedDate { get; set; }

        }

        public class ClaimDetails
        {
            public decimal Id { get; set; }

            public decimal? ClientId { get; set; }

            public int? ClaimId1 { get; set; }

            public bool? IsClaimId1 { get; set; }

            public int? ClaimId2 { get; set; }

            public bool? IsClaimId2 { get; set; }

            public int? ClaimId3 { get; set; }

            public bool? IsClaimId3 { get; set; }

            public int? ClaimId4 { get; set; }

            public bool? IsClaimId4 { get; set; }

            public int? ClaimId5 { get; set; }

            public bool? IsClaimId5 { get; set; }

            public int? ClaimId6 { get; set; }

            public bool? IsClaimId6 { get; set; }

        }
        public class DocumentDetails
        {
            public int Id { get; set; }

            public int ClientId { get; set; }

            public string DocumentType { get; set; }

            public string Documentname { get; set; }

            public string DocumentPath { get; set; }

            public string CreatedBy { get; set; }

            public DateTime? CreatedDate { get; set; }

            public string UpdatedBy { get; set; }

            public DateTime? UpdatedDate { get; set; }

        }
        public class TariffInput
        {
            public string Reqt_Ref_No { get; set; }
            public int Area { get; set; }
            public int TRIP_TYPE { get; set; }
            public int NOOF_DAYS { get; set; }
            public int CLASS { get; set; }
        }
        public class TravelDetails
        {
            public decimal BASE_PREM { get; set; }
            public decimal VAT { get; set; }
            public decimal VAT_RATE { get; set; }
            public string PRODUCT_NAME_EN { get; set; }
            public string PRODUCT_NAME_AR { get; set; }
            public int PRODUCT_ID { get; set; }
        }

        public class PremiumDetails
        {
            public int Id { get; set; }

            public int ClientId { get; set; }

            public decimal? EmergencyMedical { get; set; }

            public decimal? PreMatureReturn { get; set; }

            public decimal? PersonalLiability { get; set; }

            public decimal? Delayedbaggage { get; set; }

            public decimal? PersonalAccident { get; set; }

            public decimal? EmergencyDentalCare { get; set; }

            public decimal? MortalRemains { get; set; }

            public decimal? TripCancellation { get; set; }

            public decimal? PersonalBaggage { get; set; }

            public decimal? RepatritaionOtherInsured { get; set; }

            public decimal? EscortDepChild { get; set; }

            public decimal? DelayedDeparture { get; set; }

            public decimal? LossPassport { get; set; }

            public decimal? TotalPremiumWithoutVAT { get; set; }

            public decimal? VAT { get; set; }

            public decimal? TotalPremiumWithVAT { get; set; }

            public string CreatedBy { get; set; }

            public DateTime? CreatedDate { get; set; }

            public string UpdatedBy { get; set; }

            public DateTime? UpdatedDate { get; set; }
            public bool IsSelected { get; set; }
            public string ProductName { get; set; }
            public int ProductId { get; set; }

        }
        public class HeaderDetails
        {
            public string ReqtRefNo { get; set; }
            public bool ISERROR { get; set; }
            public string ERRORMESSAGE { get; set; }
            public long FCS_CST_ID { get; set; }
            public long CORE_PLC_ID { get; set; }
            public string SEGMENT_CODE { get; set; }
            public decimal GROSS_PREMIUM_LC { get; set; }
            public decimal TOTAL_PREMIUM_LC { get; set; }
            public decimal? VAT { get; set; }

        }

        public class PolicyHeader
        {
            public string ReqtRefNo { get; set; }
            public string NATIONALITY { get; set; }
            public string POLICY_TYPE { get; set; }
            public int POLICY_PERIOD { get; set; }
            public DateTime EFFECTIVE_DATE { get; set; }
            public DateTime EXPIRY_DATE { get; set; }
            public long TST_PRD_ID { get; set; }
            public long TST_ARA_ID { get; set; }
            public long SPONSOR_NO { get; set; }
            public string CONTACT_MOBILE { get; set; }
            public string SPONSOR_NAME { get; set; }
            public string EMAIL { get; set; }
            public DateTime SPONSOR_DOB { get; set; }
            public string NAME { get; set; }
            public DateTime BIRTH_DATE { get; set; }
            public int AGE { get; set; }
            public string GENDER { get; set; } = "M" == "M" ? "1" : "2";
            public MaritalStatus MARITAL_STATUS { get; set; }
            public string TPD_PLC_ID { get; set; }
            public string PASSPORT_NO { get; set; }
            public string PASSPORT_ISSUE_PLACE { get; set; } = "KSA";
            public DateTime PASSPORT_ISSUE_DATE { get; set; } = DateTime.Now;
            public int RELATION { get; set; } = 1;
            public int ROLE_TYPE { get; set; }
            public int COMM_RATE { get; set; }
            public int AGENT_ID { get; set; }
        }

        public enum MaritalStatus
        {
            Single = 1,
            Married = 2,
            Others = 5
        }
        public class PolPremDetails
        {
            public DateTime EFFECTIVE_DATE { get; set; }
            public DateTime EXPIRY_DATE { get; set; }
            public decimal GROSS_PREMIUM_LC { get; set; }
            public decimal TOTAL_PREMIUM_LC { get; set; }
            public decimal? VAT { get; set; }
            public bool IsError { get; set; }
            public string ErrorMessage { get; set; }
        }

        public class PolResponse
        {
            public long FCS_CST_ID { get; set; }
            public long CORE_PLC_ID { get; set; }
            public string SEGMENT_CODE { get; set; }
            public bool IsError { get; set; }
            public string ErrorMessage { get; set; }
            public int COMM_RATE { get; set; }
            public int ROLE_TYPE { get; set; }
            public int AGENT_ID { get; set; }
        }
        public class MemberResponse
        {
            public long id { get; set; }
            public List<Memberdependent> Memberdependents { get; set; }
            public bool IsError { get; set; }
            public string ErrorMessage { get; set; }
        }
        public class Memberdependent
        {
            public long id { get; set; }
        }
        public class MemberDetails
        {
            public string NAME { get; set; }
            public DateTime BIRTH_DATE { get; set; }
            public string AGE { get; set; }
            public int GENDER { get; set; }
            public int MARITAL_STATUS { get; set; }
            public string MOBILE { get; set; }
            public string EMAIL { get; set; }
            public string PASSPORT_NO { get; set; }
            public string PASSPORT_ISSUE_PLACE { get; set; }
            public DateTime? PASSPORT_ISSUE_DATE { get; set; }
            public Int64 TPD_PLC_ID { get; set; }
            public string NATIONAL_ID { get; set; }
            public int RELATION { get; set; }
            public string NATIONALITY { get; set; }
        }
        public class Policyposting
        {
            public DateTime EFFECTIVE_DATE { get; set; }
            public DateTime EXPIRY_DATE { get; set; }
            public bool IsError { get; set; }
            public string ErrorMessage { get; set; }
        }

        public class GETTST_ARA_IDReq
        {
            public int TravelCoverageAreaCode { get; set; }
            public string Productid { get; set; }
        }
        public class TravelRequest
        {
            public string ReqtRefNo { get; set; }
            public string V_NATIONALITY { get; set; }
            public string V_POLICY_TYPE { get; set; }
            public DateTime V_EFFECTIVE_DATE { get; set; }
            public DateTime V_EXPIRY_DATE { get; set; }
            public long V_TST_PRD_ID { get; set; }
            public long V_TST_ARA_ID { get; set; }
            public string V_CONTACT_MOBILE { get; set; }
            public string V_EMAIL { get; set; }
            public string V_NAME { get; set; }
            public DateTime V_BIRTH_DATE { get; set; }
            public string V_GENDER { get; set; }
            public MaritalStatus V_MARITAL_STATUS { get; set; }
            public string V_PASSPORT_NO { get; set; }
            public string V_NATIONAL_ID { get; set; }
            public string V_POLICYTYPE { get; set; }
            public string V_AGE { get; set; }
            public MemberDetails[] memberDetails { get; set; }
            public int ROLE_TYPE { get; set; }
            public int COMM_RATE { get; set; }
            public int AGENT_ID { get; set; }
        }
        public class TravelResponse
        {
            public bool ISERROR { get; set; }
            public string ERRORMESSAGE { get; set; }
            public string SEGMENT_CODE { get; set; }
            public long CORE_PLC_ID { get; set; }
            public long FCS_CST_ID { get; set; }

            //public string REQREFNO { get; set; }
            //public string STATUS { get; set; }
            //public string ERROR { get; set; }
            //public long V_FCS_CST_ID { get; set; }
            //public long V_PLC_ID { get; set; }
            //public string V_SEGMENT_CODE { get; set; }
            //public string V_GROSS_PREMIUM_LC { get; set; }
            //public string V_TOTAL_PREMIUM_LC { get; set; }
            //public string V_VAT { get; set; }
        }
        public class CreatePolicyDetail
        {
            public decimal? QuoteNo { get; set; }
            public decimal? ID { get; set; }
            public string Policynumber { get; set; }
            public decimal Premium { get; set; }
            public int VAT { get; set; }
            public DateTime? EffectiveDate { get; set; }
            public string IBAN { get; set; }
            public string VATNo { get; set; }
            public string PaymentKey { get; set; }
            public DateTime? IssueDate { get; set; }
            public DateTime? ExpiryDate { get; set; }
            public long CORE_PLC_ID { get; set; }
            public long FCS_CST_ID { get; set; }
        }

        public class TravelDetailsList
        {
            public string ID { get; set; }
            public string NationalId { get; set; }
            public string FullNameofPassport { get; set; }
            public string PassportNo { get; set; }
            public string CoverageType { get; set; }
            public DateTime? CreatedDate { get; set; }
            public string TotalPremiumWithVAT { get; set; }
            public string ProductName { get; set; }
            public string PaymentKey { get; set; }
            public string Policynumber { get; set; }
            public long CorePlcId { get; set; }
            public long FcsCstId { get; set; }

            public int? createdbyid { get; set; }
            public string scheduleFileName { get; set; }
            public DateTime? TravalStartDate { get; set; }
        }

        public class TravelReportResponse
        {
            public string GeneratedReportPath { get; set; }
            public string ReportCode { get; set; }
            public string ReportName { get; set; }
            public bool status { get; set; }
            public string Reason { get; set; }

        }
        public class SalesReport
        {
            public string ID { get; set; }
            public string CreatedDate { get; set; }
            public string CreatedBy { get; set; }
            public string Policynumber { get; set; }
            public string IssueDate { get; set; }
            public string CoverageType { get; set; }
            public string PeriodofTraval { get; set; }
            public string ProductName { get; set; }
            public string TotalPremiumWithVAT { get; set; }

        }
        public class TravelReportInput
        {
            public TravelReportInput() { }
            public string FromDate { get; set; }
            public string Todate { get; set; }
            public int UserId { get; set; }
            public bool IsSuperVisor { get; set; }
            public int ReportType { get; set; }
        }
        public class TravelReports
        {
            public TravelReports() { }
            public int ReportType { get; set; }
            public List<SalesReport> salesReports { get; set; }

        }
        public class TravelSchedule
        {
            public string CORE_SEGMENT_CODE { get; set; }
            public string MAIN_NAME { get; set; }
            public string MAIN_GENDER { get; set; }
            public string DOB_G { get; set; }
            public string PASSPORTNUMBER { get; set; }
            public string MOBILE_NO { get; set; }
            public string EMAIL_ID { get; set; }
            public DateTime CORE_EFFECTIVE_DATE { get; set; }
            public DateTime CORE_EXPIRY_DATE { get; set; }
            public string POLICY_TYPE { get; set; }
            public string NET_PREMIUM { get; set; }
            public string GROSS_PREMIUM { get; set; }
            public string RELATION { get; set; }
            public string INSUREDADDRESS { get; set; }
            public string RELATION_NAME { get; set; }
            public string POL_CLASSIFICATION { get; set; }
            public string POLICY_CAT { get; set; }
            public string VAT { get; set; }
            public string IDNUMBER { get; set; }
         

        }
        public class TravelBenefitPlan
        {
            public string BenefitsName { get; set; }
            public string Standard { get; set; }
            public string Silver { get; set; }
            public string Gold { get; set; }
            public string Platinum { get; set; }
            public string Schengen { get; set; }


        }
        public class UserDetailType
        {
            public int? UserId { get; set; }
            public int? Commission { get; set; }
            public string Name { get; set; }
        }
        public class TravalDashBaord
        {
            public TravalDashBaord() { }
            public DateTime FromDate { get; set; }
            public DateTime ToDate { get; set; }

            public int userId { get; set; }

            public bool IsSupervisor { get; set; }

        }
        public class YakeenInput
        {
            public string IQamaNumber { get; set; }
            public string birthDate { get; set; }
            public string Source { get; set; }
        }
        public class YakeenResidentInput
        {
            public string birthDate { get; set; }
            public string IQamaNumber { get; set; }
            public Int64 sponsorID { get; set; }
            public string Source { get; set; }
        }
   

        public class PersonIdInfo
        {
            public int IdIssuePlaceCode { get; set; }
            public DateTime IdExpirationDate { get; set; }
            public string IdIssuePlaceDescAR { get; set; }
        }

        public class PersonBasicInfo
        {
            public DateTime BirthDateG { get; set; }
            public string FamilyName { get; set; }
            public string FamilyNameT { get; set; }
            public string FatherName { get; set; }
            public string FatherNameT { get; set; }
            public string FirstName { get; set; }
            public string FirstNameT { get; set; }
            public string GrandFatherName { get; set; }
            public string GrandFatherNameT { get; set; }
            public string MaritalStatusCode { get; set; }
            public string MaritalStatusDescAr { get; set; }
            public string SexCode { get; set; }
            public string SexDescAr { get; set; }
            public string NationalityCode { get; set; }
            public string NationalityDescAr { get; set; }
            public string OccupationCode { get; set; }
            public string OccupationDescAr { get; set; }
        }

        public class PersonalAbsherAPIDetails
        {
            public PersonIdInfo PersonIdInfo { get; set; }
            public PersonBasicInfo PersonBasicInfo { get; set; }
            public string ErrorId { get; set; }
            public string ErrorDetail { get; set; }
            public bool Status { get; set; }
            public string ErrorMessage { get; set; }
        }
        public class PersonalBorderAbsherAPIDetails
        {
            public PersonBasicInfo PersonBasicInfo { get; set; }
            public string ErrorId { get; set; }
            public string ErrorDetail { get; set; }
            public bool Status { get; set; }
            public string ErrorMessage { get; set; }
        }

        public class Address
        {
            public string ObjLatLng { get; set; }
            public int BuildingNumber { get; set; }
            public string Street { get; set; }
            public string District { get; set; }
            public string City { get; set; }
            public int PostCode { get; set; }
            public int AdditionalNumber { get; set; }
            public bool IsPrimaryAddress { get; set; }
        }

        public class PersonNationalAddressInfo
        {
            public List<Address> Addresses { get; set; }
            public object PostCode { get; set; } // Changed to object to handle null values
        }

        public class AddresAPIResp
        {
            public PersonNationalAddressInfo PersonNationalAddressInfo { get; set; }
            public object ErrorId { get; set; } // Changed to object to handle null values
            public object ErrorDetail { get; set; } // Changed to object to handle null values
            public bool Status { get; set; }
            public object ErrorMessage { get; set; } // Changed to object to handle null values
        }
        public class GetUserDetailsInput
        {
            public string nationalId { get; set; }
            public string DOBH { get; set; }
            public string DOBG { get; set; }
        }
        public class UserDetailModel
        {
            public citizenAbsherDetails CitizenDetails { get; set; }
            public residentAbsherDetails ResidentDetails { get; set; }
        }
        public class AddToApprovals
        {
            public ApprovalHistDetails approvalHistory { get; set; }

            public AddToApprovals()
            {
                approvalHistory = new ApprovalHistDetails();
            }
        }
        public class ApprovalHistDetails
        {
            public long Id { get; set; }

            public int Status { get; set; }

            public string RejectionReason { get; set; }

            public bool? isSMSSent { get; set; }

            public bool? isEmail { get; set; }

            public string Attachments { get; set; }

            public int? ApprovalUserId { get; set; }

            public int PolicyId { get; set; }

            public DateTime RecievedDate { get; set; }

            public int? UpdatedBy { get; set; }

            public DateTime? UpdateDate { get; set; }

            public long? AppHistID { get; set; }

            public string Comments { get; set; }
            public string Referenceno { get; set; }
            public decimal Amount { get; set; }
           
        }
        public class UtilityReq
        {
            public int flag;
            public string Id;
            public string details;
            public string details2;
        }
        public class TravelIBANREquest
        {
            public string Vatno { get; set; }
            public string Ibanno { get; set; }
            public string SegmentCode { get; set; }
            public string EskaPolicyID { get; set; }
            public int Policyno { get; set; }
            public string BankNameEn { get; set; }
            public string BankNameAr { get; set; }
        }
    }
}
