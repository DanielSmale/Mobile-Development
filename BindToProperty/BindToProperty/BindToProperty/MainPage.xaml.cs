using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BindToProperty
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        Model dataModel = new Model();
        int count = 0;


        public MainPage()
        {
            InitializeComponent();

            MyLabel.BindingContext = dataModel;

            MyLabel.SetBinding(Label.TextProperty, "NumberAsString", BindingMode.OneWay);

        }

        private void MyButton_Clicked(object sender, EventArgs e)
        {
            count += 1;
            var str = $"{count}";
            dataModel.NumberAsString = str;
        }
    }
}
