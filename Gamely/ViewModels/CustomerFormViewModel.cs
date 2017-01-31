using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gamely.Models;

namespace Gamely.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}