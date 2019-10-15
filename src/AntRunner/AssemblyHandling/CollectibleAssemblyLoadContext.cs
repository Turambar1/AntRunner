namespace AntRunner.AssemblyHandling
{
   using System;
   using System.IO;
   using System.Reflection;
   using System.Runtime.Loader;

   /// <summary>
   /// Helper class to load and unload assemblies in .net core  
   /// </summary>
   public class CollectibleAssemblyLoadContext : AssemblyLoadContext, IAntContext
   {
      /// <inheritdoc />
      public CollectibleAssemblyLoadContext() : base(isCollectible: true)
      { }
 
      /// <summary>
      /// Not Used
      /// </summary>
      /// <param name="assemblyName"></param>
      /// <returns></returns>
      protected override Assembly Load(AssemblyName assemblyName)
      {
         return null;
      }

      public Assembly LoadAssembly(string assemblyPath)
      {
         if (!string.IsNullOrWhiteSpace(assemblyPath))
         {
            using var fs = new FileStream(assemblyPath, FileMode.Open, FileAccess.Read);
            return this.LoadFromStream(fs);
         }

         throw new NotImplementedException("Not sure what we can do here!");
      }
   }
}