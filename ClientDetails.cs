using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ClientDetails
    {
        // Properties
        public decimal QuoteNo { get; set; }
        public decimal CustomerID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public string IdNumber { get; set; }
        public string PRODNAME { get; set; }
        public string Status { get; set; }
        public string CustomerName { get; set; }
        public string CreatedOn { get; set; }
    }
    public class UserListResponse
    {
        public bool IsError { get; set; }
        public string Error { get; set; }
        public UserList[] userList { get; set; }
    }
    public class UserList
    {
        public Int32 Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public Int32? EskaId { get; set; }
        public Int32? ManagerId { get; set; }
        public bool? AllowCredit { get; set; }
        public string UserRole { get; set; }
        public string UserType { get; set; }
        public decimal? CreditLimit { get; set; }
        public decimal? Balance { get; set; }
        public string Status { get; set; }
        public string Sname { get; set; }
    }
    public class UserListRequest
    {
        public Int32 flag { get; set; }
        public bool IsActive { get; set; }
        public string userid { get; set; }
    }
    public class ProductResponse
    {
        public bool IsError { get; set; }
        public string Error { get; set; }
        public ProductList[] productList { get; set; }
    }


    public class ProductList
    {
        public Int32 Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public bool? IsActive { get; set; }
        public string URL { get; set; }
        public string ProductIcon { get; set; }
        public string ProductNameAR { get; set; }
        public Int32 SeqNo { get; set; }
    }
    public class UserRequestsResponse
    {
        public bool IsError { get; set; }
        public string Error { get; set; }
        public UserRequests[] userList { get; set; }
    }
    public class UserRequests
    {
        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string password { get; set; }
        public bool isactive { get; set; }
        public DateTime? creationdate { get; set; }
        public string lastpasswordchange { get; set; }
        public bool? isonetimepassword { get; set; }
        public bool? failedattempt { get; set; }
        public string eskaid { get; set; }
        public string managerid { get; set; }
        public bool? iscurrentlogedin { get; set; }
        public string accesskey { get; set; }
        public bool? allowcredit { get; set; }
        public string segmentcode { get; set; }
        public string vatno { get; set; }
        public bool? isadmin { get; set; }
        public string logofile { get; set; }
        public string companyname { get; set; }
        public ProductList[] productList { get; set; }
        public decimal CreditLimit { get; set; }
        public decimal Balance { get; set; }
        public decimal UseBalance { get; set; }
        public string SName { get; set; }
        public int roleid { get; set; }
        public int typeid { get; set; }
    }
    public class UserProducts
    {
        public string ProductCode { get; set; }
    }
    public class UserResponse
    {
        public Int32 Id { get; set; }
        public bool IsError { get; set; }
        public string Error { get; set; }

    }
    public class UpdateRequest
    {
        public Int32 flag { get; set; }
        public Int32 Id { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public string SegmentCode { get; set; }
        public decimal CreditLimit { get; set; }
        public string SName { get; set; }
        public List<UserProducts> userProducts { get; set; }
        public Int32 roleid { get; set; }
        public Int32 typeid { get; set; }
    }
    public class RolesResponse
    {
        public bool IsError { get; set; }
        public string Error { get; set; }
        public RolesList[] rolesList { get; set; }
    }
    public class RolesList
    {
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public bool? isMapped { get; set; }
    }
    public class TypesResponse
    {
        public bool IsError { get; set; }
        public string Error { get; set; }
        public TypesList[] typesList { get; set; }
    }
    public class TypesList
    {
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public Int32 MedicalId { get; set; }
        public Int32 GeneralId { get; set; }
        public Int32 TravelId { get; set; }
        public decimal Commission { get; set; }
        public Int32 ChartOfAccount { get; set; }
        public Int32 BusinessType { get; set; }
    }
}
