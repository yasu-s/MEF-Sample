using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMef.ViewModel
{
    [WpfMef.Attributes.ViewModeElxport("Main")]
    public class MainViewModel : ViewModelBase
    {

        private string label = "label";

        private string text = "text";

        public string Label
        {
            get { return label; }
            set
            {
                label = value;
                OnPropertyChanged(nameof(Label));
            }
        }

        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged(nameof(Text));
            }
        }
    }
}
