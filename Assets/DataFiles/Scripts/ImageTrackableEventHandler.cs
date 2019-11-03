using UnityEngine;
public class ImageTrackableEventHandler : DefaultTrackableEventHandler
{
    #region PROTECTED_METHODS

    public bool autoplay = true;

    public GameObject HelpPanel;

    [SerializeField]
    protected Animator animator;

    protected override void OnTrackingLost()
    {   
        var objAudioCon = mTrackableBehaviour.GetComponentsInChildren<AudioSource>();

        for (int i = 0; i < objAudioCon.Length; i++)
        {
            mTrackableBehaviour.GetComponentsInChildren<AudioSource>()[i].Pause();
        }

        animator.enabled = false;

        HelpPanel.SetActive(true);

        base.OnTrackingLost();
    }

    protected override void OnTrackingFound()
    {

        if (autoplay)
        {
            
            var objAudioCon = mTrackableBehaviour.GetComponentsInChildren<AudioSource>();

            Debug.Log("####### Animation List:" );

            for (int i = 0; i < objAudioCon.Length; i++)
            {
                mTrackableBehaviour.GetComponentsInChildren<AudioSource>()[i].Play();
            }

            animator.enabled = true;
            // animator start from first Node

            GameObject plane = GameObject.Find("Plane");
            if (plane != null)
            {
                plane.transform.localScale = new Vector3(0.16453f, 0.16453f, 0.16453f);
            }
        }

        HelpPanel.SetActive(false);

        base.OnTrackingFound();
    }

    #endregion // PROTECTED_METHODS
}
