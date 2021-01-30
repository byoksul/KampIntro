using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Student : IPerson
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FİrstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Departman { get; set; }

    }
}
