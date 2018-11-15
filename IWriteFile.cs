using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingSOLIDPrinciples
{
    interface IWriteFile
    {
        string writePath { get; set; }
        StreamWriter writer { get; set; }
        string writeOutFirstNumbers { get; set; }
        string writeOutSecondNumbers { get; set; }
        string writeOutOperators { get; set; }
        string writeOutTotals { get; set; }
    }
}
