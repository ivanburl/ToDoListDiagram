using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListDiagram.Models
{
    internal class User
    {
        private string? _password;

        public User(long id, string name, string password, ISet<Group>? groups, ISet<Tag>? tags)
        {
            Id = id;
            Name = name;
            Password = password;
            Groups = groups;
            Tags = tags;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Password { set => _password = value; }

        public ISet<Group>? Groups { get; set; }
        public ISet<Tag>? Tags { get; set; }

        public bool comparePasswords(string password)
        {
            return password.Equals(_password);
        }
    }
}
