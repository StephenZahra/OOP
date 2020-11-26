using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Abstraction
{
    class TextFile : File, IBackup
    {
        public string BackupLocation { get; set; }

        string _originalPath;
        string _content;
        public TextFile(string content)
        { _content = content; }

        public void Backup()
        {
            //implement it
            System.IO.File.Copy(_originalPath, BackupLocation);
        }

        public override string Load(string filename)
        {
            _originalPath = filename;

            _content = System.IO.File.ReadAllText(filename);
            return _content;
        }

        public override void Save(string filename)
        {
            System.IO.File.WriteAllText(filename, _content);
        }
    }
}
