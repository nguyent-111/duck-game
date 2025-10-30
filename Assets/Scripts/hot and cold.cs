using UnityEngine;

public class ProximityColorChanger : MonoBehaviour
{
    
    [Tooltip("Drag the Exit/Target GameObject here (e.g., a coin or flag).")]
    public Transform targetTransform; 
    
    [Tooltip("The distance at which the color starts changing (Coldest point).")]
    public float maxEffectiveDistance = 10.0f; 
    
    [Tooltip("The distance at which the target is considered 'Found' (Hottest point).")]
    public float winDistance = 1.0f; 

    
    private Color coldColor = new Color(0.2f, 0.5f, 1.0f); 

    private Color hotColor = new Color(1.0f, 0.2f, 0.2f); 

    private SpriteRenderer spriteRenderer;

    void Start()
    {
       
        spriteRenderer = GetComponent<SpriteRenderer>();

       
        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer component not found! Please attach this script to a GameObject with a SpriteRenderer (your duck).");
            enabled = false; 
        }

        if (targetTransform == null)
        {
            Debug.LogWarning("Target Transform is not set! Please drag your Exit GameObject onto the 'Target Transform' slot in the Inspector.");
        }
    }

    void Update()
    {
        
        if (targetTransform != null)
        {
           
            float distance = Vector3.Distance(transform.position, targetTransform.position);

            
            float clampedDistance = Mathf.Clamp(distance, winDistance, maxEffectiveDistance);

            
            float t = 1.0f - (clampedDistance - winDistance) / (maxEffectiveDistance - winDistance);

            t = Mathf.Pow(t, 2.0f); 

            Color newColor = Color.Lerp(coldColor, hotColor, t);

            
            spriteRenderer.color = newColor;

           
            if (distance <= winDistance)
            {
                Debug.Log("🎉 Exit Found! You win! 🎉");
               
            }
        }
    }
}
