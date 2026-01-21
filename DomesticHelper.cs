using Newtonsoft.Json;
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
            public string BankNameEn { set; get; }
            public string BankNameAr { set; get; }
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
        public class PayfortPaymentStatusResponse
        {
            public string transactionStatus { get; set; }
            public string transaction_code { get; set; }
            public string transaction_status { get; set; }
            public string response_code { get; set; }
            public string signature { get; set; }
            public string transaction_message { get; set; }
            public string language { get; set; }
            public string fort_id { get; set; }
            public string refunded_amount { get; set; }
            public string response_message { get; set; }
            public string merchant_reference { get; set; }
            public string query_command { get; set; }
            public string captured_amount { get; set; }
            public string authorized_amount { get; set; }
            public string status { get; set; }
        }
        #region pentaapi
        public class PentaCreateQuotationReq
        {
            public string quotationNo { get; set; }
            public string proposalNo { get; set; }
            public string planCode { get; set; }
            public string policyBranch { get; set; }
            public string proposerType { get; set; }
            public string proposerRelation { get; set; }
            public string companyCode { get; set; }
            public string branchCode { get; set; }
            public string proposerIdenType { get; set; }
            public string proposerIdenNo { get; set; }
            public string crRegNumber { get; set; }
            public string crRegType { get; set; }
            public string businessType { get; set; }
            public string businessTypeDesc { get; set; }
            public string activityId { get; set; }
            public string activityDescEN { get; set; }
            public string activityDescAR { get; set; }
            public string proposerName { get; set; }
            public string proposerFirstName { get; set; }
            public string proposerMiddleName { get; set; }
            public string proposerLastName { get; set; }
            public string proposerFourthName { get; set; }
            public string proposerDob { get; set; }
            public string proposerGender { get; set; }
            public string proposerMaritalStatus { get; set; }
            public string proposerOccupation { get; set; }
            public string proposerNationality { get; set; }
            public string idIssueDate { get; set; }
            public string idExpiryDate { get; set; }
            public string currency { get; set; }
            public int policyTerm { get; set; }
            public int premPayTerm { get; set; }
            public string paymentFrequency { get; set; }
            public object sumAssured { get; set; }
            public string commencementDateOption { get; set; }
            public string policyEffectiveDate { get; set; }
            public string policyExpiryDate { get; set; }
            public string backDatedFlag { get; set; }
            public string backDatedReason { get; set; }
            public string premPattern { get; set; }
            public int escalatingPercentage { get; set; }
            public string scPattern { get; set; }
            public int indexRate { get; set; }
            public string staffContract { get; set; }
            public string staffGroup { get; set; }
            public string staffCompany { get; set; }
            public string staffBranch { get; set; }
            public string employeeId { get; set; }
            public string department { get; set; }
            public string miIndicator { get; set; }
            public string payerType { get; set; }
            public string payerRelation { get; set; }
            public string payerIdenType { get; set; }
            public string payerIdenNo { get; set; }
            public string payingInst { get; set; }
            public string payingInstBranch { get; set; }
            public string excessPaymentOption { get; set; }
            public string paymentMethod { get; set; }
            public string survivalPayType { get; set; }
            public int loanInterestRate { get; set; }
            public int growthRate { get; set; }
            public string nationalityGroup { get; set; }
            public string zoneCode { get; set; }
            public string cashBeforeCover { get; set; }
            public string individualFloat { get; set; }
            public string familySize { get; set; }
            public string tpaCompanyCode { get; set; }
            public string tpaCompanyBranch { get; set; }
            public string userId { get; set; }
            public string sourceType { get; set; }
            public string sourceOfBusiness { get; set; }
            public object deductionDetail { get; set; }
            public List<ProposerAddressDetail> proposerAddressDetails { get; set; }
            public List<MemberDetail> memberDetails { get; set; }
            public documentDetails[] documentDetails { get; set; }
            public List<AgentDetail> agentDetails { get; set; }
        }

        public class ProposerAddressDetail
        {
            public string addressType { get; set; }
            public int additionalNo { get; set; }
            public int buildingNo { get; set; }
            public string street { get; set; }
            public string postCode { get; set; }
            public string city { get; set; }
            public string district { get; set; }
            public string isPrimaryAddress { get; set; }
        }

        public class MemberDetail
        {
            public string memberName { get; set; }
            public string memberFirstName { get; set; }
            public string memberMiddleName { get; set; }
            public string memberLastName { get; set; }
            public string memberFourthName { get; set; }
            public string memberGender { get; set; }
            public string memberDOB { get; set; }
            public string memberRel { get; set; }
            public string memberIdenType { get; set; }
            public string memberIdenNo { get; set; }
            public string memberIdIssueDate { get; set; }
            public string memberIdExpiryDate { get; set; }
            public string effectiveDate { get; set; }
            public string expiryDate { get; set; }
            public string maritalStatus { get; set; }
            public string occupation { get; set; }
            public string nationality { get; set; }
            public int subPlanCode { get; set; }
            public string memberEffectiveDate { get; set; }
            public string memberExpiryDate { get; set; }
            public string city { get; set; }
            public string sponsorNumber { get; set; }
            public string consumeAlcohol { get; set; }
            public int alcoholPerDay { get; set; }
            public string pregnantFlag { get; set; }
            public int pregnancyMonths { get; set; }
            public string smokerFlag { get; set; }
            public int noOfSticksPerDay { get; set; }
            public string loadingType { get; set; }
            public int loadingAmount { get; set; }
            public string discountType { get; set; }
            public int discountAmount { get; set; }
            public List<MemberAddressDetail> memberAddressDetails { get; set; }
            public uwQuestion[] uwQuestions { get; set; }
        }

        public class MemberAddressDetail
        {
            public string addressType { get; set; }
            public int additionalNo { get; set; }
            public int buildingNo { get; set; }
            public string street { get; set; }
            public string postCode { get; set; }
            public string city { get; set; }
            public string district { get; set; }
            public string isPrimaryAddress { get; set; }
        }

        public class AgentDetail
        {
            public int agentNumber { get; set; }
            public string rank { get; set; }
            public int agentSharePercent { get; set; }
            public string commissionType { get; set; }
            public string commissionPercent { get; set; }
        }

        public class PentaCreateQuotationRes
        {
            public bool status { get; set; }
            public ReturnValuedomestic returnValue { get; set; }
            public object returnValues { get; set; }
            public object errors { get; set; }
        }

        public class ReturnValuedomestic
        {
            public string quotationNo { get; set; }
            public string referenceQuotationNo { get; set; }
            public string policyStatus { get; set; }
            public string policyStatusDesc { get; set; }
            public string issueDate { get; set; }
            public string expiryDate { get; set; }
            public double grossPremium { get; set; }
            public double vatAmount { get; set; }
            public double netPremium { get; set; }
            public double totalBilledAmount { get; set; }
            public double commissionAmount { get; set; }
            public List<ChargesBreakdown> chargesBreakdown { get; set; }
            public List<MemberWiseDetail> memberWiseDetails { get; set; }
        }

        public class ChargesBreakdown
        {
            public string chargeCode { get; set; }
            public string chargeDesc { get; set; }
            public double amount { get; set; }
        }

        public class MemberWiseDetail
        {
            public string idenCode { get; set; }
            public string idenNo { get; set; }
            public string name { get; set; }
            public double memeberTotalPremium { get; set; }
            public List<object> uwRulesFailed { get; set; }
            public PremiumDetails premiumDetails { get; set; }
        }

        public class PremiumDetails
        {
            public double grossPremium { get; set; }
            public double discountAmount { get; set; }
            public double loadingAmount { get; set; }
            public double netPremium { get; set; }
            public double vat { get; set; }
            public double totalPremium { get; set; }
        }

        public class uwQuestion
        {

        }
        public class documentDetails
        {

        }
        #endregion
        public class PentaTokenRequest
        {
            public string username { get; set; }
            public string password { get; set; }
        }
        public class PentatokenResponse
        {
            public string status { get; set; }
            public string access_token { get; set; }
            public string refresh_token { get; set; }
            public string message { get; set; }
        }
        public class CreateProposalRequestdomestic
        {
            public string quotationNo { get; set; }
        }
        public class CreateProposalResp
        {
            public bool Status { get; set; }
            public ReturnValues ReturnValue { get; set; }
            public object ReturnValues { get; set; }
            public object Errors { get; set; }
        }
        public class ReturnValues
        {
            public string QuotationNo { get; set; }
            public string ReferenceQuotationNo { get; set; }
            public string PolicyNo { get; set; }
            public string PolicyStatus { get; set; }
            public string PolicyStatusDesc { get; set; }
            public DateTime IssueDate { get; set; }
            public DateTime ExpiryDate { get; set; }
            public decimal GrossPremium { get; set; }
            public decimal VatAmount { get; set; }
            public decimal NetPremium { get; set; }
            public decimal TotalBilledAmount { get; set; }
            public decimal CommissionAmount { get; set; }
            public List<object> ChargesBreakdown { get; set; }
            public List<MemberWiseDetails> MemberWiseDetails { get; set; }
        }
        public class MemberWiseDetails
        {
            public string IdenCode { get; set; }
            public string IdenNo { get; set; }
            public string Name { get; set; }
            public decimal MemeberTotalPremium { get; set; }
            public List<object> UwRulesFailed { get; set; }
            public PremiumDetail PremiumDetails { get; set; }
        }

        public class PremiumDetail
        {
            public decimal GrossPremium { get; set; }
            public decimal DiscountAmount { get; set; }
            public decimal LoadingAmount { get; set; }
            public decimal NetPremium { get; set; }
            public decimal Vat { get; set; }
            public decimal TotalPremium { get; set; }
        }
        public class IssuePolicyRequestdomestic
        {
            public string policyNo { get; set; }
            public ReceiptDetails receiptDetails { get; set; }
        }

        public class ReceiptDetails
        {
            public string proposalNo { get; set; }
            public string instrumentType { get; set; }
            public string instrumentBank { get; set; }
            public string instrumentBankBranch { get; set; }
            public string instrumentNo { get; set; }
            public string creditCardType { get; set; }
            public string creditCardNo { get; set; }
            public string creditCardValidFrom { get; set; }
            public string creditCardValidTo { get; set; }
            public string receiptCode { get; set; }
        }
        public class IssuePolicyResponsedomestic
        {
            public bool Status { get; set; }
            public ReceiptReturnValue ReturnValue { get; set; }
            public object ReturnValues { get; set; }
            public object Errors { get; set; }
        }

        public class ReceiptReturnValue
        {
            public string ReceiptNo { get; set; }
            public decimal ReceiptAmount { get; set; }
            public string PolicyStatus { get; set; }
            public string Description { get; set; }
        }
        public class LookupResponsedomestic
        {
            public string Status { get; set; }
            public string Message { get; set; }
            public int ErrorCode { get; set; }
            public string ErrorMessage { get; set; }
            public LookupReturnValue ReturnValue { get; set; }
            public object ReturnValues { get; set; }
        }

        public class LookupReturnValue
        {
            public int Offset { get; set; }
            public bool HasMore { get; set; }
            public int Limit { get; set; }
            public int Count { get; set; }
            public List<Link> Links { get; set; }
            public List<Itemdomestic> Items { get; set; }
        }

        public class Link
        {
            public string Rel { get; set; }
            public string Href { get; set; }
        }

        public class Itemdomestic
        {
            public List<LookupValue> Lookup_Values { get; set; }
        }

        public class LookupValue
        {
            public string V_Ins_Code { get; set; }
            public string V_Desc { get; set; }
        }
        public class LookupTabledomestic
        {
            public InputValuesdomestic inputValues { get; set; }
        }
        public class InputValuesdomestic
        {
            public string procedureName { get; set; }
            public string lookupCode { get; set; }
        }

        public class CalculateMembersReq
        {
            public List<MemberPremiumItem> memberPremium { get; set; }
        }
        public class MemberPremiumItem
        {
            public string memberIdenCode { get; set; }
            public string memberIdenNo { get; set; }
            public string planCode { get; set; }
            public string parentPlriCode { get; set; }
            public string eventCode { get; set; }
            public string companyCode { get; set; }
            public string gender { get; set; }
            public string occupClass { get; set; }
            public int age { get; set; }
            public int term { get; set; }
            public string effectiveDate { get; set; }
            public string paymentFrequency { get; set; }
            public string smoker { get; set; }
            public string alcohol { get; set; }
            public string pregnant { get; set; }
            public string sumAssured { get; set; }
            public string networkType { get; set; }
            public string subPlanCode { get; set; }
            public string maritalStatus { get; set; }
            public string nationality { get; set; }
            public string relation { get; set; }
        }

        public class PremiumResponse
        {
            public bool status { get; set; }
            public string returnValue { get; set; }
            public List<ReturnValueItem> returnValues { get; set; }
            public List<errors> errors { get; set; }
        }
        public class errors
        {
            public string Field { get; set; }
            public String Message { get; set; }
            public int Code { get; set; }
            public string Exception { get; set; }
        }
        public class ReturnValueItem
        {
            public string memberIdenCode { get; set; }
            public string memberIdenNo { get; set; }
            public double premiumRate { get; set; }
            [JsonProperty("base")]
            public double baseamount { get; set; }
            public double premiumBase { get; set; }
            public double premiumUSD { get; set; }
        }

        public class CalculatePremiumRequest
        {
            public int MemberquoteId { get; set; }
            public string MemberIdnumber { get; set; }
            public int ProposerquoteId { get; set; }
            public string ProposerIdnumber { get; set; }
            public string PolicyeffectiveDate { get; set; }
            public string NationalityCode { get; set; }
            public string DateOfBirth { get; set; }
            public string Gender { get; set; }
            public string Age { get; set; }
            public string MaritalStatus { get; set; }


        }
        public class PentaQuoteRequest
        {
            public string memberNationalId { get; set; }
            public string proposerNationalId { get; set; }
            public int quoteId { get; set; }
            public string NationalityCode { get; set; }
            public string MaritalStatus { get; set; }
        }
        public class UpdatePaymentInfo
        {
            public int quoteId { get; set; }
            public string status { get; set; }
        }

        public class GenerateReportResponse
        {
            public bool Status { get; set; }
            public string FileName { get; set; }
            public string FolderPath { get; set; }
            public string Message { get; set; }
        }
    }
}
