﻿namespace SharpRepository.Tests.Integration.TestAttributes
{
    public static class RepositoryTypes
    {
        public static RepositoryType[] All
        {
            get
            {
                return new[]
                           {
                               RepositoryType.InMemory,
//                               RepositoryType.Dbo4,
//                               RepositoryType.RavenDb,
//                               RepositoryType.Xml,
//                               RepositoryType.MongoDb,
                               RepositoryType.Ef6,
//                               RepositoryType.Cache,
//                               RepositoryType.CouchDb
                           };
            }
        }

        public static RepositoryType[] CompoundKey
        {
            get
            {
                return new[]
                           {
                               RepositoryType.InMemory,
                               RepositoryType.Ef6,
//                               RepositoryType.Cache
                           };
            }
        }
    }
}
