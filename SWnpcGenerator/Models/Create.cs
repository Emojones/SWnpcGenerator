using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SWnpcGenerator.Models;
using SWnpcGenerator;

namespace SWnpcGenerator.Models
{
    public class Create
    {
        string randomName()
        {
           return RandomName.GenerateName();
        }

        //TODO add random species method call

    }
}