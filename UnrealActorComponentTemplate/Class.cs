using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

[UClass]
public class $safeitemrootname$ : UActorComponent
{
    public override void Initialize(FObjectInitializer initializer)
    {
    base.Initialize(initializer);
    // Open Tick
    //PrimaryActorTick.SetStartWithTickEnabled(true);
    //PrimaryActorTick.SetCanEverTick(true);
    }

    public override void BeginPlay()
    {
        base.BeginPlay();
    }

    //Receive Tick Fun
    //protected override void ReceiveTick_Implementation(float DeltaSeconds)
    //{
    //    base.ReceiveTick_Implementation(DeltaSeconds);
    //}

}
