using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckScale.UI.HelperClass
{

    public class UIFactory : IUIFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public UIFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public T CreateForm<T>() where T : Form
        {
            return _serviceProvider.GetRequiredService<T>();
        }

        public T CreateUC<T>() where T : UserControl
        {
            return _serviceProvider.GetRequiredService<T>();
        }
    }
}
