using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

[UClass]
public class $safeitemrootname$ : AActor
{
    public override void Initialize(FObjectInitializer initializer)
    {
    base.Initialize(initializer);
    // Open Tick
    //PrimaryActorTick.SetStartWithTickEnabled(true);
    //PrimaryActorTick.SetCanEverTick(true);
    }

    protected override void BeginPlay()
    {
        base.BeginPlay();
    }

    //Receive Tick Fun
    //protected override void ReceiveTick_Implementation(float DeltaSeconds)
    //{
    //    base.ReceiveTick_Implementation(DeltaSeconds);
    //}

}
