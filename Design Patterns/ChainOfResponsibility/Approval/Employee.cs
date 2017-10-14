using ChainOfResponsibility.Interfaces;
using System;

namespace ChainOfResponsibility.Approval
{
    public class Employee : IExpenseApprover
    {
        private readonly decimal _approvalLimit;

        public Employee(string name, Decimal approvalLimit)
        {
            Name = name;
            _approvalLimit = approvalLimit;
        }

        public string Name { get; private set; }

        public ApprovalResponse ApproveExpense(IExpenseReport expenseReport)
        {
            return expenseReport.Total > _approvalLimit
                ? ApprovalResponse.BeyondApprovalLimit
                : ApprovalResponse.Approved;
        }

    }
}
