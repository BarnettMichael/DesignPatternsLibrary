using ChainOfResponsibility.Interfaces;

namespace ChainOfResponsibility.Approval
{
    public class ExpenseHandler : IExpenseHandler
    {
        private IExpenseApprover _approver;
        private IExpenseHandler _next = EndOfChainExpenseHandler.Instance;

        public ExpenseHandler(IExpenseApprover expenseApprover) => _approver = expenseApprover;
        
        public ApprovalResponse Approve(IExpenseReport expenseReport)
        {
            ApprovalResponse response = _approver.ApproveExpense(expenseReport);

            if(response == ApprovalResponse.BeyondApprovalLimit)
            {
                return _next.Approve(expenseReport);
            }

            return response;
        }
        public void RegisterNext(IExpenseHandler next)
        {
            _next = next;
        }
        
    }
}
