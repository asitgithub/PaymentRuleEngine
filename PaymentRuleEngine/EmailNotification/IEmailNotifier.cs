﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentRuleEngine
{
    public interface IEmailNotifier
    {
        void NotifyUser(string emailContent);
    }
}
