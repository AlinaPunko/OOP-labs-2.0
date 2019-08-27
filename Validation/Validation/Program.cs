using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    public class UserNameAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string userName = value.ToString();
                if (!userName.StartsWith("T"))
                    return true;
                else
                    this.ErrorMessage = "Имя не должно начинаться с буквы T";
            }
            return false;
        }
    }
    public class UserValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            User user = value as User;
            if (user.Name == "Alice" && user.Age == 33)
            {
                this.ErrorMessage = "Имя не должно быть Alice и возраст одновременно не должен быть равен 33";
                return false;
            }
            return true;
        }
    }
    [UserValidation]
    public class User
    {
        [Required]
        public string Id { get; set; }
        [Required]
        [UserName]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User { Id = "", Name = "Tom", Age = -22 };
            Validate(user1);
            Console.WriteLine();
            User user2 = new User { Id = "d3io", Name = "Alice", Age = 33 };
            Validate(user2);

            Console.Read();
        }
        private static void Validate(User user)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(user);
            if (!Validator.TryValidateObject(user, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
                Console.WriteLine("Пользователь прошел валидацию");
        }
    }
}
