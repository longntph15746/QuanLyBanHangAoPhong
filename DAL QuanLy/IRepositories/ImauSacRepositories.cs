using _1_DAL_QUANLY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_QUANLY.IRepositories
{
    public interface ImauSacRepositories
    {
        List<mauSac> GetMauSacFromDB();
        bool addMauSac(mauSac MauSac);
        bool RemoveMauSac(mauSac MauSac);
        bool UpdateMauSac(mauSac MauSac);
    }
}
