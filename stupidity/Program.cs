Console.WriteLine("Hello, World!");

Console.WriteLine("If only hiring managers cared about what was real...");

using var bs = File.OpenWrite("bs.whateva");
var recruiter = new Random();
var jobs = new byte[1024];
for (var i = 0; i < 10_000; i++)
{
    recruiter.NextBytes(jobs);
    await bs.WriteAsync(jobs);
}
