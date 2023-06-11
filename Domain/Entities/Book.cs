using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Book : BaseEntity, IAggregateRoot
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
