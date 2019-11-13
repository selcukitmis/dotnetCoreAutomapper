using System;
using System.Collections.Generic;

namespace VM
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public City City { get; set; }

        public ICollection<Token> Tokens { get; set; }

    }

    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }
    }

    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class Token
    {
        public int Id { get; set; }

        public string Value { get; set; }

        public bool IsActive { get; set; }
    }
}