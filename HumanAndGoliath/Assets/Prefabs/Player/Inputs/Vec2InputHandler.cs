
using UnityEngine;

public class Vec2InputHandler {

    private Vec1InputHandler x = new Vec1InputHandler();
    private Vec1InputHandler y = new Vec1InputHandler();


    public Vector2 ConsecutiveTaps { get { return new Vector2(x.ConsecutiveTaps, y.ConsecutiveTaps); } }

    public Vector2 OnDownFrame { get { return new Vector2(x.OnDownFrame, y.OnDownFrame); } }
    public Vector2 OnDownFixed { get { return new Vector2(x.OnDownFixed, y.OnDownFixed); } }

    public Vector2 OnUpFrame { get { return new Vector2(x.OnUpFrame, y.OnUpFrame); } }
    public Vector2 OnUpFixed { get { return new Vector2(x.OnUpFixed, y.OnUpFixed); } }

    public Vector2 IsDown { get { return new Vector2(x.IsDown, y.IsDown); } }
    public Vector2 WasDown { get { return new Vector2(x.WasDown, y.WasDown); } }

    public Vector2 IsUp { get { return new Vector2(x.IsUp, x.IsUp); } }
    public Vector2 WasUp { get { return new Vector2(x.WasUp, x.WasUp); } }

    public Vector2 OnDownLast { get { return new Vector2(x.OnDownLast, x.OnDownLast); } }
    public Vector2 OnUpLast { get { return new Vector2(x.OnUpLast, x.OnUpLast); } }

    // ============================================================================================

    public Vec2InputHandler(){
    }

    // ============================================================================================

    public void UpdateFrame(Vector2 liveInput){

        x.UpdateFrame(liveInput.x);
        y.UpdateFrame(liveInput.y);

    }

    // ============================================================================================

    public void UpdateFixedLate(){

        x.UpdateFixedLate();
        y.UpdateFixedLate();

    }

}
