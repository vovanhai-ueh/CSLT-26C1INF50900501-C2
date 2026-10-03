
using System.IO;


namespace CSLT_26C1INF50900501_C2.session09 {
    internal class EX03 {

        static void ReadFileAndPrint(string filePath) {
            try {
                using (StreamReader sr = new StreamReader(filePath)) { //auto-close the file after reading
                    string line;
                    while ((line = sr.ReadLine()) != null) {
                        Console.WriteLine(line);
                    }
                }
            } catch (Exception e) {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public static void WriteText2File(string filePath, string content) {
            try {
                using (StreamWriter sw = new StreamWriter(filePath)) { //auto-close the file after writing
                    sw.WriteLine(content);
                }
            } catch (Exception e) {
                Console.WriteLine("The file could not be written:");
                Console.WriteLine(e.Message);
            }
        }

        public static void Main(string[] args) {
            //string filePath = @"C:\Users\PC\source\repos\vovanhai-ueh\CSLT-26C1INF50900501-C2\ConsoleApp1\session09\Exercises_3.cs";
            string filePath = "output.csv";
            ReadFileAndPrint(filePath);

            /* string text = "This is a sample text to write to the file.";
             WriteText2File("output.txt", text);*/
        }
    }
}
