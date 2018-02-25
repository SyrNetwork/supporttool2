using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using NewClientRegistrator.Model;
using System.Collections.ObjectModel;

namespace NewClientRegistrator.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<SelendaModel.configuration> _accountsConfig;
        public ObservableCollection<SelendaModel.configuration> AccountsConfig
        {
            get
            {
                return _accountsConfig;
            }
            set
            {
                if (_accountsConfig == value)
                    return;
                _accountsConfig = value;
                OnPropetyChanged(nameof(AccountsConfig));
            }
        }
        public MainWindowViewModel()
        {
            var testpath = ConfigurationManager.AppSettings["configPath"];
            var testConfig = Path.Combine(testpath, "Helix.Console.Selenda.exe.config");
            var config = XDocument.Load(testConfig);
            //var query = from k in config.Root.Descendants("");
            var parsedXml = XmlDeserializetorToObject<SelendaModel.configuration>(testConfig);            
        }
        public void OnPropetyChanged(string propetyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propetyName));
            }
        }
        
        public static T XmlDeserializetorToObject<T> (string pathName)
        {
            T returnObject = default(T);
            if (string.IsNullOrEmpty(pathName)) return returnObject;
            try
            {
                var xmlStream = new StreamReader(pathName);
                var serializer = new XmlSerializer(typeof(T));
                returnObject = (T)serializer.Deserialize(xmlStream);
            }
            catch (Exception ex)
            {
                
            }
            return returnObject;
        }
    }


}

    



