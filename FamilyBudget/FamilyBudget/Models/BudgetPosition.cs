using System;

namespace FamilyBudget.Models
{
    public enum BudgetPositionType
    {
        Income,
        Expense,
    }
    public class BudgetPosition
    {
        
        public int Id { get; set; }

        public int BudgetId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public int UserId { get; set; }

        public int CategoryId { get; set; }

        public BudgetPositionType IncomeOrExpence { get; set; }


    }
}
