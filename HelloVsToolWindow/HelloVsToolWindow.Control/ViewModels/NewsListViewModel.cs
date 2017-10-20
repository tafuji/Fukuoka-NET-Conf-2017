using HelloVsToolWindow.Control.Models;
using HelloVsToolWindow.Control.Service;
using MahApps.Metro.IconPacks;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HelloVsToolWindow.Control.ViewModels
{
    public class NewsListViewModel : BindableBase
    {
        public NewsListViewModel()
        {
            this.Initialize();
        }

        private void Initialize()
        {
            tileNewsItems = new ObservableCollection<NewsItem>();
        }

        #region Properties
        private ObservableCollection<NewsItem> tileNewsItems;
        public ObservableCollection<NewsItem> TileNewsItems
        {
            get
            {
                return tileNewsItems;
            }
            set
            {
                SetProperty(ref tileNewsItems, value);
            }
        }

        private string url;
        public string Url
        {
            get { return url; }
            set
            {
                SetProperty(ref url, value);
            }
        }
        #endregion

        private DelegateCommand goCommand;
        public DelegateCommand GoCommand => goCommand ?? (goCommand = new DelegateCommand(GoGommandExecute, CanGoExecute));

        private bool CanGoExecute()
        {
            return true;
        }

        private async void GoGommandExecute()
        {
            tileNewsItems.Clear();
            using (XmlReader reader = XmlReader.Create(this.Url))
            {
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                foreach(var item in feed.Items)
                {
                    tileNewsItems.Add(new NewsItem()
                    {
                        Title = item?.Title.Text,
                        Uri = item?.Links[0].Uri,
                        Summary = item.Summary?.Text,
                        Icon = new PackIconFontAwesome()
                        {
                            Kind = PackIconFontAwesomeKind.NewspaperOutline,
                            Height = 40,
                            Width = 40
                        }
                    });
                }
            }
        }
    }
}
