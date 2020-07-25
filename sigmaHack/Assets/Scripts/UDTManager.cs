using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class UDTManager : MonoBehaviour , IUserDefinedTargetEventHandler
{
    private UserDefinedTargetBuildingBehaviour udt_targetBuildingBehavior;

    private ObjectTracker objectTracker;
    private DataSet dataSet;

    private ImageTargetBuilder.FrameQuality udt_FrameQuality;

    [SerializeField]private ImageTargetBehaviour targetBehavior;    
    
    private int targetCounter;
    
    
    // Start is called before the first frame update
    void Start()
    {
        udt_targetBuildingBehavior = GetComponent<UserDefinedTargetBuildingBehaviour>();
        if (udt_targetBuildingBehavior) //UserDefinedTargetBuildBehaviour has been found
        {
            udt_targetBuildingBehavior.RegisterEventHandler(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnInitialized()
    {
        objectTracker = TrackerManager.Instance.GetTracker<ObjectTracker>();
        if (objectTracker != null)
        {
            dataSet = objectTracker.CreateDataSet();
            objectTracker.ActivateDataSet(dataSet);
        }
    }

    //Method to determine picture quality
    public void OnFrameQualityChanged(ImageTargetBuilder.FrameQuality frameQuality)
    {
        udt_FrameQuality = frameQuality;
    }

    public void OnNewTrackableSource(TrackableSource trackableSource)
    {
        targetCounter++;
        objectTracker.DeactivateDataSet(dataSet);

        dataSet.CreateTrackable(trackableSource, targetBehavior.gameObject);
        objectTracker.ActivateDataSet(dataSet);
        udt_targetBuildingBehavior.StartScanning();
    }

    public void BuildTarget()
    {
        if (udt_FrameQuality == ImageTargetBuilder.FrameQuality.FRAME_QUALITY_HIGH || udt_FrameQuality == ImageTargetBuilder.FrameQuality.FRAME_QUALITY_MEDIUM)
        {
            udt_targetBuildingBehavior.BuildNewTarget(targetCounter.ToString(),targetBehavior.GetSize().x);
        }
    }
}
