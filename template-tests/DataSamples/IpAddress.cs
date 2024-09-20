namespace MyTests.DataSamples;

using System.Net;

public static class IPAddressHelper
{
    public static bool IsValid(string value)
    {
        try
        {
            var ip = IPAddress.Parse(value);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    public static bool IsNotSupported(string value)
    {
        try
        {
            var ip = IPAddress.Parse(value);
            if (ip.IsIPv6LinkLocal ||
                ip.IsIPv6Multicast ||
                ip.IsIPv6SiteLocal ||
                ip.IsIPv6Teredo)
                return true;

            if (IPAddress.IsLoopback(ip))
                return true;
            else
            {
                return false;
            }
        }
        catch (Exception)
        {
            return false;
        }
    }
}