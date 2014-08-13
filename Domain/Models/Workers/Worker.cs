using Domain.Models.Base;

namespace Domain.Models.Workers {
    public class Worker : Entity {
        public Worker(string name, string lastName) {
            Name = name;
            LastName = lastName;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}