#!/bin/sh
if [ "$1" = "--clean" ]; then
    make clean
else
    if [ -d "./obj" ]; then
        make
    else
        mkdir -p ./obj
        make
    fi
fi
