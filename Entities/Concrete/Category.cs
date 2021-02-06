using Core.Entities;



namespace Entities.Concrete
{
    //Ciplak Class Kalmasin - Eger ki bir class herhangi bir inheritance veya implementation almazsa ileride problem yasanir.
    public class Category:IEntity
    {

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }



    }
}
