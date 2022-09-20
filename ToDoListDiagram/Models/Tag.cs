using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListDiagram.Models
{
    internal class Tag
    {
        public Tag(long id, string name, User user, ISet<Note>? notes, ISet<Group>? groups)
        {
            Id = id;
            Name = name;
            User = user;
            Notes = notes;
            Groups = groups;
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public User User { get; set; }
        public ISet<Note>? Notes { get; set; }
        public ISet<Group>? Groups { get; set; }
    }
}
