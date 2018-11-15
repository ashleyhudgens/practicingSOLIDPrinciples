using System.IO;

namespace PracticingSOLIDPrinciples
{
    interface IReadFile
    {
        string readPath { get; set; }
        StreamReader reader { get; set; }
        string readLines { get; set; }
    }
}
