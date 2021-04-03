using Bogus;
using BogusExtensions.Models;
using System;
using System.Collections.Generic;
using static BogusExtensions.Models.Enums;

namespace BogusExtensions
{
    public static class BogusExtensions
    {
        public static List<UserDto> GetFakeUsers(int numUsers)
        {
            var userIds = 0;
            var testUsers = new Faker<UserDto>()
               //Optional: Call for objects that have complex initialization
               .CustomInstantiator(f => new UserDto(++userIds, f.Random.Replace("###-##-####")))

               //Basic rules using built-in generators
               .RuleFor(u => u.Gender, f => f.PickRandom<Gender>())
               .RuleFor(u => u.FirstName, (f, u) => {
                   switch (u.Gender)
                   {
                       case Gender.Male:
                           return f.Name.FirstName(Bogus.DataSets.Name.Gender.Male);
                       case Gender.Female:
                           return f.Name.FirstName(Bogus.DataSets.Name.Gender.Female);
                       case Gender.DidNotSpecify:
                       case Gender.None:
                       default:
                           return f.Name.FirstName(f.Random.Int(0) % 2 == 0 ? Bogus.DataSets.Name.Gender.Male : Bogus.DataSets.Name.Gender.Female);
                   }
               })
               .RuleFor(u => u.LastName, (f, u) => {
                   switch (u.Gender)
                   {
                       case Gender.Male:
                           return f.Name.LastName(Bogus.DataSets.Name.Gender.Male);
                       case Gender.Female:
                           return f.Name.LastName(Bogus.DataSets.Name.Gender.Female);
                       case Gender.DidNotSpecify:
                       case Gender.None:
                       default:
                           return f.Name.LastName(f.Random.Int(0) % 2 == 0 ? Bogus.DataSets.Name.Gender.Male : Bogus.DataSets.Name.Gender.Female);
                   }
               })
               .RuleFor(u => u.Avatar, f => f.Internet.Avatar())
               .RuleFor(u => u.UserName, (f, u) => f.Internet.UserName(u.FirstName, u.LastName))
               .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
               .RuleFor(u => u.SomethingUnique, f => $"Value {f.UniqueIndex}")
               .RuleFor(u => u.uuid, Guid.NewGuid)

               //Use a method outside scope.
               //And composability of a complex collection.
               //After all rules are applied finish with the following action
               .FinishWith((f, u) =>
               {
                   Console.WriteLine("User Created! Name={0} {1}", u.FirstName, u.LastName );
               });

            var users = testUsers.Generate(numUsers);
            return users;
        }

    }
}
