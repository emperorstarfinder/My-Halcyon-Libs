using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Inworldz.Joke.Compiler;
using Inworldz.Joke.Types;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using Inworldz.Joke.Compiler.BranchAnalyze;

namespace CompilerTests
{
    class CompilerFrontend
    {
        private System.IO.TextWriter _traceDestination;
        public System.IO.TextWriter TraceDestination
        {
            get
            {
                return _traceDestination;
            }

            set
            {
                _traceDestination = value;
            }
        }

        private ILSLListener _listener;
        public ILSLListener Listener
        {
            get
            {
                return _listener;
            }

            set
            {
                _listener = value;
            }
        }

        public Inworldz.Joke.Glue.CompilerFrontend Compile(ICharStream input)
        {
            Inworldz.Joke.Glue.CompilerFrontend frontEnd = new Inworldz.Joke.Glue.CompilerFrontend(_listener, "../../../../grammar", true);
            frontEnd.OutputASTGraph = true;

            frontEnd.Compile(input);

            return frontEnd;
        }
    }
}
