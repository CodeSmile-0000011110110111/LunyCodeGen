using System;

namespace LunyCodeGen
{
	[Flags]
	public enum Space
	{
		None = 0,
		Before = 1 << 0,
		After = 1 << 1,
		BeforeAndAfter = Before | After,
	}
}
