$ProjectName = "StacklandsAutoContinue"
Copy-Item "..\$ProjectName\bin\Release\netstandard2.0\$ProjectName.dll" -Destination .
Copy-Item ..\README.md
Get-ChildItem -Exclude *.zip | Compress-Archive -Force -DestinationPath ./$ProjectName.zip
