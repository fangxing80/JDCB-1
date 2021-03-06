﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RestAPICore
{
    public class DeleteRequest : RequestBase
    {
        public DeleteRequest()
        {
            base._requestMethod = "DELETE";
        }
        protected override async Task FillDataTo(System.Net.WebRequest webRequest, CancellationToken cancellationToken, IProgress<ProgressReport> progress)
        {
             await ExtensionPatchs.TaskYield();
        }
    }
}
