using _1_DAL_QUANLY.IRepositories;
using _1_DAL_QUANLY.Models;
using _1_DAL_QUANLY.Repositories;
using _2_BUS_QUANLY.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_QUANLY.Services
{
    public class QLchatLieuServices : IQLchatLieuServices
    {
        private IchatLieuRepositories _chatLieu;
        private List<chatLieu> _lstchatLieu;
        public QLchatLieuServices()
        {
            _lstchatLieu = new List<chatLieu>();
            _chatLieu = new chatLieuRepositories();
        }

        public bool addChatLieu(chatLieu ChatLieu)
        {
            _chatLieu.addchatLieu(ChatLieu);
            return true;
        }

        public bool RemoveChatLieu(chatLieu ChatLieu)
        {
            _chatLieu.RemovechatLieu(ChatLieu);
            return true;
        }

        public bool UpdateChatLieu(chatLieu ChatLieu)
        {
            _chatLieu.UpdatechatLieu(ChatLieu);
            return true;
        }


        public List<chatLieu> GetChatLieuFromDB()
        {
            _lstchatLieu = _chatLieu.GetchatLieuFromDB();
            return _lstchatLieu;
        }
    }
}
