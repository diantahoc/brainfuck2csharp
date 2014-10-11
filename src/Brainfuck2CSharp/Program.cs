using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.IO;

namespace Brainfuck2CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brainfuck to C# translator and compiler");
            Console.WriteLine("Usage: b2c <input>");
            Console.WriteLine("---------------------------------------");

            StringBuilder sb = new StringBuilder();
            sb.Append(@"using System;
                class Program {
              public static void Main() {");

            sb.Append(@"byte[] array = new byte[200000]; 
                        int ptr = 0;");

            Dictionary<char, string> mappings = new Dictionary<char, string>();

            mappings.Add('>', "++ptr;");
            mappings.Add('<', "--ptr;");
            mappings.Add('+', "array[ptr]++;");
            mappings.Add('-', "array[ptr]--;");
            mappings.Add('.', "Console.Write(Convert.ToChar(array[ptr]));");
            mappings.Add(',', "array[ptr] = Convert.ToByte(Console.ReadLine());");
            mappings.Add('[', "while (array[ptr] != 0) {");
            mappings.Add(']', "}");

            string out_cs = "out.cs";
            string out_exe = "out.exe";

            if (args.Length > 0)
            {
                FileInfo fi = new FileInfo(args[0]);
                if (fi.Exists)
                {
                    out_cs = Path.Combine(fi.Directory.FullName,
                        Path.GetFileNameWithoutExtension(args[0]) + ".cs");

                    out_exe = Path.Combine(fi.Directory.FullName,
                        Path.GetFileNameWithoutExtension(args[0]) + ".exe");

                    if (!Directory.Exists(fi.Directory.FullName)) { Directory.CreateDirectory(fi.Directory.FullName); }

                    Console.WriteLine("Translating....");

                    var s = File.OpenText(args[0]);

                    char[] b = new char[1];

                    int bs = 0;

                    while ((bs = s.Read(b, 0, 1)) > 0)
                    {
                        char ch = b[0];
                        if (mappings.ContainsKey(ch))
                        {
                            sb.Append(mappings[ch]);
                            sb.AppendLine();
                        }
                    }

                    s.Close();
                    s.Dispose();
                }
                else
                {
                    Console.WriteLine("File doesn't exist");
                }
            }
            else
            {
                Console.WriteLine("No input provided");
                return;
            }

            sb.Append("} }");

            File.WriteAllText(out_cs, sb.ToString());

            Console.WriteLine("Compiling....");

            var csc = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", "v3.5" } });
            var parameters = new CompilerParameters(new[] { "mscorlib.dll", "System.Core.dll" }, out_exe, true);
            parameters.GenerateExecutable = true;
            CompilerResults results = csc.CompileAssemblyFromSource(parameters, sb.ToString());

            if (results.Errors.Count > 0)
            {
                Console.WriteLine("Could not compile the program ({0} errors)", results.Errors.Count);
                results.Errors.Cast<CompilerError>().ToList().ForEach(error => Console.WriteLine(error.ErrorText));
            }
            else 
            {
                Console.WriteLine("Compilation finished!");
                Console.WriteLine("C# source file: '{0}'", out_cs);
                Console.WriteLine("Executable file: '{0}'", out_exe);
            }
        }
    }
}
