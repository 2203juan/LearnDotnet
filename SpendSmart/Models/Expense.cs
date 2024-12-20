using System.ComponentModel.DataAnnotations;
namespace SpendSmart.Models{
    public class Expense
    {
        public int Id {get; set;}
        public decimal Value {get; set;}
        [Required]
        public string? Description {get; set;}

        public string ToString(){
            return $"Id = {Id}, Value = {Value} , Description ={Description}";
        }
    }
}