using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookIT.WebAPI.Services
{
    public interface IPreporukaService
    {
        List<Model.Smjestaj> PreporuciSmjestaje();
    }
}
