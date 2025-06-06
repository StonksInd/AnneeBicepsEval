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
        [Fact(DisplayName ="1900 pas bis")]
        public void Annee_1900_N_Est_Pas_Bissextile()
        {
            bool resultat = Calendrier.EstBissextile(1900);
            Assert.False(resultat);
        }
        [Fact(DisplayName = "2000 est bis")]
        public void Annee_2000_Est_Bissextile()
        {
            bool resultat = Calendrier.EstBissextile(2000);
            Assert.True(resultat);
        }

    }



}
