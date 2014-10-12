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
            Console.WriteLine("Usage: b2c [-do] <input>");
            Console.WriteLine("Supply -do to disable C# source optimization");
            Console.WriteLine("---------------------------------------");

            StringBuilder sb = new StringBuilder();
            sb.Append(@"using System;
                class Program {
              public static void Main() {");

            sb.Append(@"byte[] array = new byte[200000]; 
                        int ptr = 0;");

            bool optimize = true;

            List<object> program_instructions = new List<object>();
            program_instructions.Add(null);

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
                foreach (string a in args)
                {
                    if (a == "-do") { optimize = false; break; }
                }
                FileInfo fi = new FileInfo(args.Last());
                if (fi.Exists)
                {
                    out_cs = Path.Combine(fi.Directory.FullName,
                        Path.GetFileNameWithoutExtension(args.Last()) + ".cs");

                    out_exe = Path.Combine(fi.Directory.FullName,
                        Path.GetFileNameWithoutExtension(args.Last()) + ".exe");

                    if (!Directory.Exists(fi.Directory.FullName)) { Directory.CreateDirectory(fi.Directory.FullName); }

                    Console.WriteLine("Translating....");

                    var s = File.OpenText(args.Last());

                    char[] b = new char[1];

                    int bs = 0;

                    while ((bs = s.Read(b, 0, 1)) > 0)
                    {
                        char ch = b[0];
                        switch (ch)
                        {
                            case '>':
                                if (optimize)
                                {
                                    IncrementPC pc = program_instructions.Last() as IncrementPC;
                                    if (pc != null)
                                    {
                                        pc.Count++;
                                    }
                                    else
                                    {
                                        program_instructions.Add(new IncrementPC());
                                    }
                                }
                                else
                                {
                                    sb.AppendLine(mappings[ch]);
                                }
                                break;

                            case '<':
                                if (optimize)
                                {
                                    DecrementPC pc = program_instructions.Last() as DecrementPC;
                                    if (pc != null)
                                    {
                                        pc.Count++;
                                    }
                                    else
                                    {
                                        program_instructions.Add(new DecrementPC());
                                    }
                                }
                                else
                                {
                                    sb.AppendLine(mappings[ch]);
                                }
                                break;

                            case '+':
                                if (optimize)
                                {
                                    IncrementDS ds = program_instructions.Last() as IncrementDS;
                                    if (ds != null)
                                    {
                                        ds.Count++;
                                    }
                                    else
                                    {
                                        program_instructions.Add(new IncrementDS());
                                    }
                                }
                                else
                                {
                                    sb.AppendLine(mappings[ch]);
                                }
                                break;

                            case '-':
                                if (optimize)
                                {
                                    DecrementDS ds = program_instructions.Last() as DecrementDS;
                                    if (ds != null)
                                    {
                                        ds.Count++;
                                    }
                                    else
                                    {
                                        program_instructions.Add(new DecrementDS());
                                    }
                                }
                                else
                                {
                                    sb.AppendLine(mappings[ch]);
                                }
                                break;

                            case '.':
                            case ',':
                            case '[':
                            case ']':
                                if (optimize)
                                {
                                    program_instructions.Add(mappings[ch]);
                                }
                                else
                                {
                                    sb.AppendLine(mappings[ch]);
                                }
                                break;
                            default:
                                break;
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

            if (optimize)
            {
                //convert all instructions to strings
                for (int i = 1; i < program_instructions.Count; i++)
                {
                    sb.AppendLine(program_instructions[i].ToString());
                }
            }

            sb.Append("} }");

            File.WriteAllText(out_cs, sb.ToString());

            Console.WriteLine("Compiling....");

            var csc = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", "v3.5" } });
            var parameters = new CompilerParameters(new[] { "mscorlib.dll", "System.Core.dll" }, out_exe, false);
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
