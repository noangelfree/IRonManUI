using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRonManUI.Core.Helpers
{
    public abstract class Displayable : NotifyPropertyChanged
    {
        private string displayName;

        public string DisplayName
        {
            get { return this.displayName; }
            set
            {
                if (this.displayName != value)
                {
                    displayName = value;
                    OnPropertyChanged("DisplayName");
                }
            }
        }
    }
}
