using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using SignalR;
using SignalR.Hubs;

namespace WebApp.Hubs
{
    public class blabbR : Hub, IDisconnect
    {

        private static readonly Dictionary<string, ChatUser> _users = new Dictionary<string, ChatUser>(StringComparer.OrdinalIgnoreCase);

        public bool AdminLogin(string username, string password)
        {
            if (username == "admin" && password == "password")
            {
                // o noes, using probably the most widely used admin username and password combinations!      
                if (!_users.ContainsKey("admin"))
                {
                    _users.Add("admin", new ChatUser() { connectionId = Context.ConnectionId, Id = Context.ConnectionId, isAdmin = true, name = "Tim" });
                }                
                return true;
            }
            return false;
        }

        public bool IsOnline()
        {
            if (_users.ContainsKey("admin"))
            {
                return true;
            }
            return false;
        }


        public Task Disconnect()
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    public class ChatUser
    {

        public string connectionId { get; set; }
        public string Id { get; set; }
        public string name { get; set; }
        public string hash { get; set; }
        public bool isAdmin { get; set; }

        public ChatUser()
        {

        }

        public ChatUser(string name, string hash, bool isAdmin)
        {
            this.name = name;
            this.hash = hash;
            this.Id = Guid.NewGuid().ToString("d");
            this.isAdmin = isAdmin;
        }

    }

}