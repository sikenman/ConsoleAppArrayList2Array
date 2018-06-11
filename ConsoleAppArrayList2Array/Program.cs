using System;
using System.Collections;

namespace ConsoleAppArrayList2Array
{
    /// <author>Siken M. Dongol</author>
    /// <datecreated>6/11/2018</datecreated>
    /// <summary>Console application to convert ArrayList to 2D Array with given column size</summary>
    /// 
    class Program
    {
        public const int BLOCK_COLUMN_SIZE = 7;

        static void Main(string[] args)
        {
            ArrayList MyArrayList = new ArrayList
            {
                "4feeeae6-a469-e811-8116-00155dce4461",
                "f052dc44-a569-e811-8116-00155dce4462",
                "51442479-a569-e811-8116-00155dce4463",
                "52150ea1-a569-e811-8116-00155dce4464",
                "35ea7419-b169-e811-8116-00155dce4465",
                "7451c36b-b869-e811-8116-00155dce4466",
                "cf42a857-b969-e811-8116-00155dce4467",

                "c0ed638e-b969-e811-8116-00155dce4468",
                "85a89eb2-b969-e811-8116-00155dce4469",
                "265dc677-ba69-e811-8116-00155dce446a",
                "bbe8d2c4-ba69-e811-8116-00155dce446b",
                "54aae8aa-bb69-e811-8116-00155dce446c",
                "cf7fd5d4-bb69-e811-8116-00155dce446d",
                "69dc55fd-bb69-e811-8116-00155dce446e",

                "0141932d-c569-e811-8116-00155dce446f",
                "7f34155d-c569-e811-8116-00155dce4470",
                "537ee6b0-c669-e811-8116-00155dce4471",
                "4e9bc1d4-c669-e811-8116-00155dce4472",
                "eacb9b53-c769-e811-8116-00155dce4473",
                "dce84e70-c869-e811-8116-00155dce4474",
                "77abfbb5-c869-e811-8116-00155dce4475",

                "f49eb625-896a-e811-8116-00155dce4476",
                "6f5a9b53-896a-e811-8116-00155dce4477",
                "5b1bdc83-896a-e811-8116-00155dce4478",
                "9a961dae-896a-e811-8116-00155dce4479",
                "46b1b6d7-896a-e811-8116-00155dce447a",
                "b39def72-8d6a-e811-8116-00155dce447b",
                "c39def72-8d6a-e811-8117-00155dce447c",

                "c39def72-8d6a-e811-8117-00155dce447d",
                "c39def72-8d6a-e811-8117-00155dce447e",
            };

            Console.WriteLine($"\nTotal items in ArrayList : {MyArrayList.Count}");

            float totalBlocks = (float)MyArrayList.Count / BLOCK_COLUMN_SIZE;
            int IntTotalRows = (int)Math.Ceiling(totalBlocks);

            Console.WriteLine($" Required Rows (Blocks)  : {IntTotalRows}");
            Console.WriteLine();

            // Initialization of the 2D Array
            string[,] My2DArray = new string[IntTotalRows, BLOCK_COLUMN_SIZE];

            ConvertArrayListTo2DArray(MyArrayList, My2DArray, BLOCK_COLUMN_SIZE);
            Print2DArray(My2DArray, IntTotalRows, BLOCK_COLUMN_SIZE);

            Console.WriteLine(" My2DArray    Row : " + My2DArray.GetLength(0));
            Console.WriteLine(" My2DArray Column : " + My2DArray.GetLength(1));
            Console.ReadKey();
        }

        public static void ConvertArrayListTo2DArray(ArrayList MyArrayList, string[,] My2DArray, int BlockColumnSize)
        {
            int Row = 0;
            int Column = 0;

            for (int i = 0; i < MyArrayList.Count; i++)
            {
                // Very Important LOGIC
                if (Column == BlockColumnSize)
                {
                    Row++;
                    Column = 0; // Reset Column
                }

                if (Column < BlockColumnSize)
                {
                    My2DArray[Row, Column] = MyArrayList[i].ToString();
                    Column++;
                }
            }
        }

        public static void Print2DArray(string[,] My2DArray, int RowSize, int ColumnSize)
        {
            int Sn = 1;
            // Print the 2D Array
            for (int row = 0; row < RowSize; row++)
            {
                for (int col = 0; col < ColumnSize; col++)
                {
                    Console.Write(" {0,2:00}", Sn);  // Adds leading zeros to Sn like 02,03
                    Console.WriteLine($". [{row},{col}] " + My2DArray[row, col]);
                    Sn++;
                }
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
