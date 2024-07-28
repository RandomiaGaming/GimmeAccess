using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace GimmeAccess
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string dirPath = "D:\\Windows";
            DirectorySecurity directorySecurity = Directory.GetAccessControl(dirPath)
            directorySecurity.SetOwner(new NTAccount(Environment.UserDomainName, "RandomiaGaming"));
            Directory.SetAccessControl(dirPath, directorySecurity);
            Directory.
        }
    }
}
