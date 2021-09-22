using System;


public class Observable<T>
{
  private T _value;
 
  public Action<Observable<T>, T, T> on_changed;


  public T value
  {
    get => _value;
    set
    {
      T old_value = _value;
      _value = value;
      on_changed?.Invoke( this, old_value, value );
    }
  }
}