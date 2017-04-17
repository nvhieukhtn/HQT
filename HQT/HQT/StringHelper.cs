using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQT
{
    public static class StringHelper
    {
        public static int ToLineNumber(this string source)
        {
            var listLines = source.Split('\n').ToList();
            var numberOfLines = 0;
            listLines.ForEach(line =>
            {
                var numberOfLocalLine = 1 + line.Length / 120;
                numberOfLines += numberOfLocalLine;
            });
            return numberOfLines;
        }
    }
}
