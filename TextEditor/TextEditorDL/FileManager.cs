using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TextEditorDL
{
   public class FileManager
    {
        private readonly Encoding _defaultencoding = Encoding.GetEncoding(1251);
        public bool isExist(string filePath)
        {
            bool isExist = File.Exists(filePath);
            return isExist;
        }
        public int GetNumber(string content)
        {
            int count = content.Length;
            return count;
        }
        public string GetContent(string filepath, Encoding encoding)
        {
            string content = File.ReadAllText(filepath, encoding);
            return content;
        }
        public string GetContent(string filepath)
        {
            return GetContent(filepath, _defaultencoding);
        }
        public void SaveContent(string content, string filePath, Encoding encode)
        {
            File.WriteAllText(filePath, content, encode);
        }
        public void SaveContent(string content, string filePath)
        {
            File.WriteAllText(filePath, content, _defaultencoding);
        }
    }
}
