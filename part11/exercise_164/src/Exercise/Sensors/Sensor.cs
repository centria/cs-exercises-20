namespace Exercise
{
  public interface Sensor
  {
    bool IsOn();    // returns true if the sensor is on
    void SetOn();      // sets the sensor on
    void SetOff();     // sets the sensor off
    int Read();        // returns the value of the sensor if it's on
                       // if the sensor is not on throw a IllegalStateException
  }
}