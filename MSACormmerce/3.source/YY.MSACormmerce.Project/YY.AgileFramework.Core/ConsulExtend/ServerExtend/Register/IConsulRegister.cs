﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YY.AgileFramework.Core.ConsulExtend.ServerExtend.Register
{
    public interface IConsulRegister
    {
        Task UseConsulRegist();
        Task UseConsulRegistgRPC();
    }
}
