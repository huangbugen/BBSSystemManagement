using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BBSSystemManagement.Ability.Docking.LocalService.AreaApp;
using BBSSystemManagement.Ability.Docking.LocalService.AreaApp.Dto;
using BBSSystemManagement.Ability.Docking.OtherService.UserApp;
using BBSSystemManagement.Domain.Manager;
using BBSSystemManagement.Domain.PostInfo;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Youshow.Ace.Ability;

namespace BBSSystemManagement.Ability.AreaApp
{
    public class AreaService : AbilityServicer, IAreaService
    {
        public IUserService UserService { get; set; }
        public AreaManager AreaMgr { get; set; }

        public async Task<Area> AddAreaAsync(AreaCreateDto createInput)
        {
            var lord = ModelMapper.Map<AreaCreateDto, Area>(createInput);
            var lordIds = createInput.AreaLords.ToArray();
            var userNames = await UserService.GetUserNameAsync(lordIds);
            var res = await AreaMgr.AddAreaAsync(lord, userNames);

            return res;
        }
    }
}