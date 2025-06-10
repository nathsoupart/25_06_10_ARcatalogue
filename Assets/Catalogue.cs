using UnityEngine;

public class Catalogue : MonoBehaviour
{   
    public FurnitureDataSO[] m_catalogue;
    [SerializeField] GameObject m_thumbnailPrefab;
    [SerializeField] Transform _thumbnailContainer;
    [SerializeField] UserInput _userInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (var furnitureData in m_catalogue)
        {
            GameObject furnitureObject = Instantiate(m_thumbnailPrefab, _thumbnailContainer);
            Thumbnail script = furnitureObject.GetComponent<Thumbnail>();
            script.SetFurnitureData(furnitureData);
            script._userInput = _userInput;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
