using Core2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core2.BusinessLogic
{
    public class Service
    {
        public IndexViewModel GetIndexViewModel()
        {
            return new IndexViewModel {
                Message = "YOLO"
            };
        }


    }
}
