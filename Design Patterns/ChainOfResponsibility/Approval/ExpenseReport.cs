using ChainOfResponsibility.Interfaces;
using System;

namespace ChainOfResponsibility.Approval
{
    public class ExpenseReport : IExpenseReport
    {
        public ExpenseReport(Decimal total) => Total = total;
        
        public decimal Total { get; private set; }
    }
}
