using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmToolkitExample
{
    public partial class MessagerWindowViewModel : ObservableObject
    {
        public MessagerWindowViewModel()
        {
            WeakReferenceMessenger.Default.Register<ContentChangeMessage>(this, (r, m) =>
            {
                Content = m.Content;
            });
        }

        [ObservableProperty]
        private string content = "内容";

     }


}
