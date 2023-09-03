using FixedAsset.Filters;
using FixedAsset.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FixedAsset.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [CustomActionFilter]
        [ResourceFilter]
        public IActionResult Index()
        {

            //Single Dimention Array

            string[] name = new string[5];
            name[0] = "Aalok";
            name[1] = "Praveen";
            name[2] = "Nikhil";

            foreach (var a in name)
            {
                Console.WriteLine("Single Dimention Array value is =>" + a);
            }

            //Multidimentional Array



            int[,] arr = new int[3, 3];//2d Array

            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[0, 2] = 3;
            arr[1, 0] = 4;
            arr[1, 1] = 5;
            arr[1, 2] = 6;
            arr[2, 0] = 7;
            arr[2, 1] = 8;
            arr[2, 2] = 9;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();//new line at each row  
            }
            int[,,] arr3d = new int[3, 3, 3];//Declaring 3D array

            //Jagged Array

            int[][] jgdary = new int[3][];

            jgdary[0] = new int[] { 1, 2, 3 };
            jgdary[1] = new int[] { 4, 5, 6 };
            jgdary[2] = new int[] { 7, 8, 9 };
            Console.WriteLine("This is Jagged Array");
            for (int i = 0; i < jgdary.Length; i++)
            {
                for (int j = 0; j < jgdary[i].Length; j++)
                {
                    
                    System.Console.Write(jgdary[i][j] + " ");
                }
                System.Console.WriteLine();
            }

            //HashSet
            var names=new HashSet<string>();//It only add inique data
            names.Add("aalok");
            names.Add("Praveen");
            names.Add("aalok");//It will not be added
            Console.WriteLine("HashSet Print");
            foreach (var name1 in names)
            {
                Console.WriteLine(name1);
            }


            //Sorted Set

            var names1 = new SortedSet<string>();
            names1.Add("Sonoo");
            names1.Add("Ankit");
            names1.Add("Peter");
            names1.Add("Irfan");
            names1.Add("Ankit");//will not be added  
            Console.WriteLine("Sorted Set Print");
            // Iterate SortedSet elements using foreach loop  
            foreach (var n in names1)
            {
                Console.WriteLine(n);
            }

            //Linked List

            var LL = new LinkedList<string>();
            LL.AddLast("Aalok");
            LL.AddLast("Ankit");
            LL.AddLast("Vikash");
            LL.AddLast("Milendra");

            //insert new element before "Ankit"  
            LinkedListNode<String> node = LL.Find("Ankit");
            LL.AddBefore(node, "John");
            LL.AddAfter(node, "Lucy");
            Console.WriteLine("Linked List Entry");
            // Iterate list element using foreach loop  
            foreach (var L in LL)
            {
                Console.WriteLine(L);
            }

            //Distionary

            Dictionary<string, string> Distny = new Dictionary<string, string>();
            Distny.Add("1", "Aalok1");
            Distny.Add("2", "Aalok2");
            Distny.Add("3", "Aalok3");
            Distny.Add("4", "Aalok4");
            Distny.Add("5", "Aalok5");
            //Printing Distionary
            foreach (KeyValuePair<string, string> kv in Distny)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}