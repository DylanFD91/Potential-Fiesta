using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace AsyncExample
{
    public class ContentManagement
    {
        public string GetContent()
        {
            Thread.Sleep(2000);
            return "This is some content";
        }

        public int GetCount()
        {
            Thread.Sleep(5000);
            return 4;
        }

        public string GetName()
        {
            Thread.Sleep(3000);
            return "Michael";
        }
        public async Task<string> GetContentAsync()
        {
            await Task.Delay(2000);
            return "This is some content";
        }

        public async Task<int> GetCountAsync()
        {
            await Task.Delay(5000);
            return 4;
        }

        public async Task<string> GetNameAsync()
        {
            await Task.Delay(3000);
            return "Michael";
        }
    }
}