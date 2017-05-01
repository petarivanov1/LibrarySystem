using System;
using LibrarySystem.Data.Models.Contracts;

namespace LibrarySystem.Data.Models.Models
{
    public class Publisher : IPublisher
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
