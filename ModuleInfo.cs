﻿using Discord.Commands;
using Discord.WebSocket;
using GLaDOSV3.Helpers;
using System;
using System.Reflection;
using System.Runtime.Loader;
using GLaDOSV3.Models;
using Microsoft.Extensions.DependencyInjection;

namespace GLaDOSV3.Module.ServerBackup
{
    public class ModuleInfo : GladosModule
    {
        public override string Name => "ServerBackup";

        public override string Version => "0.0.0.1";
        
        public override string AuthorLink => "https://github.com/BlackOfWorld";
    }
}
