
%echo off 
for /f %%a in (allpath.txt) do ( 
    
fixdatweek %%a
)

%echo ------------------------------
%echo ------------------------------
%echo ------------------------------
%echo ---------檔案處理完成---------
%echo ------------------------------
%echo ------------------------------
%echo ------------------------------

pause