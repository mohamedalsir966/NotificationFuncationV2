﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationFunction.Service
{
    public interface IService
    {
        Task<string> GetNotificationShifts();
        bool SendDataToQueue(string massge);
    }
}
