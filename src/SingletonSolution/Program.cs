﻿using System;

namespace SingletonSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();

            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("The same instance\n");
            }

            var balancer = LoadBalancer.GetLoadBalancer();

            for (var i = 0; i < 15; i++)
            {
                var serverName = balancer.NextServer.Name;
                Console.WriteLine("Trigger request for: " + serverName);
            }
        }
    }
}
