using Entitas.Unity;
using UnityEngine;

public class CannonView : MonoBehaviour, ICannonFireListener
{
    [SerializeField] private float reloadTime;
    [SerializeField] private Transform shootingPoint;

    public CannonEntity linkedEntity;
    private void Start()
    {
        linkedEntity = Contexts.sharedInstance.cannon.CreateEntity();
        gameObject.Link(linkedEntity);

        linkedEntity.isCannonBase = true;
        linkedEntity.AddCannonReloadTime(reloadTime);
        linkedEntity.AddCannonShootingPoint(shootingPoint);
        linkedEntity.AddTransform(transform);
        
        linkedEntity.AddCannonFireListener(this);
    }

    public void OnCannonFire(CannonEntity entity)
    {
        linkedEntity.ReplaceCannonReloadTime(reloadTime);
        entity.isCannonLaunch = false;
    }
}
