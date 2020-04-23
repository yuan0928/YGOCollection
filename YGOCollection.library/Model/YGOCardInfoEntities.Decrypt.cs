using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGOCollection.library.Extension;

namespace YGOCollection.library.Model
{
    public partial class YGOCardInfoEntities
    {
        public YGOCardInfoEntities(string cnStr) : base(cnStr)
        {
        }

        public static YGOCardInfoEntities CreateDbContext()
        {
            var cnStr = ConfigurationManager.ConnectionStrings["motcmpbEntities"].ConnectionString;

            if (!cnStr.ToLower().Contains("metadata"))
            {
                cnStr = cnStr.TripleDesDecrypt();
            }

            return new YGOCardInfoEntities(cnStr);
        }
    }
}
