using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public interface IFileGenerator
    {
        string WorkingDirectory { get; }
        string FileExtension { get; }

        void GenerateFiles(int filesCount, int contentLength);
        byte[] GenerateFileContent(int contentLength);
        void WriteBytesToFile(string fileName, byte[] content);

    }
}
