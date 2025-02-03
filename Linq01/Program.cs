using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Linq01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Extension Method
            //int X = 12345;
            //int Y = X.Reverse();
            //Console.WriteLine(Y);
            #endregion

            #region What is Linq
            //Language Integrated Query
            //Linq + 40 Methods
            //LINQ operators that added to the existing  IEnumerable and IEnumerable<T> types
            //Categorized into 13 category

            //  List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            //List<int> OddNumbers=list.Where(X => X % 2 == 1).ToList(); //Ienumerable To List by ToList()

            //foreach(int i in OddNumbers)
            //{
            //    Console.WriteLine(i);
            //}

            //You Can Use "LINq Operators" Against The Data [Stored In Sequence] Regardless Data Store [Sql Server, MySql , Oracle]
            //Sequance : The Object From Class That Implement Interface "IEnumerable"
            #endregion

            #region LINQ Syntex[Fluent Syntex, Query Syntex]
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            #region 1-Fluent Syntex
            //1.1-Static Method
            // var OddNumbers =Enumerable.Where(list, X => X % 2 == 1);
            //foreach (var X in OddNumbers)
            //{
            //    Console.Write($"{X} ");
            //}

            //2.1-Extension Method

            //OddNumbers=list.Where(X => X % 2 == 1);
            //   foreach (var i in OddNumbers)
            //   {
            //       Console.Write($"{i} ");
            //   }

            //A] Call "LINQ operators“
            //     as static method
            //B] Call "LINQ operators“
            //    as extension method

            #endregion

            #region Query Syntex
            //var OddNumbers = from X in list
            //                where X%2==1
            //                select X;
            //   foreach ( var o in OddNumbers )
            //   {
            //       Console.WriteLine(o);
            //   }

            // A] Must Be Begin With
            //    Keyword 'From’

            // B]Must be End With Select
            //     Or Groupby

            #endregion
            #endregion

            #region Linq Excution Ways
            #region Deferred Excution

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var OddNumbers = list.Where(X => X % 2 == 1);
            //list.AddRange(new int[] { 11, 12, 13, 14, 15 });

            ////used  Where is Excuted
            //foreach (int i in OddNumbers)
            //{
            //    Console.Write($"{i} ");
            //}
            #endregion

            #region Immedaite Excution ( Elements Operators , Casting Operators ,Aggregate Operators )

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // var OddNumbers = list.Where(X => X % 2 == 1).ToList();//used
            // list.AddRange(new int[] { 11, 12, 13, 14, 15 });  


            // foreach (int i in OddNumbers)
            // {
            //     Console.Write($"{i} ");
            // }
            #endregion
            #endregion


        }
    }
}
