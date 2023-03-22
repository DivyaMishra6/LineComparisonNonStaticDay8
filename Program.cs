using PipeLineNonStaticDay8;

namespace LineProgram
{
    public class Line
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Print Line Length");

            //CalculateLength_UC1.call();
            //ComparisionTwoLine_UC2.Call();
            //LineIs_Greater_UC3.Call();

            CalculateLengthUC1 line = new CalculateLengthUC1();
            line.findlength();

            CompareTwoLineUC2 compare = new CompareTwoLineUC2();
            compare.Call();

            LineIsGreaterThanUC3 largest = new LineIsGreaterThanUC3();
            largest.greaterthan();

        }
    }
}