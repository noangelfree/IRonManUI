using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRonManUI.Core.Helpers
{
   public class Link : Displayable
    {
        private Uri source;

        public Uri Source
        {
            get { return this.source; }
            set
            {
                if (this.source != value)
                {
                    this.source = value;
                    OnPropertyChanged("Source");
                }
            }
        }
    }
}
