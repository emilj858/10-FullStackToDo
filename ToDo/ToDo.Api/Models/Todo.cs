using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDo.Api.Models
{
    public class Todo
    {
        //Properties
        public int TodoId { get; set; }
        public string Item { get; set; }
        public string Priority { get; set; }

        //Methods
    }
}