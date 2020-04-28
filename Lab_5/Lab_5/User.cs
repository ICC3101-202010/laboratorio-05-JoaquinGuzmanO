using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lab_5
{
    class User
    {
        public delegate void SendEmailEventHandler(object source, EventArgs args);
        public event SendEmailEventHandler EmailVerified;
        protected virtual void OnEmailVerified()
        {
            EmailVerified(this, EventArgs.Empty);
        }

        public void OnEmailSent(object source, EventArgs args)
        {
            Console.WriteLine("desea verificar su cuenta? [si] [no]");
            string answer = Console.ReadLine();
            if(answer == "si")
            {
                OnEmailVerified();
            }
            else
            {
                Console.WriteLine("Su cuenta no ha sido verificada");
            }
        }
        public void OnEmailVerified(object source, EventArgs args)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nSu correo ha sido verificado");
            Thread.Sleep(2000);
        }
    }
}
