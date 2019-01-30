# quickguid
A simple project to help quickly get a new GUID

# Instruction
1. Compile the project, generate the exe file
2. Run registry editor by going to Start, then Run and then typing in REGEDIT. (Windows 7/8/10)
3. Add a new key call 'New GUID' under register Computer\HKEY_CLASSES_ROOT\Directory\Background\shell\
4. Add a new key call 'command' under the 'New GUID' you just created (Computer\HKEY_CLASSES_ROOT\Directory\Background\shell\New GUID)
5. Edit the default value to the exe path, for example C:\balabala\bin\release\MouseGuidGen.exe (can always copy the file to anywhere)
6. Done!
