.PHONY: all bindir

all: launcher

bindir:
	mkdir -p bin/

launcher: bindir src/launcher.cs
	mcs -out:bin/launcher.exe -win32icon:img/haxe.ico -r:System.Windows.Forms -target:winexe src/launcher.cs
