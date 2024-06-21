namespace Enumeracoes.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0, //Não é Necessário declarar um valor, o C# comecará automaticamente com 0
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
