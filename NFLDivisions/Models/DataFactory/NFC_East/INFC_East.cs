using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public interface INFC_East
    {
        public List<TeamInformation> GetNFCEastTeams(int year);

    }
}
