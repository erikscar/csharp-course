using System.Globalization;

//Podemos modificar o nome do namespace para system para que não precisamos ficar utilizando o using toda vez que precisarmos dessa função
//Faz sentido já que DateTime já é do Namespace System, e adicionamos uma função a ele
namespace System 
{
    //Ela ten que ser static para utilizar os Extensions Methods
    static class DateTimeExtensions
    {
        //Utilizar o this, para indicar que é um extension method do DateTime
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
