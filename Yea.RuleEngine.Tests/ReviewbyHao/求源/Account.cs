namespace Yea.RuleEngine.Tests.ReviewbyHao.��Դ
{
    public class Account
    {
        public void Charge(int i)
        {
            Balance += i;
        }

        public int Balance { get; private set; }

        public void Consume(int i)
        {
            Balance -= i;
        }
    }
}