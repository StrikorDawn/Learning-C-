// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// // This is the delay command like you used in python. 1000 miliseconds equals 1 second.
// Thread.Sleep(1000);
// Console.WriteLine("Done.");

// for (int i = 5; i > 0; i--)
// {
//     Console.WriteLine(i);
//     Thread.Sleep(1000);
// }
// Console.WriteLine("Done.");

// for (int i = 5; i > 0; i--)
// {
//     Console.Write(i);
//     Thread.Sleep(1000);
//     Console.Write("\b \b");
// }
// Console.WriteLine("Done.");


// for (int i = 10; i > 0; i--)
// {
//     Console.Write(i);
//     Thread.Sleep(1000);
//     // If you have doulbe didget numbers then you will nee to do
//     // \b\b  \b\b basically double it.
//     if(i < 10)
//     {
//         Console.Write("\b \b");
//     }
//     else if(i < 100)
//     {
//         Console.Write("\b\b  \b\b");
//     }
//     else if(i < 1000)
//     {
//         Console.Write("\b\b\b   \b\b\b");
//     }
//     else if(i < 10000)
//     {
//         Console.Write("\b\b\b\b    \b\b\b\b");
//     }
//     else if(i < 100000)
//     {
//         Console.Write("\b\b\b\b\b     \b\b\b\b\b");
//     }
//     else
//     {
//         Console.Write("\b\b\b\b\b\b      \b\b\b\b\b\b");
//     }
// }
// Console.WriteLine("Done.");

List<string> animationStrings = new List<string>
{
    "|","/","-","\\","|","/","-","\\"
};

// foreach (string s in animationStrings)
// {
//     Console.Write(s);
//     Thread.Sleep(50);
//     Console.Write("\b \b");
// }

DateTime startTime = DateTime.Now;
DateTime endTime = startTime.AddSeconds(10);

// while(DateTime.Now < endTime)
// {
//     Console.Write(".");
//     Thread.Sleep(1000);
// }


int i = 0;

while(DateTime.Now < endTime)
{
    string s = animationStrings[i];
    Console.Write(s);
    Thread.Sleep(100);
    Console.Write("\b \b");


    i++;
    if(i >= animationStrings.Count)
    {
        i = 0;
    }
}

Console.WriteLine("");
Console.WriteLine("Done!");