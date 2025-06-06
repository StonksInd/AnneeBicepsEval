using AnneeBiceps;

namespace HelloWorldTests
{
    public class UnitTest1
    {


        [Fact(DisplayName = "2024 bis")]
        public void Annee_2024_Est_Bissextile()
        {
            bool resultat = Calendrier.EstBissextile(2024);
            Assert.True(resultat);
        }

        [Fact(DisplayName = "2019 pas bis")]
        public void Annee_2019_N_Est_Pas_Bissextile()
        {
            bool resultat = Calendrier.EstBissextile(2019);
            Assert.False(resultat);
        }

        [Fact(DisplayName = "divisible par 4 mais pas 100")]
        public void Annee_DivisiblePar4MaisPas100_Est_Bissextile()
        {
            bool resultat = Calendrier.EstBissextile(2020);
            Assert.True(resultat);
        }


        [Fact(DisplayName = "Les années qui ne sont pas divisibles par 4 ne sont jamais bissextiles")]
        public void Annee_NonDivisiblePar4_N_Est_Pas_Bissextile()
        {
            bool resultat = Calendrier.EstBissextile(2017);
            Assert.False(resultat);
        }

        [Fact(DisplayName = "année divisible par 100 mais pas 400")]
        public void Annee_DivisiblePar100MaisPas400_N_Est_Pas_Bissextile()
        {
            bool resultat = Calendrier.EstBissextile(1900);
            Assert.False(resultat);
        }
        [Fact(DisplayName = "année divisible par 400 est bissextile")]
        public void Annee_DivisiblePar400_Est_Bissextile()
        {
            bool resultat = Calendrier.EstBissextile(2000);
            Assert.True(resultat);
        }

    }



}
