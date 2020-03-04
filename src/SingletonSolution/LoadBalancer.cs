using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonSolution
{
    public sealed class LoadBalancer
    {
        private static readonly LoadBalancer Instance = new LoadBalancer();

        private readonly List<Server> _servers;
        private readonly Random _random = new Random();

        private LoadBalancer()
        {
            _servers = new List<Server>
            {
             new Server{ Name = "ServerI", IP = "120.14.220.18" },
             new Server{ Name = "ServerII", IP = "120.14.220.19" },
             new Server{ Name = "ServerIII", IP = "120.14.220.20" },
             new Server{ Name = "ServerIV", IP = "120.14.220.21" },
             new Server{ Name = "ServerV", IP = "120.14.220.22" },
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return Instance;
        }

        // Load balancer
        public Server NextServer
        {
            get
            {
                var r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }
}
