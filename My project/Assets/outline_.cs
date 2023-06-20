using UnityEngine;

public class OutlineObject : MonoBehaviour
{
    public Material outlineMaterial;
    public Color outlineColor;

    private Material[] defaultMaterials;
    private Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        defaultMaterials = renderer.materials;
    }

    private void OnMouseEnter()
    {
        Material[] materials = new Material[defaultMaterials.Length];
        for (int i = 0; i < defaultMaterials.Length; i++)
        {
            materials[i] = outlineMaterial;
            materials[i].SetColor("_OutlineColor", outlineColor);
        }
        renderer.materials = materials;
    }

    private void OnMouseExit()
    {
        renderer.materials = defaultMaterials;
    }
}