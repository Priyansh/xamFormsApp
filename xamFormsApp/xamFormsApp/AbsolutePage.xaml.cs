using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamFormsApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AbsolutePage : ContentPage
	{
		public AbsolutePage()
		{
			InitializeComponent ();

            var layout = new AbsoluteLayout();
            Content = layout;
            var LightBlueBox = new BoxView { BackgroundColor = Color.LightBlue };
            AbsoluteLayout.SetLayoutBounds(LightBlueBox, new Rectangle(0, 0, 1, 1));
            AbsoluteLayout.SetLayoutFlags(LightBlueBox, AbsoluteLayoutFlags.All);
            //NOTE: You can achieve to show box throw below line, hence no need for SetLayoutBounds and SetLayoutFlags
            //layout.Children.Add(LightBlueBox, new Rectangle(0, 0, 1, 1), AbsoluteLayoutFlags.All);
            layout.Children.Add(LightBlueBox);

            var whiteSmokeBox = new BoxView { BackgroundColor = Color.WhiteSmoke };
            //AbsoluteLayout.SetLayoutBounds(whiteSmokeBox, new Rectangle(0.5, 0.1, 100, 100));
            //AbsoluteLayout.SetLayoutFlags(whiteSmokeBox, AbsoluteLayoutFlags.PositionProportional);
            layout.Children.Add(whiteSmokeBox, new Rectangle(0.5, 0.1, 100, 100), AbsoluteLayoutFlags.PositionProportional);

            var whiteSmokeButton = new Button { Text="Get Started", BackgroundColor = Color.WhiteSmoke };
            AbsoluteLayout.SetLayoutBounds(whiteSmokeButton, new Rectangle(0, 1, 1, 50));
            AbsoluteLayout.SetLayoutFlags(whiteSmokeButton, AbsoluteLayoutFlags.PositionProportional | AbsoluteLayoutFlags.WidthProportional);
            layout.Children.Add(whiteSmokeButton);
        }
	}
}