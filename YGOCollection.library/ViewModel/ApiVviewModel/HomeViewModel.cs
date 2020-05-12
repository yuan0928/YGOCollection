using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGOCollection.library.Enums;
using YGOCollection.library.Model;

namespace YGOCollection.library.ViewModel.ApiVviewModel
{
    public class HomeViewModel
    {
        /// <summary>
        /// 卡片新增
        /// </summary>
        public HomeListViewModel cardinfo { get; set; }
    }
    public class HomeListViewModel
    {
        public HomeListType homelisttype { get; set; }
        public List<InformationViewModel> List { get; set; }
    }
    public class HomeSearchViewModel
    {
        /// <summary>
        /// 卡片新增 Node.Id
        /// </summary>
        public int AddCardNodeId { get; set; }

    }
    public class Program
    {
        
        static void Main(string[] args)
        {

            using (var db = new YGOCardInfoEntities())
            {

                var query = from b in db.Information
                            orderby b.ID
                            select b;

                Console.WriteLine("All All student in the database:");

                foreach (var item in query)
                {
                    Console.WriteLine(item.subject + " " + item.content);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
