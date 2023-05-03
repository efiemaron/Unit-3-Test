namespace Root
{
  public static class MoreMath
{
    
    public static int Max(int x, int y)
    {
        return Math.Max(x, y);
    }

    public static int Max(int x, int y, int z)
    {
       
        return Math.Max(x, Math.Max(y, z));
    }

    public static int Max(int w, int x, int y, int z)
    {
        return Math.Max(w, Math.Max(x, Math.Max(y, z)));
    }

    public static int Max(params int[] values)
    {
        return Enumerable.Max(values);
    }
}
}