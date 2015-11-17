using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGrounds.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private string _searchQuery;
        private string _searchResults;

        public string SearchQuery
        {
            get
            {
                return _searchQuery;
            }

            set
            {
                var results = $"{value} - {value}";
                SetProperty(ref _searchQuery, value);
                SetProperty(ref _searchResults, results);
                RaisePropertyChanged(() => SearchQuery);
                RaisePropertyChanged(() => SearchResults);
            }
        }

        public string SearchResults
        {
            get { return _searchResults; }
        }
    }
}
