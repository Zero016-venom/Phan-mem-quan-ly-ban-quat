﻿using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface TaiKhoan_IRepos
    {
        List<TaiKhoan> GetKhoans();
    }
}
