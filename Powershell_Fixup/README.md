Powershell Fixup
================
This challenge is to find a bug and add a feature to an existing Powershell script.  The script file copy_configs_with_eventlogappender.ps1 is the script with a bug.  This script will also be the basis for the new feature.

Bug
---
The Powershell script is written to look at all the config files in the .\source folder, identify the files that contain a Log4NET EventLogAppender, and copy those config files to the .\destination folder.  Right now, the script doesn't copy anything.  The bug needs to be found and fixed.  (There is extra credit for modifying the script to process fewer files.)

Feature
-------
Along with copying the appropriate files, a manifest file needs to be written in the directory above .\destination.  This file needs to contain a list of all config files with the Log4NET appenders that each contains.  A sample line in the file should look like:

```
myapp.config:RollingLogFileAppender,EventLogAppender
```