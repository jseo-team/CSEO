#!/bin/sh
mcs *.cs -out:cseo.exe
mono cseo.exe cseo.txt
