using Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Text.Json.Serialization;
using static Models.TravelQuote;

namespace Models
{
    public class Quote
    {
        public decimal QuoteNo { get; set; }
        public string ProdTyp { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string Status { get; set; }
        public string ReferralBy { get; set; }
        public ClientDetails ClientDetail { get; set; }
    }
    public class PersonalInfo
    {
        public decimal QuoteNo { get; set; }

        public decimal? CustomerID { get; set; }
        public Int64 PersonalInfoId { get; set; }

        public string IdType { get; set; }

        public string IdNumber { get; set; }

        public DateTime ExpiryDate { get; set; }

        public string SocialStatus { get; set; }

        public string FirstName { get; set; }

        public string FatherName { get; set; }

        public string GrandFatherName { get; set; }

        public string FamilyName { get; set; }

        public DateTime DateofBirth { get; set; }

        public string DateofBirthH { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public decimal Height { get; set; }

        public decimal Weight { get; set; }
        public string FullName { get; set; }

    }
    public class PersonalInfoUW
    {

        public string QuoteNo { get; set; }

        public Int64 PersonalInfoId { get; set; }

        public string IdType { get; set; }

        public string IdNumber { get; set; }

        public DateTime ExpiryDate { get; set; }

        public string SocialStatus { get; set; }

        public string FirstName { get; set; }

        public string FatherName { get; set; }

        public string GrandFatherName { get; set; }

        public string FamilyName { get; set; }

        public string DateofBirth { get; set; }

