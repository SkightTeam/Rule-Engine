using Rhino.Mocks;

namespace Machine.Specifications.AutoMocking.Rhino
{
    using System;
    using Core;

    public class RhinoMocksMockFactory : IMockFactory
    {
        #region MockFactory Members

        public Dependency create_stub<Dependency>() where Dependency : class
        {
            return MockRepository.GenerateStub<Dependency>();
        }

        public object create_stub(Type type)
        {
            return MockRepository.GenerateStub(type);
        }

        #endregion
    }
}