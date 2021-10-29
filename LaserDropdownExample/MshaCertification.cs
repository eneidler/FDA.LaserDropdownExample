using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaserDropdownExample
{
    public class MshaCertification
    {
        public readonly IList<string> MinehaulCertifications = new List<string>()
        {
            "14-CBA100012-MSHA",
            "14-CBA120012-MSHA",
            "14-CBA120013-1-MSHA",
            "14-CBA120024-1-MSHA",
            "14-CBA120026-1-MSHA",
            "14-CBA130004-MSHA",
            "14-CBA130005-MSHA",
            "14-CBA130012-MSHA",
            "14-CBA130013-MSHA",
            "14-CBA180008-MSHA"
        };

        public readonly IList<string> MineflexCertifications = new List<string>()
        {
            "14-CBA090015-MSHA",
            "14-CBA120010-1-MSHA",
            "14-CBA120011-MSHA",
            "14-CBA130011-MSHA",
            "14-CBA150013-MSHA",
            "14-CBA190012-MSHA",
            "14-CBA190014-MSHA",
            "14-CBA200001-MSHA"
        };
    }
}
