using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC_
{
    public class PasswordEntry
    {
        public string Website { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"Website: {Website}, Username: {Username}";
        }
    }
}
