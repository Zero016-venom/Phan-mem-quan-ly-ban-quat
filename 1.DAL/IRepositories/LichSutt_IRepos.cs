using _1.DAL.Model1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface LichSutt_IRepos
    {
        List<LichSuTt> GetLichSuTt(string input);

        bool CreateLSTT(LichSuTt lichSuTt);
        bool UpdateLSTT(Guid id, LichSuTt lichSuTt);
    }
}
