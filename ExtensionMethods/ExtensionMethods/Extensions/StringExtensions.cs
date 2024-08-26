namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string thisObj, int value)
        {
            if(thisObj.Length <= value) //Caso o tamanho da string for menor do que queremos cortar retornar a string apenas
            {
                return thisObj;
            }
            else
            {
                //Se não recortar a string começando da posição 0 e indo até o valor passado
                return thisObj.Substring(0, value) + "...";
            }
            
        }
    }
}
