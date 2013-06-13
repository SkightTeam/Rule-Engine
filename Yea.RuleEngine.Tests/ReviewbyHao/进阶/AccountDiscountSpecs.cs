using Machine.Specifications;
using Machine.Specifications.AutoMocking.Rhino;
using Rhino.Mocks;

namespace Yea.RuleEngine.Tests.ReviewbyHao.求源
{
    public class When_account_grad_is_regular
    {
        private Establish context = () =>
        {
            subject = MockRepository.GenerateMock<Account>();
            subject.Stub(x => x.Grade).Return(Grade.Regular);
        };

        private It account_discount_should_be_95_percent = () => subject.Discount.ShouldEqual(100);
        private static Account subject;
    }
    public class When_account_grade_is_silver
    {
        private Establish context = ()=>
                                        {
                                            subject = MockRepository.GenerateMock<Account>();
                                            subject.Stub(x => x.Grade).Return(Grade.Silver);
                                        };

        private It account_discount_should_be_95_percent = () => subject.Discount.ShouldEqual(95);
        private static Account subject;
    }
}