using UnityEngine;
using TMPro;

public class PlayerQuest : MonoBehaviour
{
    [SerializeField] private int bananasToCollect = 10;
    [SerializeField] private TMP_Text bananaText;
    [SerializeField] private AudioClip pickupSoundEffect;
    private int bananas = 0;
    private AudioSource audioSource;

    private void Start()
    {
        bananaText.text = "" + bananas;
        audioSource = GetComponent<AudioSource>();
    }

    public void AddBanana()
    {
        bananas++;
        bananaText.text = "" + bananas;
        audioSource.pitch = Random.Range(0.8f, 1.2f);
        audioSource.PlayOneShot(pickupSoundEffect);
    }

    public int GetBananas() { return bananas; }
    public int GetBananasToCollect() { return bananasToCollect; }

}
