using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POS_System.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedContainer : TabbedPage
    {
        public TabbedContainer ()
        {
            InitializeComponent();
        }
    }
}