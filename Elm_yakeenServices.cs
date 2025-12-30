using System;


namespace Models
{
    public  class Elm_yakeenServices
    {
    }
    public class residentAbsherDetails
    {
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string birthDateG { get; set; }
        public string SocialStatus { get; set; }
        public string NationCode { get; set; }
        public string Occupation { get; set; }
        public string OccupationDecar { get; set; }
        public string CustRef { get; set; }
        public string EnglishSecondName { get; set; }
        public string EnglishThirdName { get; set; }
        public string EnglishFirstName { get; set; }
        public string nationalityCode { get; set; }
        public string nationalityDescAr { get; set; }
        public int Age { get; set; }
        public AbsherAddress Address { get; set; }

    }
    public class YakeenAbsherDetails
    {
        public string SecondName { get; set; }
        public string IDNUMBER { get; set; }
        public string ThirdName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex_code { get; set; }
        public string Sex_descar { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string birthDateG { get; set; }
        public string SocialStatus { get; set; }
        public string SocialStatusDescar { get; set; }
        public string Occupation { get; set; }
        public string OccupationDecar { get; set; }
        public string CustRef { get; set; }
        public string EnglishSecondName { get; set; }
        public string EnglishThirdName { get; set; }
        public string EnglishFirstName { get; set; }
        public string nationalityCode { get; set; }
        public string nationalityDescAr { get; set; }
        public int Age { get; set; }
        public AbsherAddress Address { get; set; }
        public int idref { get; set; }//changes start made by raju on 09-12-2025

    }

    public class AbsherAddress
    {
        public string unitNo { get; set; }
        public string buildingNo { get; set; }
        public string city { get; set; }
        public string distric { get; set; }
        public string coordinates { get; set; }
        public string postcode { get; set; }
        public string street { get; set; }
        public string additional_no { get; set; }
        public string logid { get; set; }
    }
    public class citizenAbsherDetails
    {
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string FamilyName { get; set; }
        public string GrandFatherName { get; set; }
        public string Gender { get; set; }
        public string DateofbirthG { get; set; }
        public string OccupationCode { get; set; }
        public string OccupationDecar { get; set; }
        public string CustRef { get; set; }
        public string socialStatus { get; set; }
        public string iqamaExpiryDateG { get; set; }
        public AbsherAddress Address { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string EnglishSecondName { get; set; }
        public string EnglishThirdName { get; set; }
        public string EnglishFirstName { get; set; }
        public string nationalityCode { get; set; }
        public string nationalityDescAr { get; set; }
    }
    public class residentAbsherDetailsReq
    {
        public string IDNUMBER { get; set; }
        public residentAbsherDetails Res { get; set; }

    }

    public class citizenAbsherDetailsReq
    {
        public string IDNUMBER { get; set; }
        public citizenAbsherDetails Req { get; set; }

    }
    public class UserDetailModelYakeen
    {
        public citizenAbsherDetails CitizenDetails { get; set; }
        public residentAbsherDetails ResidentDetails { get; set; }
    }
}
