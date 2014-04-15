using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyTunes.Bootstrapping
{
    public static class SimpleServiceLocator
    {
        public static TInterface CreateInstance<TInterface>()
        {
            // TODO: Exception Handling!!!

            Type targetType = null;

            // 1. Aktueller Ausführungspfad
            var executionPath = Assembly.GetExecutingAssembly().Location;
            var executionFolder = Path.GetDirectoryName(executionPath);
            // NOTE: Evtl. weitere Namenskonvention verwenden ("Plugins...")
            var files = Directory.GetFiles(executionFolder, "*.dll");

            // 2. Für jede DLL in Pfad

            // 3. Lese alle Typen

            // 4. Checke ob TInterface implementiert wird

            // 5. Nimm 1. Treffer
            foreach (var file in files)
            {
                var assembly = Assembly.LoadFrom(file);
                var types = assembly.GetTypes();

                foreach (var type in types)
                {
                    var sourceInterface = type.GetInterface(typeof (TInterface).ToString());

                    if (sourceInterface != null)
                    {
                        targetType = type;
                        break;
                    }
                }

                if (targetType != null)
                {
                    break;
                }
            }

            // 6. Erzeuge Objektinstanz und ferddich!
            var instance = (TInterface) Activator.CreateInstance(targetType);

            return instance;
        }
    }
}
