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
    class HomeScreenAdapter : BaseAdapter<TableItem>
    {
        List<TableItem> items;
        Activity context;
        public HomeScreenAdapter(Activity context, List<TableItem> items)
            : base()
        {
            this.context = context;
            this.items = items;
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override TableItem this[int position]
        {
            get { return items[position]; }
        }
        public override int Count
        {
            get { return items.Count; }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];

        
            if (convertView == null) // no view to re-use, create new
            {
                convertView = context.LayoutInflater.Inflate(Resource.Layout.CustomView, null);
            }
            convertView.FindViewById<TextView>(Resource.Id.Text1).Text = item.Heading;
            convertView.FindViewById<TextView>(Resource.Id.Text2).Text = item.SubHeading;
            convertView.FindViewById<ImageView>(Resource.Id.Image).SetImageResource(item.ImageResourceId);

            return convertView;
        }
    }
}