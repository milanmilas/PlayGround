using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace GenericsDynamicsFunction
{
    class Program
    {
        class Country
        {
            public String Name;
            public String Currency;

            public String GetName
            {
                get { return Name; }
                set { value = Name; }
            }

        }

        class ContextBuilderHelper<T> where T : class
        {
            private List<string> columnsNames = new List<string>();

            public ContextBuilderHelper<T> AddColumn(Expression<Func<T,object>> expr)
            {
                var result = ((MemberExpression) expr.Body).Member.Name;

                return this;
            }

            public static void GetTableFromResult(DataTable table, object result, List<string> skippColumns)
            {
                foreach (
                    PropertyInfo property in
                        result.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
                {
                    if (!skippColumns.Contains(property.Name))
                    {
                        table.Columns.Add(property.Name);
                    }
                }

                table.Rows.Add();

                foreach (
                    PropertyInfo property in
                        result.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
                {
                    if (!skippColumns.Contains(property.Name))
                    {
                        var value = property.GetValue(result, null);
                        if (value == null) continue;
                        table.Rows[0][property.Name] = value;
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            ContextBuilderHelper<Country> helper = new ContextBuilderHelper<Country>();
            helper.AddColumn(m => m.Name);
        }
    }
}
