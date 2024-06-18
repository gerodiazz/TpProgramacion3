using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Base.Entity;

namespace Domain.Base
{
    public class Entity
    {
        public abstract class Entity<TIdType> : IEntity<TIdType> where TIdType : IComparable
        {
            public abstract TIdType GetId();
        }
    }
}
