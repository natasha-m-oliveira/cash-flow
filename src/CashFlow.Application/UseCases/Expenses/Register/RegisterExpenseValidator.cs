using CashFlow.Communication.Requests;
using FluentValidation;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpenseValidator : AbstractValidator<RequestRegisterExpenseJson>
{
    public RegisterExpenseValidator()
    {
        RuleFor(expense => expense.Title).NotEmpty();
        RuleFor(expense => expense.Amount).GreaterThan(0);
        RuleFor(expense => expense.Date).LessThanOrEqualTo(DateTime.UtcNow);
        RuleFor(expense => expense.PaymentType).IsInEnum();
    }
}
