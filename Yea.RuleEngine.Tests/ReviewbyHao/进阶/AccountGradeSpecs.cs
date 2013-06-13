using System;
using System.Collections.Generic;
using Machine.Specifications;
using Machine.Specifications.AutoMocking.Rhino;

namespace Yea.RuleEngine.Tests.ReviewbyHao.求源
{
    public class When_a_new_account_with_0_balance:Specification<Account>
    {
        private It grade_should_be_regular = () => subject.Grade.ShouldEqual(Grade.Regular);
    }
    
    public class When_charged_amount_accumulated_over_100:Specification<Account>
    {
        private Because of = () => subject.Charge(100);
        private It grade_should_be_silver = () => subject.Grade.ShouldEqual(Grade.Silver);
    }
}