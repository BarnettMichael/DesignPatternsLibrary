using System;

namespace ChainOfResponsibility.Interfaces
{
    public interface IExpenseReport
    {
        Decimal Total { get; }
    }

    public interface IExpenseApprover
    {
        ApprovalResponse ApproveExpense(IExpenseReport expenseReport);
    }

    public enum ApprovalResponse
    {
        Denied,
        Approved,
        BeyondApprovalLimit
    }

    public interface IExpenseHandler
    {
        ApprovalResponse Approve(IExpenseReport expenseReport);
        void RegisterNext(IExpenseHandler next);
    }
}
