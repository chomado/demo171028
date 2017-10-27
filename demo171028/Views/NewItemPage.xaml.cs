using System;

using Xamarin.Forms;
using Microsoft.Azure.Mobile.Analytics;
using System.Collections.Generic;

namespace demo171028
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();

            Item = new Item
            {
                Text = "Item name",
                Description = "This is an item description."
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            Analytics.TrackEvent(
                name: "新規アイテム追加", 
                properties: new Dictionary<string, string> {
                    { "name", $"{Item.Text}"}
                }
            );
            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopToRootAsync();
        }
    }
}
