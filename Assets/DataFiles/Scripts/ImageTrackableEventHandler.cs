using UnityEngine;
public class ImageTrackableEventHandler : DefaultTrackableEventHandler
{
    #region PROTECTED_METHODS

    public static bool isTrakingFound = false;
    public bool autoplay = true;
    bool isFirst = true;
    public GameObject HelpPanel;

    [SerializeField]
    protected Animator animator;

    protected override void OnTrackingLost()
    {
        isTrakingFound = false;
        var objAudioCon = mTrackableBehaviour.GetComponentsInChildren<AudioSource>();

        for (int i = 0; i < objAudioCon.Length; i++)
        {
            mTrackableBehaviour.GetComponentsInChildren<AudioSource>()[i].Pause();
        }
        if(animator != null)
            animator.enabled = false;

        HelpPanel.SetActive(true);

        base.OnTrackingLost();
    }

    protected override void OnTrackingFound()
    {
        isTrakingFound = true;
        Debug.Log("#### Traking Found");
        if (autoplay)
        {
            
            var objAudioCon = mTrackableBehaviour.GetComponentsInChildren<AudioSource>();

            Debug.Log("####### Animation List:" );

            for (int i = 0; i < objAudioCon.Length; i++)
            {
                mTrackableBehaviour.GetComponentsInChildren<AudioSource>()[i].Play();
            }
            if (animator != null)
                animator.enabled = true;
            // animator start from first Node
			
			Animation[] animationComponents = GetComponentsInChildren<Animation>();
			if(isFirst && animationComponents != null)
            {
                foreach (Animation component in animationComponents)
                {
                    //component.Play();
                    component.Rewind();
                }
                isFirst = false;
            }
            /*GameObject plane = GameObject.Find("Plane");
            if (plane != null)
            {
                plane.transform.localScale = new Vector3(0.16453f, 0.16453f, 0.16453f);
            }*/
        }

        HelpPanel.SetActive(false);

        base.OnTrackingFound();
    }

    #endregion // PROTECTED_METHODS
}
