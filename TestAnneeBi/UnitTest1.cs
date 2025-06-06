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

    }



}
