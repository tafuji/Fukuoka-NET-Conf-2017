using HelloVsToolWindow.Control;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloVsToolWindow.Control.Models
{
    public class NewsItem : BindableBase
    {
        private string titile;
        public string Title
        {
            get { return titile; }
            set { SetProperty(ref titile, value); }
        }

        private object icon;
        public object Icon
        {
            get { return icon; }
            set { SetProperty(ref icon, value); }
        }

        private Uri uri;
        public Uri Uri
        {
            get { return uri; }
            set { SetProperty(ref uri, value); }
        }

        private string summary;
        public string Summary
        {
            get { return summary; }
            set { SetProperty(ref summary, value); }
        }

        private DelegateCommand openCommand;
        public DelegateCommand OpenCommand => openCommand ?? (openCommand = new DelegateCommand(OpenUrlComamndExecute, CanOpenUrlComamndExecute));

        private bool CanOpenUrlComamndExecute()
        {
            return true;
        }

        private void OpenUrlComamndExecute()
        {
            if (this.Uri == null) return;
            System.Diagnostics.Process.Start(this.Uri.ToString());
        }

    }
}