        public string DateofBirthH { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string Height { get; set; }

        public string Weight { get; set; }
        public string FullName { get; set; }
        public string ProductName { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public string CountryofBirth { get; set; }
        public string Nationality { get; set; }

        public string ApplicantID { get; set; }
        public string BenificariesID { get; set; }

        public string POLICYNUMBER { get; set; } //Added by Shyam Patil 29Nov2025
        public string IllustrationFilename { get; set; } //Added by Shyam Patil 29Nov2025
        public string PurposalFilename { get; set; } //Added by Shyam Patil 29Nov2025
        public string PaymentKey { get; set; } //Added by Shyam Patil 29Nov2025

    }
    public class ContactDetails
    {
        public decimal QuoteNo { get; set; }
        public decimal? CustomerID { get; set; }
        public decimal ContactId { get; set; }
        public string CountryofBirth { get; set; }
        public string Nationality { get; set; }
        public string City { get; set; }
        public string homePhone { get; set; }
        public string workPhone { get; set; }
        public string mobileNumber { get; set; }
        public string emailID { get; set; }
        public string otherNationality { get; set; }
        public bool? hasAnotherNatinality { get; set; }
        public string GreenCard { get; set; }
        public string SocialInsuranceNo { get; set; }

    }
    public class FinancialInfo
    {
        public decimal? QuoteNo { get; set; }

        public decimal? CustomerID { get; set; }

        public decimal FinancialID { get; set; }

        public string Job { get; set; }

        public bool? doesAnyFollowingApply { get; set; }

        public string City { get; set; }

        public double? annualIncome { get; set; }

        public double? annualExpense { get; set; }

        public string bankName { get; set; }

        public string BANNumber { get; set; }

        public string bankcode { get; set; }

        public string branchName { get; set; }

        public bool? haveAddtofIncome { get; set; }

        public decimal? TotalAnnualAdditionalIncome { get; set; }

    }
    public class ProductDetails
    {
        public decimal QuoteNo { get; set; }
        public string ProductDetID { get; set; }
        public int? selectTerm { get; set; }
        public decimal? Premium { get; set; }
        public string Frequency { get; set; }
        public decimal? sumCovered { get; set; }
        public decimal? individualTobeCovered { get; set; }
        public bool? Relation { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime DateofBirth { get; set; }
        public Int64 ProductDetailsId { get; set; }

    }
    public class BeneficiaryDetails
    {
        public decimal QuoteNo { get; set; }
        public decimal BeneficiaryID { get; set; }
        public string chooseBeneficiary { get; set; }
        public string beneficiaryFullName { get; set; }
        public DateTime? DateofBirth { get; set; }
        public decimal? PerofBeneficiary { get; set; }
        public string beneficiaryGender { get; set; }
        public string relationProposal { get; set; }
        public string IDNumber { get; set; }

    }

    public class UWPNSDetials
    {
        public PersonalInfoUW PersonalInfo { get; set; }
        public ContactDetails ContactDetails { get; set; }
        public FinancialInfo FinancialInfo { get; set; }
        public ProductDetails ProductDetails { get; set; }
        public List<BeneficiaryDetails> BeneficiaryDetails { get; set; }
        public UWNationalAddress NationalAddress { get; set; }
        public HealthDecalration healthDecalration { get; set; }
        public AdditionalPlanInfo additionalPlanInfo { get; set; }
    }
    public class UWNationalAddress
    {
        public string BuildingNo { get; set; }
        public string AdditionalNo { get; set; }
        public string UnitNo { get; set; }
        public string StreetName { get; set; }
        public string District { get; set; }
        public string city { get; set; }
        public string Postalcode { get; set; }
        public string country { get; set; }
    }
    public class Language
    {
        public string lang { get; set; }
    }
    public class ProdSelection
    {
        public string prod { get; set; }
        public string lang { get; set; }
        public int UserId { get; set; }
    }
    public class PolicyListInput
    {
        public string lang { get; set; }
        public string UserId { get; set; }
    }
    public class ListItems
    {
        public string Text { get; set; }
        public string Value { get; set; }
    }
    public class BeneficiaryList
    {
        public string Name { get; set; }
        public string IDNumber { get; set; }
        public string DOB { get; set; }
        public string PrecOfBen { get; set; }
        public string GenderText { get; set; }
        public string GenderValue { get; set; }
        public string RelationText { get; set; }
        public string RelationValue { get; set; }
    }
    public class HealthDecalration
    {
        public decimal? QuoteNo { get; set; }
        public decimal? CustomerID { get; set; }
        public long HealthDeclarationId { get; set; }
        public bool? HD1 { get; set; }
        public bool? HD2 { get; set; }
        public bool? HD3 { get; set; }
        public bool? HD4 { get; set; }
        public bool? HD5 { get; set; }
        public bool? HD6 { get; set; }
        public bool? HD7 { get; set; }
        public bool? HD8 { get; set; }
        public bool? HD9 { get; set; }
        public bool? HD10 { get; set; }
        public bool? HD11 { get; set; }
        public string HD1DR { get; set; }
        public string HD1Hospital { get; set; }
        public string HD2DR { get; set; }
        public string HD2Hospital { get; set; }
        public string HD3DR { get; set; }
        public string HD3Hospital { get; set; }
        public string HD4DR { get; set; }
        public string HD4Hospital { get; set; }
        public string HD5DR { get; set; }
        public string HD5Hospital { get; set; }
        public string HD6DR { get; set; }
        public string HD6Hospital { get; set; }
        public int HD11Month { get; set; }

    }
    public class AdditionalPlanInfo
    {
        public decimal? QuoteNo { get; set; }
        public Int64 AdditionalPlanInfoId { get; set; }
        public bool? IsAdditionalAmt { get; set; }
        public int? TimesPerYear { get; set; }
        public decimal? TxtAmntPerYear { get; set; }
        public bool? IsIncreaseContributionAmt { get; set; }
        public int? TxtTimesPerYearCntr { get; set; }
        public decimal? TxtAmtPerYearCntr { get; set; }
        public bool? IsaPartialWithdrawal { get; set; }
        public int? TxtWithDrawlTimeYear { get; set; }
        public decimal? TxtWithDrawlAmtYear { get; set; }
        public string PurposeOfSubscription { get; set; }
        public bool? IsOtherInsurance { get; set; }
        public int? ConservativeFundPer { get; set; }
        public int? BalancedFundPer { get; set; }
        public int? AggressiveFundPer { get; set; }
        public int? EquitiesFundPer { get; set; }
        public int? EuropeanEquitiesFundPer { get; set; }
        public int? JapaneseEquitiesFundPer { get; set; }
        public int? SaudiEquitiesFundPer { get; set; }
        public int? SaudiRiyalMurabahaFundPer { get; set; }
        public List<OtherInsurance> otherInsurance { get; set; }
    }

    public class OtherInsurance
    {
        public decimal? QuoteNo { get; set; }
        public Int64 AdditionalPlanInfoId { get; set; }
        public Int64 OthInsuranceId { get; set; }
        public string CompanyName { get; set; }
        public decimal? SumAssured { get; set; }

    }
    public class UploadedRequiredDoc
    {
        public decimal? QuoteNo { get; set; }
        public Int64 UploadId { get; set; }
        public string ApplicantID { get; set; }
        public string BenificariesID { get; set; }
        public string ApplicantCovered { get; set; }

    }
    public class CreatePurposal
    {
        public decimal? QuoteNo { get; set; }
        public Int64 PurposalID { get; set; }
        public string Policynumber { get; set; }
        public decimal Premium { get; set; }
        public int VAT { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string IBAN { get; set; }
        public string VATNo { get; set; }
        public string PaymentKey { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool? IsPolicyIssued { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
    public class PayFortPayment
    {
        public string payurl { get; set; }
        public string signature { get; set; }
        public string service_command { get; set; }
        public string access_code { get; set; }
        public string merchant_identifier { get; set; }
        public string merchant_reference { get; set; }
        public string language { get; set; } = "en";
        public string return_url { get; set; }
        public string card_number { get; set; }
        public string card_holder_name { get; set; }
        public string expiry_date { get; set; }
        public string card_security_code { get; set; }
    }

    public class PayfortSugnature
    {
        public string api_url { get; set; }

        public string merchant_reference { get; set; }

        public string signature { get; set; }

        public string return_url { get; set; }

        public string access_code { get; set; }

        public string language { get; set; }

        public string command_service { get; set; }

        public string merchant_identifier { get; set; }

        public string service_command { get; set; }
    }
    public class Document : Results
    {
        public List<Production> Headers { get; set; }

        public Document()
        {
            Headers = new List<Production>();
        }
    }
    public class Production
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreationDate { get; set; }

        public int DocumentType { get; set; }

        public int EndtSerial { get; set; }

        public int UWYear { get; set; }

        public string SeqmentCode { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime EffectiveDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        public string InsuredName { get; set; }

        public int AccountedFor { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal TotalFees { get; set; }

        public decimal CommissionAmount { get; set; }

        public decimal VAT { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? LoadingAmount { get; set; }

        public decimal NetPremium { get; set; }

        public long? PolicyId { get; set; }

        public int? QuotationId { get; set; }

        public int? CustomerId { get; set; }

        public int PaymentMethod { get; set; }

        public int OfficeId { get; set; }

        public int? Validity { get; set; }

        public bool IsPaid { get; set; }

        public int ChartOfAccount { get; set; }

        public int? PlanId { get; set; }

        public string CCHIPolicyNo { get; set; }

        public int? Status { get; set; }

        public int? OrginalPolicy { get; set; }

        public string UniqueGuid { get; set; }

        public int? PushToEska { get; set; }

        public decimal? TpaShare { get; set; }

        public int? TPAId { get; set; }

        public long? EskaId { get; set; }

        public int? PushToYakeen { get; set; }

        public string EskaSegment { get; set; }

        public int? EndosmentType { get; set; }

        public int? CancellationReason { get; set; }
    }
    public class PaymentLog
    {
        public Int64 Id { get; set; }

        public DateTime TransactionDate { get; set; }

        public bool Status { get; set; }

        public Int64 PolicyId { get; set; }

        public string CustomerEmail { get; set; }

        public int TransactionType { get; set; }

        public string MerchantReference { get; set; }

        public string PayfortId { get; set; }

        public string PayfortStatus { get; set; }

        public string CardDetails { get; set; }

        public string CardType { get; set; }

        public string BankAttachment { get; set; }
        public decimal Amount { get; set; }

    }
    [Serializable]
    public class Results
    {
        public bool status { get; set; }

        public string message { get; set; }

        public DateTime ResponseDate { get; set; }

        public HttpStatusCode httpStatusCode { get; set; }
    }
    public class PolicyPaymentInput
    {
        public string Key { get; set; }
    }

    public class PolicyDocuementOutput
    {
        public string GeneratedReportPath { get; set; }
        public string Reason { get; set; }
        public string ReportCode { get; set; }
        public string ReportName { get; set; }
        public bool status { get; set; }
    }

    public class Illustration
    {
        public Int64 QuoteNo { set; get; }
        public Int64 IllustrationId { set; get; }
        public int Year { set; get; }
        public string Contribution { set; get; }
        public string SumCovered { set; get; }
        public string InvestmentFund3 { set; get; }
        public string SurrenderValue3 { set; get; }
        public string DeathBenefits3 { set; get; }
        public string InvestmentFund5 { set; get; }
        public string SurrenderValue5 { set; get; }
        public string DeathBenefits5 { set; get; }
        public string InvestmentFund7 { set; get; }
        public string SurrenderValue7 { set; get; }
        public string DeathBenefits7 { set; get; }
        public string InvestmentFund3_1 { set; get; }
        public string InvestmentFund5_1 { set; get; }
        public string InvestmentFund7_1 { set; get; }
        public decimal RiskPartcipation { set; get; }
        public decimal subfee { get; set; }
        public decimal Distinvestmentamount { get; set; }
        public decimal dedcontractfee { get; set; }
        public decimal Riskmangsubs { get; set; }
    }
    public class IllustrationQuote
    {
        public int QuoteNo { set; get; }
        public string Prod_Name { set; get; }
        public DateTime? CreatedOn { set; get; }
        public string CustomerName { set; get; }
        public string IdNumber { set; get; }
        public decimal? Premium { set; get; }
        public string CreatedBy { set; get; }
        public string Status { set; get; }
        public string Policynumber { set; get; }
        public bool? IsPaid { set; get; }
        public bool? IsPolicyIssued { set; get; }
        public string PurposalFilename { set; get; }
        public string IllustrationFilename { set; get; }
        public string PaymentKey { set; get; }
        public string CreatedByName { set; get; }
        public string Channel { set; get; }
    }
    public class policy
    {
        public string QuoteNo { set; get; }
        public string Prod_Name { set; get; }
        public DateTime? CreatedOn { set; get; }
        public string CustomerName { set; get; }
        public string IdNumber { set; get; }
        public decimal? Premium { set; get; }
        public string CreatedBy { set; get; }
        public string CreatedByName { set; get; }
        public string Status { set; get; }
        public string IsPaid { set; get; }
        public string IsPolicyIssued { set; get; }
        public string Policynumber { set; get; }
        public string GUUID { set; get; }
        public string PaymentKey { set; get; }
        public string PurposalFilename { set; get; }
        public string IllustrationFilename { set; get; }
        public string Channel { set; get; }
    }
    public class PentaPolicy
    {
        public int Id { set; get; }
        public string PolicyNo { set; get; }
        public string StatusCode { set; get; }
        public DateTime StatusDate { set; get; }
        public DateTime CreationDate { set; get; }
    }
    public class AllStepId
    {
        public string QuoteNo { set; get; }
        public string CustomerID { set; get; }
        public string PersonalInfoId { set; get; }
        public string ContactId { set; get; }
        public string FinancialID { set; get; }
        public string ProductDetailsId { set; get; }
        public string HealthDeclarationId { set; get; }
        public string ProdTyp { set; get; }

    }
    public class PolicyDetail
    {
        public string QUOTENO { set; get; }
        public string POLICYNUMBER { set; get; }
        public string PROD_NAME { set; get; }
        public string PRODCODE { set; get; }
        public string FULLNAME { set; get; }
        public string PREMIUM { set; get; }
        public string VAT { set; get; }
        public string TOTALPREMIUM { set; get; }
        public string LANG { set; get; }
        public string PAYMENTKEY { set; get; }
        public string SELECTTERM { set; get; }
        public string IBAN { set; get; }
        public decimal sumCovered { set; get; }
        public int Frequency { set; get; }
        public string CustomerName { get; set; }
        public bool IsPaid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string PurposalFilename { get; set; }
    }
    public class TravelPolicyDetail
    {
        public string QUOTENO { set; get; }
        public string FULLNAMEOFPASSPORT { set; get; }
        public string COVERAGETYPE { set; get; }
        public string TRAVALSTARTDATE { set; get; }
        public string TRAVALENDATE { set; get; }
        public string PERIODOFTRAVAL { set; get; }
        public string PRODUCTNAME { set; get; }
        public string TOTALPREMIUMWITHOUTVAT { set; get; }
        public string VAT { set; get; }
        public decimal TOTALPREMIUMWITHVAT { set; get; }
        public string ISSUEDATE { set; get; }
        public string LANG { set; get; }
        public string PAYMENTKEY { set; get; }
        public string IBAN { set; get; }
        public bool IsPaid { set; get; }
        public string PolicyNumber { set; get; }
        public string coreplcid { set; get; }
        public string NationalId { set; get; }
        public string EmailID { set; get; }
        public string MobileNo { set; get; }
        public string BankNameEn { set; get; }
        public string BankNameAr { set; get; }
    }
    public class POLICYDETAIL
    {
        public Int64 QuoteNo { get; set; }

        public decimal id { get; set; }

        public string Policynumber { get; set; }

        public decimal? Premium { get; set; }

        public int? VAT { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public string IBAN { get; set; }

        public string VATNo { get; set; }

        public string PaymentKey { get; set; }

        public DateTime? IssueDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public bool IsPaid { get; set; }

        public bool IsPolicyIssued { get; set; }

        public long? CorePlcId { get; set; }

        public long? FcsCstId { get; set; }
        public string FullNameofPassport { get; set; }
        public string CoverageType { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public decimal? PolicyPremium { get; set; }
        public string NationalId { get; set; }
        public string coreplcid { set; get; }
    }
    public class ApplicationInfo
    {
        public ApplicationInfo() { }
        public string FirstName { get; set; }
        public string FathersName { get; set; }
        public string FamilyName { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }
        public string MartialStatus { get; set; }
        public string Nationality { get; set; }
        public string PlaceofBirth { get; set; }
        public string IDNumber { get; set; }
        public string IdentityType { get; set; }
        public string IdentityExpirationDate { get; set; }
        public string Occupation { get; set; }
        public decimal AnnualIncome { get; set; }
        public string FullName { get; set; }
        public string DoesanyOftheFollowingApply_ { get; set; }
        public string IllustrationNumber { get; set; }
        public string Product { get; set; }

    }
    public class InsuredInfo
    {
        public InsuredInfo() { }
        public string FirstName { get; set; }
        public string FathersName { get; set; }
        public string FamilyName { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }
        public string MartialStatus { get; set; }
        public string Nationality { get; set; }
        public string PlaceofBirth { get; set; }
        public string IDNumber { get; set; }
        public string IdentityType { get; set; }
        public string IdentityExpirationDate { get; set; }
        public string Occupation { get; set; }
        public int Age { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }

    }
    public class CONTACTDETAILS
    {
        public CONTACTDETAILS() { }
        public string BuildingNumber { get; set; }
        public string AdditionalNumber { get; set; }
        public string UnitNumber { get; set; }
        public string StreetName { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string MobileNumber { get; set; }
        public string EmailID { get; set; }
    }
    public class RDLCPOLICYDETAIL
    {
        public RDLCPOLICYDETAIL() { }
        public decimal SubscriptionAmount { get; set; }
        public decimal AnnualSubscriptionAmount { get; set; }
        public string Frequency { get; set; }
        public string PolicyTerm { get; set; }
        public string SumInsured { get; set; }
    }
    public class BENEFICIARYDETAILS
    {
        public BENEFICIARYDETAILS() { }
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public string DateofBirth { get; set; }
        public decimal BeneficiaryPercentage { get; set; }
        public string Gender { get; set; }
        public string Relation { get; set; }
    }
    public class FUNDDETAILS
    {
        public FUNDDETAILS() { }
        public int ALJAZIRAdiversifiedconservativefund { get; set; }
        public int ALJAZIRAdiversifiedbalancedfund { get; set; }
        public int ALJAZIRAdiversifiedaggressivefund { get; set; }
        public int AlJaziraInternationalEquitiesFund { get; set; }
        public int AlJaziraEuropeanEquitiesFund { get; set; }
        public int AlJaziraJapaneseEquitiesFund { get; set; }
        public int AlJaziraSaudiEquitiesFund { get; set; }
        public int AlJaziraSaudiRiyalMurabahaFund { get; set; }

    }
    public class RDLCYNQUESTION
    {
        public RDLCYNQUESTION() { }
        public string Q1 { set; get; }
        public string Q2 { set; get; }
        public string Q3 { set; get; }
        public string Q4 { set; get; }
        public string Q5 { set; get; }
        public string Q6 { set; get; }
        public string Q7 { set; get; }
        public string Q8 { set; get; }
        public string Q9 { set; get; }
        public string Q10 { set; get; }
        public string Q11 { set; get; }
        public string Q12 { set; get; }
        public string Q13 { set; get; }

        public string Q14 { set; get; }
        public string Q15 { set; get; }
        public string Q16 { set; get; }
        public string Q18 { set; get; }
        public string DATE { set; get; }
        public string DETAILS { set; get; }


    }
    public class RDLCPROPOSALDATA
    {
        public List<ApplicationInfo> Applications { get; set; }
        public List<InsuredInfo> Insureds { get; set; }
        public List<CONTACTDETAILS> Contacts { get; set; }
        public List<RDLCPOLICYDETAIL> Rdlcpolicy { get; set; }
        public List<BENEFICIARYDETAILS> Beneficial { get; set; }
        public List<FUNDDETAILS> Funds { get; set; }
        public List<RDLCYNQUESTION> Rdlquestion { get; set; }

    }
    public class PROPOSALDETAIL
    {
        //public string Illustration_Number { get; set;}
        //public string Product { get; set; }
        public string FirstName { get; set; }
        public string Father_s_Name { get; set; }
        public string FamilyName { get; set; }

    }
    public class DashBaordInput
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public string userId { get; set; }



    }
    public class DashBoardDetailsOutput
    {


        public int PENDINGPAYMENTCount { get; set; }
        public decimal? TotalPaymentPenidngPremium { get; set; }

        public int PENDINGAPPROVALCount { get; set; }
        public decimal? TotalPaymentAPPROVALPremium { get; set; }

        public int ISSUEDPOLICIESCount { get; set; }
        public decimal? TotalPaymentIssuedPremium { get; set; }


    }
    public class ReportInput
    {
        public ReportInput() { }
        public string FromDate { get; set; }
        public string Todate { get; set; }
        public string UserId { get; set; }
        public bool IsSuperVisor { get; set; }
        public int ReportType { get; set; }
    }
    public class Reports
    {
        public Reports() { }
        public int ReportType { get; set; }
        public List<SalesReportPNS> salesReports { get; set; }

    }
    public class SalesReportPNS
    {
        public int QUOTENO { get; set; }
        public string POLICYNUMBER { get; set; }
        public string PROD_NAME { get; set; }
        public string PRODCODE { get; set; }
        public string FULLNAME { get; set; }
        public decimal PREMIUM { get; set; }
        public int VAT { get; set; }
        public decimal TOTALPREMIUM { get; set; }
        public decimal sumCovered { get; set; }
        public string CreatedDate { get; set; }
        public string IssueDate { get; set; }
        public string CreatedBy { get; set; }
        public string Channel { get; set; }
        public string ReferralBy { get; set; }
        public string MerchantReference { get; set; }
        public string PaymentDate { get; set; }
    }
    public class UWReportPNS
    {
        public int QUOTENO { get; set; }
        public string POLICYNUMBER { get; set; }
        public string PROD_NAME { get; set; }
        public string FULLNAME { get; set; }
        public decimal PREMIUM { get; set; }
        public int VAT { get; set; }
        public decimal TOTALPREMIUM { get; set; }
        public decimal sumCovered { get; set; }
        public string CreatedDate { get; set; }
        public string IssuedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Status { get; set; }
        public string Channel { get; set; }
        public string AgentCode { get; set; }
        public string MerchantReference { get; set; }
        public string PaymentDate { get; set; }
        public string ReferralBy { get; set; }
    }
    public class UrlRequest
    {
        public string OriginalUrl { get; set; }
    }
    public class BankDetails
    {
        public string BANK_NAME { get; set; }
        public string BRANCH_NAME { get; set; }
        public string BRANCH_CODE { get; set; }
        public string SNo { get; set; }
    }

    public class Nationality
    {
        public string nationality_name { get; set; }
        public string Nationality_code { get; set; }
        public string language { get; set; }
        public string yakeencode { get; set; }
        public string NationalityAR { get; set; }

    }
    public class UWDecisionReq
    {
        public string Decision { get; set; }
        public string Comment { get; set; }
        public DateTime EnforcedDate { get; set; }
        public int QuoteNo { get; set; }
        public int ApprovedBy { get; set; }


    }
    public class RecurringData
    {
        public string PolicyNumber { get; set; }
        public decimal Premium { get; set; }
        public decimal SumCovered { get; set; }
        public string UpdatedDate { get; set; }
        public DateTime NextDueDate { get; set; }
        public string Comment { get; set; }
        public string CustomerName { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedByName { get; set; }
    }

    public class RecurringTransaction
    {
        public string PolicyNumber { get; set; }
        public string Channel { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Premium { get; set; }
        public string MerchantReference { get; set; }
        public string Reason { get; set; }
    }
    public class RecurringTransactionsDetail
    {
        public string Status { get; set; }
        public string MerchantReference { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class GenericReq
    {
        public int QuoteNo { get; set; }
    }
    public class RecurringDetail
    {
        public int Id { get; set; }

        public int QuoteNo { get; set; }

        public string PolicyNumber { get; set; }

        public int Term { get; set; }

        public decimal Premium { get; set; }

        public int Frequency { get; set; }

        public decimal? SumCovered { get; set; }

        public DateTime? RecurringDate { get; set; }

        public DateTime? NextDueDate { get; set; }

        public string Status { get; set; }

        public string Comment { get; set; }

        public DateTime? FailedDueDate { get; set; }

        public int? NoOfTermPaid { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? IsFullyPaid { get; set; }

        public string MerchantRefernece { get; set; }

        public string TokenName { get; set; }

        public string CustomerName { get; set; }
    }
    public class IbanDetail
    {
        public string IbanRequest { get; set; }
        public string IbanResponse { get; set; }
        public string PolicyNumber { get; set; }
        public int ProductType { get; set; }
        public string NationalId { get; set; }
        public string Source { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class IBANRequestDetails
    {
        public string iban { get; set; }
        public int idType { get; set; }
        public long? idNumber { get; set; }
        public string source { get; set; }
        public int ProductType { get; set; }
        public string PolicyNumber { get; set; }
    }
    public class IbanValidationResponse
    {
        public List<string> errors { get; set; }
        public bool isValid { get; set; }
        public ValueWrapper value { get; set; }
        public object error { get; set; }
        public int statusCode { get; set; }
        public string errormessage { get; set; }
    }

    public class ValueWrapper
    {
        public ResponseData data { get; set; }
    }

    public class ResponseData
    {
        public string requestId { get; set; }
        public string result { get; set; }
        public Bank bank { get; set; }
        public string idType { get; set; }
        public string beneficiaryName { get; set; }
    }

    public class Bank
    {
        public string englishName { get; set; }
        public string arabicName { get; set; }
    }
    public class PolicyListReq
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string Search { get; set; }
        public string Lang { get; set; }
    }
    public class PscColPolicyDetails
    {
        public string VPolicyNo { get; set; }
        public string CustName { get; set; }
        public string VArabicName { get; set; }
        public string OwnerName { get; set; }
        public DateTime? DPremDueDate { get; set; }
        public string IndCovered { get; set; }
        public int? NAgentNo { get; set; }
        public string AgentName { get; set; }
        public string ArabicAgentName { get; set; }
        public string VPlanCode { get; set; }
        public DateTime? DCommencement { get; set; }
        public DateTime? DIssue { get; set; }
        public DateTime? DDispatchDate { get; set; }
        public DateTime? DAcknowledge { get; set; }
        public string VIdenCode { get; set; }
        public string VIdenNo { get; set; }
        public string IdExpiryDate { get; set; }
        public string VPostBox { get; set; }
        public string VPostcode { get; set; }
        public string VTown { get; set; }
        public DateTime? PaidToDate { get; set; }
        public string Curr { get; set; }
        public string Freq { get; set; }
        public decimal? Amount { get; set; }
        public string Escalating { get; set; }
        public string VStatusDesc { get; set; }
        public DateTime? StatusDate { get; set; }
        public string VAgencyRegion { get; set; }
        public string VBranchCode { get; set; }
        public decimal? NSumCovered { get; set; }
        public DateTime? DateCanc { get; set; }
        public decimal? Nav { get; set; }
        public DateTime? DExpiry { get; set; }
        public DateTime? DPolicyEndDate { get; set; }
        public string MTel { get; set; }
        public string RTel { get; set; }
        public string OTel { get; set; }
        public string Email { get; set; }
        public string AgentStatus { get; set; }
        public decimal? ContriPaid { get; set; }
        public int? ContPaidCnt { get; set; }
        public int? NoOutstnd { get; set; }
        public decimal? TotOutstndSar { get; set; }
        public string VAgentCode { get; set; }
        public string VSex { get; set; }
        public int? NTerm { get; set; }
        public DateTime? DProposerDob { get; set; }
        public DateTime? DApproveDate { get; set; }
        public int? NChannelNo { get; set; }
        public string AgencyRegion { get; set; }
        public string VIsoNumber { get; set; }
        public int? TelesalesAgentNo { get; set; }
        public string VProposalNo { get; set; }
        public string VPlanName { get; set; }
        public string VChannel { get; set; }
        public string VLobDesc { get; set; }
        public string VMobile { get; set; }
        public string VProductGroup { get; set; }
        public string VOccupation { get; set; }
        public decimal? NAnnualIncome { get; set; }
        public string VSourceOfIncome { get; set; }
        public string VPortfolioType { get; set; }
        public decimal? NPwAmount { get; set; }
        public DateTime? DRecentDate { get; set; }
        public int? NInvestCount { get; set; }
        public decimal? NPrevPw { get; set; }
        public decimal? NFwAmount { get; set; }
        public string VPymtDesc { get; set; }
        public string VCurrencyDesc { get; set; }
        public DateTime? DLastPaid { get; set; }
        public string VPayMethod { get; set; }
        public decimal? NTopup { get; set; }
        public DateTime? DNextOutDate { get; set; }
        public DateTime? DAlteration { get; set; }
        public string VAlterationDesc { get; set; }
        public string VAltStatus { get; set; }
        public int? NPendingCount { get; set; }
        public string VNotes { get; set; }
        public DateTime? DCommunication { get; set; }
        public int? RmAgentNo { get; set; }
        public decimal? NProfitRatio { get; set; }
        public string PaymentKey { get; set; }
        public DateTime? Createddate { get; set; }
        public string EmailBody { get; set; }
        public string SMSContent { get; set; }
        public string EmailSubject { get; set; }
        public bool isPaid { get; set; }
    }
    //changes start made by ankita on 24-10-2025
    public class RecuringResoponse
    {
        public string Paymentkey { get; set; }
    }
    public class GetPolicyDetailsByPaymentKey
    {
        public string Paymentkey { get; set; }
    }
    public class RetentialApiLogIds
    {
        public List<int> N_LOG_ID { get; set; }
    }

    //changes end made by ankita on 24-10-2025
    public class RetentialApiLogResponse
    {
        public List<RetentialApiLogItem> Items { get; set; }
    }

    public class RetentialApiLogItem
    {
        public int N_Log_Id { get; set; }
        public DateTime D_Log_Date { get; set; }
        public string V_Api_Id { get; set; }
        public string V_Api_Request { get; set; }
        public string V_Api_Response { get; set; }
        public DateTime? D_Response { get; set; }
        public string V_Status { get; set; }
        public string V_Created_By { get; set; }
    }
    //Added by Shyam Patil 29Oct2025
    public class GetQuote
    {
        public string QuoteNo { get; set; }
    }

    public class UnifiedIssueRootRequest
    {
        public UnifiedIssueInputValues InputValues { get; set; }
    }

    public class UnifiedIssueInputValues
    {
        public string ProcedureName { get; set; }
        public string ServiceType { get; set; }
        public string RequestRefNo { get; set; }
        public string SubmissionChannel { get; set; }
        public string ChannelUser { get; set; }
        public string CustomerConsent { get; set; }
        public ReceiptDetails ReceiptDetails { get; set; }
        public PayerDetails PayerDetails { get; set; }
        public List<object> AdditionalValues { get; set; }
    }

    public class ReceiptDetails
    {
        public string PolicyNo { get; set; }
        public string DebitNoteNo { get; set; }
        public string ReceiptDate { get; set; }
        public string Currency { get; set; }
        public decimal TotalAmount { get; set; }
        public string ReceiptType { get; set; }
        public string PaymentReceivedThrough { get; set; }
        public string ReceiptInstrument { get; set; }
        public string PaymentReferenceNo { get; set; }
        public string PaymentCardNo { get; set; }
        public string PaymentConfirmationDate { get; set; }
        public int RecurringBillingDay { get; set; }
    }

    public class PayerDetails
    {
        public string PayerType { get; set; }
        public string PayerName { get; set; }
        public string NationalId { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string RelationshipWithLifeAssured { get; set; }
    }
    public class UnifiedIssueApiResponse
    {
        public string status { get; set; }

        public string message { get; set; }

        public int errorCode { get; set; }

        public string errorMessage { get; set; }

        public UnifiedReturnValueContainer returnValue { get; set; }

        public object returnValues { get; set; }
    }

    public class UnifiedReturnValueContainer
    {
        public UnifiedReturnValues InputValues { get; set; }
    }

    public class UnifiedReturnValues
    {
        public List<object> AdditionalValues { get; set; }
        public string SubmissionChannel { get; set; }
        public string CustomerConsent { get; set; }
        public PayerDetails PayerDetails { get; set; }
        public string ProcedureName { get; set; }
        public string ServiceType { get; set; }
        public ReceiptDetails ReceiptDetails { get; set; }
        public string RequestRefNo { get; set; }
        public string ChannelUser { get; set; }
    }

    public class UnifiedApiException
    {
        public string ExceptionMessage { get; set; }
        public string ExceptionAction { get; set; }

        public string ExceptionCode { get; set; }
    }
    public class UnifiedAuthRequest
    {
        public string username { get; set; }
        public string password { get; set; }
    }
    public class UnifiedAuthResponse
    {
        public string status { get; set; }
        public string access_token { get; set; }
        public string refresh_token { get; set; }
        public string message { get; set; }
    }


}
