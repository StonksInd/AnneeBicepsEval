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
    }



}
