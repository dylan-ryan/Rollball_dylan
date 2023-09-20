using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class MoveGate : MonoBehaviour
{   
    private int count;
    public TextMeshProUGUI countText;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count == 8)
        {
            transform.position = new Vector3(0f, -50f, 30f);
        }
    }
}
