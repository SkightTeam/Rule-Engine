namespace Yea.RuleEngine.Tests.ReviewbyHao.ว๓ิด
{
    public class Account
    {
        public int Balance { get; private set; }
        public Grade Grade { get; private set; }
        public int Discount { get; private set; }

        public void Charge(int i)
        {
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