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

        public configReader(/*string filepath*/)
        {
            //_path = filepath;
            _path = Program.getConfigpath();
            if (!System.IO.File.Exists(_path))
            {
                using (System.IO.StreamWriter writer = System.IO.File.CreateText(_path))
                {
                    writer.Write(",.txt\n,.html\n,.css\n,.config\n,.xml\n,.jar\n,.ini\n,.conf\n,.cfg\n,.h\n,.py\n,.htm\n,.sln\n,.csproj\n,.gitattributes\n,.gitignore\n,.pyproj\n,.php\n,.ino\n,.md\n,.cs");
                }
            }
        }
        public void readFile()
        {
            if(!System.IO.File.Exists(_path))
                try { System.IO.File.Create(_path).Close();}
                catch { return; }
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
                        v +=  Program.cutSpaces(kandv.Substring(1)).ToLower();
                        configs.Remove("path");
                        configs.Add("path", v);
                    }
                    else
                    {
                        string v = configs["path"];
                        v += "?" + Program.cutSpaces(kandv.Substring(1)).ToLower();
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
                        v += Program.cutSpaces(kandv.Substring(1)).ToLower();
                        configs.Remove("format");
                        configs.Add("format", v);
                    }
                    else
                    {
                        string v = configs["format"];
                        v += "," + Program.cutSpaces(kandv.Substring(1)).ToLower();
                        configs.Remove("format");
                        configs.Add("format", v);
                    }
                    return;
                }
                string key = kandv.Substring(0, kandv.IndexOf(':'));
                string value = kandv.Substring(key.Length+1, kandv.Length - key.Length-1);

                key = Program.cutSpaces(key);
                value = Program.cutSpaces(value);

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
                    value = value.ToLower();
                    configs.Add(key, v + value);
                }
                else if (!configs.ContainsKey(key))
                {
                    value = value.ToLower();
                    configs.Add(key, value);
                }
            }
            catch { }
        }
        
        public void Dispose()
        {

        }
    }
}
