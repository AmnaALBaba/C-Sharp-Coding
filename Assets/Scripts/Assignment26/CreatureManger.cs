using System.Collections.Generic;
using Assignment26;
using UnityEngine;
namespace Assignment26
{
public class CreatureManger : MonoBehaviour
{
    Kangroo kangroo;
    Duck duck;

    void Start()
    {
        kangroo = new Kangroo();
        duck = new Duck();
        List<Creature> creatures = new List<Creature>() { kangroo, duck };
        List<IRunnable> runnables = new List<IRunnable>();
        runnables.Add(kangroo);
        runnables.Add(duck);
        List<IJumpable> jumpables = new List<IJumpable>();
        jumpables.Add(kangroo);
        List<ISwimmable> swimmables = new List<ISwimmable>();
        swimmables.Add(duck);


        foreach (Creature creature in creatures)
        {
            creature.Speak();
        }
        foreach (IRunnable runnable in runnables)
        {
            runnable.Run();
        }
        foreach (IJumpable jumpable in jumpables)
        {
            jumpable.Jump();
        }
        foreach (ISwimmable swimmable in swimmables)
        {
            swimmable.Swim();
        }



    }

}
}
