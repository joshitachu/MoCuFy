using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoCuFy.Models
{
    public  class PaginationModel:NotifyPropertyChanged
    {
        private int _Page;
        public int Page
        {
            get { return _Page; }
            set { _Page = value; OnPropertyChanged("Page"); }
        }
        private bool _isSelected = false;
        public bool isSelected
        {
            get { return _isSelected; }
            set { _isSelected = value; OnPropertyChanged("isSelected"); }
        }

        private string _txtPage;
        public string txtPage
        {
            get { return _txtPage; }
            set { _txtPage = value; OnPropertyChanged("txtPage"); }
        }
    }
}
