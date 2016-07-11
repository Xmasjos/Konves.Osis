param([String]$file="x", [String]$version="asdf")
(Get-Content "$($file)") `
    -replace '<version>[^<]*?</version>', ('<version>{0}</version>' -f $version) |
  Out-File "$($file)"