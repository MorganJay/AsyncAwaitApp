using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //var program = new Program();
            //var k = program.SendEmailsAsync(10).Result;
            //program.RegisterStudent("140502010");
            DataStructures();
            Console.ReadLine();
        }

        public async Task<int> SendEmailsAsync(int noOfTimes)
        {
            var collation = 0;
            await Task.Run(() =>
            {
                for (var i = 0; i < noOfTimes; i++)
                {
                    Thread.Sleep(2000);
                    collation++;
                    Console.WriteLine($"email {i} is being sent");
                }
            });
            return collation;
        }

        public void RegisterStudent(string matricNo)
        {
            Console.WriteLine($"Student with matric number {matricNo} has been registered");
        }

        public static void DataStructures()
        {
            var numbers = new int[4];
            var myArray = Array.CreateInstance(typeof(string), 12, 9, 3);
            var multiarray = new int[4, 4];

            int[][] jaggedArray = new int[2][];

            int[,] array2D = new int[,] { { 1, 2 }, { 3, 2 }, { 5, 6 }, { 5, 3 } };

            int[,,] array3D = new int[4, 3, 5]
            {
                {{ 1, 2, 3, 4, 5}, {6, 7, 8, 9, 0}, {1, 2, 3, 4, 5}},
                {{6, 7, 8, 9, 0}, {1, 2, 3, 4, 5}, {6, 7, 8, 9, 0}},
                {{1, 2, 3, 4, 5} , {6, 7, 8, 9, 0},{1, 2, 3, 4, 5}},
                {{6,7,8,9,0},{1,2,3,4,5},{6,7,8,9,0}}
            };

            int[,,,] array3D_second = new int[3, 4, 2, 4]
            {
                {{{12,34,546,232},{1212,35435,6465,645}},{{2123,5353,233,635},{2,323,645,7546}},{{12,1,42,68},{12,64,97,1}},{{1212,32,121,434},{12,24334,645,122}}},
                {{{1,3,56,8},{0,83,23,5}},{{12,4,1,53},{23,5,98,09}},{{12,434,645,112},{43,5345,2,12}},{{23,32,534,1},{2,57,445,4}}},
                {{{3,4,65,8},{87,989,564,3}},{{1,2,3,4},{53,334,3,2}},{{34,645,34,2},{23,3434,23,2}},{{12,43,334,3},{34,64,76,4}}},
            };

            Console.WriteLine(array3D[0, 1, 4]);
        }
    }
}