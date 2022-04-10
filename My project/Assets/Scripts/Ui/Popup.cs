using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    [SerializeField] private HPElement playerHealthBar;
    [SerializeField] private RectTransform content;
    [SerializeField] private Sprite playerImage;
    [SerializeField] private Color playerHealthColor;
    [SerializeField] private Sprite enemyImage;
    [SerializeField] private Color enemyHealthColor;

    [SerializeField] private GameObject healthBar;

    // private List<GameObject> enemyHealthBars;
    // Start is called before the first frame update
 
    private void OnEnable() {
        BaseCharacter player = GameObject.Find("Player").GetComponent<BaseCharacter>();
        GameObject[] npcsObjects = GameObject.FindGameObjectsWithTag("NPC");

        if(player != null) {
            playerHealthBar.SetColor(playerHealthColor);
            playerHealthBar.SetHealthBar(player.Health/100.0f);
            playerHealthBar.SetPlayerImage(playerImage);
        }

        for (int i=0; i<npcsObjects.Length; i++) {
            BaseCharacter npc = npcsObjects[i].GetComponent<BaseCharacter>();
            if(npc != null) {
                Debug.Log("INSERTING " + npc);
                GameObject newHealthBar = GameObject.Instantiate(healthBar);
                newHealthBar.transform.SetParent(content.transform);
                HPElement element = newHealthBar.GetComponent<HPElement>();
                element.SetColor(new Color(255, 0, 0));
                //element.SetColor(enemyHealthColor);
                element.SetHealthBar(npc.Health/200.0f);
                element.SetPlayerImage(enemyImage);
            }
        }
    }
}
