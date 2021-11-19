using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.ComponentModel.INotifyPropertyChanged;

namespace DownloadManager.Model
{

    class DownloadModel : INotifyPropertyChanged
    {
        #region GettersAndSetters
        private string url = string.Empty;
        private string htmlSourceCode = string.Empty;
        public long timeInterval;
        public const int NUMBER_OF_THREADS = 3;
        public static int NumberOfActiveDownloaders { get; private set; } = 0;
        private static object LockNumberOfActiveDownloaders = new object();

        public string Url{
            get => url;
            set
            {
                url = value;
                RaisePropertyChanged();
            }
        }
        public string HtmlSourceCode
        {
            get => htmlSourceCode;
            set
            {
                htmlSourceCode = value;
                RaisePropertyChanged();
            }
        }
        public long TimeInterval
        {
            get => timeInterval;
            set
            {
                timeInterval = value;
                RaisePropertyChanged();
            }
        }

        #endregion GettersAndSetters

        #region Properties
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion Properties

        

       
    }

}
