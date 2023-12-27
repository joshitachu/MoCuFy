using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoCuFy.Models
{
    public  class SongsModel:NotifyPropertyChanged
    {
        private int _songId;
        public int songId
        {
            get { return _songId; }
            set { _songId = value; OnPropertyChanged("songId"); }
        }

        private string _songName;
        public string songName
        {
            get { return _songName; }
            set { _songName = value; OnPropertyChanged("songName"); }
        }
        private string _genre;
        public string genre
        {
            get { return _genre; }
            set { _genre = value; OnPropertyChanged("genre"); }
        }
        private string _artist;
        public string artist
        {
            get { return _artist; }
            set { _artist = value; OnPropertyChanged("artist"); }
        }

        private TimeSpan _duration;
        public TimeSpan duration
        {
            get { return _duration; }
            set { _duration = value; OnPropertyChanged("duration"); }
        }

        private DateTime _releaseDate;
        public DateTime releaseDate
        {
            get { return _releaseDate; }
            set { _releaseDate = value; OnPropertyChanged("releaseDate"); }
        }

        private bool _isSelected = false;
        public bool isSelected
        {
            get { return _isSelected; }
            set { _isSelected = value; OnPropertyChanged("isSelected"); }
        }

        public SongsModel()
        {

        }
    }
}
