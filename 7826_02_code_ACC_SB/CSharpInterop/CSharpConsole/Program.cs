using System;

namespace CSharpConsole
{
    using FSharpLibrary;

    class Program
    {

        static void Main(string[] args)
        {

            //Console.WriteLine($"6 times 7 is {ExportToCSharp.exportedFunction(6, 7)}");
            //Console.WriteLine($"(6 times 7) is {ExportToCSharp.exportedFunctionWithTuple(6, 7)}");

            //var partialFunction = ExportToCSharp.exportedFunction(6);

            //var tuple1 = ExportToCSharp.exportedTuple1;
            //var tuple2 = ExportToCSharp.exportedTuple2;
            //Console.WriteLine($"{tuple1} = {tuple2} is {tuple1 == tuple2}");

            //var tuple3 = new Tuple<string, string, string>("Do", "Re", "Mi");
            //Console.WriteLine($"{tuple1} = {tuple3} is {tuple1 == tuple3}");

            //var valueTuple1 = ExportToCSharp.exportedStructTuple1;
            //var valueTuple2 = ExportToCSharp.exportedStructTuple2;
            //Console.WriteLine($"{valueTuple1} = {valueTuple2} is {valueTuple1 == valueTuple2}");

            //var valueTuple3 = ("Fa", "So", "La");
            //Console.WriteLine($"{valueTuple1} = {valueTuple3} is {valueTuple1 == valueTuple3}");

            //tuple1.Item1 = "NewValue";

            //valueTuple1.Item1 = "NewValue";
            //Console.WriteLine($"{valueTuple1.Item1}, {valueTuple1.Item2}, {valueTuple1.Item3}");

            //var record1 = new ExportToCSharp.ExportedRecord
            //    ("Ti", "So", "Re");

            //var record2 = new ExportToCSharp.ExportedRecord
            //    ("ti", "so", "re");

            //Console.WriteLine($"{record1} = {record2} is {record1 == record2}");

            //record1.FirstNote = "NewValue";

            var union1 = ExportToCSharp.ExportedUnion.NewSingleString("Ti");
            var union2 = ExportToCSharp.ExportedUnion.NewSingleString("Ti");
            Console.WriteLine($"{union1} = {union2} is {union1 == union2}");

            union2 = ExportToCSharp.ExportedUnion.NewTwoBool(true, false);
            Console.WriteLine($"{union1} = {union2} is {union1 == union2}");

            var union2Value1 = (union2 as ExportToCSharp.ExportedUnion.TwoBool).Item1;
            var union2Value2 = (union2 as ExportToCSharp.ExportedUnion.TwoBool).Item2;

            Console.WriteLine($"union2Value1 = {union2Value1} and union2Value2 == {union2Value2}");

            Console.ReadKey();
        }
    }
}
