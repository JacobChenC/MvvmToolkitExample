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
    public partial class MainWindowViewModel : ObservableObject
    {
        public MainWindowViewModel()
        {
            WeakReferenceMessenger.Default.Register<ContentChangeMessage>(this, (r, m) =>
            {
                Content = m.Content;
            });
        }

        private int times = 0;

        [ObservableProperty]
        private string content = "通过MVVM方式，将字符串属性绑定到控件内容上";

        //当 Content 属性被修改后（赋值后），会调用该方法。
        partial void OnContentChanged(string? oldValue, string newValue)
        {
            times++;
            content = $"{newValue} : { times }";
        }

        [RelayCommand]
        private void ChangeContent()
        {
            Content = "Content 已通过命令方式修改";
        }

        [RelayCommand]
        private void ChangeContentWithParam(string msg)
        {
            Content = msg;
        }

        [RelayCommand]
        private void SendMessage(string msg)
        {
            WeakReferenceMessenger.Default.Send(new ContentChangeMessage(msg));
        }

    }


}
