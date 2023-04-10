
using _1_DAL_QUANLY.IRepositories;
using _1_DAL_QUANLY.Models;
using DAL_QuanLy.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.Repositories
{
    public class chatLieuRepositories : IchatLieuRepositories
    {
        private List<chatLieu> _lstchatLieu;
        private DatabaseContext _context;
        public chatLieuRepositories()
        {
            _lstchatLieu = new List<chatLieu>();
            _context = new DatabaseContext();
        }

        public bool addchatLieu(chatLieu ChatLieu)
        {
            _context.Add(ChatLieu);
            _context.SaveChanges();
            return true;

        }

        public List<chatLieu> GetchatLieuFromDB()
        {
            _lstchatLieu = _context.chatLieus.ToList();
            return _lstchatLieu;
        }

        public bool RemovechatLieu(chatLieu ChatLieu)
        {
            _context.Remove(ChatLieu);
            _context.SaveChanges();
            return true;
        }

        public bool UpdatechatLieu(chatLieu ChatLieu)
        {
            _context.Update(ChatLieu);
            _context.SaveChanges();
            return true;
        }
    }
}
