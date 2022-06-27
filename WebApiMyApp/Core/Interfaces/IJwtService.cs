using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IJwtService
    {
        string CreateToken(ApplicationUser user);
        //string CreateRefreshToken();
    }
}
