// See https://aka.ms/new-console-template for more information

while(true)
{
    OutputPid();
}


void OutputPid() 
{
    Console.WriteLine($"Hello World! {Environment.ProcessId}");
    Thread.Sleep(1000);
}
