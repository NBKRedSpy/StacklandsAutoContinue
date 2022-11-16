Copy-Item ..\StacklandsAutoContinue\bin\Release\netstandard2.0\StacklandsAutoContinue.dll -Destination .
Copy-Item ..\README.md
Get-ChildItem -Exclude *.zip | Compress-Archive -Force -DestinationPath ./StacklandsSkipIntro.zip
