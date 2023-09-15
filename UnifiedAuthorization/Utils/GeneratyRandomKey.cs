using System.Text;

namespace UnifiedAuthorization.Utils;

public class GeneratyRandomKey
{
    public string GeneratyRandomKeyJwt(int lengthKey)
    {
        const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        StringBuilder sb = new StringBuilder();
        Random random = new Random();

        for (int i = 0; i < lengthKey; i++)
        {
            int index = random.Next(validChars.Length);
            sb.Append(validChars[index]);
        }

        return sb.ToString();
    }
}