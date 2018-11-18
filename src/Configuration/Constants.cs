﻿namespace Configuration
{
    public class Constants
    {
        public class Routes
        {
            /// <summary>
            /// Routes to be used by the CMS and its features.
            /// {0} is the feature name.
            /// {1} is the endpoint name.
            /// </summary>
            public const string Api = "/api/cms/{0}/{1}";
        }
    }
}