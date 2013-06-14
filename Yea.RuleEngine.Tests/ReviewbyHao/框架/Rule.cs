using System;

namespace Yea.RuleEngine.Tests.ReviewbyHao.求源.框架
{
    public class Rule<T>
    {
        public static Rule<T> New()
        {
            return new Rule<T>();
        }

        private Predicate<T> predicate;
        private Action<T> action;

        public Rule<T> when(Predicate<T> predicate)
        {
            this.predicate = predicate;
            return this;
        }
        public Rule<T> then(Action<T> action)
        {
            this.action = action;
            return this;
        }

        public void apply(T target)
        {
            if (predicate(target))
                action(target);
        }
    }
}