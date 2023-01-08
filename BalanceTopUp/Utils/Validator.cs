using System.Text.RegularExpressions;

namespace BalanceTopUp.Utils
{
    public static class Validator
    {
        public static bool CheckNumber(string number)
        {
            return Regex.Match(number, @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$").Success;
        }
    }
}