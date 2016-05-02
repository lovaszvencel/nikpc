using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikpc.Interfaces
{
    public interface ILogInHandler
    {
        User LogInAuthentication(string username, string password);
    }
}
