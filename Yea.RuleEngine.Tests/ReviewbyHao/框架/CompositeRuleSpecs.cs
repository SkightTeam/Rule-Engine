using Machine.Specifications;

namespace Yea.RuleEngine.Tests.ReviewbyHao.求源.框架
{
    public class Account_with_memebership_rules {


        private Establish context = () =>
        {
            subject = Rules<Account>.Create()
                .when(x => x.ChargeAmount <100).then(x => x.Grade = Grade.Regular)
                .when(x=>x.ChargeAmount >=100 && x.ChargeAmount<1000).then(x=>x.Grade=Grade.Silver)
                .when(x=>x.ChargeAmount>=1000).then(x=>x.Grade=Grade.Gold);
        };

        private Because of = () => subject.apply(account);
        protected static Rules<Account> subject;
        protected static Account account;
   _}

    public class When_charge_less_100:Account_with_memebership_rules
    {
        private Establish context = () => account.Charge(20);
        private It membership_should_be_regular = () => account.Grade.ShouldEqual(Grade.Regular);
    }

     public class When_charge_100:Account_with_memebership_rules
    {
        private Establish context = () => account.Charge(100);
        private It membership_should_be_silver = () => account.Grade.ShouldEqual(Grade.Silver);
    }
}