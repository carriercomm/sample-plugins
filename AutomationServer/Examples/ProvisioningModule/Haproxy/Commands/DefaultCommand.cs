﻿using System;
using Atomia.Provisioning.Base;
using Atomia.Provisioning.Base.Module;
using Atomia.Provisioning.Modules.Common;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;

namespace Atomia.Provisioning.Modules.Haproxy.Commands
{
    class DefaultCommand : HaproxyCommandBase
    {
        public DefaultCommand(ModuleService service, ResourceDescription resource, ModuleService newServiceSettings, ModuleCommandType commandType, int listDepth)
            : base(service, resource, newServiceSettings, commandType, listDepth)
        {
        }

        protected override string GetResourceURL(ModuleService moduleService)
        {
            string id = moduleService.Properties.Single(p => p.Name == "Id").Value;
            return string.IsNullOrEmpty(id) ? "default" : ("default/" + id);
        }
    }
}
