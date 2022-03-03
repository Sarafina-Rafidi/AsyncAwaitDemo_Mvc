using System.Diagnostics;

namespace AsyncAwaitDemo_Mvc
{
    public class ContentManagement
    {
        //a simple demo class that imitates having some long running calls

        public string GetContent()
        {
            Thread.Sleep(2000);
            return "content";
        }

        public int GetCount()
        {
            Thread.Sleep(5000);
            return 4;
        }

        public string GetName()
        {
            Thread.Sleep(3000);
            return "Matthew";
        }





        public async Task<string> GetContentAsync()
        {
            await Task.Delay(10000);
            Debug.WriteLine("task delay 10000");
            return "content";
        }

        public async Task<int> GetCountAsync()
        {
            await Task.Delay(1000);
            Debug.WriteLine("task delay 1000");
            return 4;
        }

        public async Task<string> GetNameAsync()
        {
            await Task.Delay(1000);
            Debug.WriteLine("task delay 1000");
            return "Matthew";
        }
    }
}
