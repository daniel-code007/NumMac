using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nummpad_Macro
{
    class Keylogger
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);



         static void Main(string[] args)
        {
            while(true)
            {
                Thread.Sleep(5);
                for (int i = 1; i < 130; i++ )
                {
                    int KeyState = GetAsyncKeyState(i);

                    if (KeyState == -32767)
                    {
                       Console.Write((char)i + ", ");
                    }
                   
                }
            }
        }
    }
}
