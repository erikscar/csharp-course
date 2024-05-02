namespace ExerciciosMembrosEstaticos
{
    internal class ConversorDeMoeda
    {
        public static double Dolar;
        
        public static double Conversor(double quantidade)
        {
            double reais = Dolar * quantidade;

            return (reais + reais * 0.06);
        }

    }
}
