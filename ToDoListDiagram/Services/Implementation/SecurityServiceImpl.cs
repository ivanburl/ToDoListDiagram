using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListDiagram.Models;

namespace ToDoListDiagram.Services.Implementation
{
    internal class SecurityServiceImpl : ISecurityService
    {
        public SecurityServiceImpl()
        {
        }

        public bool authenification(User user)
        {
            throw new NotImplementedException();
        }

        public bool autorization(User user, object accessObject)
        {
            throw new NotImplementedException();
        }

        private bool isAdmin(User user)
        {
            return false;
        }
    }
}
