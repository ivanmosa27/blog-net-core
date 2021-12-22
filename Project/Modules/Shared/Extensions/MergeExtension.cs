using System.Linq;
using System.Reflection;

namespace blog_net_core.Project.Modules.Shared.Extensions
{
    /// <summary>
    /// Some methods to add functionality related with the object mergering.
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// This method merge the values of the second entity into the first.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="OriginalEntity">The source entity.</param>
        /// <param name="NewEntity">The entity with the values that will be used to overwrite the first entity.</param>
        /// <param name="ignoreNullValues">A flag that indicates if the null values should be ignore in mergering process.</param>
        /// <returns>The overwritten first entity.</returns>
        /// <see href="https://stackoverflow.com/questions/7663501/dataannotations-recursively-validating-an-entire-object-graph/8090614">
        ///  Merge two objects together
        /// </see>
        public static TEntity MergeEntityWith<TEntity>(
            this TEntity OriginalEntity,
            TEntity NewEntity,
            bool ignoreNullValues = true
        )
        {
            PropertyInfo[] oProperties = OriginalEntity.GetType().GetProperties();

            string[] keysToIgnore = new[] { "Id", "CreatedAt", "UpdatedAt" };

            foreach (PropertyInfo CurrentProperty in oProperties.Where(p => p.CanWrite))
            {
                // If the params to assign is one of the keys of ignore continue.
                if (keysToIgnore.Contains(CurrentProperty.Name))
                {
                    continue;
                }

                // Virtual property problems, is the property is virtual is necessary extract the value using other method.
                object? value = null;
                if (CurrentProperty.GetGetMethod()?.IsVirtual is true)
                {
                    value = NewEntity.GetType().GetProperty(CurrentProperty.Name)?.GetValue(NewEntity, null);
                }
                else
                {
                    value = CurrentProperty.GetValue(NewEntity, null);
                }

                // Don't assign the null values if should be ignore
                if (value is null && ignoreNullValues)
                {
                    continue;
                }

                CurrentProperty.SetValue(OriginalEntity, value, null);
            }

            return OriginalEntity;
        }
    }
}
