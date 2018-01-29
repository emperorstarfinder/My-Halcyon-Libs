bin\Debug\Inworldz.Joke.Tools.exe defgen ..\..\grammar\funcs.txt ..\..\grammar\Shim.stg > ..\Inworldz.Joke\Types\Defaults.cs
bin\Debug\Inworldz.Joke.Tools.exe shimgen ..\..\grammar\funcs.txt ..\..\grammar\Shim.stg > ..\Inworldz.Joke\Glue\SyscallShim.cs
bin\Debug\Inworldz.Joke.Tools.exe apigen ..\..\grammar\funcs.txt ..\..\grammar\Shim.stg > ..\Inworldz.Joke\Glue\ISystemAPI.cs
