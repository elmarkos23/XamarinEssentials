using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentials
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageTextToSpeech : ContentPage
	{
		public PageTextToSpeech()
		{
			InitializeComponent();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync(EntryTexto.Text);
        }
    }
}