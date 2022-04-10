using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace WP_Infernal.Managers.Helper
{
    class HelperClass
    {        
        public TreeNode testNode()
        {
            TreeNode livre1 = new TreeNode("Antigone", 2, 2);
            TreeNode livre2 = new TreeNode("Code da vinci", 2, 2);
            TreeNode livre3 = new TreeNode("You", 2, 2);
            TreeNode[] Collection_Livre = new TreeNode[] { livre1, livre2, livre3 };
            TreeNode result = new TreeNode("Book", 0, 1, Collection_Livre);
            return result;
        }
    }

    public class IgnoreEmptyEnumerablesResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);

            if (property.DeclaringType is IEnumerable)
            {
                property.ShouldSerialize = instance =>
                {
                    var enumer = instance
                        .GetType()
                        .GetProperty(property.PropertyName)
                        .GetValue(instance, null) as IEnumerable;

                    if (enumer != null)
                    {
                        // check to see if there is at least one item in the Enumerable
                        return enumer.GetEnumerator().MoveNext();
                    }
                    else
                    {
                        // if the enumerable is null, we defer the decision to NullValueHandling
                        return true;
                    }
                };
            }

            return property;
        }
    }
}
