using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class MyFile : IMyFile
    {
        private string _path;
        public MyFile(string path)
        {
            _path = path == null ? throw new ArgumentNullException() : path;
        }

        public string GetPath()
        {
            return _path;
        }

        public byte[] ReadAll()
        {
            using (FileStream fs = File.OpenRead(_path))
            {
                byte[] fileText = new byte[fs.Length];
                fs.Read(fileText, 0, fileText.Length);
                return fileText;
            }
        }

        public long Size()
        {
            using (FileStream fs = new FileStream(_path, FileMode.Open))
            {
                return fs.Length;
            }
        }
    }
}
