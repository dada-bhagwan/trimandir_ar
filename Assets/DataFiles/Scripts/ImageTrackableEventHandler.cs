using UnityEngine;
public class ImageTrackableEventHandler : DefaultTrackableEventHandler
{
    #region PROTECTED_METHODS

    public bool autoplay = true;

    protected override void OnTrackingLost()
    {

        
        var objAudioCon = mTrackableBehaviour.GetComponentsInChildren<AudioSource>();
        Animation[] animationComponents = GetComponentsInChildren<Animation>();

        for (int i = 0; i < objAudioCon.Length; i++)
        {
            mTrackableBehaviour.GetComponentsInChildren<AudioSource>()[i].Pause();
        }

        foreach (Animation component in animationComponents)
        {
            component.Stop();
            // component.Rewind();
        }

        base.OnTrackingLost();
    }

    protected override void OnTrackingFound()
    {

        base.OnTrackingFound();

        if (autoplay)
        {
            
            var objAudioCon = mTrackableBehaviour.GetComponentsInChildren<AudioSource>();
            Animation[] animationComponents = GetComponentsInChildren<Animation>();
            Debug.Log("####### Animation List:" + animationComponents.Length);
            for (int i = 0; i < objAudioCon.Length; i++)
            {
                mTrackableBehaviour.GetComponentsInChildren<AudioSource>()[i].Play();
            }
            foreach (Animation component in animationComponents)
            {
                component.Play();
            }

            GameObject plane = GameObject.Find("Plane");
            if (plane != null)
            {
                plane.transform.localScale = new Vector3(0.16453f, 0.16453f, 0.16453f);
            }
        }
    }

    #endregion // PROTECTED_METHODS
}
