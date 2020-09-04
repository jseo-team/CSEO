qjsc -e jseo.qjs.js -o jseo.qjs.c
rm jseo.final.c
echo #include "dotNet.h" >jseo.final.c
cat jseo.qjs.c >>jseo.final.c
gcc jseo.final.c -o jseo -I../quickjs -lquickjs -lpthread -ldl -lm

mcs *.cs -out:cseo.exe
