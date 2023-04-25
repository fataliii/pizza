using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Services.Interfaces
{
    public interface IPizzaService
    {
        public Task Create();
        public Task Update();
        public Task Delete();
        public Task ShowAll();
        public Task ShowById();
    }
}
