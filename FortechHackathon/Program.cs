namespace FortechHackathon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string encryptedText = ">&%%S,^Kf*10zc3n5,4QQ1<6NRL^43^y91je62<L,OMP!l91PPWRwM;2S4Zy?*#XU!hS%;eKQf^^L%>MN3K";

            //Console.WriteLine(encryptedText);
            Console.WriteLine(DecryptClass.Task1(encryptedText));
        }
    }
}