using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShaBoo.Entities;

namespace ShaBoo.Web.ViewModels
{
    public class HomeViewModel
    {
        public RoleViewModel Role { get; set; }
    }

    public class RoleViewModel
    {
        private IEnumerable<Role> Roles { get; set; }
    }
}