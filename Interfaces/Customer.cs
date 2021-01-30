using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Customer : IPerson
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FİrstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Address { get; set; }

    }


}
