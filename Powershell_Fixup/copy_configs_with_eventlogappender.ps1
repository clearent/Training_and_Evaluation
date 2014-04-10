$source_files = Get-ChildItem .\source

foreach ($file in $source_files)
{
  $file_data = Get-Content ".\source\$file"
  {
    if ($file_data -match "Log4NETEventLogAppender")
    {
      Copy-Item $file_data .\destination
      
      new-modulemanifest \..\Log4NET * | 
      
     }
  }
}
