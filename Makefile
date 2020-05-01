.PHONY: all bindir clean

all: launcher

bindir:
	mkdir -p bin/

launcher: bindir src/launcher.cs
	mcs -out:bin/launcher.exe -win32icon:img/icon.ico -r:System.Windows.Forms -target:winexe src/launcher.cs

clean:
	rm bin/launcher.exe
