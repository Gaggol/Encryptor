@echo off
if "%1" == "Release" (
    echo Release Build
    goto RELEASE
) else (
    echo Non-release build
    goto:eof
)
:RELEASE
cd bin\release\
rmdir %3
del %3.rar
del %3Libs.rar
mkdir %3
copy %2 %3\
copy %2.config %3\
rar a %3 %3
copy *.dll %3\
rar a %3Libs %3