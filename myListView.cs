using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;



namespace Fp
{
    [Activity(Label = "Visited Places")]
    public class myListView : Activity
    {
        List<TableItem> tableItems = new List<TableItem>();
        ListView listView;
        HomeScreenAdapter homeAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.myListView);

            listView = FindViewById<ListView>(Resource.Id.countryList);

            tableItems.Add(new TableItem() { Heading = "HAWAI", SubHeading = "BEAUTY OF BEACHES", ImageResourceId = Resource.Drawable.hawai1 });
            tableItems.Add(new TableItem() { Heading = "PETER ISLAND", SubHeading = "SUNSHINE ON ISLAND", ImageResourceId = Resource.Drawable.peter_island });
            tableItems.Add(new TableItem() { Heading = "TOKYO", SubHeading = "CITY OF HEIGHT", ImageResourceId = Resource.Drawable.tokyo });
            tableItems.Add(new TableItem() { Heading = "MUMBAI", SubHeading = "BOLLYWOOD", ImageResourceId = Resource.Drawable.mumbai });
            tableItems.Add(new TableItem() { Heading = "PARIS", SubHeading = "CITY OF LOVE", ImageResourceId = Resource.Drawable.PARIS });
            homeAdapter = new HomeScreenAdapter(this, tableItems);

            listView.Adapter = homeAdapter;
            listView.ItemClick += OnListItemClick;
        }

        protected void OnListItemClick(object sender, Android.Widget.AdapterView.ItemClickEventArgs e)
        {
            var listView = sender as ListView;
            var t = tableItems[e.Position];
            Toast.MakeText(this,t.ToString(),ToastLength.Long).Show();
            Intent intent = new Intent(this,typeof(hawai));
            StartActivity(intent);
        }
    }
}
