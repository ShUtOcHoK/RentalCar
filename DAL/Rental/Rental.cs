namespace RentalCar.DAL.Rental
{
    public class Rental
    {
       public int Id {get;set;}
       public int PersonalData_Id {get;set;}
       public int Car_Id {get;set;}
       public DateTime FirstDate {get;set;}
       public DateTime LastDate {get;set;}
       public int Price {get;set;}
       public int Discount {get;set;}
    }
}
