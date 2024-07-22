using UnityEngine;

public class ResetStaticDataManager : MonoBehaviour
{
    private void Awake()
    {
        CuttingCounter.ResetStaticData();
        BaseContainer.ResetStaticData();
        TrashCounter.ResetStaticData();
    }
}
