namespace Yea.RuleEngine.Tests.ReviewbyHao.ว๓ิด
{
    public class Account
    {
        public int Balance { get; private set; }
        public int ChargeAmount { get; set; }
        public virtual Grade Grade
        {
            get
            {
                if(ChargeAmount<100)
                    return Grade.Regular;
                if(ChargeAmount>=100)
                    return Grade.Silver;

                return Grade.Regular;
            }
        }

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