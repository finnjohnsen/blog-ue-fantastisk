#include "FantastiskMain.h"
#include "Modules/ModuleManager.h"


void FFantastiskMain::StartupModule() 
{
    UE_LOG(LogTemp, Warning, TEXT("***************************** STARTER OPP SPILL ****************************"));
}

void FFantastiskMain::ShutdownModule()
{
    UE_LOG(LogTemp, Warning, TEXT("**************************** AVSLUTTER SPILL ****************************"));
}

IMPLEMENT_PRIMARY_GAME_MODULE(FFantastiskMain, FantastiskMain, "FantastiskMain");
