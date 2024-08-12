using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BBSSystemManagement.Domain.PostInfo;
using Youshow.Ace.Domain.Repository;
using Youshow.Ace.Domain.Services;

namespace BBSSystemManagement.Domain.Manager
{
    public class AreaManager : DomainServicer
    {
        public IRepository<Area> AreaRepo { get; set; }
        public IRepository<AreaLordUserMapping> AreaLordUserMappingRepo { get; set; }

        public async Task<Area> AddAreaAsync(Area area, Dictionary<string, string> dicLords)
        {
            area.InitArea();
            area = await AreaRepo.InsertAsync(area);

            List<AreaLordUserMapping> lords = new();
            foreach (var kv in dicLords)
            {
                lords.Add(new AreaLordUserMapping(SortGuid.NewGuid().ToString("N"))
                {
                    UserId = kv.Key,
                    UserName = kv.Value,
                    AreaId = area.Id
                });
            }

            await AreaLordUserMappingRepo.InsertManyAsync(lords);
            area.AreaPadLords = lords;
            return area;
        }
    }
}