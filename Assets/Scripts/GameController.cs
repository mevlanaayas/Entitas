using UnityEngine;

public class GameController : MonoBehaviour
{
    private RootSystems _systems;

    private void Start()
    {
        // var contexts = new Contexts();
        var contexts = Contexts.sharedInstance;

        _systems = new RootSystems(contexts);
        _systems.Initialize();
    }

    private void Update()
    {
        _systems.Execute();
    }
}