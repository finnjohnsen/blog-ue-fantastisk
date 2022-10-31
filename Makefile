UE_BYGG="C:\Program Files\Epic Games\UE_5.0\Engine\Build\BatchFiles\Build.bat"
UE_EDITOR="C:\Program Files\Epic Games\UE_5.0\Engine\Binaries\Win64\UnrealEditor.exe"
UE_EDITOR_CMD="C:\Program Files\Epic Games\UE_5.0\Engine\Binaries\Win64\UnrealEditor-Cmd.exe"

U_PROJECT="C:\src\fantastisk\Fantastisk.uproject"
EXE="C:\src\fantastisk\Binaries\Win64\Fantastisk.exe"

# Bygger .dll til editoren
build-editor: 
	$(UE_BYGG) FantastiskEditor Win64 Development $(U_PROJECT) -waitmutex -NoHotReload

editor:
	$(UE_EDITOR) $(U_PROJECT) -log

run-game:
	$(UE_EDITOR) $(U_PROJECT) -game -log -windowed -resx=1280 -resy=720

build-standalone-executable:
	$(UE_BYGG) Fantastisk Win64 Development $(U_PROJECT) -waitmutex -NoHotReload

build-exe: build-standalone-executable

cook:
	$(UE_EDITOR_CMD) $(U_PROJECT) -run=cook -targetplatform=Windows


run-exe:
	$(EXE) -log -windowed -resx=1280 -resy=720

clean: 
	-rd /s /q .vscode
	-rd /s /q Binaries
	-rd /s /q Intermediate
	-rd /s /q Saved
	-rd /s /q Fantastisk.code-workspace
	-rd /s /q Build

