namespace CopyImage
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var cts = new CancellationTokenSource();

            var path = Environment.GetEnvironmentVariable("DATA_PATH");
            //var path = @"D:\test";
            Console.WriteLine("App started...");
            while (!cts.Token.IsCancellationRequested) 
            {
                
                if (path != null)
                {
                    string target = Path.Join(AppContext.BaseDirectory, "Image");
                    if (!Directory.Exists(target))
                    {
                        Directory.CreateDirectory(target);
                    }
                    string[] files = Directory.GetFiles(path);
                    if (files.Count() > 0)
                    {
                        foreach (string file in files)
                        {
                            try
                            {
                                string fileName = Path.GetFileName(file);
                                string targetFile = MainProcess.GenerateFileName(target, fileName);
                                File.Copy(file, targetFile);
                            }
                            catch
                            {

                            }
                        }
                    }
                }
                await Task.Delay(5000); // 模擬每5秒檢查一次
            }
            Console.WriteLine("App stopped.");

        }
    }
}