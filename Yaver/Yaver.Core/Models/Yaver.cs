
using Yaver.Core.Models.BaseModels;

namespace Yaver.Core.Models
{
    public class Yaver:BaseModel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        private int _id;

        public Yaver()
        {
            _id++;
            Id= _id;    
        }





    }
}
