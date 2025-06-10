using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class Thumbnail : MonoBehaviour
{
    private FurnitureDataSO _furnitureDataSO;
    private Image _image;
    [SerializeField] private Sprite _defaultSprite;
    public UserInput _userInput;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _image = GetComponent<Image>();
    }

    // Update is called once per frame
    public void SetFurnitureData(FurnitureDataSO furnitureDataSO)
    {
        _furnitureDataSO = furnitureDataSO;
        Sprite thumbnailSprite = _furnitureDataSO.m_thumbnailJPG;
        if (_image == null) _image = GetComponent<Image>();
        if(thumbnailSprite != null) _image.sprite = _furnitureDataSO.m_thumbnailJPG;
        else _image.sprite = _defaultSprite;
    }

    public void OnClick()
    {
        Debug.Log(_furnitureDataSO.m_name);
        _userInput.UpdateFurnitureData(_furnitureDataSO);
    }
}
