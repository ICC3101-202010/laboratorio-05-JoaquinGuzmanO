using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    class SendEmailEventArgs : EventArgs
    {
        public string Email { get; set; }
        public string Username { get; set; }
    }
}
