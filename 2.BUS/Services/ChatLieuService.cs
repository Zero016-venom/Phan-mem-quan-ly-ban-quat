using _1.DAL.Model1s;
using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class ChatLieuService
    {
        ChatLieuRepos _repos = new ChatLieuRepos();
        public ChatLieuService()
        {

        }
        public ChatLieuService(ChatLieuRepos repos)
        {
            _repos = repos;
        }

        public List<ChatLieu>? GetChatLieu(string name)
        {
            var lst = _repos.GetChatLieu(name);
            if (lst == null)
            {
                return null;
            }
            return lst;
        }
        public bool CreateChatLieu(ChatLieu chatlieu)
        {
            var obj = new ChatLieu()
            {
                IdChatLieu = chatlieu.IdChatLieu,
                TenChatLieu = chatlieu.TenChatLieu

            };
            return _repos.CreateChatLieu(obj);
        }
    }
}
