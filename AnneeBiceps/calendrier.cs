


namespace AnneeBiceps
{
    public class Calendrier
    {
        public static bool EstBissextile(int annee)
        {
            if (annee % 400 == 0)
                return true;
            if (annee % 100 == 0)
                return false;
            if (annee % 4 == 0)
                return true;
            return false;

        }

    }
}
