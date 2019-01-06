@ECHO OFF
ECHO Definition Directory: %1
ECHO Output Directory: %2
CD /D %1
forfiles /s /m *.yml /c "cmd /c call kaitai-struct-compiler @path --outdir=%2 --target=csharp --dotnet-namespace=KCD.Kaitai"
PAUSE
