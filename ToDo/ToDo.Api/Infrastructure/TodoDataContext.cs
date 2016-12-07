using System;
using System.Collections.Generic;
using System.Data.Entity;
using ToDo.Api.Models;
using System.Linq;
using System.Web;

namespace ToDo.Api.Infrastructure
{
    public class TodoDataContext : DbContext
    {
        public TodoDataContext() : base ("Todos")
        {

        }
       

        public System.Data.Entity.DbSet<ToDo.Api.Models.Todo> Todoes { get; set; }
    }
}