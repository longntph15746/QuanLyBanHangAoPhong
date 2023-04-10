
using _1_DAL_QUANLY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface IchatLieuRepositories
    {
        List<chatLieu> GetchatLieuFromDB();
        bool addchatLieu(chatLieu ChatLieu);
        bool RemovechatLieu(chatLieu ChatLieu);
        bool UpdatechatLieu(chatLieu ChatLieu);
        
    }
}
