using Machine.Specifications;
using Machine.Specifications.AutoMocking.Rhino;

namespace Yea.RuleEngine.Tests.ReviewbyHao.求源
{
    public class When_charge_once_to_account:Specification<Account>
    {
        Because of = () => { subject.Charge(1000); };
        It balance_should_equal_to_charged_amount = () => { subject.Balance.ShouldEqual(1000); };
    }

    public class When_charge_twice_to_account : Specification<Account> {
        Because of = () =>
            {
                subject.Charge(1000);
                subject.Charge(500);
            };
        It balance_should_equal_to_total_charged_amount = () => { subject.Balance.ShouldEqual(1500); };
    }

    public class When_charge_and_consume_to_account : Specification<Account> {
        Because of = () =>
        {
            subject.Charge(1000);
            subject.Consume(100);
            subject.Charge(500);
        };
        It balance_should_equal_to_calculated_amount = () => { subject.Balance.ShouldEqual(1400); };
    }
}