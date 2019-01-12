@ECHO OFF
ECHO Definition Directory: %1
ECHO Output Directory: %2
ECHO.
ECHO The kaitai definitions will be compiled into source code. This will take some time once started.
ECHO There is no progress reporting, please wait until the process is finished.
PAUSE
CD /D %1
FORFILES /s /m *.yml /c "cmd /c call kaitai-struct-compiler @path --outdir=%2 --target=csharp --dotnet-namespace=KCD.Library.Tables"
