using System;
using LibrarySystem.Data.Models.Contracts;
using System.Collections.Generic;

namespace LibrarySystem.Data.Models.Models
{
    public class Publisher : IPublisher
    {
        private ICollection<Author> authors;

        public Publisher()
        {
            this.authors = new HashSet<Author>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Author> Author
        {
            get { return this.authors; }
            set { this.authors = value; }
        }
    }
}
