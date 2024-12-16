using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class MyFileProxy : IMyFile
    {
        private MyFile? _myFile;
        private string _path;

        public MyFileProxy(string path)
        {
            _path = path == null ? throw new ArgumentNullException() : path;
        }

        public string GetPath()
        {
            return _path;
        }

        public byte[] ReadAll()
        {
            if (_myFile == null)
            {
                _myFile = new MyFile(_path);
            }
            return _myFile.ReadAll();
        }

        public long Size()
        {
            if (_myFile == null)
            {
                FileInfo fi = new FileInfo(_path);
                return fi.Length;
            }
            return _myFile.Size();
        }
    }
}
