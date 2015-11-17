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
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using TestingGrounds.Core.ViewModels;

namespace TestingGrounds.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);

            var search = FindViewById<SearchView>(Resource.Id.searchview);
            var text = FindViewById<TextView>(Resource.Id.textview);

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(text).To(vm => vm.SearchResults);
            set.Bind(search).To(vm => vm.SearchQuery);
            set.Apply();
        }
    }
}