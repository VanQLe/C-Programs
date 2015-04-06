using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Chap_2_ex4_change_lable
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e) {
            if(checkBox.IsChecked == true){
               myLabel.Text = "The box is checked";
               myLabel.HorizontalAlignment = HorizontalAlignment.Right;
            }
            else{
               myLabel.Text = "Checked Box is unchecked";
               myLabel.HorizontalAlignment = HorizontalAlignment.Left;
            }
                
         
        }//end button click method
    }
}
