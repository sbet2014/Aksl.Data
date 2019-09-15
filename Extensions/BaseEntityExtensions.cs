//using System;

//https://www.cnblogs.com/CreateMyself/p/6238455.html
//namespace Aksl.Data
//{
//    public static class BaseEntityExtensions
//    {
//        /// <summary>
//        /// Get unproxied entity type
//        /// </summary>
//        /// <remarks> If your Entity Framework context is proxy-enabled, 
//        /// the runtime will create a proxy instance of your entities, 
//        /// i.e. a dynamically generated class which inherits from your entity class 
//        /// and overrides its virtual properties by inserting specific code useful for example 
//        /// for tracking changes and lazy loading.
//        /// </remarks>
//        /// <param name="entity"></param>
//        /// <returns></returns>
//        public static Type GetUnproxiedEntityType(this BaseEntity entity)
//        {
//            var userType = ObjectContext.GetObjectType(entity.GetType());
//            return userType;
//        }
//    }
//}
