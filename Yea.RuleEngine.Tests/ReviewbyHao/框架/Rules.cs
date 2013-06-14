using System;
using System.Collections.Generic;
using System.Linq;

namespace Yea.RuleEngine.Tests.ReviewbyHao.求源.框架
{
    public class Rules<T>
    {
        public static RulesFactory<T> when(Predicate<T> predicate) 
        {
            return new RulesFactory<T>().when(predicate);
        }
        private IEnumerable<Rule<T>> rule_list;


        public Rules(IEnumerable<Rule<T>> ruleList) {
            rule_list = ruleList;
        }

        public void apply(T target)
        {
            foreach (var rule in rule_list)
            {
                rule.apply(target);
            }
        }
    }

    public class RulesFactory<T>
    {
        private RuleFactory<T> rule_factory;
        private IList<Rule<T>> rule_list=new List<Rule<T>>(); 
        public RulesFactory<T> when(Predicate<T> predicate) 
        {
            rule_factory=new RuleFactory<T>();
            rule_factory.when(predicate);
            return this;
        }

        public RulesFactory<T> then(Action<T> action)
        {
            rule_list.Add(rule_factory.then(action));
            return this;
        }
        public Rules<T> done()
        {
            return new Rules<T>(rule_list);
        }
    }
}