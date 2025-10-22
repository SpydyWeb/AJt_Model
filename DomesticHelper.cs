using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static Models.TravelQuote;

namespace Models
{
    public class DomesticHelper
    {
        public class APIResponse
        {
            public bool status { get; set; }

            public string message { get; set; }

            public int id { get; set; }

            public HttpStatusCode httpStatusCode { get; set; }
        }
        public class DomesticQuote
        {

            public string IDNumber { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string MobileNo { get; set; }
            public string EmailId { get; set; }
            public string CreatedBy { get; set; }
            public int CreatedByID { get; set; }
            public string FullName { get; set; }

        }

        public class DomesticHelperDetail
        {
            public int MemberId { get; set; }
            public string ID_Number { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string MobileNumber { get; set; }
            public string FullName { get; set; }
            public int Quoteid { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
            public string Country { get; set; }
            public string MaritalStatus { get; set; }
            public decimal Premium { get; set; }
            public DateTime ExpiryDate { get; set; }
            public string OccupationCode { get; set; }
            public string OccupationDescAr { get; set; }
            public string NationalityDescAr { get; set; }
            public string FamilyName { get; set; }
            public string FatherName { get; set; }
            public string FirstName { get; set; }
            public int MemberInsuranceClass { get; set; }
            public decimal AdditionalPremium { get; set; }

        }
        public class DomesticHelperDetailAdditionalpremuim
        {
            public int MemberId { get; set; }
            public decimal AdditionalPremium { get; set; }

        }

        public class DomesticHelperPremiumRequest
        {
            public int PlanId { get; set; }
            public string PolicyEffectiveDate { get; set; }
            public string PolicyExpiryDate { get; set; }
            public List<MemberPremium> MemberDatas { get; set; } = new List<MemberPremium>();
        }

        public class MemberData
        {

            public string NationalId { get; set; }
            public int RelationTypeId { get; set; }
            public int ClassType { get; set; }
            public string NationalityCode { get; set; }
            public DateTime DateOfBirth { get; set; }
            public int MaritalStatus { get; set; }
            public int GenderCode { get; set; }
        }
        public class MemberPremium
        {

            public string NationalId { get; set; }
            public int RelationTypeId { get; set; }
            public int ClassType { get; set; }
            public string NationalityCode { get; set; }
            public string DateOfBirth { get; set; }
            public int MaritalStatus { get; set; }
            public int GenderCode { get; set; }
        }
        public class DomesticHelperPremiumResponse
        {
            public string NationalId { get; set; }
            public int MemberCode { get; set; }
            public decimal MemberPremium { get; set; }
            public int MemberInsuranceClassCode { get; set; }
            public int ErrorCode { get; set; }
            public string ErrorMessage { get; set; }
        }
        public class ErrorResponseModel
        {
            public string Type { get; set; }
            public string Title { get; set; }
            public int Status { get; set; }
            public string Detail { get; set; }
            public string Instance { get; set; }
            public string AdditionalProp1 { get; set; }
            public string AdditionalProp2 { get; set; }
            public string AdditionalProp3 { get; set; }
        }
        public class PaymentInfo
        {
            public DateTime Effected_date { get; set; }
            public decimal Premium { get; set; }
            public decimal NetPremium { get; set; }
            public string PaymentKey { get; set; }
            public decimal AdminFees { get; set; }
            public bool IsPaid { get; set; }
            public bool IsPolicyIssued { get; set; }
            public string status { get; set; }
            public int Quoteid { get; set; }

        }
        public class MemberDeclaration
        {
            public int MemberId { get; set; }
            public bool QuestionOne { get; set; }
            public bool QuestionTwo { get; set; }
            public bool QuestionThree { get; set; }
            public bool QuestionFour { get; set; }
            public bool QuestionFive { get; set; }
            public bool QuestionSix { get; set; }
            public bool QuestionSeven { get; set; }
            public bool QuestionEight { get; set; }
            public bool QuestionNine { get; set; }
            public int PolicyId { get; set; }
            public string MedicalReportPath { get; set; }
            public string Height { get; set; }
            public string Weight { get; set; }
        }
        public class Occupation
        {
            public string NAME_EN { get; set; }
            public string NAME_AR { get; set; }
            public string CODE { get; set; }
        }
        public class OccupationRequest
        {
            public string code { get; set; }
        }
        public class DomesticDashBaordInput
        {
            public DateTime FromDate { get; set; }
            public DateTime ToDate { get; set; }

            public string userId { get; set; }


        }
        public class DomesticDashBoardDetailsOutput
        {
            public int PENDINGPAYMENTCount { get; set; }
            public decimal? TotalPaymentPenidngPremium { get; set; }
            public int PENDINGAPPROVALCount { get; set; }
            public decimal? TotalPaymentAPPROVALPremium { get; set; }
            public int ISSUEDPOLICIESCount { get; set; }
            public decimal? TotalPaymentIssuedPremium { get; set; }
        }
        public class DomesitcPolicyDetail
        {
            public int QUOTENO { get; set; }
            public string POLICYNUMBER { get; set; }
            public string PROD_NAME { get; set; }
            public decimal PREMIUM { get; set; }
            public decimal NetPremium { get; set; }
            public string PAYMENTKEY { get; set; }
            public string CustomerName { get; set; }
            public string Email { get; set; }
            public string Mobileno { get; set; }
            public bool IsPaid { get; set; }
            public string Status { get; set; }
            public string IBAN { get; set; }
            public string IDNumber { get; set; }
            public string FirstNameAR { get; set; }
            public string EskaPolicyID { get; set; }
            public string VATNo { get; set; }
            public decimal VATAmount { get; set; }
            public DateTime? CreatedOn { get; set; }
            public DateTime PolicyStartDate { get; set; }
        }
        public class DomesitcQuotationDetail
        {
            public int QUOTEID { get; set; }
            public string QUOTENO { get; set; }
            public string POLICYNUMBER { get; set; }
            public string PROD_NAME { get; set; }
            public decimal PREMIUM { get; set; }
            public decimal AdminFees { get; set; }
            public decimal NetPremium { get; set; }
            public string PAYMENTKEY { get; set; }
            public string CustomerName { get; set; }
            public string Email { get; set; }
            public string Mobileno { get; set; }
            public bool IsPaid { get; set; }
            public string Status { get; set; }
            public string IBAN { get; set; }
            public string IDNumber { get; set; }
            public string FirstNameAR { get; set; }
            public string EskaPolicyID { get; set; }
            public string VATNo { get; set; }
            public string SignatureID { get; set; }
            public DateTime? CreatedOn { get; set; }
            public DateTime PolicyStartDate { get; set; }
            public DateTime DateofBirth { get; set; }
            public List<DomesticHelperDetail> domesticHelperDetails { get; set; }
        }
        public class DomesticReportInput
        {
            public string FromDate { get; set; }
            public string Todate { get; set; }
            public int UserId { get; set; }
        }
        public class DomesitcPolicyListinhgData
        {
            public int ID { get; set; }
            public string QUOTENO { get; set; }
            public string POLICYNUMBER { get; set; }
            public decimal PREMIUM { get; set; }
            public decimal TotalPREMIUM { get; set; }
            public decimal AdminFees { get; set; }
            public decimal Vat { get; set; }
            public string PAYMENTKEY { get; set; }
            public string CustomerName { get; set; }
            public string NationalId { get; set; }
            public string Email { get; set; }
            public string EskaPolicyID { get; set; }
            public string Mobileno { get; set; }
            public bool IsPaid { get; set; }
            public string Status { get; set; }
            public string CreatedBy { get; set; }
            public DateTime? CreatedOn { get; set; }
            public DateTime PolicyStartDate { get; set; }
        }
        public class ProdSelectionDomestic
        {
            public string quoteNo { get; set; }

        }

        public class PolicyData
        {
            public int ReferenceId { get; set; }
            public int PolicyId { get; set; }
            public string PolicyHolderId { get; set; }
            public string PolicyHolderNameAr { get; set; }
            public string PolicyHolderNameEn { get; set; }
            public string PolicyHolderMobileNumber { get; set; }
            public DateTime PolicyEffectiveDate { get; set; }
            public List<MemberSaveData> MemberSaveDatas { get; set; }
        }

        public class MemberSaveData
        {
            public string NationalId { get; set; }
            public int RelationTypeId { get; set; }
            public string SponsorCRNo { get; set; }
            public string MemberName { get; set; }
            public string NationalityCode { get; set; }
            public DateTime DateOfBirth { get; set; }
            public int MaritalStatus { get; set; }
            public int Occupation { get; set; }
            public string OccupationDesc { get; set; }
            public int GenderCode { get; set; }
            public DateTime IdentityExpiry { get; set; }
            public int MemberInsuranceClass { get; set; }
            public bool IsDeclaration { get; set; }
            public decimal AdditionalPremium { get; set; }
            public MemberDeclarations MemberDeclarations { get; set; }
        }

        public class MemberDeclarations
        {
            public decimal Height { get; set; }
            public decimal Weight { get; set; }
            public bool PregnantStatus { get; set; }
            public string PregnancyDesc { get; set; }
            public DateTime ExpectedDeliveryDate { get; set; }
            public List<DeclarationQuestion> DeclarationQuestions { get; set; }
        }

        public class DeclarationQuestion
        {
            public int QuestionID { get; set; }
            public bool QuestionAnswer { get; set; }
        }
        public class PolicyAdditionalData
        {
            public int Id { get; set; }
            public int PolicyInfoId { get; set; }
            public long NationalId { get; set; }
            public bool Question1 { get; set; }
            public bool Question2 { get; set; }
            public bool Question3 { get; set; }
            public bool Question4 { get; set; }
            public bool Question5 { get; set; }
            public bool PregnantStatus { get; set; }
            public string PregnancyDesc { get; set; }
            public DateTime ExpectedDeliveryDate { get; set; }
            public decimal Height { get; set; }
            public decimal Weight { get; set; }
            public DateTime CreatedDate { get; set; }
        }

        public class DomesticPolicyHeader
        {
            public int PolicyId { get; set; }
            public int ReferenceId { get; set; }
            public int ChannelID { get; set; }
            public DateTime PolicyEffectiveDate { get; set; }
            public string AgentCode { get; set; }
            public string PolicyHolderNameAr { get; set; }
            public string PolicyHolderNameEn { get; set; }
            public string PolicyHolderNationality { get; set; }
            public string PolicyHolderMobileNumber { get; set; }
            public string PolicyHolderEmail { get; set; }
            public string PolicyHolderId { get; set; }
            public string CreatedBy { get; set; }
            public int EntityType { get; set; }
            public int EntityBusinessType { get; set; }
            public int EntityClassification { get; set; }
            public int EntityRevenue { get; set; }
            public string EntityCRIssueDate { get; set; }
            public string EntityCRExpiryDate { get; set; }
            public string EntityCRCity { get; set; }
            public decimal Discount { get; set; }
            public string Source { get; set; }
            public List<ISICActivity> ISICActivities { get; set; }
            public DAddressDetails AddressDetails { get; set; }
            public List<MemberSaveData> MemberSaveDatas { get; set; }
        }
        public class ISICActivity
        {
            public int IsicCode { get; set; }
            public string IsicName { get; set; }
            public string IsicNameEN { get; set; }
        }
        public class DAddressDetails
        {
            public string BuildingNumber { get; set; }
            public string Street { get; set; }
            public string City { get; set; }
            public string PostCode { get; set; }
            public string AdditionalNumber { get; set; }
        }
        public class PolicyHeaderDetails
        {
            public string PolicyHolderNameAr { get; set; }
            public string PolicyHolderNameEn { get; set; }
            public string MobileNo { get; set; }
            public string EmailId { get; set; }
            public string CreatedBy { get; set; }
            public string BuildingNumber { get; set; }
            public string AdditionalNumber { get; set; }
            public string PostCode { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
            public DateTime Effected_date { get; set; }
            public int EskaId { get; set; }
        }
        public class PolicyHeaderMemberDetails
        {
            public string FullName { get; set; }
            public string ID_Number { get; set; }
            public string Country { get; set; }
            public DateTime DateOfBirth { get; set; }
            public DateTime IdentityExpiryDate { get; set; }
            public string Occupation { get; set; }
            public string Gender { get; set; }
            public string MaritalStatus { get; set; }
            public decimal AdditionalPremium { get; set; }
            public int MemberInsuranceClass { get; set; }
            public bool IsHealthDeclaration { get; set; }
            public MemberDeclaration memberDeclaration { get; set; }
        }
        public class QuotationDeleteReq
        {
            public int quoteId { get; set; }
            public int Userid { get; set; }
        }
        public class HeaderRequest
        {
            public int quoteId { get; set; }
            public string Idnumber { get; set; }
        }

        public class StatusCT
        {
            public int StatusCode { get; set; }
            public string Reason { get; set; }
            public DateTime ReasonDate { get; set; }
        }

        public class PolicyInfo
        {
            public int PolicyId { get; set; }
            public int ReferenceId { get; set; }
            public int ENDT_NO { get; set; }
            public string SEGMENT_CODE { get; set; }
            public DateTime IssueDate { get; set; }
            public DateTime EffectiveDate { get; set; }
            public DateTime ExpiryDate { get; set; }
            public string CCHIPolicyNo { get; set; }
            public int PlanId { get; set; }
            public decimal PolicyTotalPremium { get; set; }
            public decimal PolicyGrossPremium { get; set; }
            public decimal PolicyVatPremium { get; set; }
            public decimal PolicyAgtPremium { get; set; }
        }

        public class MemberInfo
        {
            public string NationalId { get; set; }
            public Int64 MemberCode { get; set; }
            public decimal MemberPremium { get; set; }
            public int MemberInsuranceClassCode { get; set; }
            public int ErrorCode { get; set; }
            public string ErrorMessage { get; set; }
        }

        public class PolicyHeaderResponse
        {
            public StatusCT StatusCT { get; set; }
            public PolicyInfo PolicyInfo { get; set; }
            public List<MemberInfo> MemberInfo { get; set; }
        }
        public class CustomerData
        {
            public long CustomerId { get; set; }
            public string segment_code { get; set; }
        }
        public class EskaPolicyResponse
        {
            public string Error { get; set; }
            public PolicyVatDetail policyVatDetail { get; set; }
        }
        public class PolicyVatDetail
        {
            public string Vatno { get; set; }
            public string Ibanno { get; set; }
            public string SegmentCode { get; set; }
            public int Policyno { get; set; }
            public string EskaPolicyID { get; set; }
            public string BankNameEn { get; set; }
            public string BankNameAr { get; set; }

        }
        public class GenerateTokenResponse
        {
            public bool status { get; set; }
            public string token { get; set; }
            public string errorMessage { get; set; }
        }
        public class PolicyPaymentInputSME
        {
            public string Key { get; set; }
            public string paymentBody { get; set; }
            public string vatNumber { get; set; }
            public string paymentMethod { get; set; }

        }
        public class PolicyBankPaymentInput
        {
            public string Key { get; set; }
            public string ReferenceNo { get; set; }
        }
        public class FinalSaveRequest
        {
            public int policyId { get; set; }
            public string policySegment { get; set; }
            public string referenceId { get; set; }
            public string paymentMethod { get; set; }
            public string paymentBody { get; set; }
            public string vatNumber { get; set; }
            public int idType { get; set; } = 1;
            public string source { get; set; } = "PartnerPortal";
        }
        public class FinalSaveResponse
        {
            public bool status { get; set; }
            public string errorMessage { get; set; }
        }
        public class UnderwriterPolicyDecision
        {
            public string decision { get; set; }
            public string rejectionDecision { get; set; }
            public string comment { get; set; }
            public int quoteno { get; set; }
            public int ApprovedByID { get; set; }
        }
        public class PolicyUploadDocument
        {
            public string Attachment { get; set; }
            public int quoteno { get; set; }
        }
        public class SignitUploadResquest
        {
            public string document { get; set; }
            public int policyId { get; set; }
            public string full_name { get; set; }
            public string email { get; set; }
            public string mobileno { get; set; }
            public string IDNUMBER { get; set; }
            public string ProductType { get; set; }
            public string PolicyIdNumber { get; set; }
        }
        public class SignitAPIResponse
        {
            public bool IsSuccess { get; set; }
            public object Data { get; set; }
            public string Message { get; set; }
        }
        public class PaymentBankBody
        {
            public string amount { get; set; }
            public string order_description { get; set; }
            public string merchant_reference { get; set; }
            public string token_name { get; set; }
        }

    }
}
