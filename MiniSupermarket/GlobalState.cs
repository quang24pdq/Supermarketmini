using MiniSupermarket.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarket
{
    internal static class GlobalState
    {
        public static string username { get; set; }
        public static string password { get; set; }
        public static string employeeId { get; set; }
        public static string roleId { get; set; }
        public static List<string> funcs { get; set; }
        public static MenuForm menuForm { get; set; }
        public static Form loginForm { get; set; }
        public static Dictionary<string, Button> functionsButton { get; set; }
    }
}
 