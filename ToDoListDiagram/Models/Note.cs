using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListDiagram
{
    internal class Note
    {
        private long _id;
        public long Id { get => _id; set => _id = value; }
        public string Name { get; set; }

        public Group Group { get; set; }
        public ISet<Tag> Tags { get; set; }
    }
}
