using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textSearch
{
    class configReader : IDisposable
    {
        public string _path;
        public Dictionary<string, string> configs = new Dictionary<string, string>();

        public configReader(string filepath)
        {
            _path = filepath;
        }
        public void readFile()
        {
            bool comment = false;
            foreach (string x in System.IO.File.ReadLines(_path))
            {
                if (x == "")
                    continue;
                if (x.StartsWith("//"))
                    continue;
                if (x.StartsWith("/*"))
                    comment = true;
                if (x.EndsWith("*/"))
                {
                    comment = false;
                    continue;
                }
                if (comment)
                    continue;
                if (!x.Contains(':'))
                    continue;
                setVal(x);
            }
        }
        void setVal(string kandv)
        {
            try
            {
                string key = kandv.Substring(0, kandv.IndexOf(':'));
                string value = kandv.Substring(key.Length+1, kandv.Length - key.Length-1);

                key = cutSpaces(key);
                value = cutSpaces(value);

                if (key == "" || value == "")
                    return;

                if(!configs.ContainsKey(key))
                configs.Add(key, value);
            }
            catch { }
        }
        string cutSpaces(string v)
        {
            while (v.StartsWith("	") || v.StartsWith(" "))
                v = v.Substring(1);
            while (v.EndsWith("	") || v.EndsWith(" "))
                v = v.Substring(0, v.Length - 1);
            return v;
        }
        public void Dispose()
        {

        }
    }
}
