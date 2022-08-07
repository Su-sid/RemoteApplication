
using PTSLibrary2;
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

namespace RemoteServerApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpChannel channel = new HttpChannel(50000);
            ChannelServices.RegisterChannel(channel, false);
           RemotingConfiguration.RegisterWellKnownServiceType(typeof(PTSLibrary2.PTSAdminFacade),"PTSAdminFacade", WellKnownObjectMode.Singleton);
            Console.WriteLine("press the enter key to terminate the server");
            Console.ReadLine();

        }
    }
}
