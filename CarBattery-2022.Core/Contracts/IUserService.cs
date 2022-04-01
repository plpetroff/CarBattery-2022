namespace CarBattery_2022.Core.Contracts
{
    using CarBattery_2022.Core.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IUserService
    {
        Task<IEnumerable<UserListViewModel>> GetUsers();



    }
}
