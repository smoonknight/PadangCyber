using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadangCyberApp.Classes.Strings
{
    class URLWebService
    {
        public class Get
        {
            public static string category = "http://127.0.0.1:8000/api/get/category";
            public static string dish = "http://127.0.0.1:8000/api/get/dish";
        }
        
        public class Post
        {
            public static string category = "http://127.0.0.1:8000/api/post/category";
            public static string dish = "http://127.0.0.1:8000/api/post/dish";
        }

        public class Put
        {
            public static string category = "http://127.0.0.1:8000/api/put/category";
            public static string dish = "http://127.0.0.1:8000/api/put/dish";
        }

        public class Delete
        {
            public static string category = "http://127.0.0.1:8000/api/delete/category";
            public static string dish = "http://127.0.0.1:8000/api/delete/dish";
        }
    }
}
