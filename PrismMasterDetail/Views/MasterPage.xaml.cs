using Xamarin.Forms;

namespace PrismMasterDetail.Views
{
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listView.SelectedItem != null)
            {
                listView.SelectedItem = null;
            }
        }
    }

    public class MasterItem
    {
        public string Title { get; set; }

        public string Path { get; set; }
    }
}

