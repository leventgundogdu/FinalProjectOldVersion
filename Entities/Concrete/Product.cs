using Entities.Abstract;

namespace Entities.Concrete
{
    public class Product:IEntity
    {

        //Public demek bu class'a diger katmanlar da ulasabilsin demektir.
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }


    }
}
