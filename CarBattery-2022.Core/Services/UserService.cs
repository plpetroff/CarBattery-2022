namespace CarBattery_2022.Core.Service
{
    using CarBattery_2022.Core.Contracts;
    using CarBattery_2022.Core.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UserService : IUserService
    {
        public async Task<IEnumerable<UserListViewModel>> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
