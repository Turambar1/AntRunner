namespace AntRunner.AssemblyHandling
{
   using System.IO;
   using System.Reflection;

   public interface IAntContext
   {
      /// <summary>Loads the assembly with a common object file format (COFF)-based image containing a managed assembly.</summary>
      /// <param name="assembly">A byte array that is a COFF-based image containing a managed assembly.</param>
      /// <returns>The loaded assembly.</returns>
      /// <exception cref="T:System.ArgumentNullException">
      /// <paramref name="assembly" /> is <see langword="null" />.</exception>
      /// <exception cref="T:System.BadImageFormatException">
      /// <paramref name="assembly" /> is not a valid assembly.</exception>
      Assembly LoadFromStream(Stream assembly);

      
      /// <summary>Initiates an unload of this <see cref="T:System.Runtime.Loader.AssemblyLoadContext" />.</summary>
      /// <exception cref="T:System.InvalidOperationException">Unloading is not allowed.</exception>
      void Unload();

      Assembly LoadAssembly(string assemblyPath);
   }
}