using UnityEngine;


namespace DisaExten
{
  public static class VectorExtensions
  {
    #region Vector3 Set
    public static Vector3 setX( this Vector3 data, float x )
      => new Vector3( x, data.y, data.z );

    public static Vector3 setY( this Vector3 data, float y )
      => new Vector3( data.x, y, data.z );

    public static Vector3 setZ( this Vector3 data, float z )
      => new Vector3( data.x, data.y, z );
    #endregion

    #region Vector2 Set
    public static Vector2 setX( this Vector2 data, float x )
      => new Vector2( x, data.y );

    public static Vector2 setY( this Vector2 data, float y )
      => new Vector2( data.x, y );

    public static Vector3 setZ( this Vector2 data, float z )
      => new Vector3( data.x, data.y, z );
    #endregion

    #region Vector 3 Plus
    public static Vector3 plusX( this Vector3 data, float x )
      => new Vector3( data.x + x, data.y, data.z );

    public static Vector3 plusY( this Vector3 data, float y )
      => new Vector3( data.x, data.y + y, data.z );

    public static Vector3 plusZ( this Vector3 data, float z )
      => new Vector3( data.x, data.y, data.z + z );

    public static Vector3 plusX( this Vector2 data, float x )
      => new Vector3( data.x + x, data.y, 0.0f );

    public static Vector3 plusY( this Vector2 data, float y )
      => new Vector3( data.x, data.y + y, 0.0f );
    #endregion

    #region Distance
    public static float distanceTo( this Vector3 from, Vector3 to )
      => Vector3.Distance( @from, to );

    public static float distanceTo( this Vector2 from, Vector2 to )
      => Vector2.Distance( @from, to );
    #endregion

    #region ResetPosition
    public static void reset( this Transform data )
    {
      data.localPosition = Vector3.zero;
      data.localRotation = Quaternion.identity;
      data.localScale = Vector3.one;
    }
    #endregion

    #region NormalizeRotation
    private static readonly float HALF_ROTATION = 180.0f;
    private static readonly float FULL_ROTATION = 360.0f;


    public static Vector3 normalizeRotation( this Vector3 rotation )
    {
      return new Vector3( normAngle( rotation.x ), normAngle( rotation.y ), normAngle( rotation.z ) );

      float normAngle( float angle )
      {
        if ( angle > HALF_ROTATION )
          angle -= FULL_ROTATION;

        return angle;
      }
    }
    #endregion
  }
}
