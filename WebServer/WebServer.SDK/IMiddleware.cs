﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer.SDK
{
    public interface IMiddleware
    {
        Task InvokeAsync(MiddlewareContext context, ICallable next, CancellationToken cancellationToken);
    }
}
