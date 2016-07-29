using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatTest
{
    public class CustomUserIdProvider:IUserIdProvider
    {
        public string GetUserId(IRequest request)
        {
            // your logic to fetch a user identifier goes here.

            // for example:

            var userId = request.User.Identity.Name.Contains("1")?"client1":"client2";
            return userId.ToString();
        }
    }
}