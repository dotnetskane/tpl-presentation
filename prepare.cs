#r "nuget: System.Threading.Tasks.Dataflow, 8.0.0"

// Bugfix as the above 👆 will not include the package in the assembly for some reason
#r "C:\Users\matsa\.nuget\packages\system.threading.tasks.dataflow\8.0.0\lib\net8.0\System.Threading.Tasks.Dataflow.dll"

using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks.Dataflow;

IEnumerable<string> Source(params string[] values)
{
    while(true)
    {
        yield return values[Random.Shared.Next(values.Length)];
    }
}

var fruits = Source("🍌", "🍊", "🍏", "🍍", "🍑", "🍉", "🍐");
var vegetables = Source("🍅", "🥔", "🥕", "🫑", "🥒", "🫛");