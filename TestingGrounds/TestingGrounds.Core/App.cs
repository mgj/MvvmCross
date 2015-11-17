using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGrounds.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            //Mvx.RegisterSingleton<ICalendarRepositoryService>(new CalendarRepositoryMockService());

            RegisterAppStart<ViewModels.FirstViewModel>();
        }
    }
}
