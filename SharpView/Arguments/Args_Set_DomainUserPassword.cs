﻿using SharpView.Enums;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SharpView.Arguments
{
    public class Args_Set_DomainUserPassword
    {
        public string Identity { get; set; }
        public string UserName { get { return Identity; } set { Identity = value; } }
        public string UserIdentity { get { return Identity; } set { Identity = value; } }
        public string User { get { return Identity; } set { Identity = value; } }

        public string AccountPassword { get; set; }

        public string Domain { get; set; }

        public NetworkCredential Credential { get; set; }
    }
}
