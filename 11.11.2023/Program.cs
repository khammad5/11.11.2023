using System.Text;
#region task1
string words = "Salamnecesen"; string ReversedOne(string value)
{
    StringBuilder builder = new StringBuilder();
    for (int i = value.Length - 1; i >= 0; i--)
    {
        builder.Append(value[i]);
    }
    return builder.ToString();
    
}
#endregion