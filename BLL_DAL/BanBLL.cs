using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BanBLL
    {
        QLQuanCafeDataContext data = new QLQuanCafeDataContext();
        public BanBLL() { }

        public List<Ban> getDSBan()
        {
            return data.Bans.Select(s => s).ToList<Ban>();
        }
    }
}
