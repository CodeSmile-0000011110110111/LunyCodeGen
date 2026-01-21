using System;

namespace LunyCodeGen
{
	internal class Program
	{
		static int Main(string[] args)
		{
			Console.WriteLine("LunyCodeGen - Luny API Code Generator");
			Console.WriteLine("Version 0.1.0");
			Console.WriteLine();

			if (args.Length == 0)
			{
				Console.WriteLine("Usage: LunyCodeGen [--input <path>] [--validation-only] [--dry-run] [--verbose]");
				Console.WriteLine();
				Console.WriteLine("Arguments:");
				Console.WriteLine("  --input <path>       Directory or file to scan for descriptors (repeatable)");
				Console.WriteLine("                       Default: current directory");
				Console.WriteLine("  --validation-only    Parse and validate only, don't generate");
				Console.WriteLine("  --dry-run           Show what would be generated without writing files");
				Console.WriteLine("  --verbose           Detailed logging");
				Console.WriteLine();
				return 0;
			}

			// TODO: Implement descriptor discovery and generation
			Console.WriteLine("Code generation not yet implemented.");
			return 0;
		}
	}
}
