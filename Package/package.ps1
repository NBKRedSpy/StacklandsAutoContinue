$ProjectName = "StacklandsAutoContinue"

Remove-Item -Recurse -ErrorAction SilentlyContinue -Force $ProjectName
mkdir $ProjectName > $null
Copy-Item "..\$ProjectName\bin\Release\netstandard2.1\$ProjectName.dll" -Destination $ProjectName
Copy-Item "..\$ProjectName\bin\Release\netstandard2.1\manifest.json" -Destination $ProjectName
Copy-Item ..\README.md ./$ProjectName/
#Get-ChildItem $ProjectName -Exclude *.zip,*.ps1 | Compress-Archive -Force -DestinationPath ./$ProjectName.zip
Compress-Archive -Force $ProjectName -DestinationPath ./$ProjectName.zip

