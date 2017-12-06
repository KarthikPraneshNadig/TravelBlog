using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Fp
{
    [Activity(Label = "THIS IS ME")]
    public class BlogAuthorDescription : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.BlogAuthorDescription);

            // Create your application here
            Button showPopupMenu = FindViewById<Button>(Resource.Id.button1);

            showPopupMenu.Click += delegate {
                //Toast.MakeText(this, "hello", ToastLength.Long).Show();

                PopupMenu menu = new PopupMenu(this, showPopupMenu);
                menu.Inflate(Resource.Menu.popup_menu);

                menu.MenuItemClick += (s1, e1) =>
                {
                    



                    switch (e1.Item.TitleFormatted.ToString())
                    {
                        case "Visited Places":
                            StartActivity(typeof(myListView));
                            break;
                            case "Future Destinations":
                             StartActivity(typeof(myListView2));
                            break;
                            case "Contact":
                            StartActivity(typeof(contact));
                            break;
                    }
                };
                menu.Show();


            };

            /*
            showPopupMenu.Click += (s, arg) => {
                
                PopupMenu menu = new PopupMenu (this, showPopupMenu);
                
                // with Android 3 need to use MenuInfater to inflate the menu
                //menu.MenuInflater.Inflate (Resource.Menu.popup_menu, menu.Menu);
                
                // with Android 4 Inflate can be called directly on the menu
                menu.Inflate (Resource.Menu.popup_menu);
                
                menu.MenuItemClick += (s1, arg1) => {
                    Console.WriteLine ("{0} selected", arg1.Item.TitleFormatted);
                    String selection = arg1.Item.TitleFormatted.ToString();
                    Toast.MakeText(this,selection,ToastLength.Long).Show();
                };
                
                // Android 4 now has the DismissEvent
                menu.DismissEvent += (s2, arg2) => {
                    Console.WriteLine ("menu dismissed"); 
                };
                
                menu.Show ();
            };*/
        }
    }
}
 