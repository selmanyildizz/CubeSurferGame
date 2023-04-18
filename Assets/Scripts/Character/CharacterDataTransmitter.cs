using UnityEngine;

public class CharacterDataTransmitter : MonoBehaviour
{
    [SerializeField] private CharacterInputController characterInputController;


    public float GetCharacterHorizontalValue()
    {
        return characterInputController.HorizontalValue;
    }
}