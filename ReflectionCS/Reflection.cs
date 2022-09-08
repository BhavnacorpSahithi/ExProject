using System;
using System.Reflection;


namespace CollectionsCS
{
    class Reflection
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reflection");
            Type t = typeof(System.Data.DataColumn);

            //fileds of sqldb type;
            FieldInfo[] fields = t.GetFields(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public);
            Console.WriteLine("fields of sqldbtype");
            Reflection.Print(fields);
            Console.WriteLine("------------------------------------");
            EventInfo[] events = t.GetEvents(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public);
            Console.WriteLine("events of sqldbtype");
            Reflection.Print(events);
            Console.WriteLine("------------------------------------");
            PropertyInfo[] props = t.GetProperties(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public);
            Console.WriteLine("props of sqldbtype");
            Reflection.Print(props);
            Console.WriteLine("------------------------------------");
            Type t1 = typeof(System.IO.File);
            MemberInfo[] m2 = t1.GetMembers(BindingFlags.Instance | BindingFlags.Public);
            Console.WriteLine("\nin class of io file in {0} in {1}",m2.Length,t1.FullName);
            if (t1.IsPublic)
            {
                Console.WriteLine("{0}", t1.FullName);
            }
            Console.WriteLine("------------------------------------");
        }
        public static void Print(MemberInfo[] m1)
        {
            foreach (MemberInfo m in m1)
            {
                Console.WriteLine("{0}",m);
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Reflection.MethodInfo");
            // Gets and displays the Type.
            Type t2 = Type.GetType("System.Reflection.FieldInfo");
            // Specifies the member for which you want type information.
            MethodInfo myMethodInfo = t2.GetMethod("GetValue");
            Console.WriteLine(t2.FullName + "." + myMethodInfo.Name);
            // Gets and displays the MemberType property.
            MemberTypes myMemberTypes = myMethodInfo.MemberType;
            if (MemberTypes.Constructor == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type All");
            }
            else if (MemberTypes.Custom == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Custom");
            }
            else if (MemberTypes.Event == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Event");
            }
            else if (MemberTypes.Field == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Field");
            }
            else if (MemberTypes.Method == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Method");
            }
            else if (MemberTypes.Property == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Property");
            }
            else if (MemberTypes.TypeInfo == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type TypeInfo");
            }
        }
        
    }
}
