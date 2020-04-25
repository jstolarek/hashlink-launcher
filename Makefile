.PHONY: all bindir

all: bindir launcher

bindir:
	mkdir -p bin/

launcher: src/launcher.cs
	mcs -out:bin/launcher.exe -win32icon:img/haxe.ico src/launcher.cs
