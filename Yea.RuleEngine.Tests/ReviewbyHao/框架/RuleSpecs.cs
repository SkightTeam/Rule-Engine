using Machine.Specifications;

namespace Yea.RuleEngine.Tests.ReviewbyHao.求源.框架
{
    public class For_a_rule_against_mock
    {
         

        private Establish context = () =>
                                 {
                                     subject = Rule<Mock>
                                         .New()
                                         .when(x => x.Condition == 1)
                                         .then(x => x.Result = "1");
                                 };


        protected static Rule<Mock> subject;
        protected static Mock mock; 

        protected class Mock
        {
            public int Condition { get; set; }
            public string Result { get; set; }
        }
    }

    public class when_condition_meet_1:For_a_rule_against_mock
    {
        private Establish context = () => mock = new Mock {Condition = 1};
        private Because of = () => subject.apply(mock);
        private It result_should_set_to_1 = () => mock.Result.ShouldEqual("1");

    }

    public class when_condition_does_not_meet_1 : For_a_rule_against_mock {
        private Establish context = () => mock = new Mock { Condition = 2 };
        private Because of = () => subject.apply(mock);
        private It result_should_set_to_1 = () => mock.Result.ShouldNotEqual("1");
        
    }


}