using Machine.Specifications;
using Machine.Specifications.AutoMocking.Rhino;

namespace Yea.RuleEngine.Tests.ReviewbyHao.求源
{
    public class When_account_grade_is_silver:Specification<Account>
    {
        private Establish to_do_how_to_mock_grade;

        private It account_discount_should_be_95_percent = () => subject.Discount.ShouldEqual(95);
    }
}