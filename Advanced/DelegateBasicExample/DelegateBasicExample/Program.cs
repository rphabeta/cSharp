namespace DelegateBasicExample
{
    //delegate void LogDel(string text);
    class Program
    {
        delegate void LogDel(string text);

        static void Main(string[] args)
        {
            // ver1 : static 메서드 직접 받아보기
            //LogDel logDel = new LogDel(LogTextToScreen);
            //LogDel logDel = new LogDel(LogTextTOFile);

            // ver2 : 인스턴스를 통해 메서드 받아보기
            Log log = new Log();
            //LogDel logDel = new LogDel(log.LogTextToScreen);
            LogDel logDel = new LogDel(log.LogTextToFile);

            // ver3 : 멀티케스트 델리게이트 사용
            LogDel LogTextToScreenDel, LogTextTOFileDel;

            LogTextToScreenDel = new LogDel(log.LogTextToScreen);
            LogTextTOFileDel = new LogDel(log.LogTextToFile);

            LogDel multiLogDel = LogTextToScreenDel + LogTextTOFileDel;

            //logDel("text");
            //logDel.Invoke("text");

            Console.WriteLine("Please enter your name");

            var name = Console.ReadLine();

            // ver1, ver2 델리게이트 사용
            logDel(name);
            // ver3 델리게이트 사용
            multiLogDel(name);
            // ver4 델리게이트를 파라미터로 전달
            LogText(multiLogDel, name);

            Console.ReadKey();
        }

        // 델리게이트를 파라미터로 전달
        static void LogText(LogDel logDel, string text)
        {
            logDel(text);
        }

        static void LogTextToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");

        }

        static void LogTextTOFile(string text)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
            {
                sw.WriteLine($"{DateTime.Now}: {text}");
            }
        }
    }
    // delegate를 통해 인스턴스 받아보기
    public class Log
    {
        // 인스턴스 메서드가 되는지 확인을 위해 static 제거
        public void LogTextToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");

        }

        public void LogTextToFile(string text)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
            {
                sw.WriteLine($"{DateTime.Now}: {text}");
            }
        }
    }
}