using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListDiagram.Models
{
    internal class Group
    {
        public Group(long id, string name, User user, ISet<Tag>? tags, ISet<Note>? notes)
        {
            Id = id;
            Name = name;
            User = user;
            Tags = tags;
            Notes = notes;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
        public ISet<Tag>? Tags { get; set; }
        public ISet<Note>? Notes { get; set; }
    }
}
