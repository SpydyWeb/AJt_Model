using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MotorPenta
    {
    }
    public class Createquotationmtr
    {
        public string quotationNo { get; set; }
        public string idType { get; set; }
        public string idenNo { get; set; }
        public string companyCode { get; set; }
        public string companyBranch { get; set; }
        public string crIssueDate { get; set; }
        public string crExpiryDate { get; set; }
        [RegularExpression("^[ a-zA-Z0-9\u0600-\u06FF.-]*$", ErrorMessage = "ArabicFirstName Invalid Character"), StringLength(150, ErrorMessage = "ArabicFirstName Invalid Length")]
        public string insuredName { get; set; }
        public string insuredGender { get; set; }
        public string dateOfBirth { get; set; }
        public string insuredMaritalStatus { get; set; }
        public string insuredMobileNo { get; set; }
        public string insuredEmail { get; set; }
        public string nationality { get; set; }
        public string postCode { get; set; }
        public string country { get; set; }
        public string productCode { get; set; }
        public string dataBranch { get; set; }
        public string paymentType { get; set; }
        public string businessType { get; set; }
        public string transactionCurrency { get; set; }
        public string introducerCode { get; set; }
        public string agentCode { get; set; }
        public DateTime effectiveDate { get; set; }
        public DateTime expiryDate { get; set; }
        public string provinceCode { get; set; }
        public string paymentFrequency { get; set; }
        public string education { get; set; }
        public string childrens { get; set; }
        public string sourceOfBusiness { get; set; }
        public int commissionPercentage { get; set; }
        public string commissionBasis { get; set; }
        public string userId { get; set; }
        public string sourceType { get; set; }
        public RiskDetails riskDetails { get; set; }
        public List<AddressDetails> addressDetails { get; set; }
    }

    public class RiskDetails
    {
        public string plateText1 { get; set; }
        public string plateText2 { get; set; }
        public string plateText3 { get; set; }
        public int plateNumber { get; set; }
        public string makeCode { get; set; }
        public string modelCode { get; set; }
        public string coverType { get; set; }
        public string usage { get; set; }
        public string engineNo { get; set; }
        public string chassisNo { get; set; }
        public string manufacturerYear { get; set; }
        public string registrationDate { get; set; }
        public string repairType { get; set; }
        public string placeOfRegistration { get; set; }
        public int trafficFileNo { get; set; }
        public int noOfCylinders { get; set; }
        public string roadSideAssistant { get; set; }
        public string vehicleImported { get; set; }
        public string importedCountry { get; set; }
        public int noOfDoors { get; set; }
        public int sumInsured { get; set; }
        public string fuelType { get; set; }
        public string rateBasis { get; set; }
        public int rate { get; set; }
        public string srccApplicability { get; set; }
        public string tcApplicability { get; set; }
        public string bankCode { get; set; }
        public string bankBranch { get; set; }
        public string bankRefNo { get; set; }
        public string loanAccNo { get; set; }
        public string aggregator { get; set; }
        public string loyalityDisc { get; set; }
        public string mileagePerYear { get; set; }
        public string transmission { get; set; }
        public string vehicleParkedOverNight { get; set; }
        public string carModification { get; set; }
        public string braking { get; set; }
        public string acceleration { get; set; }
        public string cornering { get; set; }
        public string adherenceSpeed { get; set; }
        public string timeOfDay { get; set; }
        public string mileage { get; set; }
        public string noOfSeatBelt { get; set; }
        public string sequenceNo { get; set; }
        public string vehicleColor { get; set; }
        public string noOfSeats { get; set; }
        public int ncdYear { get; set; }
        public int deductibleAmount { get; set; }
        public string currentMileage { get; set; }
        public string antiTheftAlarm { get; set; }
        public string antiLockBrakingSystem { get; set; }
        public string automaticBrakingSystem { get; set; }
        public string cruiseControl { get; set; }
        public string adaptiveCruiseControl { get; set; }
        public string rearParkingSensor { get; set; }
        public string frontSensor { get; set; }
        public string rearCamera { get; set; }
        public string frontCamera { get; set; }
        public string camera_360_model { get; set; }
        public string fireExtinguisher { get; set; }

        public List<BenefitDiscountDetails> benefitDiscountDetails { get; set; }
        public List<DriverDetailspenta> driverDetails { get; set; }
    }

    public class BenefitDiscountDetails
    {
        public string coverCode { get; set; }
        public int amount { get; set; }
        public string rateBasisAmount { get; set; }
        public int rate { get; set; }
        public int contributionAmount { get; set; }
        public string calcBasis { get; set; }
    }

    public class DriverDetailspenta
    {
        public string driverIdenType { get; set; }
        public string driverIdenNo { get; set; }
        public string driverGender { get; set; }
        [RegularExpression("^[ a-zA-Z0-9\u0600-\u06FF.-]*$", ErrorMessage = "ArabicFirstName Invalid Character"), StringLength(150, ErrorMessage = "ArabicFirstName Invalid Length")]
        public string driverName { get; set; }
        public string driverAge { get; set; }
        public string drivingExp { get; set; }
        public string driverNationCode { get; set; }
        public string education { get; set; }
        public string maritalStatus { get; set; }
        public string children { get; set; }
        public string occupationCode { get; set; }
        [RegularExpression("^[ a-zA-Z0-9\u0600-\u06FF.-]*$", ErrorMessage = "ArabicFirstName Invalid Character"), StringLength(150, ErrorMessage = "ArabicFirstName Invalid Length")]
        public string residentialAddress { get; set; }
        [RegularExpression("^[ a-zA-Z0-9\u0600-\u06FF.-]*$", ErrorMessage = "ArabicFirstName Invalid Character"), StringLength(150, ErrorMessage = "ArabicFirstName Invalid Length")]
        public string officeAddress { get; set; }
        public string licenseType { get; set; }
        public string saudiLicenseYears { get; set; }
        public string otherCountryLicense { get; set; }
        public string nonSaudiLicenseYears { get; set; }
        public string noClaimDisc { get; set; }
        public string driverAtFaultAccount { get; set; }
        public string driverAtFaultClaims { get; set; }
        public string roadConviction { get; set; }
        public string medicalCondition { get; set; }
        public string primaryDriver { get; set; }

    }

    public class AddressDetails
    {
        public string addressType { get; set; }
        public string buildingNo { get; set; }
        public string street { get; set; }
        public string district { get; set; }
        public string city { get; set; }
        public string postCode { get; set; }
        public int additionalNo { get; set; }
        public string isPrimaryAddress { get; set; }
        public string country { get; set; }
    }

    #region CreateQuoteResponse
    public class CreateQuoteResponse
    {
        public bool status { get; set; }
        public ReturnValue returnValue { get; set; }
        public object returnValues { get; set; }
       // public object errors { get; set; }
        public List<Error> errors { get; set; }
    }
    public class Error
    {
        public string Field { get; set; }
        public string Message { get; set; }
        public object Exception { get; set; }
        public object Code { get; set; }
    }

    public class ReturnValue
    {
        public string quotationNo { get; set; }
        public string statusDesc { get; set; }
        public string issueDate { get; set; }
        public string expiryDate { get; set; }
        public PremiumDetails premiumDetails { get; set; }
        public List<CoverTypeDetails> coverTypeDetails { get; set; }
        public object receiptDetails { get; set; }
    }

    public class PremiumDetails
    {
        public double basicPremium { get; set; }
        public double grossPremium { get; set; }
        public double vat { get; set; }
        public double discountAmount { get; set; }
        public double loadingAmount { get; set; }
        public double totalPremium { get; set; }
        public double commissionAmount { get; set; }
        public double deductibleAmount { get; set; }
        public double otherCharges { get; set; }
        public double totalBenefitPremium { get; set; }
        public List<ChargesBreakdown> chargesBreakdown { get; set; }
    }

    public class ChargesBreakdown
    {
        public string chargeCode { get; set; }
        public string chargeDesc { get; set; }
        public double amount { get; set; }
    }

    public class CoverTypeDetails
    {
        public string benefitCode { get; set; }
        public string benefitDescription { get; set; }
        public double premium { get; set; }
        public double rate { get; set; }
        public string rateBasis { get; set; }
    }

    #endregion CreateQuoteResponse

    //changes start made by raju on 04-12-2025
    public class Getpentaquotation
    {

        public int Id_p { get; set; }
        public int Id_v { get; set; }
        public long Idnumber { get; set; }
        public int yakeenifo_id { get; set; }
        public string childrenbelow16 { get; set; }
        public int mileagePerYear { get; set; }
        public int ncd { get; set; }
        public MotorPremiumDetail MotorPremiumDetail { get; set; }
        public long drvid { get; set; }
        public int Maritalstatus { get; set; }
        public string overnightparking { get; set; }
        public string officeaddress { get; set; }
        public string saudiLicenseYears { get; set; }
        public string otherCountryLicense { get; set; }
        public string nonSaudiLicenseYears { get; set; }
        public string licenseType { get; set; }
        public int vehicletype { get; set; }
        public int age { get; set; }
        public string effectivedate { get; set; }
        public string sequenceno { get; set; }
    }
    public class MotorPremiumDetail
    {
        public decimal BASE_RATE { get; set; }
        public decimal VAT_RATE { get; set; }
        public decimal NCD_RATE { get; set; }
        public decimal ADDITIONAL_DISCOUNT_RATE { get; set; }
        public decimal LOYALTY_DISCOUNT { get; set; }
        public decimal NJMFEE { get; set; }
        public decimal SAMA_DISCOUNT { get; set; }
        public decimal NCD_FACTOR_RATE { get; set; }
        public string IS_ERROR { get; set; }
        public string ERROR_DESC { get; set; }
    }
    public class GetquotationResponse
    {
        public string quotaiono { get; set; }
        public string PolicyNO { get; set; }
        public object Errordecription { get; set; }
    }

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

    public class Savepentrequest
    {
        public long P_FLAG { get; set; }
        public string p_idnumber { get; set; }
        public long p_policyid { get; set; }
        public string p_QuotationNumber { get; set; }
        public string p_SegmentCode { get; set; }
        public string p_CreateQuotationRequest { get; set; }
        public string p_CreateQuotationResp { get; set; }
        public string p_CreateProposalRequest { get; set; }
        public string p_CreateProposalResp { get; set; }
        public string p_IssuePolicyRequest { get; set; }
        public string p_IssuePolicyResp { get; set; }
        public string p_CalculatePremiumRequest { get; set; }
        public string p_CalculatePremiumResp { get; set; }
        public string P_CREATEDBY { get; set; }
        public string p_Status { get; set; }
    }
    public class SavepentErrordata
    {
        public long P_FLAG { get; set; }
        public string p_idnumber { get; set; }
        public long p_policyid { get; set; }
        public string p_CreateQuotationRequest { get; set; }
        public string p_CreateQuotationResp { get; set; }
        public string p_CreateProposalRequest { get; set; }
        public string p_CreateProposalResp { get; set; }
        public string p_IssuePolicyRequest { get; set; }
        public string p_IssuePolicyResp { get; set; }
        public string p_CalculatePremiumRequest { get; set; }
        public string p_CalculatePremiumResp { get; set; }
        public string P_ERRORDESCRIPTION { get; set; }
        public string P_CREATEDBY { get; set; }
        public string p_Status { get; set; }
    }
    #region createproposal
    public class CreateProposalRequest
    {
        public string quotationNo { get; set; }
        public string effectiveDate { get; set; }
        public string expiryDate { get; set; }
        public string sourceType { get; set; }
    }

    public class CreateProposalResponse
    {
        public bool status { get; set; }
        public ReturnValue_pr returnValue { get; set; }
        public object returnValues { get; set; }
        //public object errors { get; set; }
        public List<Error> errors { get; set; }//chnages start made by raju on 17-12-2025

    }
    public class ReturnValue_pr
    {
        public string policyNo { get; set; }
        public double premium { get; set; }
        public string statusDesc { get; set; }
    }
    #endregion createproposal
    #region Issuepolicy
    public class IssuePolicyRequest
    {
        public string policyNo { get; set; }
        public string receiptCode { get; set; }
        public string instrumentType { get; set; }
        public string instrumentNumber { get; set; }
        public string sourceType { get; set; }
        public int renCount { get; set; }
        public int endCount { get; set; }
    }
    public class IssuePolicyResponse
    {
        public bool status { get; set; }
        public ReturnValues_pli returnValue { get; set; }
        public object returnValues { get; set; }
        public object errors { get; set; }
    }
    public class ReturnValues_pli
    {
        public PremiumDetails premiumDetails { get; set; }
        public ReceiptDetails receiptDetails { get; set; }
    }

    #endregion Issuepolicy

    #region lookuptable
    public class LookupTable
    {
        public InputValues inputValues { get; set; }
    }
    public class InputValues
    {
        public string procedureName { get; set; }
        public string lookupCode { get; set; }
    }
    public class LookupResponse
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
        public List<Item> Items { get; set; }
    }

    public class Link
    {
        public string Rel { get; set; }
        public string Href { get; set; }
    }

    public class Item
    {
        public List<LookupValue> Lookup_Values { get; set; }
    }

    public class LookupValue
    {
        public string V_Ins_Code { get; set; }
        public string V_Desc { get; set; }
    }

    #endregion lookuptable
    //changes end made by raju on 04-12-2025
}
