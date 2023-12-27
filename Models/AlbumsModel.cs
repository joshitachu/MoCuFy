using MoCuFy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muziekbeheren.Model
{
    public class AlbumsModel : NotifyPropertyChanged
    {
        private int _albumID;
        public int albumID
        {
            get { return _albumID; }
            set { _albumID = value; OnPropertyChanged("albumID"); }
        }
        private string _albumName;
        public string albumName
        {
            get { return _albumName; }
            set { _albumName = value; OnPropertyChanged("albumName"); }
        }

        private string _artist;
        public string artist
        {
            get { return _artist; }
            set { _artist = value; OnPropertyChanged("artist"); }
        }

        private DateTime _releaseDate;
        public DateTime releaseDate
        {
            get { return _releaseDate; }
            set { _releaseDate = value; OnPropertyChanged("releaseDate"); }
        }

        private ObservableCollection<SongsModel> _songs;
        public ObservableCollection<SongsModel> songs
        {
            get { return _songs; }
            set { _songs = value; OnPropertyChanged("songs"); }
        }
    }
}
