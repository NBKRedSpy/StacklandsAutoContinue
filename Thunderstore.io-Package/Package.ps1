$ProjectName = "StacklandsAutoContinue"
Copy-Item "..\$ProjectName\bin\Release\netstandard2.1\$ProjectName.dll" -Destination .
Copy-Item ..\README.md
Get-ChildItem -Exclude *.zip,*.ps1 | Compress-Archive -Force -DestinationPath ./$ProjectName.zip
