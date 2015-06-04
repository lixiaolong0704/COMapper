namespace COMapper
{
    public class CustomGridLookUpEditHelper
    {
        public static string GetSplit(string NameValue, int index)
        {
            if (!string.IsNullOrEmpty(NameValue.Trim()))
            {
                if (NameValue.Trim().Split('-').Length > 1)
                {
                    return NameValue.Trim().Split('-')[index];
                }
                else if (NameValue.Trim().Split('-').Length == 1)
                {
                    if (index == 0)
                    {
                        return NameValue.Trim().Split('-')[index];
                    }
                    else
                    {
                        return "";
                    }
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }
    }
}
