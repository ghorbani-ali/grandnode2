﻿using System.Reflection;

namespace Grand.Infrastructure.Roslyn
{
    public class ResultCompiler
    {
        public Assembly ReferencedAssembly { get; internal set; }
        public string OriginalFile { get; internal set; }
        public virtual string DLLAssemblyFile { get; internal set; }
        public bool IsCompiled { get; internal set; }
        public IList<string> ErrorInfo { get; internal set; } = new List<string>();
    }
}
