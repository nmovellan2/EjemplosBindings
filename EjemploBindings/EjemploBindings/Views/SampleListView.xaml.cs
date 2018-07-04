using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EjemploBindings.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SampleListView : ContentPage
	{
		public SampleListView ()
		{
			InitializeComponent ();

            List<string> items = new List<string>();
            for(int i = 0;i<100;i++)
            {
                items.Add("iTEM" + i);
            }

            listView.ItemsSource = items;
		}
	}
}