﻿using System;

namespace BlogEngine.Core.Exceptions
{
    public class EntityNullException : Exception
    {
        public EntityNullException(string entityName)
            : base($"The entity with a name = '{entityName}' was not found in the Database")
        {
        }

        public EntityNullException(string entityName, Exception innerException)
            : base($"The entity with a name = '{entityName}' was null", innerException)
        {
        }
    }
}