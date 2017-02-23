//----------------------------------------------------------------------------------------------
// <copyright file="AuditableEntity.cs" company="HexaSystems Inc">
// Copyright (c) HexaSystems Inc. Licensed under the Apache License, Version 2.0 (the "License")
// </copyright>
//-----------------------------------------------------------------------------------------------
namespace Hexa.Core.Domain.Tests
{
    using Hexa.Core.Domain;

    using Xunit;

    public class AuditableEntity : Hexa.Core.Domain.AuditableEntity<AuditableEntity>
    {
    }

    public class Entity : IEntity<int>
    {
        public int Id
        {
            get;
            set;
        }

        public string SampleProperty
        {
            get;
            set;
        }
    }

    public class EntityTests
    {
         [Fact]
        public void New_AuditableEntity_Is_Transient()
        {
            AuditableEntity entity = new AuditableEntity();
            Assert.True(entity.IsTransient());
        }
    }
}