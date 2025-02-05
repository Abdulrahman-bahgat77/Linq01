using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text.RegularExpressions;
using static Linq01.ListGenerator;
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

            #region Data Setup
            //Console.WriteLine(ProductList[0]);
            //Console.WriteLine(CustomerList[0]);
            #endregion

            #region Get Product out stock
            //Fluent Syntax
            // var Result = ProductList.Where(X => X.UnitsInStock >=1&&X.Category=="Meat/Poultry");

            //Query Syntax
            //Result =from p in ProductList
            //         where p.UnitsInStock >=1&&p.Category=="Meat/Poultry"
            //            select p;

            #region Ex02 [Index Where]
            //var Result = ProductList.Where((P, I) => I < 10 && P.UnitsInStock == 0);
            //foreach (var Item in Result)
            //{
            //    Console.WriteLine(Item);
            //}
            #endregion

            //foreach (var X in Result)
            //{
            //    Console.WriteLine(X);
            //}
            #endregion

            #region Filteration Operation[Select,Select Many]
            #region Product Name
            //Fluent Syntax
            //var Result = ProductList.Select(P => P.ProductName);

            //Query Syntax
            //var Result=from p in ProductList
            //           select p.ProductName;
            #endregion

            #region Customer Name
            //   var Result = CustomerList.Select(X => X.CustomerName);
            //var Result=from c in CustomerList
            //  select c.CustomerName;
            #endregion

            #region Customer Order
            //Fluent Syntax
            //  var Result = CustomerList.SelectMany(X => X.Orders);

            //Query Syntax
            //var Result=from C in CustomerList
            //          from O in C.Orders
            //          select O;
            #endregion

            #region Product Name and Id
            //var Result = ProductList.Select(X =>new {productId=X.ProductID , ProductName=X.ProductName });
            // Result=from p in ProductList
            //        select new
            //        {
            //            productId = p.ProductID,
            //            ProductName=p.ProductName
            //        };
            #endregion

            #region Select Product in stock and apply 10% discount
            //Fluent Syntax

            //var Result = ProductList.Where(X => X.UnitsInStock > 0)
            //      .Select(X => new
            //      {
            //          id=X.ProductID,
            //          Name=X.ProductName,
            //          OldPrice=X.UnitPrice,
            //          newprice=X.UnitPrice-(X.UnitPrice*.1M),
            //      });

            //  Query  Syntax

            //var Result=from p in ProductList
            //           where p.UnitsInStock > 0
            //           select new
            //           {
            //               id=p.ProductID,
            //               Name=p.ProductName,
            //               OldPrice=p.UnitPrice,
            //               newPrice=p.UnitPrice-(p.UnitPrice*.1M),
            //           };
            #endregion

            //Index Select Valid only fluent Syntax

            //var Result = ProductList.Where(X => X.UnitsInStock > 0)
            //    .Select((P, I) =>
            //    new
            //    {
            //        inex=I,
            //        Name=P.ProductName,
            //    }
            //    );

            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}


            #endregion

            #region ordering Operation[Ascending,Descending,Reverse,ThenBy,ThenBy Descending]

            #region Ascending
            //fluent Syntax
            //  var Result = ProductList.OrderBy(X => X.UnitPrice);


            //Query Syntax
            //var    Result=from p in ProductList
            //           orderby p.UnitPrice
            //           select p;
            #endregion

            #region Descending
            //Fluent Syntax
            // var Result =ProductList.OrderByDescending(X=>X.UnitPrice);

            //Query Syntax
            //Result = from p in ProductList
            //        orderby p.UnitPrice descending
            //        select p;
            #endregion

            #region ThenBy , Reverse
            //   var Result = ProductList.OrderBy(X => X.UnitPrice).ThenBy(X => X.UnitsInStock);

            // var Result = ProductList.Where(X => X.UnitsInStock==0).Reverse();
            #endregion
            //foreach (var Item in Result)
            //{
            //    Console.WriteLine(Item);
            //}
            #endregion

         
        }
    }
}
