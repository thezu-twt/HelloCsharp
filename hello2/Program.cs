/* 2021/01/20 programming learning
 * 2nd c#
 */
using System; //包裝Console,WriteLine等,也可以打System.Console,WriteLine
namespace hello2 //namespace(命名空間):相關函式的內容集中,以便跟其他的程式作區分,可以都有叫Program,Main的類別
{
    class Program //類別 entry point
    {
        static void Main(string[] args) //宣告主程式開頭;Main呼叫寫好的函式
        {
            string message; //宣告變數 string(字串)為message
            message = "hello"; //=::=assign(設定)：hello放進message中代表的記憶區域(unit code)
            Console.WriteLine(message); //Console(類別):keyboard(鍵盤),screen(主控台視窗螢幕);WriteLine顯示寫好的字串(output)在螢幕上面
        }
    }
}

