set msbuild="C:\Program Files (x86)\MSBuild\14.0\Bin\msbuild.exe"
set nuget=%cd%\nuget.exe

cd ..

%nuget% restore Mit.Email.sln

%msbuild% Mit.Email.sln /p:configuration=Release /p:platform="any cpu" /t:Clean,Build /p:VisualStudioVersion="14.0"

pause