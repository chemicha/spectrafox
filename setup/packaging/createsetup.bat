@echo off
echo ---------------------------------------
echo  Starting SpectraFox setup compilation
echo  #
echo  # running compilation of elevated privilege setup ...
"C:\Program Files (x86)\Inno Setup 5\iscc.exe" /dCmdPrivRequired=admin /F"spectrafox-stable" "x64x86_TwoArch.iss" > x64x86_TwoArch.log
echo  # finished!
echo  #
echo  # running compilation of low privilege setup ...
"C:\Program Files (x86)\Inno Setup 5\iscc.exe" /dCmdPrivRequired=lowest /F"spectrafox-stable_lowpriv" "x64x86_TwoArch.iss" > x64x86_TwoArch_LowPrivilege.log
echo  # finished!
echo  #
echo  ByeBye!
echo ---------------------------------------
pause