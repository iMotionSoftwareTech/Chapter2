using System;

namespace Chapter2.Shared
{
    public class Address
    {
        public string? Building { get; set; }

        public string Street { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string Region { get; set; } = string.Empty;
    }
}
