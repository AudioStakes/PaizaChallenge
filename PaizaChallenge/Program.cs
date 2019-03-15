using System;

namespace PaizaChallenge
{
    class Program
    {
        static void Main()
        {
            ChangeLocalDebugInput();

            // your code
            // ...
        }

        [System.Diagnostics.Conditional("LOCAL_DEBUG")]
        static void ChangeLocalDebugInput()
        {
            Console.SetIn(new System.IO.StreamReader("sampleInput.txt"));
        }
    }
}
