using _1_DAL_QUANLY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QUANLY.IServices
{
    public interface IQLchatLieuServices
    {
        List<chatLieu> GetChatLieuFromDB();
        bool addChatLieu(chatLieu ChatLieu);
        bool RemoveChatLieu(chatLieu ChatLieu);
        bool UpdateChatLieu(chatLieu ChatLieu);
    }
}
