using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmToolkitExample
{
    public class ContentChangeMessage
    {
        public ContentChangeMessage(string msg)
        {
            Content = msg;
        }
        //消息内容
        public string Content;
    }
}
