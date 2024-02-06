
using UnityEngine;

public class Vec3InputHandler {

    private Vec1InputHandler x = new Vec1InputHandler();
    private Vec1InputHandler y = new Vec1InputHandler();
    private Vec1InputHandler z = new Vec1InputHandler();

    public Vector3 ConsecutiveTaps { get { return new Vector3(x.ConsecutiveTaps, y.ConsecutiveTaps, z.ConsecutiveTaps); } }

    public Vector3 OnDownFrame { get { return new Vector3(x.OnDownFrame, y.OnDownFrame, z.OnDownFrame); } }
    public Vector3 OnDownFixed { get { return new Vector3(x.OnDownFixed, y.OnDownFixed, z.OnDownFixed); } }

    public Vector3 OnUpFrame { get { return new Vector3(x.OnUpFrame, y.OnUpFrame, z.OnUpFrame); } }
    public Vector3 OnUpFixed { get { return new Vector3(x.OnUpFixed, y.OnUpFixed, z.OnUpFixed); } }

    public Vector3 IsDown { get { return new Vector3(x.IsDown, y.IsDown, z.IsDown); } }
    public Vector3 WasDown { get { return new Vector3(x.WasDown, y.WasDown, z.WasDown); } }

    public Vector3 IsUp { get { return new Vector3(x.IsUp, x.IsUp, z.IsUp); } }
    public Vector3 WasUp { get { return new Vector3(x.WasUp, x.WasUp, z.WasUp); } }

    public Vector3 OnDownLast { get { return new Vector3(x.OnDownLast, x.OnDownLast, z.OnDownLast); } }
    public Vector3 OnUpLast { get { return new Vector3(x.OnUpLast, x.OnUpLast, z.OnUpLast); } }

    // ============================================================================================

    public Vec3InputHandler(){

    }

    // ============================================================================================

    public void UpdateFrame(Vector3 liveInput){

        x.UpdateFrame(liveInput.x);
        y.UpdateFrame(liveInput.y);
        z.UpdateFrame(liveInput.z);

    }

    // ============================================================================================

    public void UpdateFixedLate(Vector3 liveInput){

        x.UpdateFixedLate();
        y.UpdateFixedLate();
        z.UpdateFixedLate();

    }

}
