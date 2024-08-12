using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBSSystemManagement.Ability.Docking.LocalService.AreaApp.Dto
{
    public class AreaCreateDto
    {
        public string AreaName { get; set; }
        public int Sort { get; set; }
        public List<string> AreaLords { get; set; }
    }
}