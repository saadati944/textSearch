using System;
using System.Linq;
using System.Collections.Generic;
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
                if (!x.StartsWith("?") && !x.StartsWith(",") && !x.Contains(':'))
                    continue;
                setVal(x);
            }
        }
        void setVal(string kandv)
        {
            try
            {
                if (kandv.StartsWith("?"))
                {
                    if (!configs.ContainsKey("path"))
                    {
                        configs.Add("path", "");
                        string v = configs["path"];
                        v +=  cutSpaces(kandv.Substring(1));
                        configs.Remove("path");
                        configs.Add("path", v);
                    }
                    else
                    {
                        string v = configs["path"];
                        v += "?" + cutSpaces(kandv.Substring(1));
                        configs.Remove("path");
                        configs.Add("path", v);
                    }
                    return;
                }
                else if (kandv.StartsWith(","))
                {
                    if (!configs.ContainsKey("format"))
                    {
                        configs.Add("format", "");
                        string v = configs["format"];
                        v += cutSpaces(kandv.Substring(1));
                        configs.Remove("format");
                        configs.Add("format", v);
                    }
                    else
                    {
                        string v = configs["format"];
                        v += "," + cutSpaces(kandv.Substring(1));
                        configs.Remove("format");
                        configs.Add("format", v);
                    }
                    return;
                }
                string key = kandv.Substring(0, kandv.IndexOf(':'));
                string value = kandv.Substring(key.Length+1, kandv.Length - key.Length-1);

                key = cutSpaces(key);
                value = cutSpaces(value);

                if (key == "" || value == "")
                    return;

                if (key.StartsWith("+"))
                {
                    key = key.Substring(1);
                    string v = "";
                    if (configs.ContainsKey(key))
                    {
                        v = configs[key];
                        configs.Remove(key);
                    }
                    configs.Add(key, v + value);
                }
                else if(!configs.ContainsKey(key))
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
