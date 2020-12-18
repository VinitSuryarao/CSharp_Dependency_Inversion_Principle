using System;

namespace Dependency_Inversion_Principle
{
    // D : Dependency Inversion Principle (DIP)
    // High Level Model does not depend on low level module. But both are depend on abstraction.

    //// Before DIP
    //public class BusinessLayer // High Level Module
    //{
    //    private readonly DataAccessLayer DAL;
    //    public BusinessLayer()
    //    {
    //        DAL = new DataAccessLayer();
    //    }
    //    public void Save(Object details) // This save depend on low level module
    //    {
    //        DAL.Save(details);
    //    }
    //}

    //public class DataAccessLayer // Low Level Module
    //{
    //   public void Save(Object details)
    //    {
    //        // Save Operation
    //    }
    //}

    // After DIP
    // Same as Dependacy Injection
    public class BusinessLayer // High Level Module
    {
        private readonly IRepository DAL;
        public BusinessLayer(IRepository repository)
        {
            DAL = repository;
        }
        public void Save(Object details) 
        {
            DAL.Save(details);
        }
    }

    // Work As Abstractin or Contract between module
    
    public interface IRepository 
    {
        void Save(object Details);
    }
    public class DataAccessLayer 
    {
        public void Save(Object details)
        {
            // Save Operation
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
