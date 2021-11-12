// See https://aka.ms/new-console-template for more information

while(true)
{
    OutputPid();
    Thread.Sleep(1000);
}


void OutputPid() => 
    Console.WriteLine($"Hello World! {Environment.ProcessId}");
