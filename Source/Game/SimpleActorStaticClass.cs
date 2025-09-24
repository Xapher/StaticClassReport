using System;
using System.Collections.Generic;
using FlaxEngine;

namespace Game;

/// <summary>
/// SimpleActorStaticClass Script.
/// Holds a single instence of an actor and it's called count to provide evidence for non-disposed static classes
/// </summary>
public static class SimpleActorStaticClass 
{
    static Actor actorReference;

    static int calledCount = 0;

    static SimpleActorStaticClass()
    {
        Debug.Log(actorReference);
    }

    public static void setActor(Actor a)
    {
        Debug.Log("Call Count: " + calledCount + " --------------------------------------- ");
        Debug.Log(actorReference);
        actorReference = a;
        calledCount++;
        Debug.Log("Call Count: " + calledCount + " --------------------------------------- ");
        Debug.Log(actorReference);
    }
}
