using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAppNew.ViewModels
{
    public class EditUserViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }
        public string Id { get; internal set; }
    }
}
