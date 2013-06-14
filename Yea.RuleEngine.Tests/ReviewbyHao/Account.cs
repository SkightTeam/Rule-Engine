using Yea.RuleEngine.Tests.ReviewbyHao.求源.框架;

namespace Yea.RuleEngine.Tests.ReviewbyHao.求源
{
    public class Account
    {
        private Rules<Account> membership_rule;

        public Account()
        {
            membership_rule =
                Rules<Account>
                    .when(x => x.ChargeAmount < 100).then(x => x.Grade = Grade.Regular)
                    .when(x => x.ChargeAmount >= 100 && x.ChargeAmount < 1000).then(x => x.Grade = Grade.Silver)
                    .when(x => x.ChargeAmount > 1000).then(x => x.Grade = Grade.Gold)
                    .done();
        }

        public int Balance { get; private set; }
        public int ChargeAmount { get; set; }
        public virtual Grade Grade { get; set; }
        

        public int Discount
        {
            get
            {
                switch (Grade)
                {
                    case Grade.Regular:
                        return 100;
                    case Grade.Silver:
                        return 95;
                }
                return 100;
            }
        }

        public void Charge(int i)
        {
            ChargeAmount += i;
            Balance += i;

            membership_rule.apply(this);
        }
        
        public void Consume(int i)
        {
            Balance -= i;
        }
    }
    public enum Grade
    {
        Regular = 0,
        Silver,
        Gold,
        Platinum,
        Diamond
    }
}