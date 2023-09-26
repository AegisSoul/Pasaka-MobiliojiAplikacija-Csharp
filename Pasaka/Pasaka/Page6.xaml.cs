using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pasaka
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page6 : ContentPage
	{
		public Page6 ()
		{
			InitializeComponent ();
		}
        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page7());
        }
        private async void NavigateButton_OnClicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page5());
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("whale.mp3");
            player.Play();

        }
    }
}