REM Generic backup fie for source-code-only projects. Removes non essential inputs and intermediary compiler pipeline artifacts.
"C:\Program Files\WinRAR\rar" a -m5 -r -s -inul -agYYYY-MM-DD_NN -x*.obj -x*.ilk -x*.lib -x*.pdb -x*.idb -x*.dll -x*.ncb -x*.exe -x*.pch -x*.rar Generic-backup-
 
