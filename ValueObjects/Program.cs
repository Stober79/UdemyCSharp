using System;

namespace ValueObjects
{
    class Program
    {
        public static void Main(string[] args)
        {
            var mappper = new UserMapper();
            var entity = new UserEntity
            {
                Name = "Robert",
                Age = 42,
                Email = "przykładowy@email.com"
            };
            var dto = mappper.Map(entity);
            var viewModel = mappper.Map(dto);
            
        }
    }
}
