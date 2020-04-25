using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DILifeTime.Services
{
    public class SomeService : ITransientSerivce, IScopedService, ISingletonServie
    {
        private Guid _id;

        public SomeService()
        {
            _id = Guid.NewGuid();
        }

        public Guid GetID()
        {
            return _id;
        }
    }
}