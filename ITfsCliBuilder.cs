﻿using Microsoft.TeamFoundation.TestManagement.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfs_cli
{
    interface ITfsCliBuilder
    {
        string Finalize();
        void Append(ITestCase test);
        void Header(ITfsCliOptions opts);
    }
}