using Match3;
using UnityEngine;
using UnityEngine.UI;

public class WitchRoomSceneUI : MonoBehaviour
{
    [SerializeField]
    private LevelList levelList;
    [SerializeField]
    private Button playBtn;

    private void Awake()
    {
        playBtn.onClick.AddListener(()=>{ levelList.LoadLevel(0); });
    }
}
