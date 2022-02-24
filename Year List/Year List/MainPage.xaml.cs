using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Year_List
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
          
        }

        void setupYearList()
        {
            for (int i = 1990; i <= 2030; i++)
            {
                Label label = new Label
                {
                    Text = i.ToString(),         
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                };
                yearList.Children.Add(label);
            }

        }
        void onShowYearListButtonClicked(object sender, EventArgs args)
        {
            setupYearList();
        }
    }
}
