namespace Ecran;

static class Program {
    static void Main() {
        ElectricEcran electricEcran = new ElectricEcran(30, 10);
        
        electricEcran.ShowEcran();
        electricEcran.HideEcran();
    }
}
