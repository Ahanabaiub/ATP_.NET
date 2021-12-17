using System;

namespace E_Sheba.Controllers
{
    internal class MapperConfiguration
    {
        private Action<object> p;

        public MapperConfiguration(Action<object> p)
        {
            this.p = p;
        }
    }
}