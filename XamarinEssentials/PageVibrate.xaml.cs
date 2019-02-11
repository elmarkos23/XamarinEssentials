using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentials
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageVibrate : ContentPage
	{
		public PageVibrate ()
		{
			InitializeComponent ();
		}

        private void Vibrar_Clicked(object sender, EventArgs e)
        {
            try
            {
                Vibration.Cancel();
            }
            catch (FeatureNotSupportedException ex)
            {
                // Feature not supported on device
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }
    }
}