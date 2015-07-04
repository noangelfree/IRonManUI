using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRonManUI.Core.Helpers
{
    public class LinkCollection : ObservableCollection<Link>
    {
        public LinkCollection()
        {

        }

        public LinkCollection(IEnumerable<Link> links)
        {
            if(links == null)
            {
                throw new ArgumentNullException("links");
            }
            foreach(var link in links)
            {
                Add(link);
            }
        }
    }
}
