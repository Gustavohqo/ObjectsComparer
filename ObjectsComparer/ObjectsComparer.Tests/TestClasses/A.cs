﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace ObjectsComparer.Tests.TestClasses
{
    class A
    {
        public int Field;

        protected int ProtectedField;

        public readonly string ReadOnlyField;

        public int Property { get; set; }

        public double ReadOnlyProperty { get; }

        protected bool ProtectedProperty { get; }

        public B ClassB { get; set; }

        public int[] IntArray { get; set; }

        public B[] ArrayOfB { get; set; }

        public Collection<B> CollectionOfB { get; set; }

        public ICollection<B> ICollectionOf { get; set; }

        public List<B> ListOf { get; set; }

        public CollectionOfB ClassImplementsCollectionOfB { get; set; }

        public ITestInterface IntefaceProperty { get; set; }

        public TestStruct StructProperty { get; set; }

        public TestEnum EnumProperty { get; set; }

        public int Property3
        {
            set
            {
                if (value > 3)
                {
                    Debug.Print("value > 3");
                }
            }
        }

        public A()
        {
            ReadOnlyProperty = 3.14;
        }

        public A(double readOnlyProperty)
        {
            ReadOnlyProperty = readOnlyProperty;
        }

        public A(int protectedField)
        {
            ProtectedField = protectedField;
        }

        public A(string readOnlyField)
        {
            ReadOnlyField = readOnlyField;
        }

        public A(bool protectedProperty)
        {
            ProtectedProperty = protectedProperty;
        }
    }
}
