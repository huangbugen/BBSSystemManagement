using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Youshow.Ace.Domain.Models;

namespace BBSSystemManagement.Domain.PostInfo
{
    public class AreaLordUserMapping : BaseModel<string>
    {
        public AreaLordUserMapping(string id) : base(id)
        {

        }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string AreaId { get; set; }
    }
}