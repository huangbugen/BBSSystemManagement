using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Youshow.Ace.Ability.Services;
using Youshow.Ace.Http.Client;

namespace BBSSystemManagement.Ability.Docking.OtherService.UserApp
{
    [HttpClientServicer(HttpClientType.NormalClient)]
    public interface IUserService : IAbilityServicer
    {
        [RemoteActionName("user-names")]
        Task<Dictionary<string, string>> GetUserNameAsync(params string[] userIdentities);
    }
}