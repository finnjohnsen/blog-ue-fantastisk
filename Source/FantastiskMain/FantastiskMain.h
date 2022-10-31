#pragma once

#include "CoreMinimal.h"
#include "Modules/ModuleInterface.h"

class FFantastiskMain : public IModuleInterface
{ 
public:
    static inline FFantastiskMain& Get()
    {
        return FModuleManager::LoadModuleChecked<FFantastiskMain>("FantastiskMain");
    }

    static inline bool IsAvailable() 
    {
        return FModuleManager::Get().IsModuleLoaded("FantastiskMain");
    }

    virtual void StartupModule() override;
    virtual void ShutdownModule() override;
};
