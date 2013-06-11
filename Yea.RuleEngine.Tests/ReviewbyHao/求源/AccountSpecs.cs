using Machine.Specifications;
using Machine.Specifications.AutoMocking.Rhino;

namespace Yea.RuleEngine.Tests.ReviewbyHao.求源
{
    public class AccountSpecs:Specification<Account>
    {
        Because of = () => { subject.Charge(1000); };
        It balance_should_equal_to_charged_amount = () => { subject.Balance.ShouldEqual(1000); };
    }

    public class Account
    {
        public void Charge(int i)
        {
            throw new System.NotImplementedException();
        }

        public int Balance { get; private set; }
    }
}