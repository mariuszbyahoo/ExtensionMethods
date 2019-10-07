using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods.Library
{
    public class Target
    {
        private string _id;

        protected string Id
        {
            get { return _id; }
            set { _id = value.Trim(); }
        }

            public string GetId()
        {
            return _id;
        }

        public Target(string id)
        {
            _id = id;
        }

        // The method below has higher priority than an extension method, as it has the same signature, 
        // so it will override it
        public string GetStandardizedId()
        {
            return _id.ToLower();
        }
    }
    internal class InternalTarget
    {
        protected class ProtectedSubClass
        {

        }
    }
}
