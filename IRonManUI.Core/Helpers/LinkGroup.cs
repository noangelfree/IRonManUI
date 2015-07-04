using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRonManUI.Core.Helpers
{
    public class LinkGroup : Displayable
    {
        private string groupKey;
        private Link selectedLink;
        private LinkCollection links = new LinkCollection();
    }
}
