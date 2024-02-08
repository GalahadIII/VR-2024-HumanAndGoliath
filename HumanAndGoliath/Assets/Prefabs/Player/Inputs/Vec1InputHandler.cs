
using UnityEngine;

public class Vec1InputHandler {


    public float ConsecutiveTaps;
    private float ConsecutiveTapsLast;
    private float ConsecutiveTimeoutMs = 0.1f;


    public float OnDownFrame;
    public float OnDownFixed;
    public float OnDownLast;

    public float OnUpFrame;
    public float OnUpFixed;
    public float OnUpLast;

    public float IsDown;
    public float WasDown;

    public float IsUp   { get { return  IsDown != 0f ? 0f : 1f; } }
    public float WasUp  { get { return WasDown != 0f ? 0f : 1f; } }



    public Vec1InputHandler(){



    }

    public void UpdateFrame(float liveInput){

        // (<float> != 0) => bool => c equiv (<float>)

        WasDown = IsDown;
        IsDown = liveInput;

        OnDownFixed = OnDownFrame = (IsDown != 0f) && ! (WasDown != 0f) ? 1f : 0f; // isDown && !wasDown  ?  1f  :  0f
        OnUpFixed   = OnUpFrame   = (IsUp   != 0f) && ! (WasUp   != 0f) ? 1f : 0f; // isUp   && !wasUp    ?  1f  :  0f

        if (OnDownFrame != 0f) {
            OnDownLast = Time.time;
        }
        if (OnUpFrame != 0f) {
            OnUpLast = Time.time;
        }

        if ((OnDownFrame != 0f) || (OnUpFrame != 0f)) {

            ConsecutiveTaps += 0.5f;
            // float TimeOutAfter = ConsecutiveTapsLast + ConsecutiveTimeoutMs;
            if (ConsecutiveTapsLast + ConsecutiveTimeoutMs > Time.time) { // !TimedOut
                ConsecutiveTapsLast = Time.time;
            } else {
                ConsecutiveTaps = 0f;
            }
        }

    }

    public void UpdateFixedLate(){

        OnDownFixed = 0f;
        OnUpFixed = 0f;

        // if (ConsecutiveTapsLast + DelayConsecutiveMS < Time.time) {}

    }

}
