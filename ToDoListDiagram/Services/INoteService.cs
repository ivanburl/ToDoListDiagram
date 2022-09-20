using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListDiagram.Models;

namespace ToDoListDiagram.Services
{
    internal interface INoteService
    {
        public Note getById();
    }
}
