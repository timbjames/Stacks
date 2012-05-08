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

        public bool Join()
        {
            // if main user is online, then return true
            var userIdCookie = Context.Cookies["userid"];
            if (userIdCookie == null)
            {
                return false;
            }
            
            ChatUser user = _users.Values.FirstOrDefault(u => u.Id == userIdCookie);
            if (user != null)
            {
                user.connectionId = Context.ConnectionId;

                // set some client state
                Caller.id = user.Id;
                Caller.name = user.name;
                Caller.hash = user.hash;

                Caller.addUser(user);
                return true;

            }
                        
            return false;                    
        }

        public void Send(string command)
        {

            if (!TryHandleCommand(command))
            {
                Caller.addMessage(command);
            }
            
        }

        private bool TryHandleCommand(string message)
        {

        }

        private ChatUser AddUser(string newUserName)
        {
            var user = new ChatUser(newUserName, GetMD5Hash(newUserName));
            user.connectionId = Context.ConnectionId;
            _users[newUserName] = user;

            Caller.name = user.name;
            Caller.hash = user.hash;
            Caller.id = user.Id;

            Caller.addUser(user);

            return user;
        }

        public System.Threading.Tasks.Task Disconnect()
        {
            throw new NotImplementedException();
        }

        private string GetMD5Hash(string name)
        {
            return String.Join("", MD5.Create()
                         .ComputeHash(Encoding.Default.GetBytes(name))
                         .Select(b => b.ToString("x2")));
        }

    }

    [Serializable]
    public class ChatUser
    {

        public string connectionId { get; set; }
        public string Id { get; set; }
        public string name { get; set; }
        public string hash { get; set; }

        public ChatUser()
        {

        }

        public ChatUser(string name, string hash)
        {
            this.name = name;
            this.hash = hash;
            this.Id = Guid.NewGuid().ToString("d");
        }

    }

}