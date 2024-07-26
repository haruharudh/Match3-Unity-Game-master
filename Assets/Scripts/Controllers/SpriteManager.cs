using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    public static SpriteManager Instance { get; private set; }

    public NormalItemSprites normalItemSprites;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public Sprite GetSpriteForNormalItem(NormalItem.eNormalType itemType)
    {
        switch (itemType)
        {
            case NormalItem.eNormalType.TYPE_ONE:
                return normalItemSprites.TypeOneSprite;
            case NormalItem.eNormalType.TYPE_TWO:
                return normalItemSprites.TypeTwoSprite;
            case NormalItem.eNormalType.TYPE_THREE:
                return normalItemSprites.TypeThreeSprite;
            case NormalItem.eNormalType.TYPE_FOUR:
                return normalItemSprites.TypeFourSprite;
            case NormalItem.eNormalType.TYPE_FIVE:
                return normalItemSprites.TypeFiveSprite;
            case NormalItem.eNormalType.TYPE_SIX:
                return normalItemSprites.TypeSixSprite;
            case NormalItem.eNormalType.TYPE_SEVEN:
                return normalItemSprites.TypeSevenSprite;
            default:
                return null;
        }
    }
}
