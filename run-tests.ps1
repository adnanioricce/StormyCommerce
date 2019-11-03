# Get-ChildItem "test" | ?{ $_.PsIsContainer } | %{
    # pushd "test\$_"
    # & dotnet test --logger:trx
    # popd
# }
ForEach ($folder in (Get-ChildItem -Path .\test -Directory -Filter *.Tests)) { dotnet test $folder.FullName  }