﻿namespace Grand.Domain.Stores
{
    public static class StoreExtensions
    {
        /// <summary>
        /// Indicates whether a store contains a specified host
        /// </summary>
        /// <param name="store">Store</param>
        /// <param name="host">Host</param>
        /// <returns>true - contains, false - no</returns>
        public static bool ContainsHostValue(this Store store, string host)
        {
            ArgumentNullException.ThrowIfNull(store);

            if (string.IsNullOrEmpty(host))
                return false;

            var contains = store.Domains.FirstOrDefault(x => x.HostName.Equals(host, StringComparison.OrdinalIgnoreCase)) != null;
            return contains;
        }

        /// <summary>
        /// Return domain host
        /// </summary>
        /// <param name="store">Store</param>
        /// <param name="host">Host</param>
        /// <returns>DomainHost</returns>
        public static DomainHost HostValue(this Store store, string host)
        {
            ArgumentNullException.ThrowIfNull(store);
            return string.IsNullOrEmpty(host) ? null : store.Domains.FirstOrDefault(x => x.HostName.Equals(host, StringComparison.OrdinalIgnoreCase));
        }
    }
}
