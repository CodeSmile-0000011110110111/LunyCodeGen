using System;

namespace LunyCodeGen
{
	internal class Program
	{
		const string Version = "0.1.0";

		private static Int32 Main(String[] args)
		{
			PrintHeader();
			return args.Length == 0 ? PrintHelp() : Generate();
		}

		private static Int32 Generate()
		{
			var sb = new ScriptBuilder();
			Console.WriteLine("Code generation not yet implemented.");
			return -1;
		}

		private static void PrintHeader()
		{
			Console.WriteLine($"LunyCodeGen v{Version} - Luny API Code Generator");
			Console.WriteLine();
		}

		private static Int32 PrintHelp()
		{
			Console.WriteLine("Usage: LunyCodeGen [--input <path>] [--dry-run] [--verbose]");
			Console.WriteLine();
			Console.WriteLine("Arguments:");
			Console.WriteLine("  --input <path>      Directory or file to scan for descriptors (repeatable)");
			Console.WriteLine("                      Default: current directory");
			Console.WriteLine("  --dry-run           Logs actions and paths, doesn't make modifications");
			Console.WriteLine("  --verbose           Detailed logging");
			Console.WriteLine();
			return 0;
		}
	}
}
