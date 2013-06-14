using System;

namespace Yea.RuleEngine.Tests.ReviewbyHao.求源.框架
{
    public class Rules<T>
    {
        public static Rules<T> Create()
        {
            return new Rules<T>();
        }

        public Rule<T> when(Predicate<T> predicate)
        {
            return new RulesFactory<T>();
        }
    }

    public class RulesFactory<T>
    {
        
    }
}