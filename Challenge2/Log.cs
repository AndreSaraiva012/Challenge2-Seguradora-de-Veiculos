using System.Reflection;

namespace Challenge2
{
    public class Log
    {
        private static Log instance;

        public static Log Get
        {
            get
            {
                if (instance == null)
                {
                    instance = new Log();
                }
                return instance;
            }
        }

        public void LogInfo(string message)
        {
            string LogPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);


            try
            {
                StreamWriter sw = File.AppendText(LogPath + "\\FicheiroLog.txt");

                sw.WriteLine(DateTime.Now);
                sw.WriteLine(message);
                sw.WriteLine("----------------------------\n");

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }

    }

}
