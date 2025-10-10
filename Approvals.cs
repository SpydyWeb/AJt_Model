using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    public class ApprovalHistory
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
        public string Comments { get; set; }
        public string Referenceno { get; set; }
        public decimal Amount { get; set; }
    }
    public class ApprovalHistDeclaration : Results
    {
        public List<MemberDeclare> memberDeclares { get; set; }

        public ApprovalHistDeclaration()
        {
            memberDeclares = new List<MemberDeclare>();
        }
    }
    public class MemberDeclare
    {
        public ApprovalHistory ApprovalHistory { get; set; }

        //public MembersDeclarations HealthDeclarations { get; set; }

        //public Subjects Subjects { get; set; }

        public List<DeclarationsAnswers> declarationsAnswers { get; set; }

        public MemberDeclare()
        {
            ApprovalHistory = new ApprovalHistory();
            //HealthDeclarations = new MembersDeclarations();
            //Subjects = new Subjects();
            declarationsAnswers = new List<DeclarationsAnswers>();
        }
    }
    public class DeclarationsAnswers
    {
        public HealthDeclarations healthDeclarations { get; set; }

        public bool Answer { get; set; }

        public DeclarationsAnswers()
        {
            healthDeclarations = new HealthDeclarations();
        }
    }
    public class HealthDeclarations
    {
        public int Id { get; set; }

        public int QuestionNo { get; set; }

        public string QuestionDescEn { get; set; }

        public string QuestionAr { get; set; }
    }
    public class LoadApprovalOutPut : Results
    {
        public List<ApprovalSet> approvalSets { get; set; }

        public LoadApprovalOutPut()
        {
            approvalSets = new List<ApprovalSet>();
        }
    }

    public class ApprovalSet
    {
        public ApprovalHistory approvalHistory { get; set; }

        public Production Production { get; set; }

        public ApprovalSet()
        {
            approvalHistory = new ApprovalHistory();
            Production = new Production();
        }
    }
    public class LoadApprovalsInput
    {
        public int? UserId { get; set; }

        public bool? AllApprovals { get; set; }

        public int? ActionStatus { get; set; }

        public DateTime? Fromdate { get; set; }

        public int? NoOfApprovals { get; set; }

        public string CROrAppNo { get; set; }

        public string PolicyNo { get; set; }
    }

    public class ListApprovalsData
    {
        public long ApprovalId { get; set; }

        public string Status { get; set; }

        public string Attachments { get; set; }

        public int? ApprovalUserId { get; set; }

        public DateTime RecievedDate { get; set; }

        public int ProductionId { get; set; }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int DocumentType { get; set; }

        public string SeqmentCode { get; set; }

        public string InsuredName { get; set; }

        public string UniqueGuid { get; set; }

        public int? PlanId { get; set; }

        public long CustomerId { get; set; }

        public string UWName { get; set; }

    }
    public class ApprovalRequestDeclerationInput
    {
        public int ApprovalHistoryId { get; set; }
    }
    public class MMPInsert
    {
        public int Id { get; set; }

        public string NationalId { get; set; }

        public string Sponsor { get; set; }

        public string DateOfBirth { get; set; }

        public string Mobile { get; set; }

        public string AccountManagerMobile { get; set; }

        public string Email { get; set; }

        public string InsurerName { get; set; }

        public string PolicyNumber { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public bool? Proffision2Q { get; set; }

        public string txtProffision2Q { get; set; }

        public bool? Proffision3Q { get; set; }

        public string txtProffision3Q { get; set; }

        public bool? Proffision4Q { get; set; }

        public string txtProffision4Q { get; set; }

        public bool? Proffision5Q { get; set; }

        public string txtProffision5Q { get; set; }

        public string IndemnityLimit { get; set; }

        public string AggregatedLimit { get; set; }

        public DateTime EffectiveDate { get; set; }

        public int PolicyPeriod { get; set; }

        public int ProffessionId { get; set; }

        public DateTime? Retroactive { get; set; }

        public bool Proffision1Q { get; set; }
    }


    public class LoadCreditLimitOutput : Results
    {
        public List<CreditLimits> lcreditLimits { get; set; }

        public LoadCreditLimitOutput()
        {
            lcreditLimits = new List<CreditLimits>();
        }
    }

    public class CreditLimits
    {
        public int Id { get; set; }

        public long EskaId { get; set; }

        public decimal CreditLimit { get; set; }

        public decimal Balance { get; set; }

        public DateTime? LastPaymentDate { get; set; }

        public int FinanceUserId { get; set; }

        public decimal ExtendLimit { get; set; }

        public int? modifiedBy { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

        public int UserId { get; set; }
    }
    public class LoadCreditLimitInput
    {
        public long? EskaId { get; set; }

        public int? UserId { get; set; }

        public int? Id { get; set; }
    }

    [Serializable]
    public class UWdecisionpara
    {
        public string ApprovalId { get; set; }
        public string ProductId { get; set; }
        public string ProductionId { get; set; }
    }

}
